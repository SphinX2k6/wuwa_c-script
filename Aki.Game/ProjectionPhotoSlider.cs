using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020003A0 RID: 928
[NullableContext(1)]
[Nullable(0)]
public class ProjectionPhotoSlider : UiPanelBase
{
	// Token: 0x06003353 RID: 13139 RVA: 0x00126C90 File Offset: 0x00124E90
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUINiagara)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUINiagara)),
			new ValueTuple<int, Type>(6, typeof(UUINiagara)),
			new ValueTuple<int, Type>(7, typeof(UUINiagara))
		};
	}

	// Token: 0x06003354 RID: 13140 RVA: 0x00126D58 File Offset: 0x00124F58
	protected override UniTask OnBeforeStartAsync()
	{
		UUIItem rootItem = this.RootItem;
		object obj;
		if (rootItem == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = rootItem.GetOwner();
			obj = ((owner != null) ? owner.GetComponentByClass(UUISliderComponent.StaticClass()) : null);
		}
		this.rootSlider = (obj as UUISliderComponent);
		UUISliderComponent uuisliderComponent = this.rootSlider;
		if (uuisliderComponent != null)
		{
			uuisliderComponent.SetValue(this.originValue, true);
		}
		if (this.rootSlider != null)
		{
			this.rootSlider.OnValueChangeCb.Bind(new Action<float>(this.OnValueChange));
			this.rootSlider.OnPointUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointUp));
		}
		this.niaBgPoint = base.GetUiNiagara(0);
		this.niaGlow = base.GetUiNiagara(5);
		UUINiagara uuiniagara = this.niaGlow;
		if (uuiniagara != null)
		{
			uuiniagara.SetUIActive(false);
		}
		this.niaRange = base.GetUiNiagara(7);
		UUINiagara uuiniagara2 = this.niaRange;
		if (uuiniagara2 != null)
		{
			uuiniagara2.SetUIActive(false);
		}
		this.ApplyNiaRangeAnchorByTarget();
		this.itemConfirm = base.GetItem(4);
		UUIItem uuiitem = this.itemConfirm;
		if (uuiitem != null)
		{
			uuiitem.SetUIActive(false);
		}
		this.cursorSprite = base.GetSprite(2);
		this.pointLineSprite = base.GetSprite(3);
		UUINiagara uuiniagara3 = this.niaBgPoint;
		if (uuiniagara3 != null)
		{
			uuiniagara3.SetNiagaraVarFloat("Offset", this.GetSliderOffsetValue(this.originValue));
		}
		UMaterialParameterCollection sceneCaptureParameterCollection = RenderDataManager.Instance.GetSceneCaptureParameterCollection();
		string key = this.isHorizontal ? "BlurIntensity" : "ColorSplitIntensity";
		if (sceneCaptureParameterCollection != null)
		{
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), sceneCaptureParameterCollection, FNameUtil.GetDynamicFName(key).Value, 0f);
		}
		EventSystem.Instance.Add(EEventName.OnProjectionPhotoFinishDrag, new Action(this.OnProjectionPhotoFinishDrag));
		if (!this.isHorizontal)
		{
			InputDistributeController.Instance.BindAxis("UiScroll1", new TInputHandle<float>(this.OnAxisInput));
		}
		else
		{
			InputDistributeController.Instance.BindAxes(new string[]
			{
				"UiIncrease",
				"UiReduce"
			}, new TInputHandle<float>(this.OnAxisInput));
		}
		this.sequencePlayer = new LevelSequencePlayer(this.RootItem);
		return base.OnBeforeStartAsync();
	}

	// Token: 0x06003355 RID: 13141 RVA: 0x00126F66 File Offset: 0x00125166
	protected override void OnAfterShow()
	{
		if (this.RootItem != null)
		{
			this.RootItem.SetUIActive(false);
		}
	}

	// Token: 0x06003356 RID: 13142 RVA: 0x00126F7C File Offset: 0x0012517C
	protected override void OnBeforeDestroy()
	{
		if (this.rootSlider != null)
		{
			this.rootSlider.OnValueChangeCb.Unbind();
			this.rootSlider.OnPointUpCallBack.Unbind();
		}
		if (!this.isHorizontal)
		{
			InputDistributeController.Instance.UnBindAxis("UiScroll1", new TInputHandle<float>(this.OnAxisInput));
		}
		else
		{
			InputDistributeController.Instance.UnBindAxes(new string[]
			{
				"UiIncrease",
				"UiReduce"
			}, new TInputHandle<float>(this.OnAxisInput));
		}
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoFinishDrag, new Action(this.OnProjectionPhotoFinishDrag));
		LevelSequencePlayer levelSequencePlayer = this.sequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.sequencePlayer = null;
	}

	// Token: 0x06003357 RID: 13143 RVA: 0x00127036 File Offset: 0x00125236
	public void SetConfig(float originValue, float targetValue, float sliderTolerance, bool isHorizontal)
	{
		this.originValue = originValue;
		this.targetValue = targetValue;
		this.sliderTolerance = sliderTolerance;
		this.isHorizontal = isHorizontal;
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x00127058 File Offset: 0x00125258
	private void OnValueChange(float value)
	{
		if (this.valueFirstChange && this.isHorizontal)
		{
			this.valueFirstChange = false;
			EventSystem.Instance.Emit(EEventName.OnHorizontalSliderValueFirstChange);
		}
		bool flag = this.finishFlag;
		this.finishFlag = (Math.Abs(value - this.targetValue) < this.sliderTolerance);
		if (flag != this.finishFlag)
		{
			this.PlayRangeSequence(this.finishFlag);
		}
		if (!flag && this.finishFlag)
		{
			AudioSystem.Instance.PostEvent("play_interact_camera_ui_slider_flash");
		}
		this.UpdateIndicatorChangeColor();
		float sliderOffsetValue = this.GetSliderOffsetValue(value);
		UUINiagara uuiniagara = this.niaBgPoint;
		if (uuiniagara != null)
		{
			uuiniagara.SetNiagaraVarFloat("Offset", sliderOffsetValue);
		}
		float normalizedDistance = this.GetNormalizedDistance(value, this.targetValue);
		UMaterialParameterCollection sceneCaptureParameterCollection = RenderDataManager.Instance.GetSceneCaptureParameterCollection();
		string key = this.isHorizontal ? "BlurIntensity" : "ColorSplitIntensity";
		if (sceneCaptureParameterCollection != null)
		{
			UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), sceneCaptureParameterCollection, FNameUtil.GetDynamicFName(key).Value, normalizedDistance);
		}
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x00127152 File Offset: 0x00125352
	private void OnPointUp(ULGUIPointerEventData eventData)
	{
		this.FinishEffect();
	}

	// Token: 0x0600335A RID: 13146 RVA: 0x0012715C File Offset: 0x0012535C
	private void OnProjectionPhotoFinishDrag()
	{
		if (!this.IsDisabled() && this.RootItem != null)
		{
			this.RootItem.SetUIActive(true);
			this.valueFirstChange = true;
			UMaterialParameterCollection sceneCaptureParameterCollection = RenderDataManager.Instance.GetSceneCaptureParameterCollection();
			string key = this.isHorizontal ? "BlurIntensity" : "ColorSplitIntensity";
			float normalizedDistance = this.GetNormalizedDistance(this.originValue, this.targetValue);
			if (sceneCaptureParameterCollection != null)
			{
				UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), sceneCaptureParameterCollection, FNameUtil.GetDynamicFName(key).Value, normalizedDistance);
			}
		}
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x001271E4 File Offset: 0x001253E4
	private void PlayRangeSequence(bool isFinish)
	{
		LevelSequencePlayer levelSequencePlayer = this.sequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopPlayingSequence(false, true);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.sequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName(isFinish ? "On" : "Off", false, null, false);
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x00127230 File Offset: 0x00125430
	private void FinishEffect()
	{
		EventSystem.Instance.Emit(EEventName.OnProjectionPhotoSliderEndDrag);
		if (this.finishFlag)
		{
			UUINiagara uuiniagara = this.niaGlow;
			if (uuiniagara != null)
			{
				uuiniagara.SetUIActive(true);
			}
			UUISliderComponent uuisliderComponent = this.rootSlider;
			if (uuisliderComponent != null)
			{
				uuisliderComponent.SetSelfInteractive(false);
			}
			UUINiagara uuiniagara2 = this.niaBgPoint;
			if (uuiniagara2 != null)
			{
				uuiniagara2.SetAlpha(0.5f);
			}
			UUISprite uuisprite = this.cursorSprite;
			if (uuisprite != null)
			{
				bool bUseChangeColor = false;
				FColor? fcolor = new FColor?(this.cursorSprite.changeColor);
				uuisprite.SetChangeColor(bUseChangeColor, fcolor);
			}
			UUISprite uuisprite2 = this.pointLineSprite;
			if (uuisprite2 != null)
			{
				bool bUseChangeColor2 = false;
				FColor? fcolor = new FColor?(this.pointLineSprite.changeColor);
				uuisprite2.SetChangeColor(bUseChangeColor2, fcolor);
			}
			UUISprite uuisprite3 = this.cursorSprite;
			if (uuisprite3 != null)
			{
				uuisprite3.SetIsGray(true);
			}
			UUISprite uuisprite4 = this.pointLineSprite;
			if (uuisprite4 == null)
			{
				return;
			}
			uuisprite4.SetIsGray(true);
		}
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x00127300 File Offset: 0x00125500
	private void OnAxisInput(string axisName, float value, InputIdentification _)
	{
		if (!base.GetActive())
		{
			return;
		}
		this.wasAxisInput = this.isAxisInput;
		if (this.isHorizontal)
		{
			if (axisName == "UiIncrease")
			{
				this.uiIncreaseAxisInput = (value != 0f);
			}
			else if (axisName == "UiReduce")
			{
				this.uiReduceAxisInput = (value != 0f);
			}
			this.isAxisInput = (this.uiIncreaseAxisInput || this.uiReduceAxisInput);
		}
		else
		{
			this.isAxisInput = (value != 0f);
		}
		if (this.wasAxisInput && !this.isAxisInput)
		{
			this.FinishEffect();
		}
	}

	// Token: 0x0600335E RID: 13150 RVA: 0x001273A8 File Offset: 0x001255A8
	private float GetSliderTrackWidth()
	{
		UUIItem sliderTrackUiItem = this.GetSliderTrackUiItem();
		float num = (sliderTrackUiItem != null) ? sliderTrackUiItem.GetWidth() : 0f;
		if (num <= 0f)
		{
			return 0f;
		}
		return num;
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x001273DC File Offset: 0x001255DC
	[NullableContext(2)]
	private UUIItem GetSliderTrackUiItem()
	{
		UUISliderComponent uuisliderComponent = this.rootSlider;
		if (uuisliderComponent != null)
		{
			UUIItem uuiitem = ProjectionPhotoSlider.<GetSliderTrackUiItem>g__TryItem|33_0(uuisliderComponent.FillArea);
			if (uuiitem != null)
			{
				return uuiitem;
			}
			UUIItem uuiitem2 = ProjectionPhotoSlider.<GetSliderTrackUiItem>g__TryItem|33_0(uuisliderComponent.HandleArea);
			if (uuiitem2 != null)
			{
				return uuiitem2;
			}
			UUIItem uuiitem3 = ProjectionPhotoSlider.<GetSliderTrackUiItem>g__TryItem|33_0(uuisliderComponent.Fill);
			if (uuiitem3 != null)
			{
				return uuiitem3;
			}
		}
		return base.GetItem(1);
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x0012743C File Offset: 0x0012563C
	private void ApplyNiaRangeAnchorByTarget()
	{
		if (this.IsDisabled() || this.niaRange == null)
		{
			return;
		}
		float sliderTrackWidth = this.GetSliderTrackWidth();
		if (sliderTrackWidth <= 0f)
		{
			return;
		}
		float num = this.isHorizontal ? 1f : 0.55f;
		float inX = (this.GetSliderOffsetValue(this.targetValue) - this.GetSliderOffsetValue(0.5f)) / num * sliderTrackWidth;
		FVector2D anchorOffset = this.niaRange.GetAnchorOffset();
		this.niaRange.SetAnchorOffset(new FVector2D(inX, anchorOffset.Y));
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x001274C0 File Offset: 0x001256C0
	private void UpdateIndicatorChangeColor()
	{
		bool flag = !this.finishFlag;
		UUISprite uuisprite = this.cursorSprite;
		FColor? fcolor;
		if (uuisprite != null)
		{
			bool bUseChangeColor = flag;
			fcolor = new FColor?(this.cursorSprite.changeColor);
			uuisprite.SetChangeColor(bUseChangeColor, fcolor);
		}
		UUISprite uuisprite2 = this.pointLineSprite;
		if (uuisprite2 == null)
		{
			return;
		}
		bool bUseChangeColor2 = flag;
		fcolor = new FColor?(this.pointLineSprite.changeColor);
		uuisprite2.SetChangeColor(bUseChangeColor2, fcolor);
	}

	// Token: 0x06003362 RID: 13154 RVA: 0x00127520 File Offset: 0x00125720
	private bool IsDisabled()
	{
		return this.originValue == -1f && this.targetValue == -1f;
	}

	// Token: 0x06003363 RID: 13155 RVA: 0x0012753E File Offset: 0x0012573E
	private float GetSliderOffsetValue(float value)
	{
		if (!this.isHorizontal)
		{
			return 0.45f + value * 0.55f;
		}
		return value;
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x00127558 File Offset: 0x00125758
	private float GetNormalizedDistance(float value, float targetValue)
	{
		float num = Math.Max(targetValue, 1f - targetValue);
		return Math.Min(Math.Abs(value - targetValue) / num, 1f);
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x00127587 File Offset: 0x00125787
	public bool IsFinish()
	{
		return this.IsDisabled() || this.finishFlag;
	}

	// Token: 0x06003367 RID: 13159 RVA: 0x001275A1 File Offset: 0x001257A1
	[NullableContext(2)]
	[CompilerGenerated]
	internal static UUIItem <GetSliderTrackUiItem>g__TryItem|33_0(UUIItem item)
	{
		if (item == null || item.GetWidth() <= 0f)
		{
			return null;
		}
		return item;
	}

	// Token: 0x04002BFB RID: 11259
	private const float VerticalOffsetMin = 0.45f;

	// Token: 0x04002BFC RID: 11260
	private const string RIGHT_RANGE_AUDIO_EVENT = "play_interact_camera_ui_slider_flash";

	// Token: 0x04002BFD RID: 11261
	private float originValue;

	// Token: 0x04002BFE RID: 11262
	private float targetValue;

	// Token: 0x04002BFF RID: 11263
	private float sliderTolerance;

	// Token: 0x04002C00 RID: 11264
	private bool isHorizontal;

	// Token: 0x04002C01 RID: 11265
	private bool finishFlag;

	// Token: 0x04002C02 RID: 11266
	private bool valueFirstChange;

	// Token: 0x04002C03 RID: 11267
	private bool isAxisInput;

	// Token: 0x04002C04 RID: 11268
	private bool wasAxisInput;

	// Token: 0x04002C05 RID: 11269
	private bool uiIncreaseAxisInput;

	// Token: 0x04002C06 RID: 11270
	private bool uiReduceAxisInput;

	// Token: 0x04002C07 RID: 11271
	[Nullable(2)]
	private LevelSequencePlayer sequencePlayer;

	// Token: 0x04002C08 RID: 11272
	private UUISliderComponent rootSlider;

	// Token: 0x04002C09 RID: 11273
	private UUINiagara niaBgPoint;

	// Token: 0x04002C0A RID: 11274
	private UUINiagara niaGlow;

	// Token: 0x04002C0B RID: 11275
	private UUINiagara niaRange;

	// Token: 0x04002C0C RID: 11276
	private UUIItem itemConfirm;

	// Token: 0x04002C0D RID: 11277
	private UUISprite cursorSprite;

	// Token: 0x04002C0E RID: 11278
	private UUISprite pointLineSprite;

	// Token: 0x020066E1 RID: 26337
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04021FE2 RID: 139234
		NiaBgPoint,
		// Token: 0x04021FE3 RID: 139235
		PnlHandle,
		// Token: 0x04021FE4 RID: 139236
		SprCursor,
		// Token: 0x04021FE5 RID: 139237
		SprPointLine,
		// Token: 0x04021FE6 RID: 139238
		SprConfirm,
		// Token: 0x04021FE7 RID: 139239
		NiaGlow,
		// Token: 0x04021FE8 RID: 139240
		NiaCalibration,
		// Token: 0x04021FE9 RID: 139241
		NiaRange
	}
}
