using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001BCA RID: 7114
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsRewardData
{
	// Token: 0x06011B7D RID: 72573 RVA: 0x00538EA8 File Offset: 0x005370A8
	public RacingBetsRewardData(int id)
	{
		this.Id = id;
		this.RewardConfig = RacingBetsConfig.Instance.GetRacingBetsReward(id);
	}

	// Token: 0x06011B7E RID: 72574 RVA: 0x00538EC8 File Offset: 0x005370C8
	public void Refresh(ConditionTaskData taskData)
	{
		this.TaskStatus = taskData.Status;
		this.CurTaskRate = taskData.Rate;
		this.TaskTarget = taskData.Target;
	}

	// Token: 0x06011B7F RID: 72575 RVA: 0x00538EF0 File Offset: 0x005370F0
	public ERacingBetsRewardType GetRewardType()
	{
		return (ERacingBetsRewardType)this.RewardConfig.Value.RewardType;
	}

	// Token: 0x06011B80 RID: 72576 RVA: 0x00538F10 File Offset: 0x00537110
	public List<TItem> GetRewardList()
	{
		List<TItem> list = new List<TItem>();
		foreach (KeyValuePair<int, int> keyValuePair in this.RewardConfig.Value.TargetReward())
		{
			int key = keyValuePair.Key;
			int value = keyValuePair.Value;
			list.Add(new TItem(new InventoryDefine.GetItemData(key, 0), value));
		}
		return list;
	}

	// Token: 0x06011B81 RID: 72577 RVA: 0x00538F98 File Offset: 0x00537198
	public string GetRewardName()
	{
		return this.RewardConfig.Value.RewardName;
	}

	// Token: 0x06011B82 RID: 72578 RVA: 0x00538FB8 File Offset: 0x005371B8
	public string GetProgressText()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (this.TaskStatus == ConditionTaskStatus.Undone)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurTaskRate);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskTarget);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskTarget);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskTarget);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06011B83 RID: 72579 RVA: 0x0053903D File Offset: 0x0053723D
	public ConditionTaskStatus GetTaskStatus()
	{
		return this.TaskStatus;
	}

	// Token: 0x06011B84 RID: 72580 RVA: 0x00539045 File Offset: 0x00537245
	public bool CanReceiveReward()
	{
		return this.TaskStatus == ConditionTaskStatus.TaskFinish;
	}

	// Token: 0x06011B85 RID: 72581 RVA: 0x00539050 File Offset: 0x00537250
	public bool IsTaskReceived()
	{
		return this.TaskStatus == ConditionTaskStatus.Received;
	}

	// Token: 0x04009AB6 RID: 39606
	public readonly int Id;

	// Token: 0x04009AB7 RID: 39607
	public readonly RacingBetsReward? RewardConfig;

	// Token: 0x04009AB8 RID: 39608
	private ConditionTaskStatus TaskStatus;

	// Token: 0x04009AB9 RID: 39609
	private int CurTaskRate;

	// Token: 0x04009ABA RID: 39610
	private int TaskTarget;
}
