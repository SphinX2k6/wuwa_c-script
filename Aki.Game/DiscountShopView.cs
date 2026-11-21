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

// Token: 0x0200184F RID: 6223
[NullableContext(1)]
[Nullable(0)]
public class DiscountShopView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F614 RID: 62996 RVA: 0x0047E2FC File Offset: 0x0047C4FC
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
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIScrollViewWithScrollbarComponent))
		};
	}

	// Token: 0x0600F615 RID: 62997 RVA: 0x0047E40C File Offset: 0x0047C60C
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
	}

	// Token: 0x0600F616 RID: 62998 RVA: 0x0047E46C File Offset: 0x0047C66C
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
	}

	// Token: 0x0600F617 RID: 62999 RVA: 0x0047E4CA File Offset: 0x0047C6CA
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (this.CurrentShopId == (int)shopId && this.CurrentSelectTabId == tabId)
		{
			this.TryRefreshTabs();
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x0600F618 RID: 63000 RVA: 0x0047E4EF File Offset: 0x0047C6EF
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F619 RID: 63001 RVA: 0x0047E500 File Offset: 0x0047C700
	protected override void OnStart()
	{
		this.TabGroup = new TabComponent<PayShopSwitchItem>(base.GetHorizontalLayout(2).GetRootComponent(), new Func<UUIItem, int?, PayShopSwitchItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), base.GetItem(3));
		UUIItem scrollItem = this.GetScrollItem();
		this.LoopScrollView = new LoopScrollView<GridProxyAbstract<IPayShopUnionData>, IPayShopUnionData>(base.GetLoopScrollViewComponent(1), scrollItem.GetOwner() as AUIBaseActor, new Func<GridProxyAbstract<IPayShopUnionData>>(this.InitItem), false);
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

	// Token: 0x0600F61A RID: 63002 RVA: 0x0047E5C8 File Offset: 0x0047C7C8
	protected virtual UUIItem GetScrollItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x0600F61B RID: 63003 RVA: 0x0047E5D1 File Offset: 0x0047C7D1
	protected virtual GridProxyAbstract<IPayShopUnionData> InitItem()
	{
		return new PayShopItem();
	}

	// Token: 0x0600F61C RID: 63004 RVA: 0x0047E5D8 File Offset: 0x0047C7D8
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x0600F61D RID: 63005 RVA: 0x0047E5E0 File Offset: 0x0047C7E0
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
		this.RefreshTipsText();
		OnClickPayShopTabLogEvent onClickPayShopTabLogEvent = new OnClickPayShopTabLogEvent();
		onClickPayShopTabLogEvent.i_shop_id = this.CurrentShopId;
		onClickPayShopTabLogEvent.i_tab_id = this.CurrentSelectTabId;
		LogReportController.Instance.LogReport(onClickPayShopTabLogEvent);
		this.TryRefreshRootShopMoney();
	}

	// Token: 0x0600F61E RID: 63006 RVA: 0x0047E67C File Offset: 0x0047C87C
	private void TryRefreshRootShopMoney()
	{
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId((PayShopDefine.EPayShopTabType)this.CurrentShopId, this.CurrentSelectTabId);
		if (payShopTabDataByPayShopIdAndTabId != null)
		{
			List<int> moneyList = payShopTabDataByPayShopIdAndTabId.MoneyList;
			if (moneyList.Count > 0)
			{
				EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.TryRefreshRootShopMoney, moneyList);
			}
		}
	}

	// Token: 0x0600F61F RID: 63007 RVA: 0x0047E6C4 File Offset: 0x0047C8C4
	private void RefreshTipsText()
	{
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId((PayShopDefine.EPayShopTabType)this.CurrentShopId, this.CurrentSelectTabId);
		if (this.CurrentShopId == 4 && payShopTabDataByPayShopIdAndTabId != null && payShopTabDataByPayShopIdAndTabId.BeginTime > 0L && payShopTabDataByPayShopIdAndTabId.EndTime > 0L)
		{
			double num = (double)payShopTabDataByPayShopIdAndTabId.EndTime - TimeUtil.Instance.GetServerTime();
			if (num <= 0.0)
			{
				num = 0.0;
			}
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat9(num);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "ExchangeEntryLeftTimeText", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "ExchangeEntryTipsText", Array.Empty<object>());
		}
		base.GetText(10).SetUIActive(this.CurrentShopId == 4);
	}

	// Token: 0x0600F620 RID: 63008 RVA: 0x0047E794 File Offset: 0x0047C994
	protected virtual void RefreshLoopScroll(int tabId)
	{
		this.PayShopGoodsList = new List<IPayShopUnionData>(PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.CurrentShopId, tabId, true));
		this.LoopScrollView.ReloadProxyData(new Func<int, IPayShopUnionData>(this.GetProxyData), this.PayShopGoodsList.Count, false, false);
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(this.PayShopGoodsList.Count > 0);
		base.GetItem(8).SetUIActive(this.PayShopGoodsList.Count <= 0);
		this.CheckIfNeedShowPlayStationStoreIcon();
	}

	// Token: 0x0600F621 RID: 63009 RVA: 0x0047E82C File Offset: 0x0047CA2C
	private void OnSdkPayEnd(ESdkDialogResult _)
	{
		this.CheckIfNeedShowPlayStationStoreIcon();
	}

	// Token: 0x0600F622 RID: 63010 RVA: 0x0047E834 File Offset: 0x0047CA34
	protected void CheckIfNeedShowPlayStationStoreIcon()
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

	// Token: 0x0600F623 RID: 63011 RVA: 0x0047E8B4 File Offset: 0x0047CAB4
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x0600F624 RID: 63012 RVA: 0x0047E8C4 File Offset: 0x0047CAC4
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
		this.UpdateTabs(num, true);
		this.AddTimer();
		this.OnDiscountShopAfterShow();
		this.QueryProductPriceAndRefresh().Forget();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "PayShop:TabView 界面AfterShow";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600F625 RID: 63013 RVA: 0x0047E995 File Offset: 0x0047CB95
	protected virtual void OnDiscountShopAfterShow()
	{
	}

	// Token: 0x0600F626 RID: 63014 RVA: 0x0047E997 File Offset: 0x0047CB97
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600F627 RID: 63015 RVA: 0x0047E9C2 File Offset: 0x0047CBC2
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600F628 RID: 63016 RVA: 0x0047E9E4 File Offset: 0x0047CBE4
	private void CheckTabChange()
	{
		if (!this.NeedCheckTabChange)
		{
			return;
		}
		bool flag = false;
		if (PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true).Count != this.CurTabNum)
		{
			flag = true;
		}
		if (flag)
		{
			this.NeedCheckTabChange = false;
			EventSystem.Instance.Emit<int, bool>(EEventName.RefreshPayShop, this.CurrentShopId, true);
		}
	}

	// Token: 0x0600F629 RID: 63017 RVA: 0x0047EA40 File Offset: 0x0047CC40
	private void OnRefreshTimer()
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		foreach (KeyValuePair<int, PayShopSwitchItem> keyValuePair in this.TabGroup.GetTabItemMap())
		{
			keyValuePair.Value.RefreshCountDown((PayShopDefine.EPayShopTabType)this.CurrentShopId, payShopTabIdList[keyValuePair.Key]);
		}
		this.RefreshTipsText();
		this.CheckTabChange();
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x0600F62A RID: 63018 RVA: 0x0047EAE0 File Offset: 0x0047CCE0
	protected void TryRefreshTabs()
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		if (this.CurTabNum == payShopTabIdList.Count)
		{
			return;
		}
		int num = payShopTabIdList.FindIndex((int tabId) => tabId == this.CurrentSelectTabId);
		this.UpdateTabs((num == -1) ? 0 : num, false);
	}

	// Token: 0x0600F62B RID: 63019 RVA: 0x0047EB30 File Offset: 0x0047CD30
	protected unsafe virtual void UpdateTabs(int selectIndex, bool bScrollTo = false)
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
			if (bScrollTo)
			{
				this.LateScrollToTab(selectIndex);
			}
		};
		this.TabGroup.RefreshTabItemByLength(count, callBack);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Shop;
		ELogAuthor author2 = ELogAuthor.XXJ;
		string message2 = "PayShop:TabView 选择页签";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.NeedCheckTabChange = true;
	}

	// Token: 0x0600F62C RID: 63020 RVA: 0x0047EC37 File Offset: 0x0047CE37
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

	// Token: 0x0600F62D RID: 63021 RVA: 0x0047EC54 File Offset: 0x0047CE54
	protected override void OnShowUiTabViewFromToggle()
	{
		this.TabShowState = true;
		this.AfterShowUiTabViewFromToggle();
	}

	// Token: 0x0600F62E RID: 63022 RVA: 0x0047EC63 File Offset: 0x0047CE63
	protected virtual void AfterShowUiTabViewFromToggle()
	{
	}

	// Token: 0x0600F62F RID: 63023 RVA: 0x0047EC65 File Offset: 0x0047CE65
	protected virtual void AfterHideTabViewBase(bool fromToggle)
	{
	}

	// Token: 0x0600F630 RID: 63024 RVA: 0x0047EC67 File Offset: 0x0047CE67
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		this.RemoveTimer();
		this.TabShowState = false;
		this.AfterHideTabViewBase(fromToggle);
	}

	// Token: 0x0600F631 RID: 63025 RVA: 0x0047EC7D File Offset: 0x0047CE7D
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		this.LoopScrollView.ClearGridProxies();
	}

	// Token: 0x0600F632 RID: 63026 RVA: 0x0047EC98 File Offset: 0x0047CE98
	private UniTask QueryProductPriceAndRefresh()
	{
		DiscountShopView.<QueryProductPriceAndRefresh>d__40 <QueryProductPriceAndRefresh>d__;
		<QueryProductPriceAndRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryProductPriceAndRefresh>d__.<>4__this = this;
		<QueryProductPriceAndRefresh>d__.<>1__state = -1;
		<QueryProductPriceAndRefresh>d__.<>t__builder.Start<DiscountShopView.<QueryProductPriceAndRefresh>d__40>(ref <QueryProductPriceAndRefresh>d__);
		return <QueryProductPriceAndRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x0600F633 RID: 63027 RVA: 0x0047ECDC File Offset: 0x0047CEDC
	public void LateScrollToTab(int index)
	{
		PayShopSwitchItem tabItem = this.TabGroup.GetTabItemByIndex(index);
		UUIScrollViewWithScrollbarComponent scrollView = base.GetScrollViewWithScrollbar(11);
		TTimerAction <>9__1;
		scrollView.OnLateUpdate.Bind(delegate(float _)
		{
			TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
			TTimerAction action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(float _)
				{
					if (!scrollView.IsValid())
					{
						return;
					}
					scrollView.ScrollTo(tabItem.GetRootItem(), false);
				});
			}
			gameplayTimeInstance.Next(action, null, null);
			scrollView.OnLateUpdate.Unbind();
		});
	}

	// Token: 0x04008A26 RID: 35366
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x04008A27 RID: 35367
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x04008A28 RID: 35368
	protected int CurrentSelectTabId;

	// Token: 0x04008A29 RID: 35369
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	protected LoopScrollView<GridProxyAbstract<IPayShopUnionData>, IPayShopUnionData> LoopScrollView;

	// Token: 0x04008A2A RID: 35370
	protected int CurrentShopId;

	// Token: 0x04008A2B RID: 35371
	protected int CurTabNum;

	// Token: 0x04008A2C RID: 35372
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04008A2D RID: 35373
	private bool TabShowState;

	// Token: 0x04008A2E RID: 35374
	private const int TIMEGAP = 1000;

	// Token: 0x04008A2F RID: 35375
	private bool NeedCheckTabChange;
}
