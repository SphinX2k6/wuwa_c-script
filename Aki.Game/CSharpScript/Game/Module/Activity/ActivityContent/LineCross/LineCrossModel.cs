using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x02006567 RID: 25959
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class LineCrossModel : ModelBase
	{
		// Token: 0x060410D2 RID: 266450 RVA: 0x00FC4160 File Offset: 0x00FC2360
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

		// Token: 0x060410D3 RID: 266451 RVA: 0x00FC41C4 File Offset: 0x00FC23C4
		public bool GetGroupUnlockState(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetGroupState(groupId) != ELineCrossGroupState.Lock;
		}

		// Token: 0x060410D4 RID: 266452 RVA: 0x00FC41F4 File Offset: 0x00FC23F4
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

		// Token: 0x060410D5 RID: 266453 RVA: 0x00FC4260 File Offset: 0x00FC2460
		public string GetLockDescription(int activityId, int groupId)
		{
			long groupUnlockTime = this.GetGroupUnlockTime(activityId, groupId);
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat((double)groupUnlockTime - TimeUtil.Instance.GetServerTime());
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("LineCrossLock", null) ?? "", new string[]
			{
				((remainTimeDataFormat != null) ? remainTimeDataFormat.CountDownText : null) ?? ""
			});
		}

		// Token: 0x060410D6 RID: 266454 RVA: 0x00FC42C8 File Offset: 0x00FC24C8
		public long GetGroupUnlockTime(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			if (lineCrossActivityData != null)
			{
				return lineCrossActivityData.GetGroupUnlockTime(groupId);
			}
			return 0L;
		}

		// Token: 0x060410D7 RID: 266455 RVA: 0x00FC42F4 File Offset: 0x00FC24F4
		public int[] GetShowGroupList(int activityId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			if (lineCrossActivityData != null)
			{
				return lineCrossActivityData.GetShowGroupList();
			}
			return Array.Empty<int>();
		}

		// Token: 0x060410D8 RID: 266456 RVA: 0x00FC4324 File Offset: 0x00FC2524
		public bool GetGroupRewardState(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetGroupHasGetReward(groupId);
		}

		// Token: 0x060410D9 RID: 266457 RVA: 0x00FC4350 File Offset: 0x00FC2550
		public bool GetIfHiddenGroup(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetIfHiddenGroup(groupId);
		}

		// Token: 0x060410DA RID: 266458 RVA: 0x00FC437C File Offset: 0x00FC257C
		public bool GetGroupIfShow(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.IfGroupShow(groupId);
		}

		// Token: 0x060410DB RID: 266459 RVA: 0x00FC43A8 File Offset: 0x00FC25A8
		public bool GetChallengeRequireFinishState(int activityId, int challengeId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetChallengeRequireFinishState(challengeId);
		}

		// Token: 0x060410DC RID: 266460 RVA: 0x00FC43D4 File Offset: 0x00FC25D4
		public ELineCrossGroupState GetGroupState(int activityId, int groupId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			if (lineCrossActivityData != null)
			{
				return lineCrossActivityData.GetGroupState(groupId);
			}
			return ELineCrossGroupState.Normal;
		}

		// Token: 0x060410DD RID: 266461 RVA: 0x00FC4400 File Offset: 0x00FC2600
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

		// Token: 0x060410DE RID: 266462 RVA: 0x00FC445C File Offset: 0x00FC265C
		public bool GetChallengeFinishState(int activityId, int challengeId)
		{
			LineCrossActivityData lineCrossActivityData = ActivityModel.Instance.GetActivityById(activityId) as LineCrossActivityData;
			return lineCrossActivityData != null && lineCrossActivityData.GetChallengeIfGetReward(challengeId);
		}

		// Token: 0x060410DF RID: 266463 RVA: 0x00FC4488 File Offset: 0x00FC2688
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

		// Token: 0x060410E0 RID: 266464 RVA: 0x00FC4510 File Offset: 0x00FC2710
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

		// Token: 0x17009545 RID: 38213
		// (get) Token: 0x060410E1 RID: 266465 RVA: 0x00FC45BD File Offset: 0x00FC27BD
		public static LineCrossModel Instance
		{
			get
			{
				return LineCrossModel._Instance;
			}
		}

		// Token: 0x060410E2 RID: 266466 RVA: 0x00FC45C4 File Offset: 0x00FC27C4
		public static LineCrossModel GetOrCreateInstance()
		{
			if (LineCrossModel._Instance == null)
			{
				LineCrossModel.CreateInstance();
			}
			return LineCrossModel._Instance;
		}

		// Token: 0x060410E3 RID: 266467 RVA: 0x00FC45D8 File Offset: 0x00FC27D8
		public static bool CreateInstance()
		{
			if (LineCrossModel._Instance != null)
			{
				return true;
			}
			LineCrossModel._Instance = new LineCrossModel();
			return true;
		}

		// Token: 0x060410E4 RID: 266468 RVA: 0x00FC45EE File Offset: 0x00FC27EE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060410E5 RID: 266469 RVA: 0x00FC45F0 File Offset: 0x00FC27F0
		public static void ResetStaticDefaultValue()
		{
			LineCrossModel._Instance = null;
		}

		// Token: 0x060410E6 RID: 266470 RVA: 0x00FC45F8 File Offset: 0x00FC27F8
		static LineCrossModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LineCrossModel.CreateStaticDefaultValue), new Action(LineCrossModel.ResetStaticDefaultValue));
		}

		// Token: 0x04021E81 RID: 138881
		public bool CurrentChallengeFinishState;

		// Token: 0x04021E82 RID: 138882
		[Nullable(2)]
		private static LineCrossModel _Instance;
	}
}
