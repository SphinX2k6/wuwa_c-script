using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

// Token: 0x02001877 RID: 6263
[NullableContext(2)]
[Nullable(0)]
public class ExchangePopData : UiPopViewData
{
	// Token: 0x04008ADE RID: 35550
	public int GoodsId;

	// Token: 0x04008ADF RID: 35551
	public PayShopGoods PayShopGoods;

	// Token: 0x04008AE0 RID: 35552
	[Nullable(1)]
	public string ShopItemResource = "";

	// Token: 0x04008AE1 RID: 35553
	public Func<int> GetMaxBuyCount;

	// Token: 0x04008AE2 RID: 35554
	public Func<bool> CheckIfCanBuy;
}
