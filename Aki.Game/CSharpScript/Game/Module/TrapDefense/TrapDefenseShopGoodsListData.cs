using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A21 RID: 14881
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseShopGoodsListData : ITrapDefenseShopGoodsListData
	{
		// Token: 0x17004E81 RID: 20097
		// (get) Token: 0x06026424 RID: 156708 RVA: 0x00AB6843 File Offset: 0x00AB4A43
		// (set) Token: 0x06026425 RID: 156709 RVA: 0x00AB684B File Offset: 0x00AB4A4B
		public ETrapDefenseShopGoodsType Type { get; set; }

		// Token: 0x17004E82 RID: 20098
		// (get) Token: 0x06026426 RID: 156710 RVA: 0x00AB6854 File Offset: 0x00AB4A54
		// (set) Token: 0x06026427 RID: 156711 RVA: 0x00AB685C File Offset: 0x00AB4A5C
		public List<ITrapDefenseShopGoods> GoodsList { get; set; } = new List<ITrapDefenseShopGoods>();
	}
}
