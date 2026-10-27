using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200236A RID: 9066
[NullableContext(1)]
[Nullable(0)]
public class DiscountShopView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x06012164 RID: 74084 RVA: 0x0047116C File Offset: 0x0046F36C
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

	// Token: 0x06012165 RID: 74085 RVA: 0x0047127C File Offset: 0x0046F47C
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Add<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
	}

	// Token: 0x06012166 RID: 74086 RVA: 0x004712DC File Offset: 0x0046F4DC
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
		EventSystem.Instance.Remove<ESdkDialogResult>(EEventName.SdkPayEnd, new Action<ESdkDialogResult>(this.OnSdkPayEnd));
	}

	// Token: 0x06012167 RID: 74087 RVA: 0x0047133A File Offset: 0x0046F53A
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (this.CurrentShopId == (int)shopId && this.CurrentSelectTabId == tabId)
		{
			this.TryRefreshTabs();
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x06012168 RID: 74088 RVA: 0x0047135F File Offset: 0x0046F55F
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x06012169 RID: 74089 RVA: 0x00471370 File Offset: 0x0046F570
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

	// Token: 0x0601216A RID: 74090 RVA: 0x00471438 File Offset: 0x0046F638
	protected virtual UUIItem GetScrollItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x0601216B RID: 74091 RVA: 0x00471441 File Offset: 0x0046F641
	protected virtual GridProxyAbstract<IPayShopUnionData> InitItem()
	{
		return new PayShopItem();
	}

	// Token: 0x0601216C RID: 74092 RVA: 0x00471448 File Offset: 0x0046F648
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x0601216D RID: 74093 RVA: 0x00471450 File Offset: 0x0046F650
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

	// Token: 0x0601216E RID: 74094 RVA: 0x004714EC File Offset: 0x0046F6EC
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

	// Token: 0x0601216F RID: 74095 RVA: 0x00471534 File Offset: 0x0046F734
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

	// Token: 0x06012170 RID: 74096 RVA: 0x00471604 File Offset: 0x0046F804
	protected virtual void RefreshLoopScroll(int tabId)
	{
		this.PayShopGoodsList = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.CurrentShopId, tabId, true).Cast<IPayShopUnionData>().ToList<IPayShopUnionData>();
		this.LoopScrollView.ReloadProxyData(new Func<int, IPayShopUnionData>(this.GetProxyData), this.PayShopGoodsList.Count, false, false);
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(this.PayShopGoodsList.Count > 0);
		base.GetItem(8).SetUIActive(this.PayShopGoodsList.Count <= 0);
		this.CheckIfNeedShowPlayStationStoreIcon();
	}

	// Token: 0x06012171 RID: 74097 RVA: 0x004716A1 File Offset: 0x0046F8A1
	private void OnSdkPayEnd(ESdkDialogResult _)
	{
		this.CheckIfNeedShowPlayStationStoreIcon();
	}

	// Token: 0x06012172 RID: 74098 RVA: 0x004716AC File Offset: 0x0046F8AC
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

	// Token: 0x06012173 RID: 74099 RVA: 0x0047172C File Offset: 0x0046F92C
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x06012174 RID: 74100 RVA: 0x0047173C File Offset: 0x0046F93C
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

	// Token: 0x06012175 RID: 74101 RVA: 0x0047180D File Offset: 0x0046FA0D
	protected virtual void OnDiscountShopAfterShow()
	{
	}

	// Token: 0x06012176 RID: 74102 RVA: 0x0047180F File Offset: 0x0046FA0F
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06012177 RID: 74103 RVA: 0x0047183A File Offset: 0x0046FA3A
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06012178 RID: 74104 RVA: 0x0047185C File Offset: 0x0046FA5C
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

	// Token: 0x06012179 RID: 74105 RVA: 0x004718B8 File Offset: 0x0046FAB8
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

	// Token: 0x0601217A RID: 74106 RVA: 0x00471958 File Offset: 0x0046FB58
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

	// Token: 0x0601217B RID: 74107 RVA: 0x004719A8 File Offset: 0x0046FBA8
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

	// Token: 0x0601217C RID: 74108 RVA: 0x00471AAF File Offset: 0x0046FCAF
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

	// Token: 0x0601217D RID: 74109 RVA: 0x00471ACC File Offset: 0x0046FCCC
	protected override void OnShowUiTabViewFromToggle()
	{
		this.TabShowState = true;
		this.AfterShowUiTabViewFromToggle();
	}

	// Token: 0x0601217E RID: 74110 RVA: 0x00471ADB File Offset: 0x0046FCDB
	protected virtual void AfterShowUiTabViewFromToggle()
	{
	}

	// Token: 0x0601217F RID: 74111 RVA: 0x00471ADD File Offset: 0x0046FCDD
	protected virtual void AfterHideTabViewBase(bool fromToggle)
	{
	}

	// Token: 0x06012180 RID: 74112 RVA: 0x00471ADF File Offset: 0x0046FCDF
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		this.RemoveTimer();
		this.TabShowState = false;
		this.AfterHideTabViewBase(fromToggle);
	}

	// Token: 0x06012181 RID: 74113 RVA: 0x00471AF5 File Offset: 0x0046FCF5
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		this.LoopScrollView.ClearGridProxies();
	}

	// Token: 0x06012182 RID: 74114 RVA: 0x00471B10 File Offset: 0x0046FD10
	private UniTask QueryProductPriceAndRefresh()
	{
		DiscountShopView.<QueryProductPriceAndRefresh>d__40 <QueryProductPriceAndRefresh>d__;
		<QueryProductPriceAndRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<QueryProductPriceAndRefresh>d__.<>4__this = this;
		<QueryProductPriceAndRefresh>d__.<>1__state = -1;
		<QueryProductPriceAndRefresh>d__.<>t__builder.Start<DiscountShopView.<QueryProductPriceAndRefresh>d__40>(ref <QueryProductPriceAndRefresh>d__);
		return <QueryProductPriceAndRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x06012183 RID: 74115 RVA: 0x00471B54 File Offset: 0x0046FD54
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

	// Token: 0x040088E1 RID: 35041
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x040088E2 RID: 35042
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x040088E3 RID: 35043
	protected int CurrentSelectTabId;

	// Token: 0x040088E4 RID: 35044
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	protected LoopScrollView<GridProxyAbstract<IPayShopUnionData>, IPayShopUnionData> LoopScrollView;

	// Token: 0x040088E5 RID: 35045
	protected int CurrentShopId;

	// Token: 0x040088E6 RID: 35046
	protected int CurTabNum;

	// Token: 0x040088E7 RID: 35047
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040088E8 RID: 35048
	private bool TabShowState;

	// Token: 0x040088E9 RID: 35049
	private const int TIMEGAP = 1000;

	// Token: 0x040088EA RID: 35050
	private bool NeedCheckTabChange;
}
