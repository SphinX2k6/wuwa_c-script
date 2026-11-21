using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EAF RID: 3759
public class DailyActiveTaskData
{
	// Token: 0x04005A43 RID: 23107
	[Nullable(1)]
	public List<TItem> RewardItemList = new List<TItem>();

	// Token: 0x04005A44 RID: 23108
	public int? TaskId = new int?(0);

	// Token: 0x04005A45 RID: 23109
	public EDailyActiveState TaskState = EDailyActiveState.Unfinished;

	// Token: 0x04005A46 RID: 23110
	public int? CurrentProgress = new int?(0);

	// Token: 0x04005A47 RID: 23111
	public int? TargetProgress = new int?(0);

	// Token: 0x04005A48 RID: 23112
	public int Sort;

	// Token: 0x04005A49 RID: 23113
	public bool IsFunctionUnlock;
}
