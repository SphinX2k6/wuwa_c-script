using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000C82 RID: 3202
[NullableContext(1)]
[Nullable(0)]
public class ComboTeachingInfo : IComboTeachingInfo
{
	// Token: 0x17000EFF RID: 3839
	// (get) Token: 0x060085DE RID: 34270 RVA: 0x0028E849 File Offset: 0x0028CA49
	// (set) Token: 0x060085DF RID: 34271 RVA: 0x0028E851 File Offset: 0x0028CA51
	public int Index { get; set; }

	// Token: 0x17000F00 RID: 3840
	// (get) Token: 0x060085E0 RID: 34272 RVA: 0x0028E85A File Offset: 0x0028CA5A
	// (set) Token: 0x060085E1 RID: 34273 RVA: 0x0028E862 File Offset: 0x0028CA62
	public ComboTeaching Config { get; set; }

	// Token: 0x17000F01 RID: 3841
	// (get) Token: 0x060085E2 RID: 34274 RVA: 0x0028E86B File Offset: 0x0028CA6B
	// (set) Token: 0x060085E3 RID: 34275 RVA: 0x0028E873 File Offset: 0x0028CA73
	public float HoldTotalTime { get; set; }

	// Token: 0x17000F02 RID: 3842
	// (get) Token: 0x060085E4 RID: 34276 RVA: 0x0028E87C File Offset: 0x0028CA7C
	// (set) Token: 0x060085E5 RID: 34277 RVA: 0x0028E884 File Offset: 0x0028CA84
	public float SuccessDelay { get; set; }

	// Token: 0x17000F03 RID: 3843
	// (get) Token: 0x060085E6 RID: 34278 RVA: 0x0028E88D File Offset: 0x0028CA8D
	// (set) Token: 0x060085E7 RID: 34279 RVA: 0x0028E895 File Offset: 0x0028CA95
	[Nullable(2)]
	public TimerHandle SuccessHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000F04 RID: 3844
	// (get) Token: 0x060085E8 RID: 34280 RVA: 0x0028E89E File Offset: 0x0028CA9E
	// (set) Token: 0x060085E9 RID: 34281 RVA: 0x0028E8A6 File Offset: 0x0028CAA6
	public BaseCheckCondition SuccessCondition { get; set; }

	// Token: 0x17000F05 RID: 3845
	// (get) Token: 0x060085EA RID: 34282 RVA: 0x0028E8AF File Offset: 0x0028CAAF
	// (set) Token: 0x060085EB RID: 34283 RVA: 0x0028E8B7 File Offset: 0x0028CAB7
	public List<BaseCheckCondition> FailUpdateCondition { get; set; } = new List<BaseCheckCondition>();

	// Token: 0x17000F06 RID: 3846
	// (get) Token: 0x060085EC RID: 34284 RVA: 0x0028E8C0 File Offset: 0x0028CAC0
	// (set) Token: 0x060085ED RID: 34285 RVA: 0x0028E8C8 File Offset: 0x0028CAC8
	public float FailDelay { get; set; }

	// Token: 0x17000F07 RID: 3847
	// (get) Token: 0x060085EE RID: 34286 RVA: 0x0028E8D1 File Offset: 0x0028CAD1
	// (set) Token: 0x060085EF RID: 34287 RVA: 0x0028E8D9 File Offset: 0x0028CAD9
	[Nullable(2)]
	public TimerHandle FailHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17000F08 RID: 3848
	// (get) Token: 0x060085F0 RID: 34288 RVA: 0x0028E8E2 File Offset: 0x0028CAE2
	// (set) Token: 0x060085F1 RID: 34289 RVA: 0x0028E8EA File Offset: 0x0028CAEA
	public List<BaseCheckCondition> FailEventCondition { get; set; } = new List<BaseCheckCondition>();

	// Token: 0x17000F09 RID: 3849
	// (get) Token: 0x060085F2 RID: 34290 RVA: 0x0028E8F3 File Offset: 0x0028CAF3
	// (set) Token: 0x060085F3 RID: 34291 RVA: 0x0028E8FB File Offset: 0x0028CAFB
	public bool IsEmit { get; set; }

	// Token: 0x17000F0A RID: 3850
	// (get) Token: 0x060085F4 RID: 34292 RVA: 0x0028E904 File Offset: 0x0028CB04
	// (set) Token: 0x060085F5 RID: 34293 RVA: 0x0028E90C File Offset: 0x0028CB0C
	public bool IsHoldAction { get; set; }

	// Token: 0x17000F0B RID: 3851
	// (get) Token: 0x060085F6 RID: 34294 RVA: 0x0028E915 File Offset: 0x0028CB15
	// (set) Token: 0x060085F7 RID: 34295 RVA: 0x0028E91D File Offset: 0x0028CB1D
	public bool IsShowTag { get; set; }

	// Token: 0x17000F0C RID: 3852
	// (get) Token: 0x060085F8 RID: 34296 RVA: 0x0028E926 File Offset: 0x0028CB26
	// (set) Token: 0x060085F9 RID: 34297 RVA: 0x0028E92E File Offset: 0x0028CB2E
	public string ActionInfo { get; set; } = "";

	// Token: 0x17000F0D RID: 3853
	// (get) Token: 0x060085FA RID: 34298 RVA: 0x0028E937 File Offset: 0x0028CB37
	// (set) Token: 0x060085FB RID: 34299 RVA: 0x0028E93F File Offset: 0x0028CB3F
	public bool NeedTickSummon { get; set; }
}
