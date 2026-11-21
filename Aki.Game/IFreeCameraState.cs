using System;
using System.Runtime.CompilerServices;

// Token: 0x02000535 RID: 1333
[NullableContext(2)]
internal interface IFreeCameraState
{
	// Token: 0x1700092A RID: 2346
	// (get) Token: 0x0600410A RID: 16650
	// (set) Token: 0x0600410B RID: 16651
	[Nullable(1)]
	IFreeCameraConfig Config { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x1700092B RID: 2347
	// (get) Token: 0x0600410C RID: 16652
	// (set) Token: 0x0600410D RID: 16653
	float Timer { get; set; }

	// Token: 0x1700092C RID: 2348
	// (get) Token: 0x0600410E RID: 16654
	// (set) Token: 0x0600410F RID: 16655
	int LastDirection { get; set; }

	// Token: 0x1700092D RID: 2349
	// (get) Token: 0x06004110 RID: 16656
	// (set) Token: 0x06004111 RID: 16657
	bool IsInterpolating { get; set; }

	// Token: 0x1700092E RID: 2350
	// (get) Token: 0x06004112 RID: 16658
	// (set) Token: 0x06004113 RID: 16659
	float InterpolationElapsedTime { get; set; }

	// Token: 0x1700092F RID: 2351
	// (get) Token: 0x06004114 RID: 16660
	// (set) Token: 0x06004115 RID: 16661
	int StartDirection { get; set; }

	// Token: 0x17000930 RID: 2352
	// (get) Token: 0x06004116 RID: 16662
	// (set) Token: 0x06004117 RID: 16663
	int TargetDirection { get; set; }

	// Token: 0x17000931 RID: 2353
	// (get) Token: 0x06004118 RID: 16664
	// (set) Token: 0x06004119 RID: 16665
	bool? IsExiting { get; set; }

	// Token: 0x17000932 RID: 2354
	// (get) Token: 0x0600411A RID: 16666
	// (set) Token: 0x0600411B RID: 16667
	Vector ExitRelativePos { get; set; }

	// Token: 0x17000933 RID: 2355
	// (get) Token: 0x0600411C RID: 16668
	// (set) Token: 0x0600411D RID: 16669
	Rotator ExitRelativeRot { get; set; }

	// Token: 0x17000934 RID: 2356
	// (get) Token: 0x0600411E RID: 16670
	// (set) Token: 0x0600411F RID: 16671
	int? ExitFollowConfigIndex { get; set; }
}
