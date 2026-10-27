using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010DA RID: 4314
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeRootView : UiViewBase
{
	// Token: 0x06007049 RID: 28745 RVA: 0x0016E539 File Offset: 0x0016C739
	public AdvanceNoticeRootView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600704A RID: 28746 RVA: 0x0016E544 File Offset: 0x0016C744
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

	// Token: 0x0600704B RID: 28747 RVA: 0x0016E660 File Offset: 0x0016C860
	protected override UniTask OnBeforeStartAsync()
	{
		AdvanceNoticeRootView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AdvanceNoticeRootView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600704C RID: 28748 RVA: 0x0016E6A4 File Offset: 0x0016C8A4
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

	// Token: 0x0600704D RID: 28749 RVA: 0x0016E6E0 File Offset: 0x0016C8E0
	protected void InitTabComponent()
	{
		CommonTabComponentData<AdvanceNoticeTabItem> data = new CommonTabComponentData<AdvanceNoticeTabItem>(new Func<UUIItem, int?, AdvanceNoticeTabItem>(this.ProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
		this.TabComponent = new TabComponentWithCaptionItem<AdvanceNoticeTabItem>(base.GetItem(0), data, new Action(this.OnCloseClicked), false);
		this.TabComponent.SetHelpButtonShowState(false);
		this.TabViewComponent = new TabViewComponent<AdvanceNoticeViewModel>(base.GetItem(1), EKeyMode.Default);
	}

	// Token: 0x0600704E RID: 28750 RVA: 0x0016E758 File Offset: 0x0016C958
	private UniTask InitTabListAsync()
	{
		AdvanceNoticeRootView.<InitTabListAsync>d__11 <InitTabListAsync>d__;
		<InitTabListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTabListAsync>d__.<>4__this = this;
		<InitTabListAsync>d__.<>1__state = -1;
		<InitTabListAsync>d__.<>t__builder.Start<AdvanceNoticeRootView.<InitTabListAsync>d__11>(ref <InitTabListAsync>d__);
		return <InitTabListAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600704F RID: 28751 RVA: 0x0016E79B File Offset: 0x0016C99B
	private AdvanceNoticeTabItem ProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new AdvanceNoticeTabItem();
	}

	// Token: 0x06007050 RID: 28752 RVA: 0x0016E7A4 File Offset: 0x0016C9A4
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

	// Token: 0x06007051 RID: 28753 RVA: 0x0016E83C File Offset: 0x0016CA3C
	private CommonTabData GetCommonData(int index)
	{
		int id = this.ViewModel.TabList[index];
		AdvertisingTabInfo advertisingTabInfoById = AdvanceNoticeConfig.Instance.GetAdvertisingTabInfoById(id);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("AdvanceNoticeTitleIcon");
		CommonTabData commonTabData = new CommonTabData(advertisingTabInfoById.TabIcon, new CommonTabTitleData("Advertising_SubTitle", Array.Empty<object>()), new CommonTabTitleData(advertisingTabInfoById.TabTitle, Array.Empty<object>()));
		commonTabData.SetSmallIcon(resourcePath);
		return commonTabData;
	}

	// Token: 0x06007052 RID: 28754 RVA: 0x0016E8AC File Offset: 0x0016CAAC
	private void OnSwitchSubTab(int subTabIndex)
	{
		AdvanceNoticeTabViewBase advanceNoticeTabViewBase = this.TabViewComponent.GetTabViewByTabKey(this.ViewModel.CurrentTabView, null) as AdvanceNoticeTabViewBase;
		if (advanceNoticeTabViewBase != null)
		{
			advanceNoticeTabViewBase.OnSwitchSubTab(subTabIndex);
		}
	}

	// Token: 0x06007053 RID: 28755 RVA: 0x0016E8E8 File Offset: 0x0016CAE8
	private void OnCloseClicked()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007054 RID: 28756 RVA: 0x0016E8F1 File Offset: 0x0016CAF1
	private void OnLeftArrowButtonClick()
	{
		this.AdvanceNoticeSwitchComponent.SelectPreviousThumb();
	}

	// Token: 0x06007055 RID: 28757 RVA: 0x0016E8FE File Offset: 0x0016CAFE
	private void OnRightArrowButtonClick()
	{
		this.AdvanceNoticeSwitchComponent.SelectNextThumb();
	}

	// Token: 0x06007056 RID: 28758 RVA: 0x0016E90B File Offset: 0x0016CB0B
	private void OnTabScrollValueChange(FVector2D _)
	{
		if (!this.HasTabScrollFirstLateUpdate)
		{
			return;
		}
		this.RefreshArrow();
	}

	// Token: 0x06007057 RID: 28759 RVA: 0x0016E91C File Offset: 0x0016CB1C
	private void OnTabScrollLateUpdate(float _)
	{
		if (!this.HasTabScrollFirstLateUpdate)
		{
			this.RefreshArrow();
			this.HasTabScrollFirstLateUpdate = true;
		}
	}

	// Token: 0x06007058 RID: 28760 RVA: 0x0016E934 File Offset: 0x0016CB34
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

	// Token: 0x06007059 RID: 28761 RVA: 0x0016EA00 File Offset: 0x0016CC00
	private void HideArrow()
	{
		base.GetItem(2).SetUIActive(false);
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x0600705A RID: 28762 RVA: 0x0016EA1C File Offset: 0x0016CC1C
	protected override void OnBeforeDestroy()
	{
		if (this.TabComponent != null)
		{
			this.TabComponent.Destroy(null);
			this.TabComponent = null;
		}
	}

	// Token: 0x0400341B RID: 13339
	[Nullable(2)]
	protected AdvanceNoticeViewModel ViewModel;

	// Token: 0x0400341C RID: 13340
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponentWithCaptionItem<AdvanceNoticeTabItem> TabComponent;

	// Token: 0x0400341D RID: 13341
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabViewComponent<AdvanceNoticeViewModel> TabViewComponent;

	// Token: 0x0400341E RID: 13342
	[Nullable(2)]
	protected AdvanceNoticeSwitchComponent AdvanceNoticeSwitchComponent;

	// Token: 0x0400341F RID: 13343
	protected bool HasTabScrollFirstLateUpdate;

	// Token: 0x020076A1 RID: 30369
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402726C RID: 160364
		public const int CaptionItem = 0;

		// Token: 0x0402726D RID: 160365
		public const int ContentRootItem = 1;

		// Token: 0x0402726E RID: 160366
		public const int ArrowUpItem = 2;

		// Token: 0x0402726F RID: 160367
		public const int ArrowDownItem = 3;

		// Token: 0x04027270 RID: 160368
		public const int ThumbScrollView = 4;

		// Token: 0x04027271 RID: 160369
		public const int ThumbItem = 5;

		// Token: 0x04027272 RID: 160370
		public const int LeftArrowButton = 6;

		// Token: 0x04027273 RID: 160371
		public const int RightArrowButton = 7;

		// Token: 0x04027274 RID: 160372
		public const int ReminderText = 8;
	}
}
