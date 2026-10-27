using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002371 RID: 9073
public class PayShopSkinView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x060121E5 RID: 74213 RVA: 0x004733A0 File Offset: 0x004715A0
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
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x060121E6 RID: 74214 RVA: 0x00473468 File Offset: 0x00471668
	protected override void OnStart()
	{
		this.TabGroup = new TabComponent<PayShopSwitchItem>(base.GetHorizontalLayout(2).GetRootComponent(), new Func<UUIItem, int?, PayShopSwitchItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), base.GetItem(3));
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(false);
		base.GetItem(0).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		this.TabViewComponent = new TabViewComponent<int>(base.GetItem(7), EKeyMode.Default);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "PayShop:TabView 界面Start";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060121E7 RID: 74215 RVA: 0x0047351E File Offset: 0x0047171E
	[NullableContext(1)]
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x060121E8 RID: 74216 RVA: 0x00473528 File Offset: 0x00471728
	private void ToggleCallBack(int gridIndex)
	{
		this.CurrentSelectTabId = this.TabList[gridIndex];
		int currentSelectTabId = this.CurrentSelectTabId;
		EUiTabViewName viewName = PayShopDefine.SkinTabView[(PayShopDefine.ESkinTabType)currentSelectTabId];
		PayShopSwitchItem tabItemByIndex = this.TabGroup.GetTabItemByIndex(gridIndex);
		this.TabViewComponent.ToggleCallBack(currentSelectTabId, viewName, tabItemByIndex, this.CurrentShopId, null);
		OnClickPayShopTabLogEvent onClickPayShopTabLogEvent = new OnClickPayShopTabLogEvent();
		onClickPayShopTabLogEvent.i_shop_id = this.CurrentShopId;
		onClickPayShopTabLogEvent.i_tab_id = currentSelectTabId;
		LogReportController.Instance.LogReport(onClickPayShopTabLogEvent);
		this.TryRefreshRootShopMoney();
	}

	// Token: 0x060121E9 RID: 74217 RVA: 0x004735B4 File Offset: 0x004717B4
	private void TryRefreshRootShopMoney()
	{
		PayShopTabData payShopTabDataByPayShopIdAndTabId = PayShopModel.Instance.GetPayShopTabDataByPayShopIdAndTabId((PayShopDefine.EPayShopTabType)this.CurrentShopId, this.CurrentSelectTabId);
		List<int> list = ((payShopTabDataByPayShopIdAndTabId != null) ? payShopTabDataByPayShopIdAndTabId.MoneyList : null) ?? new List<int>();
		List<int> list2 = (list.Count > 0) ? list : PayShopModel.Instance.GetPayShopInfoMoney((PayShopDefine.EPayShopTabType)this.CurrentShopId);
		if (list2.Count > 0)
		{
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.TryRefreshRootShopMoney, list2);
		}
	}

	// Token: 0x060121EA RID: 74218 RVA: 0x00473624 File Offset: 0x00471824
	protected override void OnBeforeShow()
	{
		this.CurrentShopId = (int)this.Params;
		base.GetText(5).SetUIActive(false);
		this.RefreshSkinTabs();
	}

	// Token: 0x060121EB RID: 74219 RVA: 0x0047364A File Offset: 0x0047184A
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		if (fromToggle)
		{
			this.TabGroup.ResetSelectIndex();
		}
		this.NeedCheckGoodsList.Clear();
	}

	// Token: 0x060121EC RID: 74220 RVA: 0x00473668 File Offset: 0x00471868
	protected override void OnAfterShow()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "PayShop:TabView 界面AfterShow";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060121ED RID: 74221 RVA: 0x004736A1 File Offset: 0x004718A1
	protected override void OnBeforeHide()
	{
		this.TabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x060121EE RID: 74222 RVA: 0x004736B0 File Offset: 0x004718B0
	private UniTask UpdateTabs()
	{
		PayShopSkinView.<UpdateTabs>d__18 <UpdateTabs>d__;
		<UpdateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateTabs>d__.<>4__this = this;
		<UpdateTabs>d__.<>1__state = -1;
		<UpdateTabs>d__.<>t__builder.Start<PayShopSkinView.<UpdateTabs>d__18>(ref <UpdateTabs>d__);
		return <UpdateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x060121EF RID: 74223 RVA: 0x004736F3 File Offset: 0x004718F3
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
	}

	// Token: 0x060121F0 RID: 74224 RVA: 0x0047371B File Offset: 0x0047191B
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		this.RefreshSkinTabs();
	}

	// Token: 0x060121F1 RID: 74225 RVA: 0x00473724 File Offset: 0x00471924
	protected override void OnTickUiTabViewBase(float deltaTime)
	{
		if (!this.AllowTick)
		{
			return;
		}
		if (this.NeedCheckGoodsList.Count <= 0)
		{
			this.AllowTick = false;
			return;
		}
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		int count = this.NeedCheckGoodsList.Count;
		for (int i = 0; i < count; i++)
		{
			PayShopGoods payShopGoods = this.NeedCheckGoodsList[i];
			if (payShopGoods.NeedUpdate() || payShopGoods.NeedDown())
			{
				if (payShopGoods.IsDirect())
				{
					list.Add(payShopGoods.GetGoodsId());
				}
				else
				{
					list2.Add(payShopGoods.GetGoodsId());
				}
			}
		}
		if (list2.Count <= 0 && list.Count <= 0)
		{
			return;
		}
		this.AllowTick = false;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "PayShop:Skin 请求刷新商品";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("goodsList", list2);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (list2.Count > 0)
		{
			PayShopController.Instance.SendRequestPayShopItemUpdate(list2.ToArray());
		}
		if (list.Count > 0)
		{
			PayGiftController.Instance.SendPayGiftInfoRequest(true);
		}
	}

	// Token: 0x060121F2 RID: 74226 RVA: 0x0047382C File Offset: 0x00471A2C
	private void UpdateGoodsList()
	{
		List<PayShopGoods> payShopGoodsByTabType = PayShopModel.Instance.GetPayShopGoodsByTabType(PayShopDefine.EPayShopTabType.SkinShop, 3);
		List<PayShopGoods> list = new List<PayShopGoods>();
		int count = payShopGoodsByTabType.Count;
		for (int i = 0; i < count; i++)
		{
			PayShopGoods payShopGoods = payShopGoodsByTabType[i];
			if (payShopGoods.IsShowInShop() && (payShopGoods.InUpdateTime() || payShopGoods.InUnPermanentSellTime() || payShopGoods.WillSell()))
			{
				list.Add(payShopGoods);
			}
		}
		this.NeedCheckGoodsList.Clear();
		this.NeedCheckGoodsList.AddRange(list);
		this.AllowTick = (this.NeedCheckGoodsList.Count > 0);
	}

	// Token: 0x060121F3 RID: 74227 RVA: 0x004738C0 File Offset: 0x00471AC0
	private void RefreshSkinTabs()
	{
		List<int> payShopTableList = PayShopModel.Instance.GetPayShopTableList(6);
		this.UpdateGoodsList();
		this.TabList.Clear();
		int count = payShopTableList.Count;
		for (int i = 0; i < count; i++)
		{
			int num = payShopTableList[i];
			if (num != 3)
			{
				this.TabList.Add(num);
			}
			else if (PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.SkinShop, num, true).Count > 0)
			{
				this.TabList.Add(num);
			}
		}
		int openIndex = 0;
		if (this.ExtraParams != null && this.IsFirstOpen)
		{
			this.IsFirstOpen = false;
			int num2 = (int)this.ExtraParams;
			int count2 = this.TabList.Count;
			for (int j = 0; j < count2; j++)
			{
				if (this.TabList[j] == num2)
				{
					openIndex = j;
					break;
				}
			}
		}
		else
		{
			openIndex = this.TabGroup.TryGetSelectedIndex(openIndex);
		}
		this.UpdateTabs().ContinueWith(delegate()
		{
			this.TabGroup.SelectToggleByIndex(openIndex, true, true);
			this.TabViewComponent.SetCurrentTabViewState(true);
		}).Forget();
	}

	// Token: 0x04008904 RID: 35076
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x04008905 RID: 35077
	[Nullable(2)]
	protected TabViewComponent<int> TabViewComponent;

	// Token: 0x04008906 RID: 35078
	[Nullable(1)]
	protected List<int> TabList = new List<int>();

	// Token: 0x04008907 RID: 35079
	protected int CurrentSelectTabId;

	// Token: 0x04008908 RID: 35080
	private int CurrentShopId;

	// Token: 0x04008909 RID: 35081
	[Nullable(1)]
	private readonly List<PayShopGoods> NeedCheckGoodsList = new List<PayShopGoods>();

	// Token: 0x0400890A RID: 35082
	private bool AllowTick;

	// Token: 0x0400890B RID: 35083
	private bool IsFirstOpen = true;

	// Token: 0x0200890B RID: 35083
	private enum EComponent
	{
		// Token: 0x0402C883 RID: 182403
		ScrollerItem,
		// Token: 0x0402C884 RID: 182404
		Scroller,
		// Token: 0x0402C885 RID: 182405
		GroupScroller,
		// Token: 0x0402C886 RID: 182406
		TabItem,
		// Token: 0x0402C887 RID: 182407
		TabPanel,
		// Token: 0x0402C888 RID: 182408
		TitleTips,
		// Token: 0x0402C889 RID: 182409
		ScrollerItemRecharge,
		// Token: 0x0402C88A RID: 182410
		PanelContent
	}
}
