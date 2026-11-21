using System;

// Token: 0x02001968 RID: 6504
public interface ILongPressParam
{
	// Token: 0x170018CA RID: 6346
	// (get) Token: 0x060100C5 RID: 65733
	// (set) Token: 0x060100C6 RID: 65734
	float BeforeLongPressThreshold { get; set; }

	// Token: 0x170018CB RID: 6347
	// (get) Token: 0x060100C7 RID: 65735
	// (set) Token: 0x060100C8 RID: 65736
	float LongPressThreshold { get; set; }

	// Token: 0x170018CC RID: 6348
	// (get) Token: 0x060100C9 RID: 65737
	// (set) Token: 0x060100CA RID: 65738
	float InvalidMoveDistance { get; set; }

	// Token: 0x170018CD RID: 6349
	// (get) Token: 0x060100CB RID: 65739
	// (set) Token: 0x060100CC RID: 65740
	float OffsetX { get; set; }

	// Token: 0x170018CE RID: 6350
	// (get) Token: 0x060100CD RID: 65741
	// (set) Token: 0x060100CE RID: 65742
	float OffsetY { get; set; }
}
