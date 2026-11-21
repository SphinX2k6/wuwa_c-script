using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

// Token: 0x0200086E RID: 2158
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportTaskData
{
	// Token: 0x06006209 RID: 25097 RVA: 0x001F47B6 File Offset: 0x001F29B6
	public ActivityNewPlayerSupportTaskData(int id)
	{
		this.Id = id;
		this.TaskConfig = ActivityNewPlayerSupportConfig.Instance.GetTaskConfig(id);
	}

	// Token: 0x0600620A RID: 25098 RVA: 0x001F47D6 File Offset: 0x001F29D6
	public void Refresh(ConditionTask taskData)
	{
		this.TaskStatus = taskData.Status;
		this.TaskCurrent = taskData.Current;
		this.TaskTarget = taskData.Target;
	}

	// Token: 0x0600620B RID: 25099 RVA: 0x001F47FC File Offset: 0x001F29FC
	public List<TItem> GetRewardList()
	{
		int normalDropId = this.TaskConfig.NormalDropId;
		if (normalDropId <= 0)
		{
			return new List<TItem>();
		}
		return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(normalDropId);
	}

	// Token: 0x0600620C RID: 25100 RVA: 0x001F4830 File Offset: 0x001F2A30
	public string GetRewardName()
	{
		return this.TaskConfig.RewardName;
	}

	// Token: 0x0600620D RID: 25101 RVA: 0x001F484C File Offset: 0x001F2A4C
	public string GetProgressText()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (this.TaskStatus == ConditionTaskState.ConditionTaskRunning)
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.TaskCurrent);
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

	// Token: 0x0600620E RID: 25102 RVA: 0x001F48D1 File Offset: 0x001F2AD1
	public void SetTaskStatus(ConditionTaskState status)
	{
		this.TaskStatus = status;
	}

	// Token: 0x0600620F RID: 25103 RVA: 0x001F48DA File Offset: 0x001F2ADA
	public ConditionTaskState GetTaskStatus()
	{
		return this.TaskStatus;
	}

	// Token: 0x06006210 RID: 25104 RVA: 0x001F48E2 File Offset: 0x001F2AE2
	public int GetTaskTarget()
	{
		return this.TaskTarget;
	}

	// Token: 0x06006211 RID: 25105 RVA: 0x001F48EA File Offset: 0x001F2AEA
	public bool CanReceiveReward()
	{
		return this.TaskStatus == ConditionTaskState.ConditionTaskFinish;
	}

	// Token: 0x06006212 RID: 25106 RVA: 0x001F48F5 File Offset: 0x001F2AF5
	public bool IsTaskReceived()
	{
		return this.TaskStatus == ConditionTaskState.ConditionTaskTaken;
	}

	// Token: 0x06006213 RID: 25107 RVA: 0x001F4900 File Offset: 0x001F2B00
	public bool IsTaskRunning()
	{
		return this.TaskStatus == ConditionTaskState.ConditionTaskRunning;
	}

	// Token: 0x04003FA6 RID: 16294
	public readonly int Id;

	// Token: 0x04003FA7 RID: 16295
	public readonly NewPlayerSupportTask TaskConfig;

	// Token: 0x04003FA8 RID: 16296
	private ConditionTaskState TaskStatus;

	// Token: 0x04003FA9 RID: 16297
	private int TaskCurrent;

	// Token: 0x04003FAA RID: 16298
	private int TaskTarget;
}
