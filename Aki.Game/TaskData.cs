using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020006A2 RID: 1698
[NullableContext(1)]
[Nullable(0)]
public class TaskData
{
	// Token: 0x06004E1D RID: 19997 RVA: 0x001A57B8 File Offset: 0x001A39B8
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

	// Token: 0x040038BC RID: 14524
	public int TaskId;

	// Token: 0x040038BD RID: 14525
	public EActivityTaskState Status = EActivityTaskState.Active;

	// Token: 0x040038BE RID: 14526
	public bool IsFinished;

	// Token: 0x040038BF RID: 14527
	public bool IsTaken;

	// Token: 0x040038C0 RID: 14528
	public string DoingTextId = string.Empty;

	// Token: 0x040038C1 RID: 14529
	public int JumpId;

	// Token: 0x040038C2 RID: 14530
	public int Current;

	// Token: 0x040038C3 RID: 14531
	public int Target;

	// Token: 0x040038C4 RID: 14532
	public string TitleTextId = string.Empty;

	// Token: 0x040038C5 RID: 14533
	public List<TItem> RewardList = new List<TItem>();

	// Token: 0x040038C6 RID: 14534
	[Nullable(2)]
	public TaskReceive ReceiveDelegate;
}
