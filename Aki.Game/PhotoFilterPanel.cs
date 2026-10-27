using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002567 RID: 9575
[NullableContext(1)]
[Nullable(0)]
public class PhotoFilterPanel : PhotoDetailPanelBase
{
	// Token: 0x06013524 RID: 79140 RVA: 0x004CE9F0 File Offset: 0x004CCBF0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(10, new Action(this.OnResetAllSenoirParamClick)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnBackClick))
		};
	}

	// Token: 0x170018F6 RID: 6390
	// (get) Token: 0x06013525 RID: 79141 RVA: 0x004CEC1E File Offset: 0x004CCE1E
	protected override int TabLockPanelIndex
	{
		get
		{
			return 16;
		}
	}

	// Token: 0x170018F7 RID: 6391
	// (get) Token: 0x06013526 RID: 79142 RVA: 0x004CEC22 File Offset: 0x004CCE22
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 18;
		}
	}

	// Token: 0x170018F8 RID: 6392
	// (get) Token: 0x06013527 RID: 79143 RVA: 0x004CEC26 File Offset: 0x004CCE26
	protected override string SubTabSwitchSequenceName
	{
		get
		{
			return "Switch";
		}
	}

	// Token: 0x06013528 RID: 79144 RVA: 0x004CEC30 File Offset: 0x004CCE30
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoFilterPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoFilterPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013529 RID: 79145 RVA: 0x004CEC73 File Offset: 0x004CCE73
	public override void OnTick(float delta)
	{
		PhotoFilterPointItem pointItem = this.PointItem;
		if (pointItem == null)
		{
			return;
		}
		pointItem.OnPointTick(delta);
	}

	// Token: 0x0601352A RID: 79146 RVA: 0x004CEC86 File Offset: 0x004CCE86
	public override void RefreshDetail()
	{
		this.RefreshPanel();
	}

	// Token: 0x0601352B RID: 79147 RVA: 0x004CEC8E File Offset: 0x004CCE8E
	private void RefreshPanel()
	{
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(this.IsFilterListPanel);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(!this.IsFilterListPanel);
	}

	// Token: 0x0601352C RID: 79148 RVA: 0x004CECC2 File Offset: 0x004CCEC2
	private void SetFilterListMode(bool isListMode)
	{
		this.IsFilterListPanel = isListMode;
		this.RefreshPanel();
		Action<bool> onFilterDetailModeChanged = this.ViewModel.OnFilterDetailModeChanged;
		if (onFilterDetailModeChanged == null)
		{
			return;
		}
		onFilterDetailModeChanged(!isListMode);
	}

	// Token: 0x0601352D RID: 79149 RVA: 0x004CECEC File Offset: 0x004CCEEC
	private UniTask RefreshFilterList()
	{
		PhotoFilterPanel.<RefreshFilterList>d__20 <RefreshFilterList>d__;
		<RefreshFilterList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshFilterList>d__.<>4__this = this;
		<RefreshFilterList>d__.<>1__state = -1;
		<RefreshFilterList>d__.<>t__builder.Start<PhotoFilterPanel.<RefreshFilterList>d__20>(ref <RefreshFilterList>d__);
		return <RefreshFilterList>d__.<>t__builder.Task;
	}

	// Token: 0x0601352E RID: 79150 RVA: 0x004CED30 File Offset: 0x004CCF30
	private UniTask RefreshSubTabList()
	{
		PhotoFilterPanel.<RefreshSubTabList>d__21 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoFilterPanel.<RefreshSubTabList>d__21>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x0601352F RID: 79151 RVA: 0x004CED74 File Offset: 0x004CCF74
	private void ShowSubTabContent(EPhotoFilterSubTabType subTabType)
	{
		bool flag = subTabType == EPhotoFilterSubTabType.Point;
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(9);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		PhotoFilterPointItem pointItem = this.PointItem;
		if (pointItem != null)
		{
			pointItem.SetPointSubTabActive(flag);
		}
		if (!flag)
		{
			this.SeniorParamScroll.RefreshByData(new List<FilterSeniorSetting>(this.SeniorParamScroll.GetGenericLayout().GetDatas()), null, true);
			this.RefreshResetAllSeniorParamBtn();
			return;
		}
		PhotoFilterPointItem pointItem2 = this.PointItem;
		if (pointItem2 != null)
		{
			pointItem2.RefreshTitle();
		}
		PhotoFilterPointItem pointItem3 = this.PointItem;
		if (pointItem3 == null)
		{
			return;
		}
		pointItem3.RefreshResetBtn();
	}

	// Token: 0x06013530 RID: 79152 RVA: 0x004CEE10 File Offset: 0x004CD010
	private UniTask RefreshSeniorParamList()
	{
		PhotoFilterPanel.<RefreshSeniorParamList>d__23 <RefreshSeniorParamList>d__;
		<RefreshSeniorParamList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSeniorParamList>d__.<>4__this = this;
		<RefreshSeniorParamList>d__.<>1__state = -1;
		<RefreshSeniorParamList>d__.<>t__builder.Start<PhotoFilterPanel.<RefreshSeniorParamList>d__23>(ref <RefreshSeniorParamList>d__);
		return <RefreshSeniorParamList>d__.<>t__builder.Task;
	}

	// Token: 0x06013531 RID: 79153 RVA: 0x004CEE53 File Offset: 0x004CD053
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.FilterViewModel.OnViewDestroy();
	}

	// Token: 0x06013532 RID: 79154 RVA: 0x004CEE6C File Offset: 0x004CD06C
	private void OnResetAllSenoirParamClick()
	{
		FilterSettingViewModel filterViewModel = this.FilterViewModel;
		if (filterViewModel != null)
		{
			Action onResetAllSeniorParamClick = filterViewModel.OnResetAllSeniorParamClick;
			if (onResetAllSeniorParamClick != null)
			{
				onResetAllSeniorParamClick();
			}
		}
		this.SeniorParamScroll.RefreshByData(new List<FilterSeniorSetting>(this.SeniorParamScroll.GetGenericLayout().GetDatas()), null, true);
		this.RefreshResetAllSeniorParamBtn();
	}

	// Token: 0x06013533 RID: 79155 RVA: 0x004CEEBD File Offset: 0x004CD0BD
	public override void HideDetail()
	{
		if (!this.IsFilterListPanel)
		{
			this.BackToFilterListPanel();
		}
		base.HideDetail();
	}

	// Token: 0x06013534 RID: 79156 RVA: 0x004CEED3 File Offset: 0x004CD0D3
	private void OnBackClick()
	{
		this.BackToFilterListPanel();
	}

	// Token: 0x06013535 RID: 79157 RVA: 0x004CEEDB File Offset: 0x004CD0DB
	private void BackToFilterListPanel()
	{
		this.SetFilterListMode(true);
		LoopScrollView<PhotoFilterSetItem, FilterSetting> filterScroll = this.FilterScroll;
		if (filterScroll == null)
		{
			return;
		}
		filterScroll.RefreshAllGridProxies();
	}

	// Token: 0x06013536 RID: 79158 RVA: 0x004CEEF4 File Offset: 0x004CD0F4
	private void OnFilterClick(FilterSetting data)
	{
		int gridIndex = Array.FindIndex<FilterSetting>(this.FilterViewModel.FilterList, (FilterSetting setting) => setting.Id == data.Id);
		this.FilterScroll.SelectGridProxy(gridIndex, false);
		FilterSettingViewModel filterViewModel = this.FilterViewModel;
		if (filterViewModel != null)
		{
			Action<int> onIndexChanged = filterViewModel.OnIndexChanged;
			if (onIndexChanged != null)
			{
				onIndexChanged(data.Id);
			}
		}
		bool flag = data.Id == 1;
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIItem item2 = base.GetItem(15);
		if (item2 != null)
		{
			item2.SetUIActive(flag);
		}
		if (!flag)
		{
			PhotoFilterStrengthSliderItem strengthSlider = this.StrengthSlider;
			if (strengthSlider != null)
			{
				strengthSlider.RefreshByViewModel();
			}
		}
		PhotoFilterPointItem pointItem = this.PointItem;
		if (pointItem != null)
		{
			pointItem.RefreshTitle();
		}
		PhotoFilterPointItem pointItem2 = this.PointItem;
		if (pointItem2 != null)
		{
			pointItem2.RefreshResetBtn();
		}
		this.RefreshFilterName();
		this.RefreshResetAllSeniorParamBtn();
	}

	// Token: 0x06013537 RID: 79159 RVA: 0x004CEFDB File Offset: 0x004CD1DB
	private void RefreshFilterName()
	{
		FilterSettingViewModel filterViewModel = this.FilterViewModel;
		if (((filterViewModel != null) ? filterViewModel.FilterNameTextId : null) == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(20), this.FilterViewModel.FilterNameTextId, Array.Empty<object>());
	}

	// Token: 0x06013538 RID: 79160 RVA: 0x004CF014 File Offset: 0x004CD214
	private PhotoFilterSetItem CreateFilterItem()
	{
		return new PhotoFilterSetItem
		{
			OnFilterClick = new Action<FilterSetting>(this.OnFilterClick),
			OnEditClick = new Action<FilterSetting>(this.OnFilterEditClick)
		};
	}

	// Token: 0x06013539 RID: 79161 RVA: 0x004CF03F File Offset: 0x004CD23F
	private void OnFilterEditClick(FilterSetting data)
	{
		base.PlaySequence("Switch2");
		this.SetFilterListMode(false);
	}

	// Token: 0x0601353A RID: 79162 RVA: 0x004CF054 File Offset: 0x004CD254
	private void OnSubTabClick(PhotoSubTab data, bool playSwitchAnim = true)
	{
		GenericScrollViewNew<PhotoFilterSubTabItem, PhotoSubTab> subTabScroll = this.SubTabScroll;
		if (subTabScroll != null)
		{
			GenericLayout<PhotoFilterSubTabItem, PhotoSubTab> genericLayout = subTabScroll.GetGenericLayout();
			if (genericLayout != null)
			{
				genericLayout.SelectGridProxyByKey(data.Id, false);
			}
		}
		base.SetSubTabId(data.Id, playSwitchAnim);
		this.ShowSubTabContent((EPhotoFilterSubTabType)data.Type);
	}

	// Token: 0x0601353B RID: 79163 RVA: 0x004CF0A5 File Offset: 0x004CD2A5
	private PhotoFilterSubTabItem CreateSubTabItem()
	{
		return new PhotoFilterSubTabItem
		{
			OnSubTabClick = delegate(PhotoSubTab data)
			{
				this.OnSubTabClick(data, true);
			}
		};
	}

	// Token: 0x0601353C RID: 79164 RVA: 0x004CF0BE File Offset: 0x004CD2BE
	private PhotoFilterSeniorSliderItem CreateSeniorParamItem()
	{
		return new PhotoFilterSeniorSliderItem
		{
			ParentViewModel = this.FilterViewModel,
			OnParamValueChanged = new Action(this.RefreshResetAllSeniorParamBtn)
		};
	}

	// Token: 0x0601353D RID: 79165 RVA: 0x004CF0E3 File Offset: 0x004CD2E3
	private void RefreshResetAllSeniorParamBtn()
	{
		UUIButtonComponent button = base.GetButton(10);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(FilterSettingController.Instance.IsAnySeniorParamChanged());
	}

	// Token: 0x040091B7 RID: 37303
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhotoFilterSetItem, FilterSetting> FilterScroll;

	// Token: 0x040091B8 RID: 37304
	[Nullable(2)]
	private FilterSettingViewModel FilterViewModel;

	// Token: 0x040091B9 RID: 37305
	[Nullable(2)]
	private PhotoFilterPointItem PointItem;

	// Token: 0x040091BA RID: 37306
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<PhotoFilterSeniorSliderItem, FilterSeniorSetting> SeniorParamScroll;

	// Token: 0x040091BB RID: 37307
	[Nullable(2)]
	private PhotoFilterStrengthSliderItem StrengthSlider;

	// Token: 0x040091BC RID: 37308
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<PhotoFilterSubTabItem, PhotoSubTab> SubTabScroll;

	// Token: 0x040091BD RID: 37309
	private bool IsFilterListPanel = true;

	// Token: 0x02008B44 RID: 35652
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D370 RID: 185200
		ItemFilterListPanel,
		// Token: 0x0402D371 RID: 185201
		LoopScrollFilters,
		// Token: 0x0402D372 RID: 185202
		ItemFilterTemplate,
		// Token: 0x0402D373 RID: 185203
		ItemDetailAdjustPanel,
		// Token: 0x0402D374 RID: 185204
		ItemSubTabMenu,
		// Token: 0x0402D375 RID: 185205
		BtnBack,
		// Token: 0x0402D376 RID: 185206
		ScrollSubTab,
		// Token: 0x0402D377 RID: 185207
		ItemSubTabTemplate,
		// Token: 0x0402D378 RID: 185208
		ItemPointArea,
		// Token: 0x0402D379 RID: 185209
		ItemSeniorParamPanel,
		// Token: 0x0402D37A RID: 185210
		BtnResetAllSeniorParam,
		// Token: 0x0402D37B RID: 185211
		ScrollSeniorParam,
		// Token: 0x0402D37C RID: 185212
		ItemSeniorParamTemplate,
		// Token: 0x0402D37D RID: 185213
		ItemStrengthPanel,
		// Token: 0x0402D37E RID: 185214
		ItemStrengthSlider,
		// Token: 0x0402D37F RID: 185215
		ItemEmpty,
		// Token: 0x0402D380 RID: 185216
		ItemTabLockPanel,
		// Token: 0x0402D381 RID: 185217
		TextTabLockTips,
		// Token: 0x0402D382 RID: 185218
		ItemSubTabLockPanel,
		// Token: 0x0402D383 RID: 185219
		TextSubTabLockTips,
		// Token: 0x0402D384 RID: 185220
		TextFilterName
	}
}
