using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200184D RID: 6221
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerShopTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F5FD RID: 62973 RVA: 0x0047DDE4 File Offset: 0x0047BFE4
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

	// Token: 0x0600F5FE RID: 62974 RVA: 0x0047DEC3 File Offset: 0x0047C0C3
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
	}

	// Token: 0x0600F5FF RID: 62975 RVA: 0x0047DEFD File Offset: 0x0047C0FD
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
	}

	// Token: 0x0600F600 RID: 62976 RVA: 0x0047DF37 File Offset: 0x0047C137
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (this.CurrentShopId == (int)shopId && this.CurrentSelectTabId == tabId)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x0600F601 RID: 62977 RVA: 0x0047DF56 File Offset: 0x0047C156
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F602 RID: 62978 RVA: 0x0047DF64 File Offset: 0x0047C164
	protected override void OnStart()
	{
		this.TabGroup = new TabComponent<PayShopSwitchItem>(base.GetHorizontalLayout(2).GetRootComponent(), new Func<UUIItem, int?, PayShopSwitchItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), base.GetItem(3));
		UUIItem scrollItem = this.GetScrollItem();
		this.LoopScrollView = new LoopScrollView<PayShopItem, IPayShopUnionData>(base.GetLoopScrollViewComponent(1), scrollItem.GetOwner() as AUIBaseActor, new Func<PayShopItem>(this.InitItem), false);
		base.GetItem(0).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		this.TabGroup.SelectToggleByIndex(0, false, true);
	}

	// Token: 0x0600F603 RID: 62979 RVA: 0x0047E00D File Offset: 0x0047C20D
	protected UUIItem GetScrollItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x0600F604 RID: 62980 RVA: 0x0047E016 File Offset: 0x0047C216
	protected PayShopItem InitItem()
	{
		return new PayShopItem();
	}

	// Token: 0x0600F605 RID: 62981 RVA: 0x0047E01D File Offset: 0x0047C21D
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x0600F606 RID: 62982 RVA: 0x0047E024 File Offset: 0x0047C224
	private void ToggleCallBack(int tabIndex)
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		this.CurrentSelectTabId = payShopTabIdList[tabIndex];
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F607 RID: 62983 RVA: 0x0047E05C File Offset: 0x0047C25C
	protected void RefreshLoopScroll(int tabId)
	{
		List<PayShopGoods> payShopTabData = PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.CurrentShopId, tabId, true);
		this.PayShopGoodsList.Clear();
		foreach (PayShopGoods item in payShopTabData)
		{
			this.PayShopGoodsList.Add(item);
		}
		this.LoopScrollView.ReloadProxyData(new Func<int, IPayShopUnionData>(this.GetProxyData), this.PayShopGoodsList.Count, false, false);
		base.GetLoopScrollViewComponent(1).RootUIComp.Get().SetUIActive(this.PayShopGoodsList.Count > 0);
		base.GetItem(8).SetUIActive(this.PayShopGoodsList.Count <= 0);
	}

	// Token: 0x0600F608 RID: 62984 RVA: 0x0047E134 File Offset: 0x0047C334
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x0600F609 RID: 62985 RVA: 0x0047E144 File Offset: 0x0047C344
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

	// Token: 0x0600F60A RID: 62986 RVA: 0x0047E1DD File Offset: 0x0047C3DD
	protected virtual void OnDiscountShopAfterShow()
	{
	}

	// Token: 0x0600F60B RID: 62987 RVA: 0x0047E1DF File Offset: 0x0047C3DF
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600F60C RID: 62988 RVA: 0x0047E20A File Offset: 0x0047C40A
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600F60D RID: 62989 RVA: 0x0047E22C File Offset: 0x0047C42C
	private void OnRefreshTimer()
	{
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x0600F60E RID: 62990 RVA: 0x0047E240 File Offset: 0x0047C440
	private void UpdateTabs(int selectIndex)
	{
		BabelTowerShopTabView.<>c__DisplayClass25_0 CS$<>8__locals1 = new BabelTowerShopTabView.<>c__DisplayClass25_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.selectIndex = selectIndex;
		CS$<>8__locals1.tabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		int count = CS$<>8__locals1.tabIdList.Count;
		this.TabGroup.ResetLastSelectTab();
		this.TabGroup.RefreshTabItemByLength(count, new Action(CS$<>8__locals1.<UpdateTabs>g__CallBack|0));
	}

	// Token: 0x0600F60F RID: 62991 RVA: 0x0047E2A7 File Offset: 0x0047C4A7
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		if (@params is int)
		{
			return;
		}
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F610 RID: 62992 RVA: 0x0047E2BE File Offset: 0x0047C4BE
	protected override void OnBeforeHide()
	{
		this.RemoveTimer();
	}

	// Token: 0x0600F611 RID: 62993 RVA: 0x0047E2C6 File Offset: 0x0047C4C6
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		this.LoopScrollView.ClearGridProxies();
	}

	// Token: 0x04008A12 RID: 35346
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x04008A13 RID: 35347
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x04008A14 RID: 35348
	protected int CurrentSelectTabId;

	// Token: 0x04008A15 RID: 35349
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<PayShopItem, IPayShopUnionData> LoopScrollView;

	// Token: 0x04008A16 RID: 35350
	private int CurrentShopId;

	// Token: 0x04008A17 RID: 35351
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04008A18 RID: 35352
	private const int TIMEGAP = 1000;

	// Token: 0x02007A80 RID: 31360
	[NullableContext(0)]
	private enum EDiscountShopComponent
	{
		// Token: 0x04027B3E RID: 162622
		ScrollerItem,
		// Token: 0x04027B3F RID: 162623
		Scroller,
		// Token: 0x04027B40 RID: 162624
		HoriGroupScroller,
		// Token: 0x04027B41 RID: 162625
		TabItem,
		// Token: 0x04027B42 RID: 162626
		TabPanel,
		// Token: 0x04027B43 RID: 162627
		TitleTips,
		// Token: 0x04027B44 RID: 162628
		ScrollerItemRecharge,
		// Token: 0x04027B45 RID: 162629
		PanelItem,
		// Token: 0x04027B46 RID: 162630
		EmptyItem,
		// Token: 0x04027B47 RID: 162631
		EmptyText
	}
}
