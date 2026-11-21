using System;

// Token: 0x02001046 RID: 4166
public interface IProgressItem
{
	// Token: 0x17001183 RID: 4483
	// (get) Token: 0x0600A5DA RID: 42458
	// (set) Token: 0x0600A5DB RID: 42459
	int DayIndex { get; set; }

	// Token: 0x17001184 RID: 4484
	// (get) Token: 0x0600A5DC RID: 42460
	// (set) Token: 0x0600A5DD RID: 42461
	bool IsPassed { get; set; }
}
