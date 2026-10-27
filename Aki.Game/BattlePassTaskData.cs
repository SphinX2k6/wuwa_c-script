using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002332 RID: 9010
public class BattlePassTaskData
{
	// Token: 0x0400872A RID: 34602
	[Nullable(1)]
	public List<TItem> RewardItemList = new List<TItem>();

	// Token: 0x0400872B RID: 34603
	public int TaskId;

	// Token: 0x0400872C RID: 34604
	public EBattlePassTaskState TaskState = EBattlePassTaskState.Running;

	// Token: 0x0400872D RID: 34605
	public EBattlePassTaskUpdateState UpdateType;

	// Token: 0x0400872E RID: 34606
	public int CurrentProgress;

	// Token: 0x0400872F RID: 34607
	public int TargetProgress;

	// Token: 0x04008730 RID: 34608
	public int Exp;

	// Token: 0x04008731 RID: 34609
	public int? SkipId;
}
