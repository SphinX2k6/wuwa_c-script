using System;

// Token: 0x02001F59 RID: 8025
public class ShipTowerViewParams
{
	// Token: 0x17001DFD RID: 7677
	// (get) Token: 0x06013D62 RID: 81250 RVA: 0x005C8EEA File Offset: 0x005C70EA
	// (set) Token: 0x06013D63 RID: 81251 RVA: 0x005C8EF2 File Offset: 0x005C70F2
	public int ApplyTeamEditStageId { get; set; }

	// Token: 0x17001DFE RID: 7678
	// (get) Token: 0x06013D64 RID: 81252 RVA: 0x005C8EFB File Offset: 0x005C70FB
	// (set) Token: 0x06013D65 RID: 81253 RVA: 0x005C8F03 File Offset: 0x005C7103
	public int? StageId { get; set; }

	// Token: 0x17001DFF RID: 7679
	// (get) Token: 0x06013D66 RID: 81254 RVA: 0x005C8F0C File Offset: 0x005C710C
	// (set) Token: 0x06013D67 RID: 81255 RVA: 0x005C8F14 File Offset: 0x005C7114
	public bool? IsOpenStageDesc { get; set; }

	// Token: 0x17001E00 RID: 7680
	// (get) Token: 0x06013D68 RID: 81256 RVA: 0x005C8F1D File Offset: 0x005C711D
	// (set) Token: 0x06013D69 RID: 81257 RVA: 0x005C8F25 File Offset: 0x005C7125
	public bool? IsFromInstanceDungeon { get; set; }

	// Token: 0x0400A936 RID: 43318
	public bool? IsOpenCover;
}
