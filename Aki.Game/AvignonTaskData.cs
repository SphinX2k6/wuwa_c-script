using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020005C2 RID: 1474
[NullableContext(1)]
[Nullable(0)]
public class AvignonTaskData
{
	// Token: 0x060045B7 RID: 17847 RVA: 0x0017E257 File Offset: 0x0017C457
	public AvignonTaskData(int taskId)
	{
		this.TaskId = taskId;
	}

	// Token: 0x170009C2 RID: 2498
	// (get) Token: 0x060045B8 RID: 17848 RVA: 0x0017E283 File Offset: 0x0017C483
	// (set) Token: 0x060045B9 RID: 17849 RVA: 0x0017E28B File Offset: 0x0017C48B
	public int TaskId { get; set; }

	// Token: 0x170009C3 RID: 2499
	// (get) Token: 0x060045BA RID: 17850 RVA: 0x0017E294 File Offset: 0x0017C494
	// (set) Token: 0x060045BB RID: 17851 RVA: 0x0017E29C File Offset: 0x0017C49C
	public EActivityTaskState Status { get; set; } = EActivityTaskState.Active;

	// Token: 0x170009C4 RID: 2500
	// (get) Token: 0x060045BC RID: 17852 RVA: 0x0017E2A5 File Offset: 0x0017C4A5
	public bool IsFinished
	{
		get
		{
			return this.Status != EActivityTaskState.Active;
		}
	}

	// Token: 0x170009C5 RID: 2501
	// (get) Token: 0x060045BD RID: 17853 RVA: 0x0017E2B3 File Offset: 0x0017C4B3
	public bool IsTaken
	{
		get
		{
			return this.Status == EActivityTaskState.FinishedAndClaimed;
		}
	}

	// Token: 0x170009C6 RID: 2502
	// (get) Token: 0x060045BE RID: 17854 RVA: 0x0017E2BE File Offset: 0x0017C4BE
	// (set) Token: 0x060045BF RID: 17855 RVA: 0x0017E2C6 File Offset: 0x0017C4C6
	public int Current { get; set; }

	// Token: 0x170009C7 RID: 2503
	// (get) Token: 0x060045C0 RID: 17856 RVA: 0x0017E2CF File Offset: 0x0017C4CF
	// (set) Token: 0x060045C1 RID: 17857 RVA: 0x0017E2D7 File Offset: 0x0017C4D7
	public int Target { get; set; }

	// Token: 0x170009C8 RID: 2504
	// (get) Token: 0x060045C2 RID: 17858 RVA: 0x0017E2E0 File Offset: 0x0017C4E0
	// (set) Token: 0x060045C3 RID: 17859 RVA: 0x0017E2E8 File Offset: 0x0017C4E8
	public int JumpId { get; set; }

	// Token: 0x170009C9 RID: 2505
	// (get) Token: 0x060045C4 RID: 17860 RVA: 0x0017E2F1 File Offset: 0x0017C4F1
	// (set) Token: 0x060045C5 RID: 17861 RVA: 0x0017E2F9 File Offset: 0x0017C4F9
	public string TitleTextId { get; set; } = "";

	// Token: 0x170009CA RID: 2506
	// (get) Token: 0x060045C6 RID: 17862 RVA: 0x0017E302 File Offset: 0x0017C502
	// (set) Token: 0x060045C7 RID: 17863 RVA: 0x0017E30A File Offset: 0x0017C50A
	public List<TItem> RewardList { get; set; } = new List<TItem>();

	// Token: 0x0400357F RID: 13695
	[Nullable(2)]
	public Action<int> ReceiveDelegate;
}
