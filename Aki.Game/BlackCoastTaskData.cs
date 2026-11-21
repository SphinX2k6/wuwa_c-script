using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000661 RID: 1633
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastTaskData
{
	// Token: 0x17000A68 RID: 2664
	// (get) Token: 0x06004B8E RID: 19342 RVA: 0x0019A4C3 File Offset: 0x001986C3
	// (set) Token: 0x06004B8F RID: 19343 RVA: 0x0019A4CB File Offset: 0x001986CB
	public int TaskId { get; private set; }

	// Token: 0x06004B90 RID: 19344 RVA: 0x0019A4D4 File Offset: 0x001986D4
	public BlackCoastTaskData(int taskId)
	{
		this.TaskId = taskId;
	}

	// Token: 0x17000A69 RID: 2665
	// (get) Token: 0x06004B91 RID: 19345 RVA: 0x0019A500 File Offset: 0x00198700
	public bool IsFinished
	{
		get
		{
			return this.Status != EActivityTaskState.Active;
		}
	}

	// Token: 0x17000A6A RID: 2666
	// (get) Token: 0x06004B92 RID: 19346 RVA: 0x0019A50E File Offset: 0x0019870E
	public bool IsTaken
	{
		get
		{
			return this.Status == EActivityTaskState.FinishedAndClaimed;
		}
	}

	// Token: 0x040037CD RID: 14285
	public EActivityTaskState Status = EActivityTaskState.Active;

	// Token: 0x040037CE RID: 14286
	public int Current;

	// Token: 0x040037CF RID: 14287
	public int Target;

	// Token: 0x040037D0 RID: 14288
	public int JumpId;

	// Token: 0x040037D1 RID: 14289
	public int SortId;

	// Token: 0x040037D2 RID: 14290
	public string TitleTextId = "";

	// Token: 0x040037D3 RID: 14291
	public List<TItem> RewardList = new List<TItem>();

	// Token: 0x040037D4 RID: 14292
	[Nullable(2)]
	public Action<int> ReceiveDelegate;
}
