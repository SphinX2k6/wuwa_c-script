using System;
using System.Runtime.CompilerServices;

// Token: 0x020016B5 RID: 5813
[NullableContext(1)]
public interface IPeriodicityChallengeTypeData
{
	// Token: 0x17000DDE RID: 3550
	// (get) Token: 0x0600A5C4 RID: 42436
	// (set) Token: 0x0600A5C5 RID: 42437
	float LeftTime { get; set; }

	// Token: 0x17000DDF RID: 3551
	// (get) Token: 0x0600A5C6 RID: 42438
	// (set) Token: 0x0600A5C7 RID: 42439
	int CurrentNum { get; set; }

	// Token: 0x17000DE0 RID: 3552
	// (get) Token: 0x0600A5C8 RID: 42440
	// (set) Token: 0x0600A5C9 RID: 42441
	int TotalNum { get; set; }

	// Token: 0x17000DE1 RID: 3553
	// (get) Token: 0x0600A5CA RID: 42442
	// (set) Token: 0x0600A5CB RID: 42443
	bool IsFinish { get; set; }

	// Token: 0x17000DE2 RID: 3554
	// (get) Token: 0x0600A5CC RID: 42444
	// (set) Token: 0x0600A5CD RID: 42445
	bool RedPoint { get; set; }

	// Token: 0x17000DE3 RID: 3555
	// (get) Token: 0x0600A5CE RID: 42446
	// (set) Token: 0x0600A5CF RID: 42447
	string SubText { get; set; }
}
