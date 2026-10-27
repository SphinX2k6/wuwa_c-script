using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200236C RID: 9068
[NullableContext(1)]
[Nullable(0)]
public class PayShopExchangeEntryView : UiTabViewBase, IUiTabViewRefresh
{
	// Token: 0x06012193 RID: 74131 RVA: 0x00471EC8 File Offset: 0x004700C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06012194 RID: 74132 RVA: 0x00471F24 File Offset: 0x00470124
	protected override void OnStart()
	{
		this.TabLayout = new GenericScrollView<PayShopSecondTabItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<PayShopSecondTabItem>(this.InitTabItem), null);
		UUIItem item = base.GetItem(2);
		this.LoopScrollView = new LoopScrollView<PayShopGiftItem, PayShopGoods>(base.GetLoopScrollViewComponent(1), item.GetOwner() as AUIBaseActor, new Func<PayShopGiftItem>(this.InitItem), false);
	}

	// Token: 0x06012195 RID: 74133 RVA: 0x00471F84 File Offset: 0x00470184
	protected void RefreshTabItem()
	{
		List<int> payShopTabIdList = PayShopModel.Instance.GetPayShopTabIdList((PayShopDefine.EPayShopTabType)this.Params, true);
		this.CurrentTabId = payShopTabIdList[0];
		this.TabLayout.RefreshByData<int>(payShopTabIdList, null);
		this.SelectTabItem();
	}

	// Token: 0x06012196 RID: 74134 RVA: 0x00471FD0 File Offset: 0x004701D0
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

	// Token: 0x06012197 RID: 74135 RVA: 0x00472006 File Offset: 0x00470206
	protected void RefreshLoopScroll()
	{
		this.PayShopGoodsList = PayShopModel.Instance.GetPayShopTabData(PayShopDefine.EPayShopTabType.ExchangeEntry, this.CurrentTabId, true);
		this.LoopScrollView.ReloadProxyData(new Func<int, PayShopGoods>(this.GetProxyData), this.PayShopGoodsList.Count, false, false);
	}

	// Token: 0x06012198 RID: 74136 RVA: 0x00472044 File Offset: 0x00470244
	protected override void OnBeforeShow()
	{
		this.RefreshTabItem();
		this.LoopScrollView.ClearGridProxies();
		this.RefreshLoopScroll();
	}

	// Token: 0x06012199 RID: 74137 RVA: 0x0047205D File Offset: 0x0047025D
	protected override void OnBeforeHide()
	{
		this.LoopScrollView.ClearGridProxies();
	}

	// Token: 0x0601219A RID: 74138 RVA: 0x0047206A File Offset: 0x0047026A
	protected override void OnBeforeDestroy()
	{
		if (this.TabLayout != null)
		{
			this.TabLayout.ClearChildren();
			this.TabLayout = null;
		}
	}

	// Token: 0x0601219B RID: 74139 RVA: 0x00472088 File Offset: 0x00470288
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

	// Token: 0x0601219C RID: 74140 RVA: 0x004720D8 File Offset: 0x004702D8
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

	// Token: 0x0601219D RID: 74141 RVA: 0x00472126 File Offset: 0x00470326
	private PayShopGiftItem InitItem()
	{
		PayShopGiftItem payShopGiftItem = new PayShopGiftItem(EQualityPathType.PathType1, null);
		payShopGiftItem.SetToggleFunction(new Action<int>(this.OpenExchangeView));
		return payShopGiftItem;
	}

	// Token: 0x0601219E RID: 74142 RVA: 0x00472141 File Offset: 0x00470341
	private void OpenExchangeView(int goodsId)
	{
		PayShopController.Instance.OpenExchangePopView(goodsId, null);
	}

	// Token: 0x0601219F RID: 74143 RVA: 0x0047214F File Offset: 0x0047034F
	private PayShopGoods GetProxyData(int gridIndex)
	{
		return this.PayShopGoodsList[gridIndex];
	}

	// Token: 0x060121A0 RID: 74144 RVA: 0x00472160 File Offset: 0x00470360
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

	// Token: 0x040088EC RID: 35052
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<PayShopGiftItem, PayShopGoods> LoopScrollView;

	// Token: 0x040088ED RID: 35053
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<PayShopSecondTabItem> TabLayout;

	// Token: 0x040088EE RID: 35054
	protected int CurrentTabId;

	// Token: 0x040088EF RID: 35055
	protected List<PayShopGoods> PayShopGoodsList = new List<PayShopGoods>();

	// Token: 0x040088F0 RID: 35056
	protected Dictionary<int, int> PayShopGoodsMap = new Dictionary<int, int>();

	// Token: 0x020088FF RID: 35071
	[NullableContext(0)]
	private enum EPayShopExchangeEntryViewDefine
	{
		// Token: 0x0402C84B RID: 182347
		TabRootLayout,
		// Token: 0x0402C84C RID: 182348
		ScrollView,
		// Token: 0x0402C84D RID: 182349
		ScrollItem
	}
}
