using System;

// Token: 0x02001B87 RID: 7047
public interface IProgressItem
{
	// Token: 0x1700115E RID: 4446
	// (get) Token: 0x0600D1C9 RID: 53705
	// (set) Token: 0x0600D1CA RID: 53706
	int DayIndex { get; set; }

	// Token: 0x1700115F RID: 4447
	// (get) Token: 0x0600D1CB RID: 53707
	// (set) Token: 0x0600D1CC RID: 53708
	bool IsPassed { get; set; }
}
