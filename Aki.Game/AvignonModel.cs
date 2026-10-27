using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200110A RID: 4362
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AvignonModel : ModelBase
{
	// Token: 0x060071DD RID: 29149 RVA: 0x00174C03 File Offset: 0x00172E03
	protected override bool OnInit()
	{
		this.AvignonProtocolData = new AvignonProtocolData();
		return true;
	}

	// Token: 0x060071DE RID: 29150 RVA: 0x00174C14 File Offset: 0x00172E14
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

	// Token: 0x060071DF RID: 29151 RVA: 0x00174CA4 File Offset: 0x00172EA4
	public void UpdateTaskRewardStatus(int taskId)
	{
		foreach (ActivityBaseData activityBaseData in this.GetActivityDataList())
		{
			(activityBaseData as AvignonProtocolData).TaskRewardGot(taskId);
			int avignonActivityId = this.GetAvignonActivityId();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, avignonActivityId);
		}
	}

	// Token: 0x060071E0 RID: 29152 RVA: 0x00174D14 File Offset: 0x00172F14
	public void ReadRedDot()
	{
		int avignonActivityId = this.GetAvignonActivityId();
		ActivityModel.Instance.SaveActivityData(avignonActivityId, 100, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, avignonActivityId);
	}

	// Token: 0x060071E1 RID: 29153 RVA: 0x00174D4C File Offset: 0x00172F4C
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

	// Token: 0x060071E2 RID: 29154 RVA: 0x00174D94 File Offset: 0x00172F94
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

	// Token: 0x060071E3 RID: 29155 RVA: 0x00174DEE File Offset: 0x00172FEE
	public AvignonProtocolData GetAvigonoProtocolData()
	{
		return this.AvignonProtocolData;
	}

	// Token: 0x060071E4 RID: 29156 RVA: 0x00174DF6 File Offset: 0x00172FF6
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

	// Token: 0x060071E5 RID: 29157 RVA: 0x00174E0A File Offset: 0x0017300A
	public int[] GetAvignonAllStagesId()
	{
		return this.AvignonProtocolData.GetAllStagesId();
	}

	// Token: 0x060071E6 RID: 29158 RVA: 0x00174E17 File Offset: 0x00173017
	public string GetAvignonActivityName()
	{
		return this.AvignonProtocolData.GetTitle();
	}

	// Token: 0x060071E7 RID: 29159 RVA: 0x00174E24 File Offset: 0x00173024
	public int GetAvignonActivityId()
	{
		return this.AvignonProtocolData.Id;
	}

	// Token: 0x060071E8 RID: 29160 RVA: 0x00174E31 File Offset: 0x00173031
	private List<ActivityBaseData> GetActivityDataList()
	{
		return ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.Avignon);
	}

	// Token: 0x1700099C RID: 2460
	// (get) Token: 0x060071E9 RID: 29161 RVA: 0x00174E3F File Offset: 0x0017303F
	public static AvignonModel Instance
	{
		get
		{
			return AvignonModel._Instance;
		}
	}

	// Token: 0x060071EA RID: 29162 RVA: 0x00174E46 File Offset: 0x00173046
	public static AvignonModel GetOrCreateInstance()
	{
		if (AvignonModel._Instance == null)
		{
			AvignonModel.CreateInstance();
		}
		return AvignonModel._Instance;
	}

	// Token: 0x060071EB RID: 29163 RVA: 0x00174E5A File Offset: 0x0017305A
	public static bool CreateInstance()
	{
		if (AvignonModel._Instance != null)
		{
			return true;
		}
		AvignonModel._Instance = new AvignonModel();
		return true;
	}

	// Token: 0x060071EC RID: 29164 RVA: 0x00174E70 File Offset: 0x00173070
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060071ED RID: 29165 RVA: 0x00174E72 File Offset: 0x00173072
	public static void ResetStaticDefaultValue()
	{
		AvignonModel._Instance = null;
	}

	// Token: 0x060071EE RID: 29166 RVA: 0x00174E7A File Offset: 0x0017307A
	static AvignonModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AvignonModel.CreateStaticDefaultValue), new Action(AvignonModel.ResetStaticDefaultValue));
	}

	// Token: 0x040034D6 RID: 13526
	private const int AVIGNON_RED_DOT_CACHE_KEY = 100;

	// Token: 0x040034D7 RID: 13527
	private AvignonProtocolData AvignonProtocolData;

	// Token: 0x040034D8 RID: 13528
	[Nullable(2)]
	private static AvignonModel _Instance;
}
