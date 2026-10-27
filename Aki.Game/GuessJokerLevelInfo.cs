using System;

// Token: 0x0200105E RID: 4190
public class GuessJokerLevelInfo : IGuessJokerLevelInfo
{
	// Token: 0x170008BC RID: 2236
	// (get) Token: 0x06006B5A RID: 27482 RVA: 0x001591D3 File Offset: 0x001573D3
	// (set) Token: 0x06006B5B RID: 27483 RVA: 0x001591DB File Offset: 0x001573DB
	public int LevelId { get; set; }

	// Token: 0x170008BD RID: 2237
	// (get) Token: 0x06006B5C RID: 27484 RVA: 0x001591E4 File Offset: 0x001573E4
	// (set) Token: 0x06006B5D RID: 27485 RVA: 0x001591EC File Offset: 0x001573EC
	public bool Unlock { get; set; }

	// Token: 0x170008BE RID: 2238
	// (get) Token: 0x06006B5E RID: 27486 RVA: 0x001591F5 File Offset: 0x001573F5
	// (set) Token: 0x06006B5F RID: 27487 RVA: 0x001591FD File Offset: 0x001573FD
	public bool FirstPass { get; set; }

	// Token: 0x170008BF RID: 2239
	// (get) Token: 0x06006B60 RID: 27488 RVA: 0x00159206 File Offset: 0x00157406
	// (set) Token: 0x06006B61 RID: 27489 RVA: 0x0015920E File Offset: 0x0015740E
	public bool RewardGet { get; set; }

	// Token: 0x170008C0 RID: 2240
	// (get) Token: 0x06006B62 RID: 27490 RVA: 0x00159217 File Offset: 0x00157417
	// (set) Token: 0x06006B63 RID: 27491 RVA: 0x0015921F File Offset: 0x0015741F
	public bool PlayerWin { get; set; }
}
