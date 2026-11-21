using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054E5 RID: 21733
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LineCrossModel : ModelBase
	{
		// Token: 0x06035D97 RID: 220567 RVA: 0x00F0B144 File Offset: 0x00F09344
		public string GetProgressByActivityId(int activityId, string formatString)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			if (lineCrossActivityData != null)
			{
				int finishChallengeNumber = lineCrossActivityData.GetFinishChallengeNumber();
				int challengeNumber = lineCrossActivityData.GetChallengeNumber();
				return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(formatString, null) ?? "", new string[]
				{
					finishChallengeNumber.ToString(),
					challengeNumber.ToString()
				});
			}
			return "";
		}

		// Token: 0x06035D98 RID: 220568 RVA: 0x00F0B1A8 File Offset: 0x00F093A8
		public bool GetGroupUnlockState(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetGroupState(groupId) != ELineCrossGroupState.Lock;
		}

		// Token: 0x06035D99 RID: 220569 RVA: 0x00F0B1D8 File Offset: 0x00F093D8
		public string GetGroupRewardProgress(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			if (lineCrossActivityData != null)
			{
				int groupRewardProgress = lineCrossActivityData.GetGroupRewardProgress(groupId);
				int groupChallengeNumber = lineCrossActivityData.GetGroupChallengeNumber(groupId);
				return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("LineCrossProgress", null) ?? "", new string[]
				{
					groupRewardProgress.ToString(),
					groupChallengeNumber.ToString()
				});
			}
			return "";
		}

		// Token: 0x06035D9A RID: 220570 RVA: 0x00F0B244 File Offset: 0x00F09444
		public string GetLockDescription(int activityId, int groupId)
		{
			long groupUnlockTime = this.GetGroupUnlockTime(activityId, groupId);
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat((double)groupUnlockTime - TimeUtil.Instance.GetServerTime());
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("LineCrossLock", null) ?? "", new string[]
			{
				((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? ""
			});
		}

		// Token: 0x06035D9B RID: 220571 RVA: 0x00F0B2AC File Offset: 0x00F094AC
		public long GetGroupUnlockTime(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			if (lineCrossActivityData != null)
			{
				return lineCrossActivityData.GetGroupUnlockTime(groupId);
			}
			return 0L;
		}

		// Token: 0x06035D9C RID: 220572 RVA: 0x00F0B2D8 File Offset: 0x00F094D8
		public int[] GetShowGroupList(int activityId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			if (lineCrossActivityData != null)
			{
				return lineCrossActivityData.GetShowGroupList();
			}
			return Array.Empty<int>();
		}

		// Token: 0x06035D9D RID: 220573 RVA: 0x00F0B308 File Offset: 0x00F09508
		public bool GetGroupRewardState(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetGroupHasGetReward(groupId);
		}

		// Token: 0x06035D9E RID: 220574 RVA: 0x00F0B334 File Offset: 0x00F09534
		public bool GetIfHiddenGroup(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetIfHiddenGroup(groupId);
		}

		// Token: 0x06035D9F RID: 220575 RVA: 0x00F0B360 File Offset: 0x00F09560
		public bool GetGroupIfShow(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.IfGroupShow(groupId);
		}

		// Token: 0x06035DA0 RID: 220576 RVA: 0x00F0B38C File Offset: 0x00F0958C
		public bool GetChallengeRequireFinishState(int activityId, int challengeId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetChallengeRequireFinishState(challengeId);
		}

		// Token: 0x06035DA1 RID: 220577 RVA: 0x00F0B3B8 File Offset: 0x00F095B8
		public ELineCrossGroupState GetGroupState(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			if (lineCrossActivityData != null)
			{
				return lineCrossActivityData.GetGroupState(groupId);
			}
			return ELineCrossGroupState.Normal;
		}

		// Token: 0x06035DA2 RID: 220578 RVA: 0x00F0B3E4 File Offset: 0x00F095E4
		public bool GetGroupRedDotState(int groupId)
		{
			LineCrossGroup? lineCrossGroupByGroupId = LineCrossConfig.Instance.GetLineCrossGroupByGroupId(groupId);
			if (lineCrossGroupByGroupId == null)
			{
				return false;
			}
			for (int i = 0; i < lineCrossGroupByGroupId.Value.ChallengeListLength; i++)
			{
				int challengeId = lineCrossGroupByGroupId.Value.ChallengeList(i);
				if (this.GetChallengeRedDotState(challengeId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06035DA3 RID: 220579 RVA: 0x00F0B440 File Offset: 0x00F09640
		public bool GetChallengeFinishState(int activityId, int challengeId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetChallengeIfGetReward(challengeId);
		}

		// Token: 0x06035DA4 RID: 220580 RVA: 0x00F0B46C File Offset: 0x00F0966C
		public void SaveChallengeRedDotState(int activityId, int challengeId)
		{
			List<ActivityBaseData> currentShowingActivities = ActivityModel.Instance.GetCurrentShowingActivities();
			LineCrossActivityData lineCrossActivityData = null;
			foreach (ActivityBaseData activityBaseData in currentShowingActivities)
			{
				if (activityBaseData.Type == ActivityType.LineCross)
				{
					LineCrossActivityData lineCrossActivityData2 = activityBaseData as LineCrossActivityData;
					if (lineCrossActivityData2 != null && lineCrossActivityData2.CheckIfHaveChallenge(challengeId))
					{
						lineCrossActivityData = lineCrossActivityData2;
						break;
					}
				}
			}
			if (lineCrossActivityData == null)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(activityId, challengeId, 0, 0, 1);
		}

		// Token: 0x06035DA5 RID: 220581 RVA: 0x00F0B4F4 File Offset: 0x00F096F4
		public bool GetChallengeRedDotState(int challengeId)
		{
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.LineCross);
			LineCrossActivityData lineCrossActivityData = null;
			if (currentActivitiesByType.Count > 0)
			{
				lineCrossActivityData = (currentActivitiesByType[0] as LineCrossActivityData);
			}
			if (lineCrossActivityData == null)
			{
				return false;
			}
			int activityCacheData = ActivityModel.Instance.GetActivityCacheData(lineCrossActivityData.Id, 0, challengeId, 0, 0);
			int groupId = LineCrossConfig.Instance.GetLineCrossChallengeById(challengeId).Value.GroupId;
			bool challengeRequireFinishState = this.GetChallengeRequireFinishState(lineCrossActivityData.Id, challengeId);
			bool ifHiddenGroup = this.GetIfHiddenGroup(lineCrossActivityData.Id, groupId);
			bool groupIfShow = this.GetGroupIfShow(lineCrossActivityData.Id, groupId);
			return (!ifHiddenGroup || groupIfShow) && (activityCacheData == 0 && lineCrossActivityData.GetGroupIfOverUnlockTime(groupId) && challengeRequireFinishState);
		}

		// Token: 0x170068A7 RID: 26791
		// (get) Token: 0x06035DA6 RID: 220582 RVA: 0x00F0B5A1 File Offset: 0x00F097A1
		public static LineCrossModel Instance
		{
			get
			{
				return LineCrossModel._Instance;
			}
		}

		// Token: 0x06035DA7 RID: 220583 RVA: 0x00F0B5A8 File Offset: 0x00F097A8
		public static LineCrossModel GetOrCreateInstance()
		{
			if (LineCrossModel._Instance == null)
			{
				LineCrossModel.CreateInstance();
			}
			return LineCrossModel._Instance;
		}

		// Token: 0x06035DA8 RID: 220584 RVA: 0x00F0B5BC File Offset: 0x00F097BC
		public static bool CreateInstance()
		{
			if (LineCrossModel._Instance != null)
			{
				return true;
			}
			LineCrossModel._Instance = new LineCrossModel();
			return true;
		}

		// Token: 0x06035DA9 RID: 220585 RVA: 0x00F0B5D2 File Offset: 0x00F097D2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035DAA RID: 220586 RVA: 0x00F0B5D4 File Offset: 0x00F097D4
		public static void ResetStaticDefaultValue()
		{
			LineCrossModel._Instance = null;
		}

		// Token: 0x06035DAB RID: 220587 RVA: 0x00F0B5DC File Offset: 0x00F097DC
		static LineCrossModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LineCrossModel.CreateStaticDefaultValue), new Action(LineCrossModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401C7B2 RID: 116658
		public bool CurrentChallengeFinishState;

		// Token: 0x0401C7B3 RID: 116659
		[Nullable(2)]
		private static LineCrossModel _Instance;
	}
}
