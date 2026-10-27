using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A78 RID: 19064
	[NullableContext(1)]
	public interface ITrapDefenseShopGoodsListData
	{
		// Token: 0x17007AD2 RID: 31442
		// (get) Token: 0x06031690 RID: 202384
		// (set) Token: 0x06031691 RID: 202385
		ETrapDefenseShopGoodsType Type { get; set; }

		// Token: 0x17007AD3 RID: 31443
		// (get) Token: 0x06031692 RID: 202386
		// (set) Token: 0x06031693 RID: 202387
		List<ITrapDefenseShopGoods> GoodsList { get; set; }
	}
}
