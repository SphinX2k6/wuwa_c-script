using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A20 RID: 14880
	[NullableContext(1)]
	public interface ITrapDefenseShopGoodsListData
	{
		// Token: 0x17004E7F RID: 20095
		// (get) Token: 0x06026420 RID: 156704
		// (set) Token: 0x06026421 RID: 156705
		ETrapDefenseShopGoodsType Type { get; set; }

		// Token: 0x17004E80 RID: 20096
		// (get) Token: 0x06026422 RID: 156706
		// (set) Token: 0x06026423 RID: 156707
		List<ITrapDefenseShopGoods> GoodsList { get; set; }
	}
}
