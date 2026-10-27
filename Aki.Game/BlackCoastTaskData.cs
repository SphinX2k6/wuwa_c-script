using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020011AD RID: 4525
[NullableContext(1)]
[Nullable(0)]
public class BlackCoastTaskData
{
	// Token: 0x17000A48 RID: 2632
	// (get) Token: 0x060077F7 RID: 30711 RVA: 0x001918E7 File Offset: 0x0018FAE7
	// (set) Token: 0x060077F8 RID: 30712 RVA: 0x001918EF File Offset: 0x0018FAEF
	public int TaskId { get; private set; }

	// Token: 0x060077F9 RID: 30713 RVA: 0x001918F8 File Offset: 0x0018FAF8
	public BlackCoastTaskData(int taskId)
	{
		this.TaskId = taskId;
	}

	// Token: 0x17000A49 RID: 2633
	// (get) Token: 0x060077FA RID: 30714 RVA: 0x00191924 File Offset: 0x0018FB24
	public bool IsFinished
	{
		get
		{
			return this.Status != EActivityTaskState.Active;
		}
	}

	// Token: 0x17000A4A RID: 2634
	// (get) Token: 0x060077FB RID: 30715 RVA: 0x00191932 File Offset: 0x0018FB32
	public bool IsTaken
	{
		get
		{
			return this.Status == EActivityTaskState.FinishedAndClaimed;
		}
	}

	// Token: 0x04003734 RID: 14132
	public EActivityTaskState Status = EActivityTaskState.Active;

	// Token: 0x04003735 RID: 14133
	public int Current;

	// Token: 0x04003736 RID: 14134
	public int Target;

	// Token: 0x04003737 RID: 14135
	public int JumpId;

	// Token: 0x04003738 RID: 14136
	public int SortId;

	// Token: 0x04003739 RID: 14137
	public string TitleTextId = "";

	// Token: 0x0400373A RID: 14138
	public List<TItem> RewardList = new List<TItem>();

	// Token: 0x0400373B RID: 14139
	[Nullable(2)]
	public Action<int> ReceiveDelegate;
}
