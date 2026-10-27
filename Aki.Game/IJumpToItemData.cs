using System;

// Token: 0x0200116F RID: 4463
public interface IJumpToItemData
{
	// Token: 0x17000A2F RID: 2607
	// (get) Token: 0x060075CE RID: 30158
	// (set) Token: 0x060075CF RID: 30159
	int LevelId { get; set; }

	// Token: 0x17000A30 RID: 2608
	// (get) Token: 0x060075D0 RID: 30160
	// (set) Token: 0x060075D1 RID: 30161
	bool Done { get; set; }

	// Token: 0x17000A31 RID: 2609
	// (get) Token: 0x060075D2 RID: 30162
	// (set) Token: 0x060075D3 RID: 30163
	bool IsUnlock { get; set; }

	// Token: 0x17000A32 RID: 2610
	// (get) Token: 0x060075D4 RID: 30164
	// (set) Token: 0x060075D5 RID: 30165
	int StarNumber { get; set; }
}
