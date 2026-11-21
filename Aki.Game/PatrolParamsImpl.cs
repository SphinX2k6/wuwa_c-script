using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x0200264C RID: 9804
[NullableContext(2)]
[Nullable(0)]
public class PatrolParamsImpl : IPatrolParams
{
	// Token: 0x17002691 RID: 9873
	// (get) Token: 0x060187D4 RID: 100308 RVA: 0x00766922 File Offset: 0x00764B22
	// (set) Token: 0x060187D5 RID: 100309 RVA: 0x0076692A File Offset: 0x00764B2A
	public bool? DebugMode { get; set; }

	// Token: 0x17002692 RID: 9874
	// (get) Token: 0x060187D6 RID: 100310 RVA: 0x00766933 File Offset: 0x00764B33
	// (set) Token: 0x060187D7 RID: 100311 RVA: 0x0076693B File Offset: 0x00764B3B
	public bool? ReturnFalseWhenNavigationFailed { get; set; }

	// Token: 0x17002693 RID: 9875
	// (get) Token: 0x060187D8 RID: 100312 RVA: 0x00766944 File Offset: 0x00764B44
	// (set) Token: 0x060187D9 RID: 100313 RVA: 0x0076694C File Offset: 0x00764B4C
	public EPatrolStartMode? StartMode { get; set; }

	// Token: 0x17002694 RID: 9876
	// (get) Token: 0x060187DA RID: 100314 RVA: 0x00766955 File Offset: 0x00764B55
	// (set) Token: 0x060187DB RID: 100315 RVA: 0x0076695D File Offset: 0x00764B5D
	public List<double> RandomDistanceRange { get; set; }

	// Token: 0x17002695 RID: 9877
	// (get) Token: 0x060187DC RID: 100316 RVA: 0x00766966 File Offset: 0x00764B66
	// (set) Token: 0x060187DD RID: 100317 RVA: 0x0076696E File Offset: 0x00764B6E
	public bool? IsFollowStrictly { get; set; }

	// Token: 0x17002696 RID: 9878
	// (get) Token: 0x060187DE RID: 100318 RVA: 0x00766977 File Offset: 0x00764B77
	// (set) Token: 0x060187DF RID: 100319 RVA: 0x0076697F File Offset: 0x00764B7F
	public int? StartPointIndex { get; set; }

	// Token: 0x17002697 RID: 9879
	// (get) Token: 0x060187E0 RID: 100320 RVA: 0x00766988 File Offset: 0x00764B88
	// (set) Token: 0x060187E1 RID: 100321 RVA: 0x00766990 File Offset: 0x00764B90
	public int? EndPointIndex { get; set; }

	// Token: 0x17002698 RID: 9880
	// (get) Token: 0x060187E2 RID: 100322 RVA: 0x00766999 File Offset: 0x00764B99
	// (set) Token: 0x060187E3 RID: 100323 RVA: 0x007669A1 File Offset: 0x00764BA1
	public bool? NoRequestServer { get; set; }

	// Token: 0x17002699 RID: 9881
	// (get) Token: 0x060187E4 RID: 100324 RVA: 0x007669AA File Offset: 0x00764BAA
	// (set) Token: 0x060187E5 RID: 100325 RVA: 0x007669B2 File Offset: 0x00764BB2
	public bool? NoSyncPoint { get; set; }

	// Token: 0x1700269A RID: 9882
	// (get) Token: 0x060187E6 RID: 100326 RVA: 0x007669BB File Offset: 0x00764BBB
	// (set) Token: 0x060187E7 RID: 100327 RVA: 0x007669C3 File Offset: 0x00764BC3
	public float? TurnSpeed { get; set; }

	// Token: 0x1700269B RID: 9883
	// (get) Token: 0x060187E8 RID: 100328 RVA: 0x007669CC File Offset: 0x00764BCC
	// (set) Token: 0x060187E9 RID: 100329 RVA: 0x007669D4 File Offset: 0x00764BD4
	public Action<int> OnArrivePointHandle { get; set; }

	// Token: 0x1700269C RID: 9884
	// (get) Token: 0x060187EA RID: 100330 RVA: 0x007669DD File Offset: 0x00764BDD
	// (set) Token: 0x060187EB RID: 100331 RVA: 0x007669E5 File Offset: 0x00764BE5
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public Action<IList<ActionInfo>> OnTriggerActionsHandle { [return: Nullable(new byte[]
	{
		2,
		1,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1,
		1
	})] set; }

	// Token: 0x1700269D RID: 9885
	// (get) Token: 0x060187EC RID: 100332 RVA: 0x007669EE File Offset: 0x00764BEE
	// (set) Token: 0x060187ED RID: 100333 RVA: 0x007669F6 File Offset: 0x00764BF6
	public Action<ELevelEventState> OnPatrolEndHandle { get; set; }

	// Token: 0x1700269E RID: 9886
	// (get) Token: 0x060187EE RID: 100334 RVA: 0x007669FF File Offset: 0x00764BFF
	// (set) Token: 0x060187EF RID: 100335 RVA: 0x00766A07 File Offset: 0x00764C07
	public Action OnResetLocationCallback { get; set; }
}
