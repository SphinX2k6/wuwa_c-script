using System;

// Token: 0x02001367 RID: 4967
public class MoonChasingTaskViewData
{
	// Token: 0x06008A7E RID: 35454 RVA: 0x001D98C0 File Offset: 0x001D7AC0
	public MoonChasingTaskViewData(EMoonChasingTaskType taskType, int taskId, bool isLastTask)
	{
		this.TaskType = taskType;
		this.TargetTaskId = taskId;
		this.IsLastTask = isLastTask;
	}

	// Token: 0x04003DB1 RID: 15793
	public EMoonChasingTaskType TaskType = EMoonChasingTaskType.MainLine;

	// Token: 0x04003DB2 RID: 15794
	public int TargetTaskId;

	// Token: 0x04003DB3 RID: 15795
	public bool IsLastTask;
}
