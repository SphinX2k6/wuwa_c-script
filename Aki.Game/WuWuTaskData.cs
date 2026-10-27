using System;

// Token: 0x0200166E RID: 5742
public class WuWuTaskData
{
	// Token: 0x17000DA1 RID: 3489
	// (get) Token: 0x0600A1E0 RID: 41440 RVA: 0x0023C06D File Offset: 0x0023A26D
	public float ProgressPercent
	{
		get
		{
			if (this.TargetProgress <= 0)
			{
				return 0f;
			}
			return Math.Min((float)this.Progress / (float)this.TargetProgress, 1f);
		}
	}

	// Token: 0x17000DA2 RID: 3490
	// (get) Token: 0x0600A1E1 RID: 41441 RVA: 0x0023C097 File Offset: 0x0023A297
	public bool IsCompleted
	{
		get
		{
			return this.Progress >= this.TargetProgress;
		}
	}

	// Token: 0x17000DA3 RID: 3491
	// (get) Token: 0x0600A1E2 RID: 41442 RVA: 0x0023C0AA File Offset: 0x0023A2AA
	public bool CanReceiveReward
	{
		get
		{
			return this.State == EWuWuTaskState.Finish;
		}
	}

	// Token: 0x17000DA4 RID: 3492
	// (get) Token: 0x0600A1E3 RID: 41443 RVA: 0x0023C0B5 File Offset: 0x0023A2B5
	public bool IsRewarded
	{
		get
		{
			return this.State == EWuWuTaskState.Taken;
		}
	}

	// Token: 0x040049BE RID: 18878
	public int TaskId;

	// Token: 0x040049BF RID: 18879
	public int TaskPackId;

	// Token: 0x040049C0 RID: 18880
	public int Progress;

	// Token: 0x040049C1 RID: 18881
	public int TargetProgress;

	// Token: 0x040049C2 RID: 18882
	public EWuWuTaskState State;
}
