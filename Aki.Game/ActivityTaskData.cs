using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200056B RID: 1387
[NullableContext(1)]
[Nullable(0)]
public class ActivityTaskData
{
	// Token: 0x060042E9 RID: 17129 RVA: 0x00174098 File Offset: 0x00172298
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

	// Token: 0x060042EA RID: 17130 RVA: 0x00174104 File Offset: 0x00172304
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

	// Token: 0x04003461 RID: 13409
	public int Id;

	// Token: 0x04003462 RID: 13410
	public int TypeId;

	// Token: 0x04003463 RID: 13411
	public int Current;

	// Token: 0x04003464 RID: 13412
	public int Target = 1;

	// Token: 0x04003465 RID: 13413
	public EActivityTaskState Status = EActivityTaskState.Active;
}
