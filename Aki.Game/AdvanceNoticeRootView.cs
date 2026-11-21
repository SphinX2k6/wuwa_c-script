using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200058E RID: 1422
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeRootView : UiViewBase
{
	// Token: 0x060043DF RID: 17375 RVA: 0x00176EF5 File Offset: 0x001750F5
	public AdvanceNoticeRootView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060043E0 RID: 17376 RVA: 0x00176F00 File Offset: 0x00175100
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnLeftArrowButtonClick)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnRightArrowButtonClick))
		};
	}

	// Token: 0x060043E1 RID: 17377 RVA: 0x0017701C File Offset: 0x0017521C
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeRootView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeRootView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060043E2 RID: 17378 RVA: 0x00177060 File Offset: 0x00175260
	protected override void OnBeforeShow()
	{
		this.HideArrow();
		this.HasTabScrollFirstLateUpdate = false;
		int num = this.ViewModel.TabIndex;
		if (num == 0 || num == -1)
		{
			num = 0;
		}
		this.TabComponent.LateScrollToToggleByIndex(num);
	}

	// Token: 0x060043E3 RID: 17379 RVA: 0x0017709C File Offset: 0x0017529C
	protected void InitTabComponent()
	{
		CommonTabComponentData<AdvanceNoticeTabItem> data = new CommonTabComponentData<AdvanceNoticeTabItem>(new Func<UUIItem, int?, AdvanceNoticeTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<AdvanceNoticeTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
		this.TabComponent.SetHelpButtonShowState(false);
		this.TabViewComponent = new TabViewComponent<AdvanceNoticeViewModel>(base.GetItem(1), EKeyMode.Default);
	}

	// Token: 0x060043E4 RID: 17380 RVA: 0x00177114 File Offset: 0x00175314
	private UniTask InitTabListAsync()
	{
		AdvanceNoticeRootView.<InitTabListAsync>d__11 <InitTabListAsync>d__;
		<InitTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabListAsync>d__.<>4__this = this;
		<InitTabListAsync>d__.<>1__state = -1;
		<InitTabListAsync>d__.<>t__builder.Start<AdvanceNoticeRootView.<InitTabListAsync>d__11>(ref <InitTabListAsync>d__);
		return <InitTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060043E5 RID: 17381 RVA: 0x00177157 File Offset: 0x00175357
	private AdvanceNoticeTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new AdvanceNoticeTabItem();
	}

	// Token: 0x060043E6 RID: 17382 RVA: 0x00177160 File Offset: 0x00175360
	private void ToggleCallBack(int index)
	{
		AdvanceNoticeTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(index);
		int id = this.ViewModel.TabList[index];
		AdvertisingTabInfo advertisingTabInfoById = AdvanceNoticeConfig.Instance.GetAdvertisingTabInfoById(id);
		EUiTabViewName viewName = AdvanceNoticeDefine.advanceNoticeTabTypeToTabViewName[(EAdvanceNoticeTabType)advertisingTabInfoById.Type];
		this.ViewModel.UpdateTabDataOnTabChange(index);
		this.TabViewComponent.ToggleCallBack(this.ViewModel, viewName, tabItemByIndex, null, null);
		this.AdvanceNoticeSwitchComponent.Refresh(this.ViewModel);
		AdvanceNoticeViewModel viewModel = this.ViewModel;
		if (viewModel == null)
		{
			return;
		}
		viewModel.ClickTabLogEvent();
	}

	// Token: 0x060043E7 RID: 17383 RVA: 0x001771F8 File Offset: 0x001753F8
	private CommonTabData GetCommonData(int index)
	{
		int id = this.ViewModel.TabList[index];
		AdvertisingTabInfo advertisingTabInfoById = AdvanceNoticeConfig.Instance.GetAdvertisingTabInfoById(id);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("AdvanceNoticeTitleIcon");
		CommonTabData commonTabData = new CommonTabData(advertisingTabInfoById.TabIcon, new CommonTabTitleData("Advertising_SubTitle", Array.Empty<object>()), new CommonTabTitleData(advertisingTabInfoById.TabTitle, Array.Empty<object>()));
		commonTabData.SetSmallIcon(resourcePath);
		return commonTabData;
	}

	// Token: 0x060043E8 RID: 17384 RVA: 0x00177268 File Offset: 0x00175468
	private void OnSwitchSubTab(int subTabIndex)
	{
		AdvanceNoticeTabViewBase advanceNoticeTabViewBase = this.TabViewComponent.GetTabViewByTabKey(this.ViewModel.CurrentTabView, null) as AdvanceNoticeTabViewBase;
		if (advanceNoticeTabViewBase != null)
		{
			advanceNoticeTabViewBase.OnSwitchSubTab(subTabIndex);
		}
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x001772A4 File Offset: 0x001754A4
	private void OnCloseClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x060043EA RID: 17386 RVA: 0x001772AD File Offset: 0x001754AD
	private void OnLeftArrowButtonClick()
	{
		this.AdvanceNoticeSwitchComponent.SelectPreviousThumb();
	}

	// Token: 0x060043EB RID: 17387 RVA: 0x001772BA File Offset: 0x001754BA
	private void OnRightArrowButtonClick()
	{
		this.AdvanceNoticeSwitchComponent.SelectNextThumb();
	}

	// Token: 0x060043EC RID: 17388 RVA: 0x001772C7 File Offset: 0x001754C7
	private void OnTabScrollValueChange(FVector2D _)
	{
		if (!this.HasTabScrollFirstLateUpdate)
		{
			return;
		}
		this.RefreshArrow();
	}

	// Token: 0x060043ED RID: 17389 RVA: 0x001772D8 File Offset: 0x001754D8
	private void OnTabScrollLateUpdate(float _)
	{
		if (!this.HasTabScrollFirstLateUpdate)
		{
			this.RefreshArrow();
			this.HasTabScrollFirstLateUpdate = true;
		}
	}

	// Token: 0x060043EE RID: 17390 RVA: 0x001772F0 File Offset: 0x001754F0
	private void RefreshArrow()
	{
		int count = this.ViewModel.TabList.Count;
		if (this.TabComponent == null || count <= 0)
		{
			this.HideArrow();
			return;
		}
		UUIScrollViewWithScrollbarComponent scrollView = this.TabComponent.GetScrollView();
		AdvanceNoticeTabItem tabItemByIndex = this.TabComponent.GetTabItemByIndex(0);
		UUIItem uuiitem = (tabItemByIndex != null) ? tabItemByIndex.GetRootItem() : null;
		AdvanceNoticeTabItem tabItemByIndex2 = this.TabComponent.GetTabItemByIndex(count - 1);
		UUIItem uuiitem2 = (tabItemByIndex2 != null) ? tabItemByIndex2.GetRootItem() : null;
		if (uuiitem == null || uuiitem2 == null)
		{
			this.HideArrow();
			return;
		}
		EOutOfBoundsType eoutOfBoundsType = EOutOfBoundsType.EOutOfBoundsType_MAX;
		EOutOfBoundsType eoutOfBoundsType2 = EOutOfBoundsType.EOutOfBoundsType_MAX;
		scrollView.GetOutOfBottomBoundsType(uuiitem, ref eoutOfBoundsType, ref eoutOfBoundsType2, 0.1f);
		EOutOfBoundsType eoutOfBoundsType3 = EOutOfBoundsType.EOutOfBoundsType_MAX;
		EOutOfBoundsType eoutOfBoundsType4 = EOutOfBoundsType.EOutOfBoundsType_MAX;
		scrollView.GetOutOfBottomBoundsType(uuiitem2, ref eoutOfBoundsType3, ref eoutOfBoundsType4, 0.1f);
		base.GetItem(2).SetUIActive(eoutOfBoundsType == EOutOfBoundsType.OutOfBegin);
		base.GetItem(3).SetUIActive(eoutOfBoundsType3 == EOutOfBoundsType.OutOfEnd);
	}

	// Token: 0x060043EF RID: 17391 RVA: 0x001773BC File Offset: 0x001755BC
	private void HideArrow()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x060043F0 RID: 17392 RVA: 0x001773D8 File Offset: 0x001755D8
	protected override void OnBeforeDestroy()
	{
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
	}

	// Token: 0x040034B4 RID: 13492
	[Nullable(2)]
	protected AdvanceNoticeViewModel ViewModel;

	// Token: 0x040034B5 RID: 13493
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<AdvanceNoticeTabItem> TabComponent;

	// Token: 0x040034B6 RID: 13494
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabViewComponent<AdvanceNoticeViewModel> TabViewComponent;

	// Token: 0x040034B7 RID: 13495
	[Nullable(2)]
	protected AdvanceNoticeSwitchComponent AdvanceNoticeSwitchComponent;

	// Token: 0x040034B8 RID: 13496
	protected bool HasTabScrollFirstLateUpdate;

	// Token: 0x02006835 RID: 26677
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040225B5 RID: 140725
		public const int CaptionItem = 0;

		// Token: 0x040225B6 RID: 140726
		public const int ContentRootItem = 1;

		// Token: 0x040225B7 RID: 140727
		public const int ArrowUpItem = 2;

		// Token: 0x040225B8 RID: 140728
		public const int ArrowDownItem = 3;

		// Token: 0x040225B9 RID: 140729
		public const int ThumbScrollView = 4;

		// Token: 0x040225BA RID: 140730
		public const int ThumbItem = 5;

		// Token: 0x040225BB RID: 140731
		public const int LeftArrowButton = 6;

		// Token: 0x040225BC RID: 140732
		public const int RightArrowButton = 7;

		// Token: 0x040225BD RID: 140733
		public const int ReminderText = 8;
	}
}
