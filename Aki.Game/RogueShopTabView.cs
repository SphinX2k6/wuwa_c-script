using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001857 RID: 6231
[NullableContext(1)]
[Nullable(0)]
public class RogueShopTabView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F6A5 RID: 63141 RVA: 0x00480B88 File Offset: 0x0047ED88
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

	// Token: 0x0600F6A6 RID: 63142 RVA: 0x00480C67 File Offset: 0x0047EE67
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Add<int, PayShopDefine.EPayShopTabType, int>(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
	}

	// Token: 0x0600F6A7 RID: 63143 RVA: 0x00480CA1 File Offset: 0x0047EEA1
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.GoodsSoldOut, new Action<int>(this.OnGoodsSoldOut));
		EventSystem.Instance.Remove(EEventName.RefreshGoods, new Action<int, PayShopDefine.EPayShopTabType, int>(this.OnRefreshGoods));
	}

	// Token: 0x0600F6A8 RID: 63144 RVA: 0x00480CDB File Offset: 0x0047EEDB
	private void OnRefreshGoods(int goodsId, PayShopDefine.EPayShopTabType shopId, int tabId)
	{
		if (this.CurrentShopId == (int)shopId && this.CurrentSelectTabId == tabId)
		{
			this.LoopScrollView.RefreshAllGridProxies();
		}
	}

	// Token: 0x0600F6A9 RID: 63145 RVA: 0x00480CFA File Offset: 0x0047EEFA
	private void OnGoodsSoldOut(int goodsId)
	{
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F6AA RID: 63146 RVA: 0x00480D08 File Offset: 0x0047EF08
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

	// Token: 0x0600F6AB RID: 63147 RVA: 0x00480DBF File Offset: 0x0047EFBF
	protected UUIItem GetScrollItem()
	{
		return base.GetItem(0);
	}

	// Token: 0x0600F6AC RID: 63148 RVA: 0x00480DC8 File Offset: 0x0047EFC8
	protected PayShopItem InitItem()
	{
		return new PayShopItem();
	}

	// Token: 0x0600F6AD RID: 63149 RVA: 0x00480DCF File Offset: 0x0047EFCF
	private PayShopSwitchItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new PayShopSwitchItem();
	}

	// Token: 0x0600F6AE RID: 63150 RVA: 0x00480DD8 File Offset: 0x0047EFD8
	private void ToggleCallBack(int tabIndex)
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.CurrentShopId, true);
		this.CurrentSelectTabId = payShopTabIdList[tabIndex];
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F6AF RID: 63151 RVA: 0x00480E10 File Offset: 0x0047F010
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

	// Token: 0x0600F6B0 RID: 63152 RVA: 0x00480EE8 File Offset: 0x0047F0E8
	protected IPayShopUnionData GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x0600F6B1 RID: 63153 RVA: 0x00480EF8 File Offset: 0x0047F0F8
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

	// Token: 0x0600F6B2 RID: 63154 RVA: 0x00480F91 File Offset: 0x0047F191
	protected virtual void OnDiscountShopAfterShow()
	{
	}

	// Token: 0x0600F6B3 RID: 63155 RVA: 0x00480F93 File Offset: 0x0047F193
	private void AddTimer()
	{
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.OnRefreshTimer();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600F6B4 RID: 63156 RVA: 0x00480FBE File Offset: 0x0047F1BE
	private void RemoveTimer()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600F6B5 RID: 63157 RVA: 0x00480FE0 File Offset: 0x0047F1E0
	private void OnRefreshTimer()
	{
		EventSystem.Instance.Emit(EEventName.DiscountShopTimerRefresh);
	}

	// Token: 0x0600F6B6 RID: 63158 RVA: 0x00480FF4 File Offset: 0x0047F1F4
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

	// Token: 0x0600F6B7 RID: 63159 RVA: 0x0048105B File Offset: 0x0047F25B
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		if (@params is int)
		{
			return;
		}
		this.RefreshLoopScroll(this.CurrentSelectTabId);
	}

	// Token: 0x0600F6B8 RID: 63160 RVA: 0x00481072 File Offset: 0x0047F272
	protected override void OnBeforeHide()
	{
		this.RemoveTimer();
	}

	// Token: 0x0600F6B9 RID: 63161 RVA: 0x0048107A File Offset: 0x0047F27A
	protected override void OnBeforeDestroy()
	{
		this.TabGroup.Destroy(null);
		this.LoopScrollView.ClearGridProxies();
	}

	// Token: 0x04008A51 RID: 35409
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected TabComponent<PayShopSwitchItem> TabGroup;

	// Token: 0x04008A52 RID: 35410
	protected List<IPayShopUnionData> PayShopGoodsList = new List<IPayShopUnionData>();

	// Token: 0x04008A53 RID: 35411
	protected int CurrentSelectTabId;

	// Token: 0x04008A54 RID: 35412
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		1
	})]
	protected LoopScrollView<GridProxyAbstract<IPayShopUnionData>, IPayShopUnionData> LoopScrollView;

	// Token: 0x04008A55 RID: 35413
	private int CurrentShopId;

	// Token: 0x04008A56 RID: 35414
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04008A57 RID: 35415
	private const int TIMEGAP = 1000;

	// Token: 0x02007A98 RID: 31384
	[NullableContext(0)]
	private enum EDiscountShopComponent
	{
		// Token: 0x04027BAA RID: 162730
		ScrollerItem,
		// Token: 0x04027BAB RID: 162731
		Scroller,
		// Token: 0x04027BAC RID: 162732
		HoriGroupScroller,
		// Token: 0x04027BAD RID: 162733
		TabItem,
		// Token: 0x04027BAE RID: 162734
		TabPanel,
		// Token: 0x04027BAF RID: 162735
		TitleTips,
		// Token: 0x04027BB0 RID: 162736
		ScrollerItemRecharge,
		// Token: 0x04027BB1 RID: 162737
		PanelItem,
		// Token: 0x04027BB2 RID: 162738
		EmptyItem,
		// Token: 0x04027BB3 RID: 162739
		EmptyText
	}
}
