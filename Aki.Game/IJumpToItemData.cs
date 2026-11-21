using System;

// Token: 0x02000623 RID: 1571
public interface IJumpToItemData
{
	// Token: 0x17000A4F RID: 2639
	// (get) Token: 0x06004965 RID: 18789
	// (set) Token: 0x06004966 RID: 18790
	int LevelId { get; set; }

	// Token: 0x17000A50 RID: 2640
	// (get) Token: 0x06004967 RID: 18791
	// (set) Token: 0x06004968 RID: 18792
	bool Done { get; set; }

	// Token: 0x17000A51 RID: 2641
	// (get) Token: 0x06004969 RID: 18793
	// (set) Token: 0x0600496A RID: 18794
	bool IsUnlock { get; set; }

	// Token: 0x17000A52 RID: 2642
	// (get) Token: 0x0600496B RID: 18795
	// (set) Token: 0x0600496C RID: 18796
	int StarNumber { get; set; }
}
