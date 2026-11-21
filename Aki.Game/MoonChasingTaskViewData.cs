using System;

// Token: 0x0200081B RID: 2075
public class MoonChasingTaskViewData
{
	// Token: 0x06005E19 RID: 24089 RVA: 0x001E271C File Offset: 0x001E091C
	public MoonChasingTaskViewData(EMoonChasingTaskType taskType, int taskId, bool isLastTask)
	{
		this.TaskType = taskType;
		this.TargetTaskId = taskId;
		this.IsLastTask = isLastTask;
	}

	// Token: 0x04003E49 RID: 15945
	public EMoonChasingTaskType TaskType = EMoonChasingTaskType.MainLine;

	// Token: 0x04003E4A RID: 15946
	public int TargetTaskId;

	// Token: 0x04003E4B RID: 15947
	public bool IsLastTask;
}
