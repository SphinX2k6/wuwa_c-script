using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;

// Token: 0x02000FB5 RID: 4021
public class FloroRanchMilestoneData
{
	// Token: 0x0600A0F5 RID: 41205 RVA: 0x002F7773 File Offset: 0x002F5973
	public FloroRanchMilestoneData(FloroRanchReward config)
	{
		this.Config = config;
		this.RewardList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(config.DropId);
	}

	// Token: 0x17001110 RID: 4368
	// (get) Token: 0x0600A0F7 RID: 41207 RVA: 0x002F77AD File Offset: 0x002F59AD
	// (set) Token: 0x0600A0F6 RID: 41206 RVA: 0x002F77A4 File Offset: 0x002F59A4
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

	// Token: 0x17001111 RID: 4369
	// (get) Token: 0x0600A0F9 RID: 41209 RVA: 0x002F77BE File Offset: 0x002F59BE
	// (set) Token: 0x0600A0F8 RID: 41208 RVA: 0x002F77B5 File Offset: 0x002F59B5
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

	// Token: 0x17001112 RID: 4370
	// (get) Token: 0x0600A0FA RID: 41210 RVA: 0x002F77C6 File Offset: 0x002F59C6
	public bool IsReceivable
	{
		get
		{
			return this.IsFinishedInterval && !this.IsReceiveInternal;
		}
	}

	// Token: 0x17001113 RID: 4371
	// (get) Token: 0x0600A0FB RID: 41211 RVA: 0x002F77DC File Offset: 0x002F59DC
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17001114 RID: 4372
	// (get) Token: 0x0600A0FC RID: 41212 RVA: 0x002F77F8 File Offset: 0x002F59F8
	public int Goal
	{
		get
		{
			return this.Config.NeedNum;
		}
	}

	// Token: 0x04005EDB RID: 24283
	private readonly FloroRanchReward Config;

	// Token: 0x04005EDC RID: 24284
	private bool IsReceiveInternal;

	// Token: 0x04005EDD RID: 24285
	private bool IsFinishedInterval;

	// Token: 0x04005EDE RID: 24286
	[Nullable(1)]
	public List<TItem> RewardList = new List<TItem>();
}
