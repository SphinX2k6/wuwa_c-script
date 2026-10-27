using System;

// Token: 0x02002879 RID: 10361
public class LevelLayoutGridData : ILevelLayoutGridData
{
	// Token: 0x17001C6F RID: 7279
	// (get) Token: 0x0601551D RID: 87325 RVA: 0x00562591 File Offset: 0x00560791
	// (set) Token: 0x0601551E RID: 87326 RVA: 0x00562599 File Offset: 0x00560799
	public bool IsChosen { get; set; }

	// Token: 0x17001C70 RID: 7280
	// (get) Token: 0x0601551F RID: 87327 RVA: 0x005625A2 File Offset: 0x005607A2
	// (set) Token: 0x06015520 RID: 87328 RVA: 0x005625AA File Offset: 0x005607AA
	public bool IsAvailable { get; set; }

	// Token: 0x17001C71 RID: 7281
	// (get) Token: 0x06015521 RID: 87329 RVA: 0x005625B3 File Offset: 0x005607B3
	// (set) Token: 0x06015522 RID: 87330 RVA: 0x005625BB File Offset: 0x005607BB
	public int LevelContent { get; set; }
}
