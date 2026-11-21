using System;

// Token: 0x0200151C RID: 5404
public class KingShipResultViewData : IKingShipResultViewData
{
	// Token: 0x17001409 RID: 5129
	// (get) Token: 0x0600D82F RID: 55343 RVA: 0x004026DA File Offset: 0x004008DA
	// (set) Token: 0x0600D830 RID: 55344 RVA: 0x004026E2 File Offset: 0x004008E2
	public int CardId { get; set; }

	// Token: 0x1700140A RID: 5130
	// (get) Token: 0x0600D831 RID: 55345 RVA: 0x004026EB File Offset: 0x004008EB
	// (set) Token: 0x0600D832 RID: 55346 RVA: 0x004026F3 File Offset: 0x004008F3
	public int ReignsId { get; set; }

	// Token: 0x1700140B RID: 5131
	// (get) Token: 0x0600D833 RID: 55347 RVA: 0x004026FC File Offset: 0x004008FC
	// (set) Token: 0x0600D834 RID: 55348 RVA: 0x00402704 File Offset: 0x00400904
	public bool IsSuccess { get; set; }

	// Token: 0x1700140C RID: 5132
	// (get) Token: 0x0600D835 RID: 55349 RVA: 0x0040270D File Offset: 0x0040090D
	// (set) Token: 0x0600D836 RID: 55350 RVA: 0x00402715 File Offset: 0x00400915
	public int NextReignsId { get; set; }
}
