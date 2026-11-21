using System;
using System.Runtime.CompilerServices;

// Token: 0x0200055D RID: 1373
[NullableContext(2)]
[Nullable(0)]
public class ActivityRewardData : IActivityRewardData
{
	// Token: 0x17000953 RID: 2387
	// (get) Token: 0x06004284 RID: 17028 RVA: 0x00173C8B File Offset: 0x00171E8B
	// (set) Token: 0x06004285 RID: 17029 RVA: 0x00173C93 File Offset: 0x00171E93
	public int? Id { get; set; }

	// Token: 0x17000954 RID: 2388
	// (get) Token: 0x06004286 RID: 17030 RVA: 0x00173C9C File Offset: 0x00171E9C
	// (set) Token: 0x06004287 RID: 17031 RVA: 0x00173CA4 File Offset: 0x00171EA4
	[Nullable(1)]
	public string NameText { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000955 RID: 2389
	// (get) Token: 0x06004288 RID: 17032 RVA: 0x00173CAD File Offset: 0x00171EAD
	// (set) Token: 0x06004289 RID: 17033 RVA: 0x00173CB5 File Offset: 0x00171EB5
	public string NameTextId { get; set; }

	// Token: 0x17000956 RID: 2390
	// (get) Token: 0x0600428A RID: 17034 RVA: 0x00173CBE File Offset: 0x00171EBE
	// (set) Token: 0x0600428B RID: 17035 RVA: 0x00173CC6 File Offset: 0x00171EC6
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] NameTextArgs { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000957 RID: 2391
	// (get) Token: 0x0600428C RID: 17036 RVA: 0x00173CCF File Offset: 0x00171ECF
	// (set) Token: 0x0600428D RID: 17037 RVA: 0x00173CD7 File Offset: 0x00171ED7
	public TItem[] RewardList { get; set; }

	// Token: 0x17000958 RID: 2392
	// (get) Token: 0x0600428E RID: 17038 RVA: 0x00173CE0 File Offset: 0x00171EE0
	// (set) Token: 0x0600428F RID: 17039 RVA: 0x00173CE8 File Offset: 0x00171EE8
	public EActivityRewardState RewardState { get; set; }

	// Token: 0x17000959 RID: 2393
	// (get) Token: 0x06004290 RID: 17040 RVA: 0x00173CF1 File Offset: 0x00171EF1
	// (set) Token: 0x06004291 RID: 17041 RVA: 0x00173CF9 File Offset: 0x00171EF9
	public string RewardButtonTextId { get; set; }

	// Token: 0x1700095A RID: 2394
	// (get) Token: 0x06004292 RID: 17042 RVA: 0x00173D02 File Offset: 0x00171F02
	// (set) Token: 0x06004293 RID: 17043 RVA: 0x00173D0A File Offset: 0x00171F0A
	public string RewardButtonText { get; set; }

	// Token: 0x1700095B RID: 2395
	// (get) Token: 0x06004294 RID: 17044 RVA: 0x00173D13 File Offset: 0x00171F13
	// (set) Token: 0x06004295 RID: 17045 RVA: 0x00173D1B File Offset: 0x00171F1B
	public bool? RewardButtonRedDot { get; set; }

	// Token: 0x1700095C RID: 2396
	// (get) Token: 0x06004296 RID: 17046 RVA: 0x00173D24 File Offset: 0x00171F24
	// (set) Token: 0x06004297 RID: 17047 RVA: 0x00173D2C File Offset: 0x00171F2C
	public Action ClickFunction { get; set; }

	// Token: 0x1700095D RID: 2397
	// (get) Token: 0x06004298 RID: 17048 RVA: 0x00173D35 File Offset: 0x00171F35
	// (set) Token: 0x06004299 RID: 17049 RVA: 0x00173D3D File Offset: 0x00171F3D
	public bool? ClickFunctionAndCloseSelf { get; set; }

	// Token: 0x1700095E RID: 2398
	// (get) Token: 0x0600429A RID: 17050 RVA: 0x00173D46 File Offset: 0x00171F46
	// (set) Token: 0x0600429B RID: 17051 RVA: 0x00173D4E File Offset: 0x00171F4E
	public string ProgressText { get; set; }
}
