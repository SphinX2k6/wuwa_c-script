using System;

// Token: 0x02000624 RID: 1572
public class JumpToItemData : IJumpToItemData
{
	// Token: 0x17000A53 RID: 2643
	// (get) Token: 0x0600496D RID: 18797 RVA: 0x0018E826 File Offset: 0x0018CA26
	// (set) Token: 0x0600496E RID: 18798 RVA: 0x0018E82E File Offset: 0x0018CA2E
	public int LevelId { get; set; }

	// Token: 0x17000A54 RID: 2644
	// (get) Token: 0x0600496F RID: 18799 RVA: 0x0018E837 File Offset: 0x0018CA37
	// (set) Token: 0x06004970 RID: 18800 RVA: 0x0018E83F File Offset: 0x0018CA3F
	public bool Done { get; set; }

	// Token: 0x17000A55 RID: 2645
	// (get) Token: 0x06004971 RID: 18801 RVA: 0x0018E848 File Offset: 0x0018CA48
	// (set) Token: 0x06004972 RID: 18802 RVA: 0x0018E850 File Offset: 0x0018CA50
	public bool IsUnlock { get; set; }

	// Token: 0x17000A56 RID: 2646
	// (get) Token: 0x06004973 RID: 18803 RVA: 0x0018E859 File Offset: 0x0018CA59
	// (set) Token: 0x06004974 RID: 18804 RVA: 0x0018E861 File Offset: 0x0018CA61
	public int StarNumber { get; set; }
}
