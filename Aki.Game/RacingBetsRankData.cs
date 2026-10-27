using System;
using System.Runtime.CompilerServices;

// Token: 0x020026FA RID: 9978
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsRankData : IRacingBetsRankData
{
	// Token: 0x17001AC0 RID: 6848
	// (get) Token: 0x0601475A RID: 83802 RVA: 0x0052BB14 File Offset: 0x00529D14
	// (set) Token: 0x0601475B RID: 83803 RVA: 0x0052BB1C File Offset: 0x00529D1C
	public int PlayerId { get; set; }

	// Token: 0x17001AC1 RID: 6849
	// (get) Token: 0x0601475C RID: 83804 RVA: 0x0052BB25 File Offset: 0x00529D25
	// (set) Token: 0x0601475D RID: 83805 RVA: 0x0052BB2D File Offset: 0x00529D2D
	public int PlayerHeadPhoto { get; set; }

	// Token: 0x17001AC2 RID: 6850
	// (get) Token: 0x0601475E RID: 83806 RVA: 0x0052BB36 File Offset: 0x00529D36
	// (set) Token: 0x0601475F RID: 83807 RVA: 0x0052BB3E File Offset: 0x00529D3E
	public int RankNum { get; set; }

	// Token: 0x17001AC3 RID: 6851
	// (get) Token: 0x06014760 RID: 83808 RVA: 0x0052BB47 File Offset: 0x00529D47
	// (set) Token: 0x06014761 RID: 83809 RVA: 0x0052BB4F File Offset: 0x00529D4F
	public string Name { get; set; }

	// Token: 0x17001AC4 RID: 6852
	// (get) Token: 0x06014762 RID: 83810 RVA: 0x0052BB58 File Offset: 0x00529D58
	// (set) Token: 0x06014763 RID: 83811 RVA: 0x0052BB60 File Offset: 0x00529D60
	public int HitNum { get; set; }

	// Token: 0x17001AC5 RID: 6853
	// (get) Token: 0x06014764 RID: 83812 RVA: 0x0052BB69 File Offset: 0x00529D69
	// (set) Token: 0x06014765 RID: 83813 RVA: 0x0052BB71 File Offset: 0x00529D71
	public int CashNum { get; set; }
}
