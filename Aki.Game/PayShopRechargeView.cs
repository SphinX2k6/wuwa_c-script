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

// Token: 0x0200236F RID: 9071
[NullableContext(1)]
[Nullable(0)]
public class PayShopRechargeView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x060121B1 RID: 74161 RVA: 0x004724C4 File Offset: 0x004706C4
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

	// Token: 0x060121B2 RID: 74162 RVA: 0x004725A4 File Offset: 0x004707A4
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
		EventSystem.Instance.Add<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060121B3 RID: 74163 RVA: 0x00472620 File Offset: 0x00470820
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
		EventSystem.Instance.Remove<PayItemSuccess>(EEventName.OnPayItemSuccess, new Action<PayItemSuccess>(this.OnPayItemSuccess));
	}

	// Token: 0x060121B4 RID: 74164 RVA: 0x0047269A File Offset: 0x0047089A
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (this.CurrentShopId == (int)shopId && this.CurrentSelectTabId == tabId)
		{
			this.TryRefreshTabs();
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x060121B5 RID: 74165 RVA: 0x004726BF File Offset: 0x004708BF
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x060121B6 RID: 74166 RVA: 0x004726D0 File Offset: 0x004708D0
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

	// Token: 0x060121B7 RID: 74167 RVA: 0x00472797 File Offset: 0x00470997
	protected UUIItem GetScrollItem()
	{
		return base.GetItem(6);
	}

	// Token: 0x060121B8 RID: 74168 RVA: 0x004727A0 File Offset: 0x004709A0
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

	// Token: 0x060121B9 RID: 74169 RVA: 0x004727CC File Offset: 0x004709CC
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x060121BA RID: 74170 RVA: 0x004727DA File Offset: 0x004709DA
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x060121BB RID: 74171 RVA: 0x004727E4 File Offset: 0x004709E4
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

	// Token: 0x060121BC RID: 74172 RVA: 0x00472874 File Offset: 0x00470A74
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

	// Token: 0x060121BD RID: 74173 RVA: 0x00472968 File Offset: 0x00470B68
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

	// Token: 0x060121BE RID: 74174 RVA: 0x00472A08 File Offset: 0x00470C08
	private UniTask OpenThirdPartyMessageBox()
	{
		PayShopRechargeView.<OpenThirdPartyMessageBox>d__24 <OpenThirdPartyMessageBox>d__;
		<OpenThirdPartyMessageBox>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenThirdPartyMessageBox>d__.<>1__state = -1;
		<OpenThirdPartyMessageBox>d__.<>t__builder.Start<PayShopRechargeView.<OpenThirdPartyMessageBox>d__24>(ref <OpenThirdPartyMessageBox>d__);
		return <OpenThirdPartyMessageBox>d__.<>t__builder.Task;
	}

	// Token: 0x060121BF RID: 74175 RVA: 0x00472A44 File Offset: 0x00470C44
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		PayShopRechargeView.<OnBeforeShowAsyncImplement>d__25 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PayShopRechargeView.<OnBeforeShowAsyncImplement>d__25>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060121C0 RID: 74176 RVA: 0x00472A88 File Offset: 0x00470C88
	protected override void OnBeforeShow()
	{
		base.GetItem(4).SetUIActive(false);
		this.TabGroup.SetActive(false);
		OnClickPayShopTabLogEvent onClickPayShopTabLogEvent = new OnClickPayShopTabLogEvent();
		onClickPayShopTabLogEvent.i_shop_id = this.CurrentShopId;
		LogReportController.Instance.LogReport(onClickPayShopTabLogEvent);
	}

	// Token: 0x060121C1 RID: 74177 RVA: 0x00472ACB File Offset: 0x00470CCB
	protected override void OnShowUiTabViewFromToggle()
	{
		this.TabShowState = true;
		this.AfterShowUiTabViewFromToggle();
	}

	// Token: 0x060121C2 RID: 74178 RVA: 0x00472ADA File Offset: 0x00470CDA
	protected void AfterShowUiTabViewFromToggle()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.ShowPlayStationStoreIcon(0);
	}

	// Token: 0x060121C3 RID: 74179 RVA: 0x00472AF1 File Offset: 0x00470CF1
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		this.RemoveTimer();
		this.TabShowState = false;
		this.AfterHideTabViewBase(fromToggle);
	}

	// Token: 0x060121C4 RID: 74180 RVA: 0x00472B07 File Offset: 0x00470D07
	protected void AfterHideTabViewBase(bool fromToggle)
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk == null)
		{
			return;
		}
		platformSdk.HidePlayStationStoreIcon();
	}

	// Token: 0x060121C5 RID: 74181 RVA: 0x00472B20 File Offset: 0x00470D20
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

	// Token: 0x060121C6 RID: 74182 RVA: 0x00472BB9 File Offset: 0x00470DB9
	protected virtual void OnDiscountShopAfterShow()
	{
		base.GetText(5).SetUIActive(true);
	}

	// Token: 0x060121C7 RID: 74183 RVA: 0x00472BC8 File Offset: 0x00470DC8
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x060121C8 RID: 74184 RVA: 0x00472BF3 File Offset: 0x00470DF3
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x060121C9 RID: 74185 RVA: 0x00472C15 File Offset: 0x00470E15
	private void OnRefreshTimer()
	{
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x060121CA RID: 74186 RVA: 0x00472C28 File Offset: 0x00470E28
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

	// Token: 0x060121CB RID: 74187 RVA: 0x00472C78 File Offset: 0x00470E78
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

	// Token: 0x060121CC RID: 74188 RVA: 0x00472D71 File Offset: 0x00470F71
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

	// Token: 0x060121CD RID: 74189 RVA: 0x00472D8E File Offset: 0x00470F8E
	private void OnPayItemSuccess(PayItemSuccess notify)
	{
	}

	// Token: 0x060121CE RID: 74190 RVA: 0x00472D90 File Offset: 0x00470F90
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

	// Token: 0x060121CF RID: 74191 RVA: 0x00472DEB File Offset: 0x00470FEB
	private void OnSdkPayEnd(ESdkDialogResult _)
	{
		this.CheckIfNeedShowPlayStationStoreIcon();
	}

	// Token: 0x060121D0 RID: 74192 RVA: 0x00472DF4 File Offset: 0x00470FF4
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

	// Token: 0x040088F5 RID: 35061
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x040088F6 RID: 35062
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x040088F7 RID: 35063
	protected int CurrentSelectTabId;

	// Token: 0x040088F8 RID: 35064
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<PayShopBigItem, IPayShopUnionData> LoopScrollView;

	// Token: 0x040088F9 RID: 35065
	protected int CurrentShopId;

	// Token: 0x040088FA RID: 35066
	protected int CurTabNum;

	// Token: 0x040088FB RID: 35067
	private bool OnShowRequestInfo;

	// Token: 0x040088FC RID: 35068
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040088FD RID: 35069
	private bool TabShowState;

	// Token: 0x040088FE RID: 35070
	private const int TIMEGAP = 1000;

	// Token: 0x02008901 RID: 35073
	[NullableContext(0)]
	private enum EDiscountShopComponent
	{
		// Token: 0x0402C856 RID: 182358
		ScrollerItem,
		// Token: 0x0402C857 RID: 182359
		Scroller,
		// Token: 0x0402C858 RID: 182360
		HoriGroupScroller,
		// Token: 0x0402C859 RID: 182361
		TabItem,
		// Token: 0x0402C85A RID: 182362
		TabPanel,
		// Token: 0x0402C85B RID: 182363
		TitleTips,
		// Token: 0x0402C85C RID: 182364
		ScrollerItemNew,
		// Token: 0x0402C85D RID: 182365
		PanelItem,
		// Token: 0x0402C85E RID: 182366
		EmptyItem,
		// Token: 0x0402C85F RID: 182367
		EmptyText
	}
}
