using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A52 RID: 6738
[NullableContext(1)]
[Nullable(0)]
public class PhotoFilterPanel : PhotoDetailPanelBase
{
	// Token: 0x06010A06 RID: 68102 RVA: 0x004DD628 File Offset: 0x004DB828
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

	// Token: 0x17001930 RID: 6448
	// (get) Token: 0x06010A07 RID: 68103 RVA: 0x004DD856 File Offset: 0x004DBA56
	protected override int TabLockPanelIndex
	{
		get
		{
			return 16;
		}
	}

	// Token: 0x17001931 RID: 6449
	// (get) Token: 0x06010A08 RID: 68104 RVA: 0x004DD85A File Offset: 0x004DBA5A
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 18;
		}
	}

	// Token: 0x17001932 RID: 6450
	// (get) Token: 0x06010A09 RID: 68105 RVA: 0x004DD85E File Offset: 0x004DBA5E
	protected override string SubTabSwitchSequenceName
	{
		get
		{
			return "Switch";
		}
	}

	// Token: 0x06010A0A RID: 68106 RVA: 0x004DD868 File Offset: 0x004DBA68
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoFilterPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoFilterPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010A0B RID: 68107 RVA: 0x004DD8AB File Offset: 0x004DBAAB
	public override void OnTick(float delta)
	{
		PhotoFilterPointItem pointItem = this.PointItem;
		if (pointItem == null)
		{
			return;
		}
		pointItem.OnPointTick(delta);
	}

	// Token: 0x06010A0C RID: 68108 RVA: 0x004DD8BE File Offset: 0x004DBABE
	public override void RefreshDetail()
	{
		this.RefreshPanel();
	}

	// Token: 0x06010A0D RID: 68109 RVA: 0x004DD8C6 File Offset: 0x004DBAC6
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

	// Token: 0x06010A0E RID: 68110 RVA: 0x004DD8FA File Offset: 0x004DBAFA
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

	// Token: 0x06010A0F RID: 68111 RVA: 0x004DD924 File Offset: 0x004DBB24
	private UniTask RefreshFilterList()
	{
		PhotoFilterPanel.<RefreshFilterList>d__20 <RefreshFilterList>d__;
		<RefreshFilterList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshFilterList>d__.<>4__this = this;
		<RefreshFilterList>d__.<>1__state = -1;
		<RefreshFilterList>d__.<>t__builder.Start<PhotoFilterPanel.<RefreshFilterList>d__20>(ref <RefreshFilterList>d__);
		return <RefreshFilterList>d__.<>t__builder.Task;
	}

	// Token: 0x06010A10 RID: 68112 RVA: 0x004DD968 File Offset: 0x004DBB68
	private UniTask RefreshSubTabList()
	{
		PhotoFilterPanel.<RefreshSubTabList>d__21 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoFilterPanel.<RefreshSubTabList>d__21>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x06010A11 RID: 68113 RVA: 0x004DD9AC File Offset: 0x004DBBAC
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

	// Token: 0x06010A12 RID: 68114 RVA: 0x004DDA48 File Offset: 0x004DBC48
	private UniTask RefreshSeniorParamList()
	{
		PhotoFilterPanel.<RefreshSeniorParamList>d__23 <RefreshSeniorParamList>d__;
		<RefreshSeniorParamList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSeniorParamList>d__.<>4__this = this;
		<RefreshSeniorParamList>d__.<>1__state = -1;
		<RefreshSeniorParamList>d__.<>t__builder.Start<PhotoFilterPanel.<RefreshSeniorParamList>d__23>(ref <RefreshSeniorParamList>d__);
		return <RefreshSeniorParamList>d__.<>t__builder.Task;
	}

	// Token: 0x06010A13 RID: 68115 RVA: 0x004DDA8B File Offset: 0x004DBC8B
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.FilterViewModel.OnViewDestroy();
	}

	// Token: 0x06010A14 RID: 68116 RVA: 0x004DDAA4 File Offset: 0x004DBCA4
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

	// Token: 0x06010A15 RID: 68117 RVA: 0x004DDAF5 File Offset: 0x004DBCF5
	public override void HideDetail()
	{
		if (!this.IsFilterListPanel)
		{
			this.BackToFilterListPanel();
		}
		base.HideDetail();
	}

	// Token: 0x06010A16 RID: 68118 RVA: 0x004DDB0B File Offset: 0x004DBD0B
	private void OnBackClick()
	{
		this.BackToFilterListPanel();
	}

	// Token: 0x06010A17 RID: 68119 RVA: 0x004DDB13 File Offset: 0x004DBD13
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

	// Token: 0x06010A18 RID: 68120 RVA: 0x004DDB2C File Offset: 0x004DBD2C
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

	// Token: 0x06010A19 RID: 68121 RVA: 0x004DDC13 File Offset: 0x004DBE13
	private void RefreshFilterName()
	{
		FilterSettingViewModel filterViewModel = this.FilterViewModel;
		if (((filterViewModel != null) ? filterViewModel.FilterNameTextId : null) == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(20), this.FilterViewModel.FilterNameTextId, Array.Empty<object>());
	}

	// Token: 0x06010A1A RID: 68122 RVA: 0x004DDC4C File Offset: 0x004DBE4C
	private PhotoFilterSetItem CreateFilterItem()
	{
		return new PhotoFilterSetItem
		{
			OnFilterClick = new Action<FilterSetting>(this.OnFilterClick),
			OnEditClick = new Action<FilterSetting>(this.OnFilterEditClick)
		};
	}

	// Token: 0x06010A1B RID: 68123 RVA: 0x004DDC77 File Offset: 0x004DBE77
	private void OnFilterEditClick(FilterSetting data)
	{
		base.PlaySequence("Switch2");
		this.SetFilterListMode(false);
	}

	// Token: 0x06010A1C RID: 68124 RVA: 0x004DDC8C File Offset: 0x004DBE8C
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

	// Token: 0x06010A1D RID: 68125 RVA: 0x004DDCDD File Offset: 0x004DBEDD
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

	// Token: 0x06010A1E RID: 68126 RVA: 0x004DDCF6 File Offset: 0x004DBEF6
	private PhotoFilterSeniorSliderItem CreateSeniorParamItem()
	{
		return new PhotoFilterSeniorSliderItem
		{
			ParentViewModel = this.FilterViewModel,
			OnParamValueChanged = new Action(this.RefreshResetAllSeniorParamBtn)
		};
	}

	// Token: 0x06010A1F RID: 68127 RVA: 0x004DDD1B File Offset: 0x004DBF1B
	private void RefreshResetAllSeniorParamBtn()
	{
		UUIButtonComponent button = base.GetButton(10);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(FilterSettingController.Instance.IsAnySeniorParamChanged());
	}

	// Token: 0x04009310 RID: 37648
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<PhotoFilterSetItem, FilterSetting> FilterScroll;

	// Token: 0x04009311 RID: 37649
	[Nullable(2)]
	private FilterSettingViewModel FilterViewModel;

	// Token: 0x04009312 RID: 37650
	[Nullable(2)]
	private PhotoFilterPointItem PointItem;

	// Token: 0x04009313 RID: 37651
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<PhotoFilterSeniorSliderItem, FilterSeniorSetting> SeniorParamScroll;

	// Token: 0x04009314 RID: 37652
	[Nullable(2)]
	private PhotoFilterStrengthSliderItem StrengthSlider;

	// Token: 0x04009315 RID: 37653
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<PhotoFilterSubTabItem, PhotoSubTab> SubTabScroll;

	// Token: 0x04009316 RID: 37654
	private bool IsFilterListPanel = true;

	// Token: 0x02007CCA RID: 31946
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402867D RID: 165501
		ItemFilterListPanel,
		// Token: 0x0402867E RID: 165502
		LoopScrollFilters,
		// Token: 0x0402867F RID: 165503
		ItemFilterTemplate,
		// Token: 0x04028680 RID: 165504
		ItemDetailAdjustPanel,
		// Token: 0x04028681 RID: 165505
		ItemSubTabMenu,
		// Token: 0x04028682 RID: 165506
		BtnBack,
		// Token: 0x04028683 RID: 165507
		ScrollSubTab,
		// Token: 0x04028684 RID: 165508
		ItemSubTabTemplate,
		// Token: 0x04028685 RID: 165509
		ItemPointArea,
		// Token: 0x04028686 RID: 165510
		ItemSeniorParamPanel,
		// Token: 0x04028687 RID: 165511
		BtnResetAllSeniorParam,
		// Token: 0x04028688 RID: 165512
		ScrollSeniorParam,
		// Token: 0x04028689 RID: 165513
		ItemSeniorParamTemplate,
		// Token: 0x0402868A RID: 165514
		ItemStrengthPanel,
		// Token: 0x0402868B RID: 165515
		ItemStrengthSlider,
		// Token: 0x0402868C RID: 165516
		ItemEmpty,
		// Token: 0x0402868D RID: 165517
		ItemTabLockPanel,
		// Token: 0x0402868E RID: 165518
		TextTabLockTips,
		// Token: 0x0402868F RID: 165519
		ItemSubTabLockPanel,
		// Token: 0x04028690 RID: 165520
		TextSubTabLockTips,
		// Token: 0x04028691 RID: 165521
		TextFilterName
	}
}
