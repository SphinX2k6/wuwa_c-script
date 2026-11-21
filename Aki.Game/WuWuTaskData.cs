using System;

// Token: 0x02000B26 RID: 2854
public class WuWuTaskData
{
	// Token: 0x17000DC2 RID: 3522
	// (get) Token: 0x060075BE RID: 30142 RVA: 0x00245F09 File Offset: 0x00244109
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

	// Token: 0x17000DC3 RID: 3523
	// (get) Token: 0x060075BF RID: 30143 RVA: 0x00245F33 File Offset: 0x00244133
	public bool IsCompleted
	{
		get
		{
			return this.Progress >= this.TargetProgress;
		}
	}

	// Token: 0x17000DC4 RID: 3524
	// (get) Token: 0x060075C0 RID: 30144 RVA: 0x00245F46 File Offset: 0x00244146
	public bool CanReceiveReward
	{
		get
		{
			return this.State == EWuWuTaskState.Finish;
		}
	}

	// Token: 0x17000DC5 RID: 3525
	// (get) Token: 0x060075C1 RID: 30145 RVA: 0x00245F51 File Offset: 0x00244151
	public bool IsRewarded
	{
		get
		{
			return this.State == EWuWuTaskState.Taken;
		}
	}

	// Token: 0x04004A64 RID: 19044
	public int TaskId;

	// Token: 0x04004A65 RID: 19045
	public int TaskPackId;

	// Token: 0x04004A66 RID: 19046
	public int Progress;

	// Token: 0x04004A67 RID: 19047
	public int TargetProgress;

	// Token: 0x04004A68 RID: 19048
	public EWuWuTaskState State;
}
