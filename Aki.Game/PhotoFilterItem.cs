using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001AB0 RID: 6832
public class PhotoFilterItem : UiPanelBase
{
	// Token: 0x06010EA2 RID: 69282 RVA: 0x004F6850 File Offset: 0x004F4A50
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClicked))
		};
	}

	// Token: 0x06010EA3 RID: 69283 RVA: 0x004F6968 File Offset: 0x004F4B68
	protected override void OnStart()
	{
		UUISliderComponent slider = base.GetSlider(4);
		if (slider != null)
		{
			slider.OnValueChangeCb.Bind(new Action<float>(this.OnValueChanged));
		}
		this.FilterItemLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetExtendToggle(0).OnPointEnterCallBack.Bind(new Action<EToggleState>(this.PointEnterCallBack));
	}

	// Token: 0x06010EA4 RID: 69284 RVA: 0x004F69C6 File Offset: 0x004F4BC6
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(4);
		if (slider != null)
		{
			slider.OnValueChangeCb.Unbind();
		}
		this.FilterItemLevelSequencePlayer = null;
	}

	// Token: 0x06010EA5 RID: 69285 RVA: 0x004F69E8 File Offset: 0x004F4BE8
	protected override void OnBeforeShow()
	{
		bool bSelected = !this.IsUnSelected();
		this.SetSelected(bSelected, false);
	}

	// Token: 0x06010EA6 RID: 69286 RVA: 0x004F6A08 File Offset: 0x004F4C08
	public void Refresh(int photoFilterId)
	{
		if (photoFilterId == 0)
		{
			return;
		}
		this.PhotoFilterId = photoFilterId;
		this.PhotoFilterConfig = PhotographConfig.Instance.GetPhotoFilterConfigById(photoFilterId);
		if (this.PhotoFilterConfig == null)
		{
			return;
		}
		string name = this.PhotoFilterConfig.Value.Name;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), name, Array.Empty<object>());
		string icon = this.PhotoFilterConfig.Value.Icon;
		base.SetTextureByPath(icon, base.GetTexture(2), null, null);
		UUISliderComponent slider = base.GetSlider(4);
		if (slider != null)
		{
			slider.SetMinValue(0f, false, false);
		}
		if (slider != null)
		{
			slider.SetMaxValue(1f, false, false);
		}
		float filterStrengthByFilterId = PhotographModel.Instance.GetFilterStrengthByFilterId(this.PhotoFilterId);
		if (slider != null)
		{
			slider.SetValue(filterStrengthByFilterId, false);
		}
		int num = (int)Math.Floor((double)(filterStrengthByFilterId * 100f));
		base.GetText(3).SetText(num.ToString(), true);
	}

	// Token: 0x06010EA7 RID: 69287 RVA: 0x004F6B08 File Offset: 0x004F4D08
	private bool IsUnSelected()
	{
		return PhotographModel.Instance.GetPhotographFilter() != this.PhotoFilterId;
	}

	// Token: 0x06010EA8 RID: 69288 RVA: 0x004F6B20 File Offset: 0x004F4D20
	private void OnValueChanged(float value)
	{
		PhotographController.Instance.SetSingleFilterStrength(this.PhotoFilterId, value);
		int num = (int)Math.Floor((double)(value * 100f));
		base.GetText(3).SetText(num.ToString(), true);
	}

	// Token: 0x06010EA9 RID: 69289 RVA: 0x004F6B61 File Offset: 0x004F4D61
	[NullableContext(1)]
	public void BindOnSelected(Action<PhotoFilterItem, bool> onSelected)
	{
		this.OnSelected = onSelected;
	}

	// Token: 0x06010EAA RID: 69290 RVA: 0x004F6B6C File Offset: 0x004F4D6C
	public void SetSelected(bool bSelected, bool bFireEvent = false)
	{
		UUISprite sprite = base.GetSprite(7);
		if (sprite != null)
		{
			sprite.SetUIActive(bSelected);
		}
		this.SetFilterStrengthVisible(bSelected, false);
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (bSelected)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, bFireEvent, false, false);
			PhotographModel.Instance.SetPhotographFilter(this.PhotoFilterId);
			PhotographController.Instance.InitPostProcessVolBlendWeight(this.PhotoFilterId);
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, bFireEvent, false, false);
	}

	// Token: 0x06010EAB RID: 69291 RVA: 0x004F6BD4 File Offset: 0x004F4DD4
	private void OnClicked(EToggleState state)
	{
		if (PhotographModel.Instance.GetPhotographFilter() == this.PhotoFilterId)
		{
			bool bShow = state == EToggleState.ETT_Checked;
			this.SetFilterStrengthVisible(bShow, true);
			return;
		}
		if (this.OnSelected != null)
		{
			this.OnSelected(this, true);
		}
	}

	// Token: 0x06010EAC RID: 69292 RVA: 0x004F6C18 File Offset: 0x004F4E18
	public void SetFilterStrengthVisible(bool bShow, bool needAnim = true)
	{
		UUIItem panelFilterStrength = base.GetItem(8);
		if (this.PhotoFilterId == 1)
		{
			UUISprite sprite = base.GetSprite(9);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUIItem panelFilterStrength5 = panelFilterStrength;
			if (panelFilterStrength5 == null)
			{
				return;
			}
			panelFilterStrength5.SetUIActive(false);
			return;
		}
		else if (!needAnim)
		{
			UUIItem panelFilterStrength2 = panelFilterStrength;
			if (panelFilterStrength2 == null)
			{
				return;
			}
			panelFilterStrength2.SetUIActive(bShow);
			return;
		}
		else if (bShow)
		{
			UUIItem panelFilterStrength3 = panelFilterStrength;
			if (panelFilterStrength3 != null)
			{
				panelFilterStrength3.SetUIActive(true);
			}
			if (this.ScrollToSelectedItem != null)
			{
				this.ScrollToSelectedItem(this);
			}
			LevelSequencePlayer filterItemLevelSequencePlayer = this.FilterItemLevelSequencePlayer;
			if (filterItemLevelSequencePlayer == null)
			{
				return;
			}
			filterItemLevelSequencePlayer.PlayLevelSequenceByName("Unfold", false, null, false);
			return;
		}
		else
		{
			LevelSequencePlayer filterItemLevelSequencePlayer2 = this.FilterItemLevelSequencePlayer;
			if (filterItemLevelSequencePlayer2 == null)
			{
				return;
			}
			filterItemLevelSequencePlayer2.PlaySequenceAsync("Collapse", new CustomPromise<bool>(), false, false, null, false).ContinueWith(delegate()
			{
				UUIItem panelFilterStrength4 = panelFilterStrength;
				if (panelFilterStrength4 == null)
				{
					return;
				}
				panelFilterStrength4.SetUIActive(false);
			}).Forget();
			return;
		}
	}

	// Token: 0x06010EAD RID: 69293 RVA: 0x004F6D02 File Offset: 0x004F4F02
	public void ShowFilterItem()
	{
		this.IsVisible = true;
		this.SetActive(true);
	}

	// Token: 0x06010EAE RID: 69294 RVA: 0x004F6D12 File Offset: 0x004F4F12
	public int GetPhotoFilterId()
	{
		return this.PhotoFilterId;
	}

	// Token: 0x06010EAF RID: 69295 RVA: 0x004F6D1A File Offset: 0x004F4F1A
	public void PlayDisappearSequence(bool isByClickToggle)
	{
		this.IsVisible = false;
		if (isByClickToggle)
		{
			this.PlayDisappearSequenceAsync().Forget();
			return;
		}
		this.SetActive(false);
	}

	// Token: 0x06010EB0 RID: 69296 RVA: 0x004F6D3C File Offset: 0x004F4F3C
	public UniTask PlayDisappearSequenceAsync()
	{
		PhotoFilterItem.<PlayDisappearSequenceAsync>d__21 <PlayDisappearSequenceAsync>d__;
		<PlayDisappearSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDisappearSequenceAsync>d__.<>4__this = this;
		<PlayDisappearSequenceAsync>d__.<>1__state = -1;
		<PlayDisappearSequenceAsync>d__.<>t__builder.Start<PhotoFilterItem.<PlayDisappearSequenceAsync>d__21>(ref <PlayDisappearSequenceAsync>d__);
		return <PlayDisappearSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010EB1 RID: 69297 RVA: 0x004F6D7F File Offset: 0x004F4F7F
	[NullableContext(1)]
	public void BindScrollToSelectedItem(Action<PhotoFilterItem> scrollToSelectedItem)
	{
		this.ScrollToSelectedItem = scrollToSelectedItem;
	}

	// Token: 0x06010EB2 RID: 69298 RVA: 0x004F6D88 File Offset: 0x004F4F88
	private void PointEnterCallBack(EToggleState _)
	{
		if (this.IsUnSelected())
		{
			return;
		}
		if (!Info.Instance.IsInGamepad())
		{
			return;
		}
		if (this.ScrollToSelectedItem != null)
		{
			this.ScrollToSelectedItem(this);
		}
	}

	// Token: 0x04009540 RID: 38208
	private int PhotoFilterId;

	// Token: 0x04009541 RID: 38209
	[Nullable(2)]
	private LevelSequencePlayer FilterItemLevelSequencePlayer;

	// Token: 0x04009542 RID: 38210
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhotoFilterItem, bool> OnSelected;

	// Token: 0x04009543 RID: 38211
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhotoFilterItem> ScrollToSelectedItem;

	// Token: 0x04009544 RID: 38212
	private PhotoFilter? PhotoFilterConfig;

	// Token: 0x04009545 RID: 38213
	private bool IsVisible;

	// Token: 0x02007D5E RID: 32094
	private enum EChildType
	{
		// Token: 0x04028968 RID: 166248
		Toggle,
		// Token: 0x04028969 RID: 166249
		TextName,
		// Token: 0x0402896A RID: 166250
		TextureIcon,
		// Token: 0x0402896B RID: 166251
		TextFilterStrengthNum,
		// Token: 0x0402896C RID: 166252
		ValueSlider,
		// Token: 0x0402896D RID: 166253
		SpriteHandle,
		// Token: 0x0402896E RID: 166254
		RedPoint,
		// Token: 0x0402896F RID: 166255
		SpriteSelected,
		// Token: 0x04028970 RID: 166256
		PanelFilterStrength,
		// Token: 0x04028971 RID: 166257
		SpriteArrow
	}
}
