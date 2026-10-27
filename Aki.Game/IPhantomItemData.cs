using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002424 RID: 9252
[NullableContext(1)]
public interface IPhantomItemData
{
	// Token: 0x1700180D RID: 6157
	// (get) Token: 0x060128DF RID: 75999
	// (set) Token: 0x060128E0 RID: 76000
	bool IsPhantomData { get; set; }

	// Token: 0x1700180E RID: 6158
	// (get) Token: 0x060128E1 RID: 76001
	// (set) Token: 0x060128E2 RID: 76002
	int Id { get; set; }

	// Token: 0x1700180F RID: 6159
	// (get) Token: 0x060128E3 RID: 76003
	// (set) Token: 0x060128E4 RID: 76004
	int Quality { get; set; }

	// Token: 0x17001810 RID: 6160
	// (get) Token: 0x060128E5 RID: 76005
	// (set) Token: 0x060128E6 RID: 76006
	bool IsEquip { get; set; }

	// Token: 0x17001811 RID: 6161
	// (get) Token: 0x060128E7 RID: 76007
	// (set) Token: 0x060128E8 RID: 76008
	int Role { get; set; }

	// Token: 0x17001812 RID: 6162
	// (get) Token: 0x060128E9 RID: 76009
	// (set) Token: 0x060128EA RID: 76010
	int Level { get; set; }

	// Token: 0x17001813 RID: 6163
	// (get) Token: 0x060128EB RID: 76011
	// (set) Token: 0x060128EC RID: 76012
	bool IsBreach { get; set; }

	// Token: 0x17001814 RID: 6164
	// (get) Token: 0x060128ED RID: 76013
	// (set) Token: 0x060128EE RID: 76014
	int MonsterId { get; set; }

	// Token: 0x17001815 RID: 6165
	// (get) Token: 0x060128EF RID: 76015
	// (set) Token: 0x060128F0 RID: 76016
	List<PhantomSortStruct> MainPropMap { get; set; }

	// Token: 0x17001816 RID: 6166
	// (get) Token: 0x060128F1 RID: 76017
	// (set) Token: 0x060128F2 RID: 76018
	List<PhantomSortStruct> SubPropMap { get; set; }

	// Token: 0x17001817 RID: 6167
	// (get) Token: 0x060128F3 RID: 76019
	// (set) Token: 0x060128F4 RID: 76020
	bool IsLock { get; set; }

	// Token: 0x17001818 RID: 6168
	// (get) Token: 0x060128F5 RID: 76021
	// (set) Token: 0x060128F6 RID: 76022
	bool IsDeprecate { get; set; }

	// Token: 0x17001819 RID: 6169
	// (get) Token: 0x060128F7 RID: 76023
	// (set) Token: 0x060128F8 RID: 76024
	int ConfigId { get; set; }

	// Token: 0x1700181A RID: 6170
	// (get) Token: 0x060128F9 RID: 76025
	// (set) Token: 0x060128FA RID: 76026
	int Rarity { get; set; }
}
