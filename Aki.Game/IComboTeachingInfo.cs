using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020017C2 RID: 6082
[NullableContext(1)]
public interface IComboTeachingInfo
{
	// Token: 0x17000EBF RID: 3775
	// (get) Token: 0x0600B1A3 RID: 45475
	// (set) Token: 0x0600B1A4 RID: 45476
	int Index { get; set; }

	// Token: 0x17000EC0 RID: 3776
	// (get) Token: 0x0600B1A5 RID: 45477
	// (set) Token: 0x0600B1A6 RID: 45478
	ComboTeaching Config { get; set; }

	// Token: 0x17000EC1 RID: 3777
	// (get) Token: 0x0600B1A7 RID: 45479
	// (set) Token: 0x0600B1A8 RID: 45480
	float HoldTotalTime { get; set; }

	// Token: 0x17000EC2 RID: 3778
	// (get) Token: 0x0600B1A9 RID: 45481
	// (set) Token: 0x0600B1AA RID: 45482
	float SuccessDelay { get; set; }

	// Token: 0x17000EC3 RID: 3779
	// (get) Token: 0x0600B1AB RID: 45483
	// (set) Token: 0x0600B1AC RID: 45484
	[Nullable(2)]
	TimerHandle SuccessHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000EC4 RID: 3780
	// (get) Token: 0x0600B1AD RID: 45485
	// (set) Token: 0x0600B1AE RID: 45486
	BaseCheckCondition SuccessCondition { get; set; }

	// Token: 0x17000EC5 RID: 3781
	// (get) Token: 0x0600B1AF RID: 45487
	// (set) Token: 0x0600B1B0 RID: 45488
	List<BaseCheckCondition> FailUpdateCondition { get; set; }

	// Token: 0x17000EC6 RID: 3782
	// (get) Token: 0x0600B1B1 RID: 45489
	// (set) Token: 0x0600B1B2 RID: 45490
	float FailDelay { get; set; }

	// Token: 0x17000EC7 RID: 3783
	// (get) Token: 0x0600B1B3 RID: 45491
	// (set) Token: 0x0600B1B4 RID: 45492
	[Nullable(2)]
	TimerHandle FailHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000EC8 RID: 3784
	// (get) Token: 0x0600B1B5 RID: 45493
	// (set) Token: 0x0600B1B6 RID: 45494
	List<BaseCheckCondition> FailEventCondition { get; set; }

	// Token: 0x17000EC9 RID: 3785
	// (get) Token: 0x0600B1B7 RID: 45495
	// (set) Token: 0x0600B1B8 RID: 45496
	bool IsEmit { get; set; }

	// Token: 0x17000ECA RID: 3786
	// (get) Token: 0x0600B1B9 RID: 45497
	// (set) Token: 0x0600B1BA RID: 45498
	bool IsHoldAction { get; set; }

	// Token: 0x17000ECB RID: 3787
	// (get) Token: 0x0600B1BB RID: 45499
	// (set) Token: 0x0600B1BC RID: 45500
	bool IsShowTag { get; set; }

	// Token: 0x17000ECC RID: 3788
	// (get) Token: 0x0600B1BD RID: 45501
	// (set) Token: 0x0600B1BE RID: 45502
	string ActionInfo { get; set; }

	// Token: 0x17000ECD RID: 3789
	// (get) Token: 0x0600B1BF RID: 45503
	// (set) Token: 0x0600B1C0 RID: 45504
	bool NeedTickSummon { get; set; }
}
