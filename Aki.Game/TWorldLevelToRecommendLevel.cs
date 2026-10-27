using System;

// Token: 0x02001FA4 RID: 8100
public class TWorldLevelToRecommendLevel
{
	// Token: 0x17001348 RID: 4936
	// (get) Token: 0x0600FBA7 RID: 64423 RVA: 0x003D0413 File Offset: 0x003CE613
	// (set) Token: 0x0600FBA8 RID: 64424 RVA: 0x003D041B File Offset: 0x003CE61B
	public int Item1 { get; set; }

	// Token: 0x17001349 RID: 4937
	// (get) Token: 0x0600FBA9 RID: 64425 RVA: 0x003D0424 File Offset: 0x003CE624
	// (set) Token: 0x0600FBAA RID: 64426 RVA: 0x003D042C File Offset: 0x003CE62C
	public int Item2 { get; set; }

	// Token: 0x0600FBAB RID: 64427 RVA: 0x003D0435 File Offset: 0x003CE635
	public TWorldLevelToRecommendLevel(int item1, int item2)
	{
		this.Item1 = item1;
		this.Item2 = item2;
	}
}
