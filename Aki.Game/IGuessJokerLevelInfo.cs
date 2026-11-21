using System;

// Token: 0x02000511 RID: 1297
public interface IGuessJokerLevelInfo
{
	// Token: 0x170008D7 RID: 2263
	// (get) Token: 0x06003EE5 RID: 16101
	// (set) Token: 0x06003EE6 RID: 16102
	int LevelId { get; set; }

	// Token: 0x170008D8 RID: 2264
	// (get) Token: 0x06003EE7 RID: 16103
	// (set) Token: 0x06003EE8 RID: 16104
	bool Unlock { get; set; }

	// Token: 0x170008D9 RID: 2265
	// (get) Token: 0x06003EE9 RID: 16105
	// (set) Token: 0x06003EEA RID: 16106
	bool FirstPass { get; set; }

	// Token: 0x170008DA RID: 2266
	// (get) Token: 0x06003EEB RID: 16107
	// (set) Token: 0x06003EEC RID: 16108
	bool RewardGet { get; set; }

	// Token: 0x170008DB RID: 2267
	// (get) Token: 0x06003EED RID: 16109
	// (set) Token: 0x06003EEE RID: 16110
	bool PlayerWin { get; set; }
}
