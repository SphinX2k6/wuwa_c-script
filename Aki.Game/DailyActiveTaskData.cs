using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019F0 RID: 6640
public class DailyActiveTaskData
{
	// Token: 0x04005974 RID: 22900
	[Nullable(1)]
	public List<TItem> RewardItemList = new List<TItem>();

	// Token: 0x04005975 RID: 22901
	public int? TaskId = new int?(0);

	// Token: 0x04005976 RID: 22902
	public EDailyActiveState TaskState = EDailyActiveState.Unfinished;

	// Token: 0x04005977 RID: 22903
	public int? CurrentProgress = new int?(0);

	// Token: 0x04005978 RID: 22904
	public int? TargetProgress = new int?(0);

	// Token: 0x04005979 RID: 22905
	public int Sort;

	// Token: 0x0400597A RID: 22906
	public bool IsFunctionUnlock;
}
