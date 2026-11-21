using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001817 RID: 6167
public class BattlePassTaskData
{
	// Token: 0x0400886D RID: 34925
	[Nullable(1)]
	public List<TItem> RewardItemList = new List<TItem>();

	// Token: 0x0400886E RID: 34926
	public int TaskId;

	// Token: 0x0400886F RID: 34927
	public EBattlePassTaskState TaskState = EBattlePassTaskState.Running;

	// Token: 0x04008870 RID: 34928
	public EBattlePassTaskUpdateState UpdateType;

	// Token: 0x04008871 RID: 34929
	public int CurrentProgress;

	// Token: 0x04008872 RID: 34930
	public int TargetProgress;

	// Token: 0x04008873 RID: 34931
	public int Exp;

	// Token: 0x04008874 RID: 34932
	public int? SkipId;
}
