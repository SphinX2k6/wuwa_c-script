using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200110E RID: 4366
[NullableContext(1)]
[Nullable(0)]
public class AvignonTaskData
{
	// Token: 0x06007221 RID: 29217 RVA: 0x0017589B File Offset: 0x00173A9B
	public AvignonTaskData(int taskId)
	{
		this.TaskId = taskId;
	}

	// Token: 0x170009A2 RID: 2466
	// (get) Token: 0x06007222 RID: 29218 RVA: 0x001758C7 File Offset: 0x00173AC7
	// (set) Token: 0x06007223 RID: 29219 RVA: 0x001758CF File Offset: 0x00173ACF
	public int TaskId { get; set; }

	// Token: 0x170009A3 RID: 2467
	// (get) Token: 0x06007224 RID: 29220 RVA: 0x001758D8 File Offset: 0x00173AD8
	// (set) Token: 0x06007225 RID: 29221 RVA: 0x001758E0 File Offset: 0x00173AE0
	public EActivityTaskState Status { get; set; } = EActivityTaskState.Active;

	// Token: 0x170009A4 RID: 2468
	// (get) Token: 0x06007226 RID: 29222 RVA: 0x001758E9 File Offset: 0x00173AE9
	public bool IsFinished
	{
		get
		{
			return this.Status != EActivityTaskState.Active;
		}
	}

	// Token: 0x170009A5 RID: 2469
	// (get) Token: 0x06007227 RID: 29223 RVA: 0x001758F7 File Offset: 0x00173AF7
	public bool IsTaken
	{
		get
		{
			return this.Status == EActivityTaskState.FinishedAndClaimed;
		}
	}

	// Token: 0x170009A6 RID: 2470
	// (get) Token: 0x06007228 RID: 29224 RVA: 0x00175902 File Offset: 0x00173B02
	// (set) Token: 0x06007229 RID: 29225 RVA: 0x0017590A File Offset: 0x00173B0A
	public int Current { get; set; }

	// Token: 0x170009A7 RID: 2471
	// (get) Token: 0x0600722A RID: 29226 RVA: 0x00175913 File Offset: 0x00173B13
	// (set) Token: 0x0600722B RID: 29227 RVA: 0x0017591B File Offset: 0x00173B1B
	public int Target { get; set; }

	// Token: 0x170009A8 RID: 2472
	// (get) Token: 0x0600722C RID: 29228 RVA: 0x00175924 File Offset: 0x00173B24
	// (set) Token: 0x0600722D RID: 29229 RVA: 0x0017592C File Offset: 0x00173B2C
	public int JumpId { get; set; }

	// Token: 0x170009A9 RID: 2473
	// (get) Token: 0x0600722E RID: 29230 RVA: 0x00175935 File Offset: 0x00173B35
	// (set) Token: 0x0600722F RID: 29231 RVA: 0x0017593D File Offset: 0x00173B3D
	public string TitleTextId { get; set; } = "";

	// Token: 0x170009AA RID: 2474
	// (get) Token: 0x06007230 RID: 29232 RVA: 0x00175946 File Offset: 0x00173B46
	// (set) Token: 0x06007231 RID: 29233 RVA: 0x0017594E File Offset: 0x00173B4E
	public List<TItem> RewardList { get; set; } = new List<TItem>();

	// Token: 0x040034E6 RID: 13542
	[Nullable(2)]
	public Action<int> ReceiveDelegate;
}
