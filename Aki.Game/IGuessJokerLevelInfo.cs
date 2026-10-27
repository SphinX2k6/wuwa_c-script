using System;

// Token: 0x0200105D RID: 4189
public interface IGuessJokerLevelInfo
{
	// Token: 0x170008B7 RID: 2231
	// (get) Token: 0x06006B50 RID: 27472
	// (set) Token: 0x06006B51 RID: 27473
	int LevelId { get; set; }

	// Token: 0x170008B8 RID: 2232
	// (get) Token: 0x06006B52 RID: 27474
	// (set) Token: 0x06006B53 RID: 27475
	bool Unlock { get; set; }

	// Token: 0x170008B9 RID: 2233
	// (get) Token: 0x06006B54 RID: 27476
	// (set) Token: 0x06006B55 RID: 27477
	bool FirstPass { get; set; }

	// Token: 0x170008BA RID: 2234
	// (get) Token: 0x06006B56 RID: 27478
	// (set) Token: 0x06006B57 RID: 27479
	bool RewardGet { get; set; }

	// Token: 0x170008BB RID: 2235
	// (get) Token: 0x06006B58 RID: 27480
	// (set) Token: 0x06006B59 RID: 27481
	bool PlayerWin { get; set; }
}
