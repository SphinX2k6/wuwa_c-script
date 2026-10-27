using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020011EE RID: 4590
[NullableContext(1)]
[Nullable(0)]
public class TaskData
{
	// Token: 0x06007A86 RID: 31366 RVA: 0x0019CB10 File Offset: 0x0019AD10
	public TaskData DeepCopy(TaskData origin)
	{
		return new TaskData
		{
			TaskId = origin.TaskId,
			Status = origin.Status,
			IsFinished = origin.IsFinished,
			IsTaken = origin.IsTaken,
			DoingTextId = origin.DoingTextId,
			JumpId = origin.JumpId,
			Current = origin.Current,
			Target = origin.Target,
			TitleTextId = origin.TitleTextId,
			RewardList = origin.RewardList,
			ReceiveDelegate = origin.ReceiveDelegate
		};
	}

	// Token: 0x04003823 RID: 14371
	public int TaskId;

	// Token: 0x04003824 RID: 14372
	public EActivityTaskState Status = EActivityTaskState.Active;

	// Token: 0x04003825 RID: 14373
	public bool IsFinished;

	// Token: 0x04003826 RID: 14374
	public bool IsTaken;

	// Token: 0x04003827 RID: 14375
	public string DoingTextId = string.Empty;

	// Token: 0x04003828 RID: 14376
	public int JumpId;

	// Token: 0x04003829 RID: 14377
	public int Current;

	// Token: 0x0400382A RID: 14378
	public int Target;

	// Token: 0x0400382B RID: 14379
	public string TitleTextId = string.Empty;

	// Token: 0x0400382C RID: 14380
	public List<TItem> RewardList = new List<TItem>();

	// Token: 0x0400382D RID: 14381
	[Nullable(2)]
	public TaskReceive ReceiveDelegate;
}
