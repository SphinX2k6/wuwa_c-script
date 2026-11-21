using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001851 RID: 6225
[NullableContext(1)]
[Nullable(0)]
public class PayShopExchangeEntryView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x0600F643 RID: 63043 RVA: 0x0047F048 File Offset: 0x0047D248
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600F644 RID: 63044 RVA: 0x0047F0A4 File Offset: 0x0047D2A4
	protected override void OnStart()
	{
		this.TabLayout = new GenericScrollView<PayShopSecondTabItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PayShopSecondTabItem>(this.InitTabItem), null);
		UUIItem item = base.GetItem(2);
		this.LoopScrollView = new LoopScrollView<PayShopGiftItem, PayShopGoods>(base.GetLoopScrollViewComponent(1), item.GetOwner() as AUIBaseActor, new Func<PayShopGiftItem>(this.InitItem), false);
	}

	// Token: 0x0600F645 RID: 63045 RVA: 0x0047F104 File Offset: 0x0047D304
	protected void RefreshTabItem()
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.Params, true);
		this.CurrentTabId = payShopTabIdList[0];
		this.TabLayout.RefreshByData<int>(payShopTabIdList, null);
		this.SelectTabItem();
	}

	// Token: 0x0600F646 RID: 63046 RVA: 0x0047F150 File Offset: 0x0047D350
	protected void SelectTabItem()
	{
		if (this.CurrentTabId != 0)
		{
			PayShopSecondTabItem scrollItemByKey = this.TabLayout.GetScrollItemByKey(this.CurrentTabId);
			if (scrollItemByKey != null)
			{
				scrollItemByKey.SetToggleState(true);
			}
		}
	}

	// Token: 0x0600F647 RID: 63047 RVA: 0x0047F186 File Offset: 0x0047D386
	protected void RefreshLoopScroll()
	{
		this.PayShopGoodsList = PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.ExchangeEntry, this.CurrentTabId, true);
		this.LoopScrollView.ReloadProxyData(new Func<int, PayShopGoods>(this.GetProxyData), this.PayShopGoodsList.Count, false, false);
	}

	// Token: 0x0600F648 RID: 63048 RVA: 0x0047F1C4 File Offset: 0x0047D3C4
	protected override void OnBeforeShow()
	{
		this.RefreshTabItem();
		this.LoopScrollView.ClearGridProxies();
		this.RefreshLoopScroll();
	}

	// Token: 0x0600F649 RID: 63049 RVA: 0x0047F1DD File Offset: 0x0047D3DD
	protected override void OnBeforeHide()
	{
		this.LoopScrollView.ClearGridProxies();
	}

	// Token: 0x0600F64A RID: 63050 RVA: 0x0047F1EA File Offset: 0x0047D3EA
	protected override void OnBeforeDestroy()
	{
		if (this.TabLayout != null)
		{
			this.TabLayout.ClearChildren();
			this.TabLayout = null;
		}
	}

	// Token: 0x0600F64B RID: 63051 RVA: 0x0047F208 File Offset: 0x0047D408
	private ILayoutItem<PayShopSecondTabItem> InitTabItem(object tabId, UUIItem uiItem, int index)
	{
		PayShopSecondTabItem payShopSecondTabItem = new PayShopSecondTabItem(uiItem);
		payShopSecondTabItem.SetName(PayShopDefine.EPayShopTabType.ExchangeEntry, (int)tabId);
		payShopSecondTabItem.SetToggleFunction(new Action<int>(this.TabToggleFunction));
		return new LayoutItem<PayShopSecondTabItem>
		{
			Key = (int)tabId,
			Value = payShopSecondTabItem
		};
	}

	// Token: 0x0600F64C RID: 63052 RVA: 0x0047F258 File Offset: 0x0047D458
	private void TabToggleFunction(int tabId)
	{
		if (this.CurrentTabId != 0)
		{
			PayShopSecondTabItem scrollItemByKey = this.TabLayout.GetScrollItemByKey(this.CurrentTabId);
			if (scrollItemByKey != null)
			{
				scrollItemByKey.SetToggleState(false);
			}
		}
		this.CurrentTabId = tabId;
		this.LoopScrollView.ClearGridProxies();
		this.RefreshLoopScroll();
	}

	// Token: 0x0600F64D RID: 63053 RVA: 0x0047F2A6 File Offset: 0x0047D4A6
	private PayShopGiftItem InitItem()
	{
		PayShopGiftItem payShopGiftItem = new PayShopGiftItem(EQualityPathType.PathType1, null);
		payShopGiftItem.SetToggleFunction(new Action<int>(this.OpenExchangeView));
		return payShopGiftItem;
	}

	// Token: 0x0600F64E RID: 63054 RVA: 0x0047F2C1 File Offset: 0x0047D4C1
	private void OpenExchangeView(int goodsId)
	{
		PayShopController.Instance.OpenExchangePopView(goodsId, null);
	}

	// Token: 0x0600F64F RID: 63055 RVA: 0x0047F2CF File Offset: 0x0047D4CF
	private PayShopGoods GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x0600F650 RID: 63056 RVA: 0x0047F2E0 File Offset: 0x0047D4E0
	[NullableContext(2)]
	public void RefreshView(object @params)
	{
		if (@params is int)
		{
			int num = (int)@params;
			if (this.CurrentTabId != num)
			{
				this.CurrentTabId = num;
				this.SelectTabItem();
			}
			this.LoopScrollView.ClearGridProxies();
			this.RefreshLoopScroll();
			return;
		}
		HashSet<int> hashSet = @params as HashSet<int>;
		if (hashSet != null && hashSet.Contains(this.CurrentTabId))
		{
			this.LoopScrollView.ClearGridProxies();
			this.RefreshLoopScroll();
		}
	}

	// Token: 0x04008A31 RID: 35377
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<PayShopGiftItem, PayShopGoods> LoopScrollView;

	// Token: 0x04008A32 RID: 35378
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<PayShopSecondTabItem> TabLayout;

	// Token: 0x04008A33 RID: 35379
	protected int CurrentTabId;

	// Token: 0x04008A34 RID: 35380
	protected List<PayShopGoods> PayShopGoodsList = new List<PayShopGoods>();

	// Token: 0x04008A35 RID: 35381
	protected Dictionary<int, int> PayShopGoodsMap = new Dictionary<int, int>();

	// Token: 0x02007A89 RID: 31369
	[NullableContext(0)]
	private enum EPayShopExchangeEntryViewDefine
	{
		// Token: 0x04027B63 RID: 162659
		TabRootLayout,
		// Token: 0x04027B64 RID: 162660
		ScrollView,
		// Token: 0x04027B65 RID: 162661
		ScrollItem
	}
}
