using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200185F RID: 6239
public class OrnamentItemContentData
{
	// Token: 0x04008A69 RID: 35433
	[Nullable(2)]
	public ShopRoleOrnamentData ShopRoleOrnamentData;

	// Token: 0x04008A6A RID: 35434
	[Nullable(1)]
	public List<PayShopGoods> AllData = new List<PayShopGoods>();
}
