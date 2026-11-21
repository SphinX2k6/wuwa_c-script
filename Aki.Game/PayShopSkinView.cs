using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001856 RID: 6230
public class PayShopSkinView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F695 RID: 63125 RVA: 0x00480520 File Offset: 0x0047E720
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

	// Token: 0x0600F696 RID: 63126 RVA: 0x004805E8 File Offset: 0x0047E7E8
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

	// Token: 0x0600F697 RID: 63127 RVA: 0x0048069E File Offset: 0x0047E89E
	[NullableContext(1)]
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x0600F698 RID: 63128 RVA: 0x004806A8 File Offset: 0x0047E8A8
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

	// Token: 0x0600F699 RID: 63129 RVA: 0x00480734 File Offset: 0x0047E934
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

	// Token: 0x0600F69A RID: 63130 RVA: 0x004807A4 File Offset: 0x0047E9A4
	protected override void OnBeforeShow()
	{
		this.CurrentShopId = (int)this.Params;
		base.GetText(5).SetUIActive(false);
		this.RefreshSkinTabs();
	}

	// Token: 0x0600F69B RID: 63131 RVA: 0x004807CA File Offset: 0x0047E9CA
	protected override void OnHideUiTabViewBase(bool fromToggle)
	{
		if (fromToggle)
		{
			this.TabGroup.ResetSelectIndex();
		}
		this.NeedCheckGoodsList.Clear();
	}

	// Token: 0x0600F69C RID: 63132 RVA: 0x004807E8 File Offset: 0x0047E9E8
	protected override void OnAfterShow()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "PayShop:TabView 界面AfterShow";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", base.GetViewName());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600F69D RID: 63133 RVA: 0x00480821 File Offset: 0x0047EA21
	protected override void OnBeforeHide()
	{
		this.TabViewComponent.SetCurrentTabViewState(false);
	}

	// Token: 0x0600F69E RID: 63134 RVA: 0x00480830 File Offset: 0x0047EA30
	private UniTask UpdateTabs()
	{
		PayShopSkinView.<UpdateTabs>d__18 <UpdateTabs>d__;
		<UpdateTabs>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateTabs>d__.<>4__this = this;
		<UpdateTabs>d__.<>1__state = -1;
		<UpdateTabs>d__.<>t__builder.Start<PayShopSkinView.<UpdateTabs>d__18>(ref <UpdateTabs>d__);
		return <UpdateTabs>d__.<>t__builder.Task;
	}

	// Token: 0x0600F69F RID: 63135 RVA: 0x00480873 File Offset: 0x0047EA73
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		if (this.TabViewComponent != null)
		{
			this.TabViewComponent.DestroyTabViewComponent();
			this.TabViewComponent = null;
		}
	}

	// Token: 0x0600F6A0 RID: 63136 RVA: 0x0048089B File Offset: 0x0047EA9B
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		this.RefreshSkinTabs();
	}

	// Token: 0x0600F6A1 RID: 63137 RVA: 0x004808A4 File Offset: 0x0047EAA4
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

	// Token: 0x0600F6A2 RID: 63138 RVA: 0x004809AC File Offset: 0x0047EBAC
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

	// Token: 0x0600F6A3 RID: 63139 RVA: 0x00480A40 File Offset: 0x0047EC40
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

	// Token: 0x04008A49 RID: 35401
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x04008A4A RID: 35402
	[Nullable(2)]
	protected TabViewComponent<int> TabViewComponent;

	// Token: 0x04008A4B RID: 35403
	[Nullable(1)]
	protected List<int> TabList = new List<int>();

	// Token: 0x04008A4C RID: 35404
	protected int CurrentSelectTabId;

	// Token: 0x04008A4D RID: 35405
	private int CurrentShopId;

	// Token: 0x04008A4E RID: 35406
	[Nullable(1)]
	private readonly List<PayShopGoods> NeedCheckGoodsList = new List<PayShopGoods>();

	// Token: 0x04008A4F RID: 35407
	private bool AllowTick;

	// Token: 0x04008A50 RID: 35408
	private bool IsFirstOpen = true;

	// Token: 0x02007A95 RID: 31381
	private enum EComponent
	{
		// Token: 0x04027B9B RID: 162715
		ScrollerItem,
		// Token: 0x04027B9C RID: 162716
		Scroller,
		// Token: 0x04027B9D RID: 162717
		GroupScroller,
		// Token: 0x04027B9E RID: 162718
		TabItem,
		// Token: 0x04027B9F RID: 162719
		TabPanel,
		// Token: 0x04027BA0 RID: 162720
		TitleTips,
		// Token: 0x04027BA1 RID: 162721
		ScrollerItemRecharge,
		// Token: 0x04027BA2 RID: 162722
		PanelContent
	}
}
