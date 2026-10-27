using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02000EEB RID: 3819
[NullableContext(1)]
[Nullable(0)]
public class ProjectionPhotoSlider : UiPanelBase
{
	// Token: 0x06005FBD RID: 24509 RVA: 0x0011EE38 File Offset: 0x0011D038
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

	// Token: 0x06005FBE RID: 24510 RVA: 0x0011EF00 File Offset: 0x0011D100
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

	// Token: 0x06005FBF RID: 24511 RVA: 0x0011F10E File Offset: 0x0011D30E
	protected override void OnAfterShow()
	{
		if (this.RootItem != null)
		{
			this.RootItem.SetUIActive(false);
		}
	}

	// Token: 0x06005FC0 RID: 24512 RVA: 0x0011F124 File Offset: 0x0011D324
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

	// Token: 0x06005FC1 RID: 24513 RVA: 0x0011F1DE File Offset: 0x0011D3DE
	public void SetConfig(float originValue, float targetValue, float sliderTolerance, bool isHorizontal)
	{
		this.originValue = originValue;
		this.targetValue = targetValue;
		this.sliderTolerance = sliderTolerance;
		this.isHorizontal = isHorizontal;
	}

	// Token: 0x06005FC2 RID: 24514 RVA: 0x0011F200 File Offset: 0x0011D400
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

	// Token: 0x06005FC3 RID: 24515 RVA: 0x0011F2FA File Offset: 0x0011D4FA
	private void OnPointUp(ULGUIPointerEventData eventData)
	{
		this.FinishEffect();
	}

	// Token: 0x06005FC4 RID: 24516 RVA: 0x0011F304 File Offset: 0x0011D504
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

	// Token: 0x06005FC5 RID: 24517 RVA: 0x0011F38C File Offset: 0x0011D58C
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

	// Token: 0x06005FC6 RID: 24518 RVA: 0x0011F3D8 File Offset: 0x0011D5D8
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

	// Token: 0x06005FC7 RID: 24519 RVA: 0x0011F4A8 File Offset: 0x0011D6A8
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

	// Token: 0x06005FC8 RID: 24520 RVA: 0x0011F550 File Offset: 0x0011D750
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

	// Token: 0x06005FC9 RID: 24521 RVA: 0x0011F584 File Offset: 0x0011D784
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

	// Token: 0x06005FCA RID: 24522 RVA: 0x0011F5E4 File Offset: 0x0011D7E4
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

	// Token: 0x06005FCB RID: 24523 RVA: 0x0011F668 File Offset: 0x0011D868
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

	// Token: 0x06005FCC RID: 24524 RVA: 0x0011F6C8 File Offset: 0x0011D8C8
	private bool IsDisabled()
	{
		return this.originValue == -1f && this.targetValue == -1f;
	}

	// Token: 0x06005FCD RID: 24525 RVA: 0x0011F6E6 File Offset: 0x0011D8E6
	private float GetSliderOffsetValue(float value)
	{
		if (!this.isHorizontal)
		{
			return 0.45f + value * 0.55f;
		}
		return value;
	}

	// Token: 0x06005FCE RID: 24526 RVA: 0x0011F700 File Offset: 0x0011D900
	private float GetNormalizedDistance(float value, float targetValue)
	{
		float num = Math.Max(targetValue, 1f - targetValue);
		return Math.Min(Math.Abs(value - targetValue) / num, 1f);
	}

	// Token: 0x06005FCF RID: 24527 RVA: 0x0011F72F File Offset: 0x0011D92F
	public bool IsFinish()
	{
		return this.IsDisabled() || this.finishFlag;
	}

	// Token: 0x06005FD1 RID: 24529 RVA: 0x0011F749 File Offset: 0x0011D949
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

	// Token: 0x04002B62 RID: 11106
	private const float VerticalOffsetMin = 0.45f;

	// Token: 0x04002B63 RID: 11107
	private const string RIGHT_RANGE_AUDIO_EVENT = "play_interact_camera_ui_slider_flash";

	// Token: 0x04002B64 RID: 11108
	private float originValue;

	// Token: 0x04002B65 RID: 11109
	private float targetValue;

	// Token: 0x04002B66 RID: 11110
	private float sliderTolerance;

	// Token: 0x04002B67 RID: 11111
	private bool isHorizontal;

	// Token: 0x04002B68 RID: 11112
	private bool finishFlag;

	// Token: 0x04002B69 RID: 11113
	private bool valueFirstChange;

	// Token: 0x04002B6A RID: 11114
	private bool isAxisInput;

	// Token: 0x04002B6B RID: 11115
	private bool wasAxisInput;

	// Token: 0x04002B6C RID: 11116
	private bool uiIncreaseAxisInput;

	// Token: 0x04002B6D RID: 11117
	private bool uiReduceAxisInput;

	// Token: 0x04002B6E RID: 11118
	[Nullable(2)]
	private LevelSequencePlayer sequencePlayer;

	// Token: 0x04002B6F RID: 11119
	private UUISliderComponent rootSlider;

	// Token: 0x04002B70 RID: 11120
	private UUINiagara niaBgPoint;

	// Token: 0x04002B71 RID: 11121
	private UUINiagara niaGlow;

	// Token: 0x04002B72 RID: 11122
	private UUINiagara niaRange;

	// Token: 0x04002B73 RID: 11123
	private UUIItem itemConfirm;

	// Token: 0x04002B74 RID: 11124
	private UUISprite cursorSprite;

	// Token: 0x04002B75 RID: 11125
	private UUISprite pointLineSprite;

	// Token: 0x0200754D RID: 30029
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04026C97 RID: 158871
		NiaBgPoint,
		// Token: 0x04026C98 RID: 158872
		PnlHandle,
		// Token: 0x04026C99 RID: 158873
		SprCursor,
		// Token: 0x04026C9A RID: 158874
		SprPointLine,
		// Token: 0x04026C9B RID: 158875
		SprConfirm,
		// Token: 0x04026C9C RID: 158876
		NiaGlow,
		// Token: 0x04026C9D RID: 158877
		NiaCalibration,
		// Token: 0x04026C9E RID: 158878
		NiaRange
	}
}
