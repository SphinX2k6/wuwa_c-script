using System;
using System.Runtime.CompilerServices;

// Token: 0x0200043F RID: 1087
[NullableContext(1)]
public interface IFurnitureShopViewOpenData
{
	// Token: 0x1700080C RID: 2060
	// (get) Token: 0x0600399F RID: 14751
	int ShopId { get; }

	// Token: 0x1700080D RID: 2061
	// (get) Token: 0x060039A0 RID: 14752
	int NpcEntityId { get; }

	// Token: 0x1700080E RID: 2062
	// (get) Token: 0x060039A1 RID: 14753
	string NpcName { get; }

	// Token: 0x1700080F RID: 2063
	// (get) Token: 0x060039A2 RID: 14754
	string NpcDesc { get; }

	// Token: 0x17000810 RID: 2064
	// (get) Token: 0x060039A3 RID: 14755
	string NpcStartMontagePath { get; }

	// Token: 0x17000811 RID: 2065
	// (get) Token: 0x060039A4 RID: 14756
	int GoodsId { get; }

	// Token: 0x17000812 RID: 2066
	// (get) Token: 0x060039A5 RID: 14757
	bool UseSpareShopNpc { get; }
}
