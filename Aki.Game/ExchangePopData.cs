using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

// Token: 0x02002392 RID: 9106
[NullableContext(2)]
[Nullable(0)]
public class ExchangePopData : UiPopViewData
{
	// Token: 0x04008997 RID: 35223
	public int GoodsId;

	// Token: 0x04008998 RID: 35224
	public PayShopGoods PayShopGoods;

	// Token: 0x04008999 RID: 35225
	[Nullable(1)]
	public string ShopItemResource = "";

	// Token: 0x0400899A RID: 35226
	public Func<int> GetMaxBuyCount;

	// Token: 0x0400899B RID: 35227
	public Func<bool> CheckIfCanBuy;
}
