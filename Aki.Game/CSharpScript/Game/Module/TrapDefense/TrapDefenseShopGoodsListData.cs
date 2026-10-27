using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A79 RID: 19065
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopGoodsListData : ITrapDefenseShopGoodsListData
	{
		// Token: 0x17007AD4 RID: 31444
		// (get) Token: 0x06031694 RID: 202388 RVA: 0x00B728BF File Offset: 0x00B70ABF
		// (set) Token: 0x06031695 RID: 202389 RVA: 0x00B728C7 File Offset: 0x00B70AC7
		public ETrapDefenseShopGoodsType Type { get; set; }

		// Token: 0x17007AD5 RID: 31445
		// (get) Token: 0x06031696 RID: 202390 RVA: 0x00B728D0 File Offset: 0x00B70AD0
		// (set) Token: 0x06031697 RID: 202391 RVA: 0x00B728D8 File Offset: 0x00B70AD8
		public List<ITrapDefenseShopGoods> GoodsList { get; set; } = new List<ITrapDefenseShopGoods>();
	}
}
