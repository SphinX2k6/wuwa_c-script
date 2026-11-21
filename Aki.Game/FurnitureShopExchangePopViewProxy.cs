using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000429 RID: 1065
public class FurnitureShopExchangePopViewProxy : CommonGameplayShopExchangePopViewProxy
{
	// Token: 0x060038E3 RID: 14563 RVA: 0x0014AF4C File Offset: 0x0014914C
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

	// Token: 0x060038E4 RID: 14564 RVA: 0x0014AF7B File Offset: 0x0014917B
	public override void UpdateShopItemResource()
	{
		base.ShopItemResource = "PnlDIYShopItem";
	}

	// Token: 0x060038E5 RID: 14565 RVA: 0x0014AF88 File Offset: 0x00149188
	[NullableContext(1)]
	public override UiPanelBase ShopItemCreate()
	{
		this.ShopItem = new FurnitureExchangeShopItem();
		return this.ShopItem;
	}

	// Token: 0x060038E6 RID: 14566 RVA: 0x0014AF9C File Offset: 0x0014919C
	public override void ShopItemRefresh()
	{
		FurnitureExchangeShopItem furnitureExchangeShopItem = this.ShopItem as FurnitureExchangeShopItem;
		if (furnitureExchangeShopItem == null || base.ShopItemProxy == null)
		{
			return;
		}
		furnitureExchangeShopItem.RefreshByData((FurnitureShopExchangeItemProxy)base.ShopItemProxy);
	}

	// Token: 0x060038E7 RID: 14567 RVA: 0x0014AFD2 File Offset: 0x001491D2
	public override void UpdateTipTitleItem()
	{
		base.TipTitleItemVisible = false;
	}
}
