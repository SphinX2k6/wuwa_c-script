using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;

// Token: 0x020013BA RID: 5050
[NullableContext(1)]
[Nullable(0)]
public class ActivityNewPlayerSupportTaskData
{
	// Token: 0x06008E74 RID: 36468 RVA: 0x001EBC96 File Offset: 0x001E9E96
	public ActivityNewPlayerSupportTaskData(int id)
	{
		this.Id = id;
		this.TaskConfig = ActivityNewPlayerSupportConfig.Instance.GetTaskConfig(id);
	}

	// Token: 0x06008E75 RID: 36469 RVA: 0x001EBCB6 File Offset: 0x001E9EB6
	public void Refresh(ConditionTask taskData)
	{
		this.TaskStatus = taskData.Status;
		this.TaskCurrent = taskData.Current;
		this.TaskTarget = taskData.Target;
	}

	// Token: 0x06008E76 RID: 36470 RVA: 0x001EBCDC File Offset: 0x001E9EDC
	public List<TItem> GetRewardList()
	{
		int normalDropId = this.TaskConfig.NormalDropId;
		if (normalDropId <= 0)
		{
			return new List<TItem>();
		}
		return CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(normalDropId);
	}

	// Token: 0x06008E77 RID: 36471 RVA: 0x001EBD10 File Offset: 0x001E9F10
	public string GetRewardName()
	{
		return this.TaskConfig.RewardName;
	}

	// Token: 0x06008E78 RID: 36472 RVA: 0x001EBD2C File Offset: 0x001E9F2C
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

	// Token: 0x06008E79 RID: 36473 RVA: 0x001EBDB1 File Offset: 0x001E9FB1
	public void SetTaskStatus(ConditionTaskState status)
	{
		this.TaskStatus = status;
	}

	// Token: 0x06008E7A RID: 36474 RVA: 0x001EBDBA File Offset: 0x001E9FBA
	public ConditionTaskState GetTaskStatus()
	{
		return this.TaskStatus;
	}

	// Token: 0x06008E7B RID: 36475 RVA: 0x001EBDC2 File Offset: 0x001E9FC2
	public int GetTaskTarget()
	{
		return this.TaskTarget;
	}

	// Token: 0x06008E7C RID: 36476 RVA: 0x001EBDCA File Offset: 0x001E9FCA
	public bool CanReceiveReward()
	{
		return this.TaskStatus == ConditionTaskState.ConditionTaskFinish;
	}

	// Token: 0x06008E7D RID: 36477 RVA: 0x001EBDD5 File Offset: 0x001E9FD5
	public bool IsTaskReceived()
	{
		return this.TaskStatus == ConditionTaskState.ConditionTaskTaken;
	}

	// Token: 0x06008E7E RID: 36478 RVA: 0x001EBDE0 File Offset: 0x001E9FE0
	public bool IsTaskRunning()
	{
		return this.TaskStatus == ConditionTaskState.ConditionTaskRunning;
	}

	// Token: 0x04003F0E RID: 16142
	public readonly int Id;

	// Token: 0x04003F0F RID: 16143
	public readonly NewPlayerSupportTask TaskConfig;

	// Token: 0x04003F10 RID: 16144
	private ConditionTaskState TaskStatus;

	// Token: 0x04003F11 RID: 16145
	private int TaskCurrent;

	// Token: 0x04003F12 RID: 16146
	private int TaskTarget;
}
