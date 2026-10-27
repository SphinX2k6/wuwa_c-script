using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002368 RID: 9064
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerShopTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0601214D RID: 74061 RVA: 0x00470C54 File Offset: 0x0046EE54
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

	// Token: 0x0601214E RID: 74062 RVA: 0x00470D33 File Offset: 0x0046EF33
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
	}

	// Token: 0x0601214F RID: 74063 RVA: 0x00470D6D File Offset: 0x0046EF6D
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
	}

	// Token: 0x06012150 RID: 74064 RVA: 0x00470DA7 File Offset: 0x0046EFA7
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (this.CurrentShopId == (int)shopId && this.CurrentSelectTabId == tabId)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x06012151 RID: 74065 RVA: 0x00470DC6 File Offset: 0x0046EFC6
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x06012152 RID: 74066 RVA: 0x00470DD4 File Offset: 0x0046EFD4
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

	// Token: 0x06012153 RID: 74067 RVA: 0x00470E7D File Offset: 0x0046F07D
	protected UUIItem GetScrollItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x06012154 RID: 74068 RVA: 0x00470E86 File Offset: 0x0046F086
	protected PayShopItem InitItem()
	{
		return new PayShopItem();
	}

	// Token: 0x06012155 RID: 74069 RVA: 0x00470E8D File Offset: 0x0046F08D
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x06012156 RID: 74070 RVA: 0x00470E94 File Offset: 0x0046F094
	private void ToggleCallBack(int tabIndex)
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		this.CurrentSelectTabId = payShopTabIdList[tabIndex];
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x06012157 RID: 74071 RVA: 0x00470ECC File Offset: 0x0046F0CC
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

	// Token: 0x06012158 RID: 74072 RVA: 0x00470FA4 File Offset: 0x0046F1A4
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x06012159 RID: 74073 RVA: 0x00470FB4 File Offset: 0x0046F1B4
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

	// Token: 0x0601215A RID: 74074 RVA: 0x0047104D File Offset: 0x0046F24D
	protected virtual void OnDiscountShopAfterShow()
	{
	}

	// Token: 0x0601215B RID: 74075 RVA: 0x0047104F File Offset: 0x0046F24F
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0601215C RID: 74076 RVA: 0x0047107A File Offset: 0x0046F27A
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0601215D RID: 74077 RVA: 0x0047109C File Offset: 0x0046F29C
	private void OnRefreshTimer()
	{
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x0601215E RID: 74078 RVA: 0x004710B0 File Offset: 0x0046F2B0
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

	// Token: 0x0601215F RID: 74079 RVA: 0x00471117 File Offset: 0x0046F317
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		if (@params is int)
		{
			return;
		}
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x06012160 RID: 74080 RVA: 0x0047112E File Offset: 0x0046F32E
	protected override void OnBeforeHide()
	{
		this.RemoveTimer();
	}

	// Token: 0x06012161 RID: 74081 RVA: 0x00471136 File Offset: 0x0046F336
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		this.LoopScrollView.ClearGridProxies();
	}

	// Token: 0x040088CD RID: 35021
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x040088CE RID: 35022
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x040088CF RID: 35023
	protected int CurrentSelectTabId;

	// Token: 0x040088D0 RID: 35024
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<PayShopItem, IPayShopUnionData> LoopScrollView;

	// Token: 0x040088D1 RID: 35025
	private int CurrentShopId;

	// Token: 0x040088D2 RID: 35026
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x040088D3 RID: 35027
	private const int TIMEGAP = 1000;

	// Token: 0x020088F6 RID: 35062
	[NullableContext(0)]
	private enum EDiscountShopComponent
	{
		// Token: 0x0402C826 RID: 182310
		ScrollerItem,
		// Token: 0x0402C827 RID: 182311
		Scroller,
		// Token: 0x0402C828 RID: 182312
		HoriGroupScroller,
		// Token: 0x0402C829 RID: 182313
		TabItem,
		// Token: 0x0402C82A RID: 182314
		TabPanel,
		// Token: 0x0402C82B RID: 182315
		TitleTips,
		// Token: 0x0402C82C RID: 182316
		ScrollerItemRecharge,
		// Token: 0x0402C82D RID: 182317
		PanelItem,
		// Token: 0x0402C82E RID: 182318
		EmptyItem,
		// Token: 0x0402C82F RID: 182319
		EmptyText
	}
}
