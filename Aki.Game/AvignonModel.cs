using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020005BE RID: 1470
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AvignonModel : ModelBase
{
	// Token: 0x06004573 RID: 17779 RVA: 0x0017D5BF File Offset: 0x0017B7BF
	protected override bool OnInit()
	{
		this.AvignonProtocolData = new AvignonProtocolData();
		return true;
	}

	// Token: 0x06004574 RID: 17780 RVA: 0x0017D5D0 File Offset: 0x0017B7D0
	public void AvignonInfoUpdate(AvignonTaskNotify notify)
	{
		foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
		{
			AvignonProtocolData avignonProtocolData = activityBaseData as AvignonProtocolData;
			if (notify.ActivityTask != null)
			{
				avignonProtocolData.UpdateTask(notify.ActivityTask);
			}
			int unLockStepId = notify.UnLockStepId;
			avignonProtocolData.UnlockStage(notify.UnLockStepId);
		}
		int avignonActivityId = this.GetAvignonActivityId();
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, avignonActivityId);
	}

	// Token: 0x06004575 RID: 17781 RVA: 0x0017D660 File Offset: 0x0017B860
	public void UpdateTaskRewardStatus(int taskId)
	{
		foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
		{
			(activityBaseData as AvignonProtocolData).TaskRewardGot(taskId);
			int avignonActivityId = this.GetAvignonActivityId();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, avignonActivityId);
		}
	}

	// Token: 0x06004576 RID: 17782 RVA: 0x0017D6D0 File Offset: 0x0017B8D0
	public void ReadRedDot()
	{
		int avignonActivityId = this.GetAvignonActivityId();
		ActivityModel.Instance.SaveActivityData(avignonActivityId, 100, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, avignonActivityId);
	}

	// Token: 0x06004577 RID: 17783 RVA: 0x0017D708 File Offset: 0x0017B908
	public void SaveNewStageFlag(int stageId)
	{
		AvignonStageInfo avignonStageInfo = this.GetAvignonStageInfo(stageId);
		if (avignonStageInfo == null || !avignonStageInfo.HasNewStageFlag())
		{
			return;
		}
		int avignonActivityId = this.GetAvignonActivityId();
		ActivityModel.Instance.SaveActivityData(avignonActivityId, stageId, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, avignonActivityId);
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x0017D750 File Offset: 0x0017B950
	public bool CheckRedDot()
	{
		int avignonActivityId = this.GetAvignonActivityId();
		if (ActivityModel.Instance.GetActivityCacheData(avignonActivityId, 0, 100, 0, 0) == 0)
		{
			return true;
		}
		foreach (int stageId in this.GetAvignonAllStagesId())
		{
			AvignonStageInfo avignonStageInfo = this.GetAvignonStageInfo(stageId);
			if (avignonStageInfo != null && avignonStageInfo.HasNewStageFlag())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x0017D7AA File Offset: 0x0017B9AA
	public AvignonProtocolData GetAvigonoProtocolData()
	{
		return this.AvignonProtocolData;
	}

	// Token: 0x0600457A RID: 17786 RVA: 0x0017D7B2 File Offset: 0x0017B9B2
	[NullableContext(2)]
	public AvignonStageInfo GetAvignonStageInfo(int stageId)
	{
		AvignonProtocolData avignonProtocolData = this.AvignonProtocolData;
		if (avignonProtocolData == null)
		{
			return null;
		}
		return avignonProtocolData.GetStageInfo(stageId);
	}

	// Token: 0x0600457B RID: 17787 RVA: 0x0017D7C6 File Offset: 0x0017B9C6
	public int[] GetAvignonAllStagesId()
	{
		return this.AvignonProtocolData.GetAllStagesId();
	}

	// Token: 0x0600457C RID: 17788 RVA: 0x0017D7D3 File Offset: 0x0017B9D3
	public string GetAvignonActivityName()
	{
		return this.AvignonProtocolData.GetTitle();
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x0017D7E0 File Offset: 0x0017B9E0
	public int GetAvignonActivityId()
	{
		return this.AvignonProtocolData.Id;
	}

	// Token: 0x0600457E RID: 17790 RVA: 0x0017D7ED File Offset: 0x0017B9ED
	private List<ActivityBaseData> GetActivityDataList()
	{
		return ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.Avignon);
	}

	// Token: 0x170009BC RID: 2492
	// (get) Token: 0x0600457F RID: 17791 RVA: 0x0017D7FB File Offset: 0x0017B9FB
	public static AvignonModel Instance
	{
		get
		{
			return AvignonModel._Instance;
		}
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x0017D802 File Offset: 0x0017BA02
	public static AvignonModel GetOrCreateInstance()
	{
		if (AvignonModel._Instance == null)
		{
			AvignonModel.CreateInstance();
		}
		return AvignonModel._Instance;
	}

	// Token: 0x06004581 RID: 17793 RVA: 0x0017D816 File Offset: 0x0017BA16
	public static bool CreateInstance()
	{
		if (AvignonModel._Instance != null)
		{
			return true;
		}
		AvignonModel._Instance = new AvignonModel();
		return true;
	}

	// Token: 0x06004582 RID: 17794 RVA: 0x0017D82C File Offset: 0x0017BA2C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06004583 RID: 17795 RVA: 0x0017D82E File Offset: 0x0017BA2E
	public static void ResetStaticDefaultValue()
	{
		AvignonModel._Instance = null;
	}

	// Token: 0x06004584 RID: 17796 RVA: 0x0017D836 File Offset: 0x0017BA36
	static AvignonModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AvignonModel.CreateStaticDefaultValue), new Action(AvignonModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400356F RID: 13679
	private const int AVIGNON_RED_DOT_CACHE_KEY = 100;

	// Token: 0x04003570 RID: 13680
	private AvignonProtocolData AvignonProtocolData;

	// Token: 0x04003571 RID: 13681
	[Nullable(2)]
	private static AvignonModel _Instance;
}
