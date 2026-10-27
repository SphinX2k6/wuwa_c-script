using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F8A RID: 3978
[NullableContext(1)]
public interface IFurnitureShopViewOpenData
{
	// Token: 0x170007EA RID: 2026
	// (get) Token: 0x06006607 RID: 26119
	int ShopId { get; }

	// Token: 0x170007EB RID: 2027
	// (get) Token: 0x06006608 RID: 26120
	int NpcEntityId { get; }

	// Token: 0x170007EC RID: 2028
	// (get) Token: 0x06006609 RID: 26121
	string NpcName { get; }

	// Token: 0x170007ED RID: 2029
	// (get) Token: 0x0600660A RID: 26122
	string NpcDesc { get; }

	// Token: 0x170007EE RID: 2030
	// (get) Token: 0x0600660B RID: 26123
	string NpcStartMontagePath { get; }

	// Token: 0x170007EF RID: 2031
	// (get) Token: 0x0600660C RID: 26124
	int GoodsId { get; }

	// Token: 0x170007F0 RID: 2032
	// (get) Token: 0x0600660D RID: 26125
	bool UseSpareShopNpc { get; }
}
