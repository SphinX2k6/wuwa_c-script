using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002372 RID: 9074
[NullableContext(1)]
[Nullable(0)]
public class RogueShopTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x060121F5 RID: 74229 RVA: 0x00473A08 File Offset: 0x00471C08
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

	// Token: 0x060121F6 RID: 74230 RVA: 0x00473AE7 File Offset: 0x00471CE7
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
	}

	// Token: 0x060121F7 RID: 74231 RVA: 0x00473B21 File Offset: 0x00471D21
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
	}

	// Token: 0x060121F8 RID: 74232 RVA: 0x00473B5B File Offset: 0x00471D5B
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (this.CurrentShopId == (int)shopId && this.CurrentSelectTabId == tabId)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x060121F9 RID: 74233 RVA: 0x00473B7A File Offset: 0x00471D7A
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x060121FA RID: 74234 RVA: 0x00473B88 File Offset: 0x00471D88
	protected override void OnStart()
	{
		this.TabGroup = new TabComponent<PayShopSwitchItem>(base.GetHorizontalLayout(2).GetRootComponent(), new Func<UUIItem, int?, PayShopSwitchItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), base.GetItem(3));
		UUIItem scrollItem = this.GetScrollItem();
		this.LoopScrollView = new LoopScrollView<GridProxyAbstract<IPayShopUnionData>, IPayShopUnionData>(base.GetLoopScrollViewComponent(1), scrollItem.GetOwner() as AUIBaseActor, new Func<GridProxyAbstract<IPayShopUnionData>>(this.InitItem), false);
		base.GetItem(0).SetUIActive(false);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "Rogue_Shop_Sold_out", Array.Empty<object>());
	}

	// Token: 0x060121FB RID: 74235 RVA: 0x00473C3F File Offset: 0x00471E3F
	protected UUIItem GetScrollItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x060121FC RID: 74236 RVA: 0x00473C48 File Offset: 0x00471E48
	protected PayShopItem InitItem()
	{
		return new PayShopItem();
	}

	// Token: 0x060121FD RID: 74237 RVA: 0x00473C4F File Offset: 0x00471E4F
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x060121FE RID: 74238 RVA: 0x00473C58 File Offset: 0x00471E58
	private void ToggleCallBack(int tabIndex)
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		this.CurrentSelectTabId = payShopTabIdList[tabIndex];
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x060121FF RID: 74239 RVA: 0x00473C90 File Offset: 0x00471E90
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

	// Token: 0x06012200 RID: 74240 RVA: 0x00473D68 File Offset: 0x00471F68
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x06012201 RID: 74241 RVA: 0x00473D78 File Offset: 0x00471F78
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

	// Token: 0x06012202 RID: 74242 RVA: 0x00473E11 File Offset: 0x00472011
	protected virtual void OnDiscountShopAfterShow()
	{
	}

	// Token: 0x06012203 RID: 74243 RVA: 0x00473E13 File Offset: 0x00472013
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x06012204 RID: 74244 RVA: 0x00473E3E File Offset: 0x0047203E
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06012205 RID: 74245 RVA: 0x00473E60 File Offset: 0x00472060
	private void OnRefreshTimer()
	{
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x06012206 RID: 74246 RVA: 0x00473E74 File Offset: 0x00472074
	private void UpdateTabs(int selectIndex)
	{
		RogueShopTabView.<>c__DisplayClass25_0 CS$<>8__locals1 = new RogueShopTabView.<>c__DisplayClass25_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.selectIndex = selectIndex;
		CS$<>8__locals1.tabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		int count = CS$<>8__locals1.tabIdList.Count;
		this.TabGroup.ResetLastSelectTab();
		this.TabGroup.RefreshTabItemByLength(count, new Action(CS$<>8__locals1.<UpdateTabs>g__CallBack|0));
	}

	// Token: 0x06012207 RID: 74247 RVA: 0x00473EDB File Offset: 0x004720DB
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		if (@params is int)
		{
			return;
		}
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x06012208 RID: 74248 RVA: 0x00473EF2 File Offset: 0x004720F2
	protected override void OnBeforeHide()
	{
		this.RemoveTimer();
	}

	// Token: 0x06012209 RID: 74249 RVA: 0x00473EFA File Offset: 0x004720FA
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		this.LoopScrollView.ClearGridProxies();
	}

	// Token: 0x0400890C RID: 35084
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x0400890D RID: 35085
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x0400890E RID: 35086
	protected int CurrentSelectTabId;

	// Token: 0x0400890F RID: 35087
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	protected LoopScrollView<GridProxyAbstract<IPayShopUnionData>, IPayShopUnionData> LoopScrollView;

	// Token: 0x04008910 RID: 35088
	private int CurrentShopId;

	// Token: 0x04008911 RID: 35089
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04008912 RID: 35090
	private const int TIMEGAP = 1000;

	// Token: 0x0200890E RID: 35086
	[NullableContext(0)]
	private enum EDiscountShopComponent
	{
		// Token: 0x0402C892 RID: 182418
		ScrollerItem,
		// Token: 0x0402C893 RID: 182419
		Scroller,
		// Token: 0x0402C894 RID: 182420
		HoriGroupScroller,
		// Token: 0x0402C895 RID: 182421
		TabItem,
		// Token: 0x0402C896 RID: 182422
		TabPanel,
		// Token: 0x0402C897 RID: 182423
		TitleTips,
		// Token: 0x0402C898 RID: 182424
		ScrollerItemRecharge,
		// Token: 0x0402C899 RID: 182425
		PanelItem,
		// Token: 0x0402C89A RID: 182426
		EmptyItem,
		// Token: 0x0402C89B RID: 182427
		EmptyText
	}
}
