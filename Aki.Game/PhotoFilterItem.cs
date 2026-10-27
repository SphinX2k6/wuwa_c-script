using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020025C5 RID: 9669
public class PhotoFilterItem : UiPanelBase
{
	// Token: 0x060139C2 RID: 80322 RVA: 0x004E7C50 File Offset: 0x004E5E50
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

	// Token: 0x060139C3 RID: 80323 RVA: 0x004E7D68 File Offset: 0x004E5F68
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

	// Token: 0x060139C4 RID: 80324 RVA: 0x004E7DC6 File Offset: 0x004E5FC6
	protected override void OnBeforeDestroy()
	{
		UUISliderComponent slider = base.GetSlider(4);
		if (slider != null)
		{
			slider.OnValueChangeCb.Unbind();
		}
		this.FilterItemLevelSequencePlayer = null;
	}

	// Token: 0x060139C5 RID: 80325 RVA: 0x004E7DE8 File Offset: 0x004E5FE8
	protected override void OnBeforeShow()
	{
		bool bSelected = !this.IsUnSelected();
		this.SetSelected(bSelected, false);
	}

	// Token: 0x060139C6 RID: 80326 RVA: 0x004E7E08 File Offset: 0x004E6008
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

	// Token: 0x060139C7 RID: 80327 RVA: 0x004E7F08 File Offset: 0x004E6108
	private bool IsUnSelected()
	{
		return PhotographModel.Instance.GetPhotographFilter() != this.PhotoFilterId;
	}

	// Token: 0x060139C8 RID: 80328 RVA: 0x004E7F20 File Offset: 0x004E6120
	private void OnValueChanged(float value)
	{
		PhotographController.Instance.SetSingleFilterStrength(this.PhotoFilterId, value);
		int num = (int)Math.Floor((double)(value * 100f));
		base.GetText(3).SetText(num.ToString(), true);
	}

	// Token: 0x060139C9 RID: 80329 RVA: 0x004E7F61 File Offset: 0x004E6161
	[NullableContext(1)]
	public void BindOnSelected(Action<PhotoFilterItem, bool> onSelected)
	{
		this.OnSelected = onSelected;
	}

	// Token: 0x060139CA RID: 80330 RVA: 0x004E7F6C File Offset: 0x004E616C
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

	// Token: 0x060139CB RID: 80331 RVA: 0x004E7FD4 File Offset: 0x004E61D4
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

	// Token: 0x060139CC RID: 80332 RVA: 0x004E8018 File Offset: 0x004E6218
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

	// Token: 0x060139CD RID: 80333 RVA: 0x004E8102 File Offset: 0x004E6302
	public void ShowFilterItem()
	{
		this.IsVisible = true;
		this.SetActive(true);
	}

	// Token: 0x060139CE RID: 80334 RVA: 0x004E8112 File Offset: 0x004E6312
	public int GetPhotoFilterId()
	{
		return this.PhotoFilterId;
	}

	// Token: 0x060139CF RID: 80335 RVA: 0x004E811A File Offset: 0x004E631A
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

	// Token: 0x060139D0 RID: 80336 RVA: 0x004E813C File Offset: 0x004E633C
	public UniTask PlayDisappearSequenceAsync()
	{
		PhotoFilterItem.<PlayDisappearSequenceAsync>d__21 <PlayDisappearSequenceAsync>d__;
		<PlayDisappearSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDisappearSequenceAsync>d__.<>4__this = this;
		<PlayDisappearSequenceAsync>d__.<>1__state = -1;
		<PlayDisappearSequenceAsync>d__.<>t__builder.Start<PhotoFilterItem.<PlayDisappearSequenceAsync>d__21>(ref <PlayDisappearSequenceAsync>d__);
		return <PlayDisappearSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060139D1 RID: 80337 RVA: 0x004E817F File Offset: 0x004E637F
	[NullableContext(1)]
	public void BindScrollToSelectedItem(Action<PhotoFilterItem> scrollToSelectedItem)
	{
		this.ScrollToSelectedItem = scrollToSelectedItem;
	}

	// Token: 0x060139D2 RID: 80338 RVA: 0x004E8188 File Offset: 0x004E6388
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

	// Token: 0x040093EA RID: 37866
	private int PhotoFilterId;

	// Token: 0x040093EB RID: 37867
	[Nullable(2)]
	private LevelSequencePlayer FilterItemLevelSequencePlayer;

	// Token: 0x040093EC RID: 37868
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhotoFilterItem, bool> OnSelected;

	// Token: 0x040093ED RID: 37869
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhotoFilterItem> ScrollToSelectedItem;

	// Token: 0x040093EE RID: 37870
	private PhotoFilter? PhotoFilterConfig;

	// Token: 0x040093EF RID: 37871
	private bool IsVisible;

	// Token: 0x02008BD6 RID: 35798
	private enum EChildType
	{
		// Token: 0x0402D653 RID: 185939
		Toggle,
		// Token: 0x0402D654 RID: 185940
		TextName,
		// Token: 0x0402D655 RID: 185941
		TextureIcon,
		// Token: 0x0402D656 RID: 185942
		TextFilterStrengthNum,
		// Token: 0x0402D657 RID: 185943
		ValueSlider,
		// Token: 0x0402D658 RID: 185944
		SpriteHandle,
		// Token: 0x0402D659 RID: 185945
		RedPoint,
		// Token: 0x0402D65A RID: 185946
		SpriteSelected,
		// Token: 0x0402D65B RID: 185947
		PanelFilterStrength,
		// Token: 0x0402D65C RID: 185948
		SpriteArrow
	}
}
