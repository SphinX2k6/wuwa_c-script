using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200129C RID: 4764
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LifePointDrawModel : ModelBase
{
	// Token: 0x0600826D RID: 33389 RVA: 0x001BAD8C File Offset: 0x001B8F8C
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

	// Token: 0x0600826E RID: 33390 RVA: 0x001BADF0 File Offset: 0x001B8FF0
	public bool GetGroupUnlockState(int activityId, int groupId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetGroupIfOverUnlockTime(groupId);
	}

	// Token: 0x0600826F RID: 33391 RVA: 0x001BAE1C File Offset: 0x001B901C
	public long GetGroupUnlockTime(int activityId, int groupId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		if (lifePointDrawActivityData != null)
		{
			return lifePointDrawActivityData.GetGroupUnlockTime(groupId);
		}
		return 0L;
	}

	// Token: 0x06008270 RID: 33392 RVA: 0x001BAE48 File Offset: 0x001B9048
	public bool GetGroupRewardState(int activityId, int groupId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetGroupHasGetReward(groupId);
	}

	// Token: 0x06008271 RID: 33393 RVA: 0x001BAE74 File Offset: 0x001B9074
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

	// Token: 0x06008272 RID: 33394 RVA: 0x001BAEE0 File Offset: 0x001B90E0
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

	// Token: 0x06008273 RID: 33395 RVA: 0x001BAF3C File Offset: 0x001B913C
	public bool GetChallengeFinishState(int activityId, int challengeId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetChallengeIfGetReward(challengeId);
	}

	// Token: 0x06008274 RID: 33396 RVA: 0x001BAF68 File Offset: 0x001B9168
	public bool GetChallengeRequireFinishState(int activityId, int challengeId)
	{
		LifePointDrawActivityData lifePointDrawActivityData = ActivityModel.Instance.GetActivityById(activityId) as LifePointDrawActivityData;
		return lifePointDrawActivityData != null && lifePointDrawActivityData.GetChallengeRequireFinishState(challengeId);
	}

	// Token: 0x06008275 RID: 33397 RVA: 0x001BAF94 File Offset: 0x001B9194
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

	// Token: 0x06008276 RID: 33398 RVA: 0x001BB060 File Offset: 0x001B9260
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

	// Token: 0x17000B2E RID: 2862
	// (get) Token: 0x06008277 RID: 33399 RVA: 0x001BB0E4 File Offset: 0x001B92E4
	public static LifePointDrawModel Instance
	{
		get
		{
			return LifePointDrawModel._Instance;
		}
	}

	// Token: 0x06008278 RID: 33400 RVA: 0x001BB0EB File Offset: 0x001B92EB
	public static LifePointDrawModel GetOrCreateInstance()
	{
		if (LifePointDrawModel._Instance == null)
		{
			LifePointDrawModel.CreateInstance();
		}
		return LifePointDrawModel._Instance;
	}

	// Token: 0x06008279 RID: 33401 RVA: 0x001BB0FF File Offset: 0x001B92FF
	public static bool CreateInstance()
	{
		if (LifePointDrawModel._Instance != null)
		{
			return true;
		}
		LifePointDrawModel._Instance = new LifePointDrawModel();
		return true;
	}

	// Token: 0x0600827A RID: 33402 RVA: 0x001BB115 File Offset: 0x001B9315
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600827B RID: 33403 RVA: 0x001BB117 File Offset: 0x001B9317
	public static void ResetStaticDefaultValue()
	{
		LifePointDrawModel._Instance = null;
	}

	// Token: 0x0600827C RID: 33404 RVA: 0x001BB11F File Offset: 0x001B931F
	static LifePointDrawModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LifePointDrawModel.CreateStaticDefaultValue), new Action(LifePointDrawModel.ResetStaticDefaultValue));
	}

	// Token: 0x04003AE7 RID: 15079
	public bool CurrentChallengeFinishState;

	// Token: 0x04003AE8 RID: 15080
	[Nullable(2)]
	private static LifePointDrawModel _Instance;
}
