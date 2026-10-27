using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020010B7 RID: 4279
[NullableContext(1)]
[Nullable(0)]
public class ActivityTaskData
{
	// Token: 0x06006F53 RID: 28499 RVA: 0x0016B720 File Offset: 0x00169920
	public void Refresh(ConditionTask task, TChangeCallback statusChangeCallback = null)
	{
		this.Id = task.Id;
		this.Current = task.Current;
		this.Target = task.Target;
		EActivityTaskState status = this.Status;
		this.Status = TaskStateResolver.ConditionState[task.Status];
		if (statusChangeCallback != null)
		{
			statusChangeCallback(status != this.Status, status, this.Status);
		}
	}

	// Token: 0x06006F54 RID: 28500 RVA: 0x0016B78C File Offset: 0x0016998C
	public void Refresh(ActivityTask task, TChangeCallback statusChangeCallback = null)
	{
		this.Id = task.Id;
		this.Current = task.Current;
		this.Target = task.Target;
		EActivityTaskState status = this.Status;
		this.Status = TaskStateResolver.TaskState[task.Status];
		if (statusChangeCallback != null)
		{
			statusChangeCallback(status != this.Status, status, this.Status);
		}
	}

	// Token: 0x040033C8 RID: 13256
	public int Id;

	// Token: 0x040033C9 RID: 13257
	public int TypeId;

	// Token: 0x040033CA RID: 13258
	public int Current;

	// Token: 0x040033CB RID: 13259
	public int Target = 1;

	// Token: 0x040033CC RID: 13260
	public EActivityTaskState Status = EActivityTaskState.Active;
}
