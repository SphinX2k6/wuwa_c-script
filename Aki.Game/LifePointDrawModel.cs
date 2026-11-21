using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000750 RID: 1872
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LifePointDrawModel : ModelBase
{
	// Token: 0x06005604 RID: 22020 RVA: 0x001C3A5C File Offset: 0x001C1C5C
	public string GetProgressByActivityId(int activityId, string formatString)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		if (lifePointDrawActivityData != null)
		{
			int finishChallengeNumber = lifePointDrawActivityData.GetFinishChallengeNumber();
			int challengeNumber = lifePointDrawActivityData.GetChallengeNumber();
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(formatString, null) ?? "", new string[]
			{
				finishChallengeNumber.ToString(),
				challengeNumber.ToString()
			});
		}
		return "";
	}

	// Token: 0x06005605 RID: 22021 RVA: 0x001C3AC0 File Offset: 0x001C1CC0
	public bool GetGroupUnlockState(int activityId, int groupId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetGroupIfOverUnlockTime(groupId);
	}

	// Token: 0x06005606 RID: 22022 RVA: 0x001C3AEC File Offset: 0x001C1CEC
	public long GetGroupUnlockTime(int activityId, int groupId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		if (lifePointDrawActivityData != null)
		{
			return lifePointDrawActivityData.GetGroupUnlockTime(groupId);
		}
		return 0L;
	}

	// Token: 0x06005607 RID: 22023 RVA: 0x001C3B18 File Offset: 0x001C1D18
	public bool GetGroupRewardState(int activityId, int groupId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetGroupHasGetReward(groupId);
	}

	// Token: 0x06005608 RID: 22024 RVA: 0x001C3B44 File Offset: 0x001C1D44
	public string GetGroupRewardProgress(int activityId, int groupId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		if (lifePointDrawActivityData != null)
		{
			int groupRewardProgress = lifePointDrawActivityData.GetGroupRewardProgress(groupId);
			int groupChallengeNumber = lifePointDrawActivityData.GetGroupChallengeNumber(groupId);
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("Colorful_Challenge_Progress", null) ?? "", new string[]
			{
				groupRewardProgress.ToString(),
				groupChallengeNumber.ToString()
			});
		}
		return "";
	}

	// Token: 0x06005609 RID: 22025 RVA: 0x001C3BB0 File Offset: 0x001C1DB0
	public bool GetGroupRedDotState(int groupId)
	{
		LifePointGroup? lifePointGroupByGroupId = LifePointDrawConfig.Instance.GetLifePointGroupByGroupId(groupId);
		if (lifePointGroupByGroupId == null)
		{
			return false;
		}
		for (int i = 0; i < lifePointGroupByGroupId.Value.ChallengeListLength; i++)
		{
			int challengeId = lifePointGroupByGroupId.Value.ChallengeList(i);
			if (this.GetChallengeRedDotState(challengeId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600560A RID: 22026 RVA: 0x001C3C0C File Offset: 0x001C1E0C
	public bool GetChallengeFinishState(int activityId, int challengeId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetChallengeIfGetReward(challengeId);
	}

	// Token: 0x0600560B RID: 22027 RVA: 0x001C3C38 File Offset: 0x001C1E38
	public bool GetChallengeRequireFinishState(int activityId, int challengeId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetChallengeRequireFinishState(challengeId);
	}

	// Token: 0x0600560C RID: 22028 RVA: 0x001C3C64 File Offset: 0x001C1E64
	public bool GetChallengeRedDotState(int challengeId)
	{
		List<ActivityBaseData> currentShowingActivities = ActivityModel.Instance.GetCurrentShowingActivities();
		LifePointDrawActivityData lifePointDrawActivityData = null;
		foreach (ActivityBaseData activityBaseData in currentShowingActivities)
		{
			if (activityBaseData.Type == ActivityType.LifePointChallenge)
			{
				LifePointDrawActivityData lifePointDrawActivityData2 = activityBaseData as LifePointDrawActivityData;
				if (lifePointDrawActivityData2.CheckIfHaveChallenge(challengeId))
				{
					lifePointDrawActivityData = lifePointDrawActivityData2;
					break;
				}
			}
		}
		if (lifePointDrawActivityData == null)
		{
			return false;
		}
		bool activityCacheData = ActivityModel.Instance.GetActivityCacheData(lifePointDrawActivityData.Id, 0, challengeId, 0, 0) != 0;
		int groupId = LifePointDrawConfig.Instance.GetLifePointChallengeById(challengeId).Value.GroupId;
		bool challengeRequireFinishState = this.GetChallengeRequireFinishState(lifePointDrawActivityData.Id, challengeId);
		return !activityCacheData && lifePointDrawActivityData.GetGroupIfOverUnlockTime(groupId) && challengeRequireFinishState;
	}

	// Token: 0x0600560D RID: 22029 RVA: 0x001C3D30 File Offset: 0x001C1F30
	public void SaveChallengeRedDotState(int activityId, int challengeId)
	{
		List<ActivityBaseData> currentShowingActivities = ActivityModel.Instance.GetCurrentShowingActivities();
		LifePointDrawActivityData lifePointDrawActivityData = null;
		foreach (ActivityBaseData activityBaseData in currentShowingActivities)
		{
			if (activityBaseData.Type == ActivityType.LifePointChallenge)
			{
				LifePointDrawActivityData lifePointDrawActivityData2 = activityBaseData as LifePointDrawActivityData;
				if (lifePointDrawActivityData2.CheckIfHaveChallenge(challengeId))
				{
					lifePointDrawActivityData = lifePointDrawActivityData2;
					break;
				}
			}
		}
		if (lifePointDrawActivityData == null)
		{
			return;
		}
		ActivityModel.Instance.SaveActivityData(activityId, challengeId, 0, 0, 1);
	}

	// Token: 0x17000B4E RID: 2894
	// (get) Token: 0x0600560E RID: 22030 RVA: 0x001C3DB4 File Offset: 0x001C1FB4
	public static LifePointDrawModel Instance
	{
		get
		{
			return LifePointDrawModel._Instance;
		}
	}

	// Token: 0x0600560F RID: 22031 RVA: 0x001C3DBB File Offset: 0x001C1FBB
	public static LifePointDrawModel GetOrCreateInstance()
	{
		if (LifePointDrawModel._Instance == null)
		{
			LifePointDrawModel.CreateInstance();
		}
		return LifePointDrawModel._Instance;
	}

	// Token: 0x06005610 RID: 22032 RVA: 0x001C3DCF File Offset: 0x001C1FCF
	public static bool CreateInstance()
	{
		if (LifePointDrawModel._Instance != null)
		{
			return true;
		}
		LifePointDrawModel._Instance = new LifePointDrawModel();
		return true;
	}

	// Token: 0x06005611 RID: 22033 RVA: 0x001C3DE5 File Offset: 0x001C1FE5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06005612 RID: 22034 RVA: 0x001C3DE7 File Offset: 0x001C1FE7
	public static void ResetStaticDefaultValue()
	{
		LifePointDrawModel._Instance = null;
	}

	// Token: 0x06005613 RID: 22035 RVA: 0x001C3DEF File Offset: 0x001C1FEF
	static LifePointDrawModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LifePointDrawModel.CreateStaticDefaultValue), new Action(LifePointDrawModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003B7F RID: 15231
	public bool CurrentChallengeFinishState;

	// Token: 0x04003B80 RID: 15232
	[Nullable(2)]
	private static LifePointDrawModel _Instance;
}
