using System;

// Token: 0x02000512 RID: 1298
public class GuessJokerLevelInfo : IGuessJokerLevelInfo
{
	// Token: 0x170008DC RID: 2268
	// (get) Token: 0x06003EEF RID: 16111 RVA: 0x00161AFB File Offset: 0x0015FCFB
	// (set) Token: 0x06003EF0 RID: 16112 RVA: 0x00161B03 File Offset: 0x0015FD03
	public int LevelId { get; set; }

	// Token: 0x170008DD RID: 2269
	// (get) Token: 0x06003EF1 RID: 16113 RVA: 0x00161B0C File Offset: 0x0015FD0C
	// (set) Token: 0x06003EF2 RID: 16114 RVA: 0x00161B14 File Offset: 0x0015FD14
	public bool Unlock { get; set; }

	// Token: 0x170008DE RID: 2270
	// (get) Token: 0x06003EF3 RID: 16115 RVA: 0x00161B1D File Offset: 0x0015FD1D
	// (set) Token: 0x06003EF4 RID: 16116 RVA: 0x00161B25 File Offset: 0x0015FD25
	public bool FirstPass { get; set; }

	// Token: 0x170008DF RID: 2271
	// (get) Token: 0x06003EF5 RID: 16117 RVA: 0x00161B2E File Offset: 0x0015FD2E
	// (set) Token: 0x06003EF6 RID: 16118 RVA: 0x00161B36 File Offset: 0x0015FD36
	public bool RewardGet { get; set; }

	// Token: 0x170008E0 RID: 2272
	// (get) Token: 0x06003EF7 RID: 16119 RVA: 0x00161B3F File Offset: 0x0015FD3F
	// (set) Token: 0x06003EF8 RID: 16120 RVA: 0x00161B47 File Offset: 0x0015FD47
	public bool PlayerWin { get; set; }
}
