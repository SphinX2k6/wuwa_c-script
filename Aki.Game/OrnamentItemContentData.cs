using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Ornament;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200237A RID: 9082
public class OrnamentItemContentData
{
	// Token: 0x04008924 RID: 35108
	[Nullable(2)]
	public ShopRoleOrnamentData ShopRoleOrnamentData;

	// Token: 0x04008925 RID: 35109
	[Nullable(1)]
	public List<PayShopGoods> AllData = new List<PayShopGoods>();
}
