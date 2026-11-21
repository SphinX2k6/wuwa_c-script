using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000C7B RID: 3195
[NullableContext(1)]
public interface IComboTeachingInfo
{
	// Token: 0x17000EE2 RID: 3810
	// (get) Token: 0x0600858B RID: 34187
	// (set) Token: 0x0600858C RID: 34188
	int Index { get; set; }

	// Token: 0x17000EE3 RID: 3811
	// (get) Token: 0x0600858D RID: 34189
	// (set) Token: 0x0600858E RID: 34190
	ComboTeaching Config { get; set; }

	// Token: 0x17000EE4 RID: 3812
	// (get) Token: 0x0600858F RID: 34191
	// (set) Token: 0x06008590 RID: 34192
	float HoldTotalTime { get; set; }

	// Token: 0x17000EE5 RID: 3813
	// (get) Token: 0x06008591 RID: 34193
	// (set) Token: 0x06008592 RID: 34194
	float SuccessDelay { get; set; }

	// Token: 0x17000EE6 RID: 3814
	// (get) Token: 0x06008593 RID: 34195
	// (set) Token: 0x06008594 RID: 34196
	[Nullable(2)]
	TimerHandle SuccessHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000EE7 RID: 3815
	// (get) Token: 0x06008595 RID: 34197
	// (set) Token: 0x06008596 RID: 34198
	BaseCheckCondition SuccessCondition { get; set; }

	// Token: 0x17000EE8 RID: 3816
	// (get) Token: 0x06008597 RID: 34199
	// (set) Token: 0x06008598 RID: 34200
	List<BaseCheckCondition> FailUpdateCondition { get; set; }

	// Token: 0x17000EE9 RID: 3817
	// (get) Token: 0x06008599 RID: 34201
	// (set) Token: 0x0600859A RID: 34202
	float FailDelay { get; set; }

	// Token: 0x17000EEA RID: 3818
	// (get) Token: 0x0600859B RID: 34203
	// (set) Token: 0x0600859C RID: 34204
	[Nullable(2)]
	TimerHandle FailHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000EEB RID: 3819
	// (get) Token: 0x0600859D RID: 34205
	// (set) Token: 0x0600859E RID: 34206
	List<BaseCheckCondition> FailEventCondition { get; set; }

	// Token: 0x17000EEC RID: 3820
	// (get) Token: 0x0600859F RID: 34207
	// (set) Token: 0x060085A0 RID: 34208
	bool IsEmit { get; set; }

	// Token: 0x17000EED RID: 3821
	// (get) Token: 0x060085A1 RID: 34209
	// (set) Token: 0x060085A2 RID: 34210
	bool IsHoldAction { get; set; }

	// Token: 0x17000EEE RID: 3822
	// (get) Token: 0x060085A3 RID: 34211
	// (set) Token: 0x060085A4 RID: 34212
	bool IsShowTag { get; set; }

	// Token: 0x17000EEF RID: 3823
	// (get) Token: 0x060085A5 RID: 34213
	// (set) Token: 0x060085A6 RID: 34214
	string ActionInfo { get; set; }

	// Token: 0x17000EF0 RID: 3824
	// (get) Token: 0x060085A7 RID: 34215
	// (set) Token: 0x060085A8 RID: 34216
	bool NeedTickSummon { get; set; }
}
