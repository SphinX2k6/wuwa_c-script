using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001854 RID: 6228
[NullableContext(1)]
[Nullable(0)]
public class PayShopRechargeView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F661 RID: 63073 RVA: 0x0047F644 File Offset: 0x0047D844
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText))
		};
	}

	// Token: 0x0600F662 RID: 63074 RVA: 0x0047F724 File Offset: 0x0047D924
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600F663 RID: 63075 RVA: 0x0047F7A0 File Offset: 0x0047D9A0
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
		EventSystem.Instance.Remove<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x0600F664 RID: 63076 RVA: 0x0047F81A File Offset: 0x0047DA1A
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (this.CurrentShopId == (int)shopId && this.CurrentSelectTabId == tabId)
		{
			this.TryRefreshTabs();
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x0600F665 RID: 63077 RVA: 0x0047F83F File Offset: 0x0047DA3F
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F666 RID: 63078 RVA: 0x0047F850 File Offset: 0x0047DA50
	protected override void OnStart()
	{
		this.TabGroup = new TabComponent<PayShopSwitchItem>(base.GetHorizontalLayout(2).GetRootComponent(), new Func<UUIItem, int?, PayShopSwitchItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), base.GetItem(3));
		UUIItem scrollItem = this.GetScrollItem();
		this.LoopScrollView = new LoopScrollView<PayShopBigItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(1), scrollItem.GetOwner() as AUIBaseActor, new Func<PayShopBigItem>(this.InitItem), false);
		base.GetItem(0).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:TabView 界面Start";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600F667 RID: 63079 RVA: 0x0047F917 File Offset: 0x0047DB17
	protected UUIItem GetScrollItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x0600F668 RID: 63080 RVA: 0x0047F920 File Offset: 0x0047DB20
	protected PayShopBigItem InitItem()
	{
		PayShopBigItem payShopBigItem = new PayShopBigItem();
		payShopBigItem.SetOnClickRechargeCallback(delegate(PayItemData data)
		{
			OnClickRechargeItemLogEvent onClickRechargeItemLogEvent = new OnClickRechargeItemLogEvent();
			onClickRechargeItemLogEvent.i_id = data.PayItemId;
			onClickRechargeItemLogEvent.i_shop_id = 100;
			LogReportController.Instance.LogReport(onClickRechargeItemLogEvent);
		});
		return payShopBigItem;
	}

	// Token: 0x0600F669 RID: 63081 RVA: 0x0047F94C File Offset: 0x0047DB4C
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x0600F66A RID: 63082 RVA: 0x0047F95A File Offset: 0x0047DB5A
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x0600F66B RID: 63083 RVA: 0x0047F964 File Offset: 0x0047DB64
	private void ToggleCallBack(int tabIndex)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:TabView 点击刷新商品";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		this.CurrentSelectTabId = payShopTabIdList[tabIndex];
		this.RefreshLoopScroll(this.CurrentSelectTabId);
		OnClickPayShopTabLogEvent onClickPayShopTabLogEvent = new OnClickPayShopTabLogEvent();
		onClickPayShopTabLogEvent.i_shop_id = this.CurrentShopId;
		onClickPayShopTabLogEvent.i_tab_id = this.CurrentSelectTabId;
		LogReportController.Instance.LogReport(onClickPayShopTabLogEvent);
	}

	// Token: 0x0600F66C RID: 63084 RVA: 0x0047F9F4 File Offset: 0x0047DBF4
	protected void RefreshLoopScroll(int tabId)
	{
		List<PayItemData> dataList = PayItemModel.Instance.GetDataList();
		List<PayItemData> list = new List<PayItemData>();
		int count = dataList.Count;
		for (int i = 0; i < count; i++)
		{
			PayItemData payItemData = dataList[i];
			if (payItemData.GetIfCanShow())
			{
				list.Add(payItemData);
			}
		}
		list.Sort((PayItemData payItem1, PayItemData payItem2) => payItem1.ItemCount - payItem2.ItemCount);
		this.PayShopGoodsList.Clear();
		int count2 = list.Count;
		for (int j = 0; j < count2; j++)
		{
			this.PayShopGoodsList.Add(list[j]);
		}
		this.CheckSdkProductInfoConfirmIfCanShow(list);
		this.LoopScrollView.ReloadProxyData(new Func<int, IPayShopUnionData>(this.GetProxyData), this.PayShopGoodsList.Count, false, false);
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(true);
	}

	// Token: 0x0600F66D RID: 63085 RVA: 0x0047FAE8 File Offset: 0x0047DCE8
	private bool CheckSdkProductInfoConfirmIfCanShow(List<PayItemData> currentShowData)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (!((platformSdk != null) ? new bool?(platformSdk.NeedConfirmSdkProductInfo()) : null).GetValueOrDefault())
		{
			return true;
		}
		if (currentShowData.Count > 0)
		{
			return true;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CannotFindSdkProduct);
		Action value = delegate()
		{
			UiManager.Instance.CloseView(EUiViewName.PayShopRootView, null);
		};
		confirmBoxDataNew.FunctionMap.Add(1, value);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		this.OpenThirdPartyMessageBox().Forget();
		return false;
	}

	// Token: 0x0600F66E RID: 63086 RVA: 0x0047FB88 File Offset: 0x0047DD88
	private UniTask OpenThirdPartyMessageBox()
	{
		PayShopRechargeView.<OpenThirdPartyMessageBox>d__24 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<PayShopRechargeView.<OpenThirdPartyMessageBox>d__24>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x0600F66F RID: 63087 RVA: 0x0047FBC4 File Offset: 0x0047DDC4
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PayShopRechargeView.<OnBeforeShowAsyncImplement>d__25 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PayShopRechargeView.<OnBeforeShowAsyncImplement>d__25>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600F670 RID: 63088 RVA: 0x0047FC08 File Offset: 0x0047DE08
	protected override void OnBeforeShow()
	{
		base.GetItem(4).SetUIActive(false);
		this.TabGroup.SetActive(false);
		OnClickPayShopTabLogEvent onClickPayShopTabLogEvent = new OnClickPayShopTabLogEvent();
		onClickPayShopTabLogEvent.i_shop_id = this.CurrentShopId;
		LogReportController.Instance.LogReport(onClickPayShopTabLogEvent);
	}

	// Token: 0x0600F671 RID: 63089 RVA: 0x0047FC4B File Offset: 0x0047DE4B
	protected override void OnShowUiTabViewFromToggle()
	{
		this.TabShowState = true;
		this.AfterShowUiTabViewFromToggle();
	}

	// Token: 0x0600F672 RID: 63090 RVA: 0x0047FC5A File Offset: 0x0047DE5A
	protected void AfterShowUiTabViewFromToggle()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x0600F673 RID: 63091 RVA: 0x0047FC71 File Offset: 0x0047DE71
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		this.RemoveTimer();
		this.TabShowState = false;
		this.AfterHideTabViewBase(fromToggle);
	}

	// Token: 0x0600F674 RID: 63092 RVA: 0x0047FC87 File Offset: 0x0047DE87
	protected void AfterHideTabViewBase(bool fromToggle)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.HidePlayStationStoreIcon();
	}

	// Token: 0x0600F675 RID: 63093 RVA: 0x0047FCA0 File Offset: 0x0047DEA0
	protected override void OnAfterShow()
	{
		this.CurrentShopId = (int)this.Params;
		int num = 0;
		if (this.ExtraParams != null)
		{
			int switchId = (int)this.ExtraParams;
			List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
			num = payShopTabIdList.FindIndex((int tabId) => tabId == switchId);
			num = MathUtils.Instance.Clamp(num, 0, payShopTabIdList.Count - 1);
		}
		base.GetText(5).SetUIActive(false);
		this.UpdateTabs(num);
		this.AddTimer();
		this.OnDiscountShopAfterShow();
	}

	// Token: 0x0600F676 RID: 63094 RVA: 0x0047FD39 File Offset: 0x0047DF39
	protected virtual void OnDiscountShopAfterShow()
	{
		base.GetText(5).SetUIActive(true);
	}

	// Token: 0x0600F677 RID: 63095 RVA: 0x0047FD48 File Offset: 0x0047DF48
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600F678 RID: 63096 RVA: 0x0047FD73 File Offset: 0x0047DF73
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600F679 RID: 63097 RVA: 0x0047FD95 File Offset: 0x0047DF95
	private void OnRefreshTimer()
	{
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x0600F67A RID: 63098 RVA: 0x0047FDA8 File Offset: 0x0047DFA8
	protected void TryRefreshTabs()
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		if (this.CurTabNum == payShopTabIdList.Count)
		{
			return;
		}
		int num = payShopTabIdList.FindIndex((int tabId) => tabId == this.CurrentSelectTabId);
		this.UpdateTabs((num == -1) ? 0 : num);
	}

	// Token: 0x0600F67B RID: 63099 RVA: 0x0047FDF8 File Offset: 0x0047DFF8
	protected unsafe void UpdateTabs(int selectIndex)
	{
		List<int> tabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:TabView 页签数据";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ViewName", base.GetViewName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Data", tabIdList);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		int count = tabIdList.Count;
		this.CurTabNum = count;
		this.TabGroup.ResetLastSelectTab();
		Action callBack = delegate()
		{
			foreach (KeyValuePair<int, PayShopSwitchItem> keyValuePair in this.TabGroup.GetTabItemMap())
			{
				int key = keyValuePair.Key;
				PayShopSwitchItem value = keyValuePair.Value;
				value.UpdateView((PayShopDefine.EPayShopTabType)this.CurrentShopId, tabIdList[key]);
				value.BindRedDot(ERedDotName.PayShopTab, tabIdList[key]);
			}
			this.TabGroup.SelectToggleByIndex(selectIndex, true, true);
		};
		this.TabGroup.RefreshTabItemByLength(count, callBack);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Shop;
		ELogAuthor author2 = ELogAuthor.XXJ;
		string message2 = "PayShop:TabView 选择页签";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600F67C RID: 63100 RVA: 0x0047FEF1 File Offset: 0x0047E0F1
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		if (@params is int)
		{
			return;
		}
		this.TryRefreshTabs();
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F67D RID: 63101 RVA: 0x0047FF0E File Offset: 0x0047E10E
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
	}

	// Token: 0x0600F67E RID: 63102 RVA: 0x0047FF10 File Offset: 0x0047E110
	private void OnRefreshPayItemList()
	{
		if (!this.OnShowRequestInfo)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RefreshChargeView);
			Action value = delegate()
			{
				this.RefreshLoopScroll(this.CurrentSelectTabId);
			};
			confirmBoxDataNew.FunctionMap.Add(1, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}
		else
		{
			this.RefreshLoopScroll(this.CurrentSelectTabId);
		}
		this.OnShowRequestInfo = false;
	}

	// Token: 0x0600F67F RID: 63103 RVA: 0x0047FF6B File Offset: 0x0047E16B
	private void OnSdkPayEnd(ESdkDialogResult _)
	{
		this.CheckIfNeedShowPlayStationStoreIcon();
	}

	// Token: 0x0600F680 RID: 63104 RVA: 0x0047FF74 File Offset: 0x0047E174
	private void CheckIfNeedShowPlayStationStoreIcon()
	{
		if (!this.TabShowState)
		{
			return;
		}
		bool flag = false;
		int count = this.PayShopGoodsList.Count;
		for (int i = 0; i < count; i++)
		{
			PayShopGoods payShopGoods = this.PayShopGoodsList[i] as PayShopGoods;
			flag = (payShopGoods == null || payShopGoods.IsDirect());
			if (flag)
			{
				break;
			}
		}
		if (flag)
		{
			PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.ShowPlayStationStoreIcon(0);
			return;
		}
		else
		{
			PlatformSdkNew platformSdk2 = PlatformSdkManagerNew.Instance.GetPlatformSdk();
			if (platformSdk2 == null)
			{
				return;
			}
			platformSdk2.HidePlayStationStoreIcon();
			return;
		}
	}

	// Token: 0x04008A3A RID: 35386
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x04008A3B RID: 35387
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x04008A3C RID: 35388
	protected int CurrentSelectTabId;

	// Token: 0x04008A3D RID: 35389
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<PayShopBigItem, IPayShopUnionData> LoopScrollView;

	// Token: 0x04008A3E RID: 35390
	protected int CurrentShopId;

	// Token: 0x04008A3F RID: 35391
	protected int CurTabNum;

	// Token: 0x04008A40 RID: 35392
	private bool OnShowRequestInfo;

	// Token: 0x04008A41 RID: 35393
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04008A42 RID: 35394
	private bool TabShowState;

	// Token: 0x04008A43 RID: 35395
	private const int TIMEGAP = 1000;

	// Token: 0x02007A8B RID: 31371
	[NullableContext(0)]
	private enum EDiscountShopComponent
	{
		// Token: 0x04027B6E RID: 162670
		ScrollerItem,
		// Token: 0x04027B6F RID: 162671
		Scroller,
		// Token: 0x04027B70 RID: 162672
		HoriGroupScroller,
		// Token: 0x04027B71 RID: 162673
		TabItem,
		// Token: 0x04027B72 RID: 162674
		TabPanel,
		// Token: 0x04027B73 RID: 162675
		TitleTips,
		// Token: 0x04027B74 RID: 162676
		ScrollerItemNew,
		// Token: 0x04027B75 RID: 162677
		PanelItem,
		// Token: 0x04027B76 RID: 162678
		EmptyItem,
		// Token: 0x04027B77 RID: 162679
		EmptyText
	}
}
