using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020026DF RID: 9951
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsRewardData
{
	// Token: 0x0601469B RID: 83611 RVA: 0x0052A18C File Offset: 0x0052838C
	public RacingBetsRewardData(int id)
	{
		this.Id = id;
		this.RewardConfig = RacingBetsConfig.Instance.GetRacingBetsReward(id);
	}

	// Token: 0x0601469C RID: 83612 RVA: 0x0052A1AC File Offset: 0x005283AC
	public void Refresh(ConditionTaskData taskData)
	{
		this.TaskStatus = taskData.Status;
		this.CurTaskRate = taskData.Rate;
		this.TaskTarget = taskData.Target;
	}

	// Token: 0x0601469D RID: 83613 RVA: 0x0052A1D4 File Offset: 0x005283D4
	public ERacingBetsRewardType GetRewardType()
	{
		return (ERacingBetsRewardType)this.RewardConfig.Value.RewardType;
	}

	// Token: 0x0601469E RID: 83614 RVA: 0x0052A1F4 File Offset: 0x005283F4
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

	// Token: 0x0601469F RID: 83615 RVA: 0x0052A27C File Offset: 0x0052847C
	public string GetRewardName()
	{
		return this.RewardConfig.Value.RewardName;
	}

	// Token: 0x060146A0 RID: 83616 RVA: 0x0052A29C File Offset: 0x0052849C
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

	// Token: 0x060146A1 RID: 83617 RVA: 0x0052A321 File Offset: 0x00528521
	public ConditionTaskStatus GetTaskStatus()
	{
		return this.TaskStatus;
	}

	// Token: 0x060146A2 RID: 83618 RVA: 0x0052A329 File Offset: 0x00528529
	public bool CanReceiveReward()
	{
		return this.TaskStatus == ConditionTaskStatus.TaskFinish;
	}

	// Token: 0x060146A3 RID: 83619 RVA: 0x0052A334 File Offset: 0x00528534
	public bool IsTaskReceived()
	{
		return this.TaskStatus == ConditionTaskStatus.Received;
	}

	// Token: 0x0400995E RID: 39262
	public readonly int Id;

	// Token: 0x0400995F RID: 39263
	public readonly RacingBetsReward? RewardConfig;

	// Token: 0x04009960 RID: 39264
	private ConditionTaskStatus TaskStatus;

	// Token: 0x04009961 RID: 39265
	private int CurTaskRate;

	// Token: 0x04009962 RID: 39266
	private int TaskTarget;
}
