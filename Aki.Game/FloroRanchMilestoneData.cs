using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x02001AF6 RID: 6902
public class FloroRanchMilestoneData
{
	// Token: 0x0600CCE4 RID: 52452 RVA: 0x002EC687 File Offset: 0x002EA887
	public FloroRanchMilestoneData(FloroRanchReward config)
	{
		this.Config = config;
		this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.DropId);
	}

	// Token: 0x170010EB RID: 4331
	// (get) Token: 0x0600CCE6 RID: 52454 RVA: 0x002EC6C1 File Offset: 0x002EA8C1
	// (set) Token: 0x0600CCE5 RID: 52453 RVA: 0x002EC6B8 File Offset: 0x002EA8B8
	public bool IsReceive
	{
		get
		{
			return this.IsReceiveInternal;
		}
		set
		{
			this.IsReceiveInternal = value;
		}
	}

	// Token: 0x170010EC RID: 4332
	// (get) Token: 0x0600CCE8 RID: 52456 RVA: 0x002EC6D2 File Offset: 0x002EA8D2
	// (set) Token: 0x0600CCE7 RID: 52455 RVA: 0x002EC6C9 File Offset: 0x002EA8C9
	public bool IsFinished
	{
		get
		{
			return this.IsFinishedInterval;
		}
		set
		{
			this.IsFinishedInterval = value;
		}
	}

	// Token: 0x170010ED RID: 4333
	// (get) Token: 0x0600CCE9 RID: 52457 RVA: 0x002EC6DA File Offset: 0x002EA8DA
	public bool IsReceivable
	{
		get
		{
			return this.IsFinishedInterval && !this.IsReceiveInternal;
		}
	}

	// Token: 0x170010EE RID: 4334
	// (get) Token: 0x0600CCEA RID: 52458 RVA: 0x002EC6F0 File Offset: 0x002EA8F0
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x170010EF RID: 4335
	// (get) Token: 0x0600CCEB RID: 52459 RVA: 0x002EC70C File Offset: 0x002EA90C
	public int Goal
	{
		get
		{
			return this.Config.NeedNum;
		}
	}

	// Token: 0x04005E0C RID: 24076
	private readonly FloroRanchReward Config;

	// Token: 0x04005E0D RID: 24077
	private bool IsReceiveInternal;

	// Token: 0x04005E0E RID: 24078
	private bool IsFinishedInterval;

	// Token: 0x04005E0F RID: 24079
	[Nullable(1)]
	public List<TItem> RewardList = new List<TItem>();
}
