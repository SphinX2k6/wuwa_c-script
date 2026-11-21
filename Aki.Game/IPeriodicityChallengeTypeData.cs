using System;
using System.Runtime.CompilerServices;

// Token: 0x02000B6D RID: 2925
[NullableContext(1)]
public interface IPeriodicityChallengeTypeData
{
	// Token: 0x17000DFF RID: 3583
	// (get) Token: 0x060079A4 RID: 31140
	// (set) Token: 0x060079A5 RID: 31141
	float LeftTime { get; set; }

	// Token: 0x17000E00 RID: 3584
	// (get) Token: 0x060079A6 RID: 31142
	// (set) Token: 0x060079A7 RID: 31143
	int CurrentNum { get; set; }

	// Token: 0x17000E01 RID: 3585
	// (get) Token: 0x060079A8 RID: 31144
	// (set) Token: 0x060079A9 RID: 31145
	int TotalNum { get; set; }

	// Token: 0x17000E02 RID: 3586
	// (get) Token: 0x060079AA RID: 31146
	// (set) Token: 0x060079AB RID: 31147
	bool IsFinish { get; set; }

	// Token: 0x17000E03 RID: 3587
	// (get) Token: 0x060079AC RID: 31148
	// (set) Token: 0x060079AD RID: 31149
	bool RedPoint { get; set; }

	// Token: 0x17000E04 RID: 3588
	// (get) Token: 0x060079AE RID: 31150
	// (set) Token: 0x060079AF RID: 31151
	string SubText { get; set; }
}
