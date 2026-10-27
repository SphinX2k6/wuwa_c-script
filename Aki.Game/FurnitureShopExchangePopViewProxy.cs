using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000F74 RID: 3956
public class FurnitureShopExchangePopViewProxy : CommonGameplayShopExchangePopViewProxy
{
	// Token: 0x0600654B RID: 25931 RVA: 0x001426B0 File Offset: 0x001408B0
	public override void UpdateShopItemData()
	{
		if (this.GoodsData == null)
		{
			return;
		}
		FurnitureShopExchangeItemProxy furnitureShopExchangeItemProxy = new FurnitureShopExchangeItemProxy();
		furnitureShopExchangeItemProxy.UpdateFromPayShopGoods(this.GoodsData);
		base.ShopItemProxy = furnitureShopExchangeItemProxy;
	}

	// Token: 0x0600654C RID: 25932 RVA: 0x001426DF File Offset: 0x001408DF
	public override void UpdateShopItemResource()
	{
		base.ShopItemResource = "PnlDIYShopItem";
	}

	// Token: 0x0600654D RID: 25933 RVA: 0x001426EC File Offset: 0x001408EC
	[NullableContext(1)]
	public override UiPanelBase ShopItemCreate()
	{
		this.ShopItem = new FurnitureExchangeShopItem();
		return this.ShopItem;
	}

	// Token: 0x0600654E RID: 25934 RVA: 0x00142700 File Offset: 0x00140900
	public override void ShopItemRefresh()
	{
		FurnitureExchangeShopItem furnitureExchangeShopItem = this.ShopItem as FurnitureExchangeShopItem;
		if (furnitureExchangeShopItem == null || base.ShopItemProxy == null)
		{
			return;
		}
		furnitureExchangeShopItem.RefreshByData((FurnitureShopExchangeItemProxy)base.ShopItemProxy);
	}

	// Token: 0x0600654F RID: 25935 RVA: 0x00142736 File Offset: 0x00140936
	public override void UpdateTipTitleItem()
	{
		base.TipTitleItemVisible = false;
	}
}
