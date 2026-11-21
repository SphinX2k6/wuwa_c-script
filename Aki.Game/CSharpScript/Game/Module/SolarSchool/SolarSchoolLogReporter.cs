using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200597A RID: 22906
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolLogReporter
	{
		// Token: 0x06038729 RID: 231209 RVA: 0x00FC97D0 File Offset: 0x00FC79D0
		public void ReportFavorLevelUp(int roleId, int newLevel)
		{
			SolarSchoolFavorLevelUpLogData logData = new SolarSchoolFavorLevelUpLogData
			{
				i_activity_type = 117,
				i_role_id = roleId,
				i_new_level = newLevel
			};
			this.Report(logData);
		}

		// Token: 0x0603872A RID: 231210 RVA: 0x00FC9800 File Offset: 0x00FC7A00
		public void ReportItemGet(int itemId, int count, int itemType)
		{
			SolarSchoolItemGetLogData logData = new SolarSchoolItemGetLogData
			{
				i_activity_type = 117,
				i_item_id = itemId,
				i_count = count,
				i_type = itemType
			};
			this.Report(logData);
		}

		// Token: 0x0603872B RID: 231211 RVA: 0x00FC9838 File Offset: 0x00FC7A38
		public void ReportInfluenceJoin(ESolarSchoolInfluence influence)
		{
			SolarSchoolInfluenceJoinLogData logData = new SolarSchoolInfluenceJoinLogData
			{
				i_activity_type = 117,
				i_status = (int)influence
			};
			this.Report(logData);
		}

		// Token: 0x0603872C RID: 231212 RVA: 0x00FC9864 File Offset: 0x00FC7A64
		public void ReportImportantAttrSelect(IEnumerable<ESolarSchoolSecondAttr> attrs)
		{
			SolarSchoolImportantAttrSelectLogData solarSchoolImportantAttrSelectLogData = new SolarSchoolImportantAttrSelectLogData
			{
				i_activity_type = 117
			};
			foreach (ESolarSchoolSecondAttr item in attrs)
			{
				solarSchoolImportantAttrSelectLogData.o_option_ids.Add((int)item);
			}
			this.Report(solarSchoolImportantAttrSelectLogData);
		}

		// Token: 0x0603872D RID: 231213 RVA: 0x00FC98C8 File Offset: 0x00FC7AC8
		public void ReportStageSettle(ESolarSchoolStageSettleType settleType)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolStageSettleLogData solarSchoolStageSettleLogData = new SolarSchoolStageSettleLogData
			{
				i_activity_type = 117,
				i_type = (int)settleType,
				s_tag = ((settleType == ESolarSchoolStageSettleType.CycleFinish) ? string.Join<int>(",", instance.SelectedEndingIds) : ""),
				s_roles = string.Join<int>(",", instance.FriendData.GetMaxFavorRoleIds()),
				o_attr_info = this.CreateAttrInfo(),
				i_count = instance.PlayerData.GetFinishedSpecialCount()
			};
			foreach (SolarSchoolExamResult solarSchoolExamResult in instance.PlayerData.GetExamResults().Values)
			{
				solarSchoolStageSettleLogData.o_exam_result.Add(new SolarSchoolExamResultLogData
				{
					i_exam_id = solarSchoolExamResult.ExamId,
					i_score = solarSchoolExamResult.Score
				});
			}
			this.Report(solarSchoolStageSettleLogData);
		}

		// Token: 0x0603872E RID: 231214 RVA: 0x00FC99BC File Offset: 0x00FC7BBC
		public void ReportQuest(int questId, ESolarSchoolQuestLogResultType resultType)
		{
			SolarSchoolQuestLogData logData = new SolarSchoolQuestLogData
			{
				i_quest_id = questId,
				i_result = (int)resultType
			};
			this.Report(logData);
		}

		// Token: 0x0603872F RID: 231215 RVA: 0x00FC99E4 File Offset: 0x00FC7BE4
		public void ReportQuestNode(int nodeId)
		{
			SolarSchoolQuestNodeLogData logData = new SolarSchoolQuestNodeLogData
			{
				i_node_id = nodeId
			};
			this.Report(logData);
		}

		// Token: 0x06038730 RID: 231216 RVA: 0x00FC9A08 File Offset: 0x00FC7C08
		public void ReportSkipClick(int flowId)
		{
			SolarSchoolSkipClickLogData logData = new SolarSchoolSkipClickLogData
			{
				i_flow_id = flowId
			};
			this.Report(logData);
		}

		// Token: 0x06038731 RID: 231217 RVA: 0x00FC9A2C File Offset: 0x00FC7C2C
		private SolarSchoolAttrInfoLogData CreateAttrInfo()
		{
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			return new SolarSchoolAttrInfoLogData
			{
				i_heat = playerData.GetAttr(ESolarSchoolSecondAttr.Popularity),
				i_know_score = playerData.GetAttr(ESolarSchoolSecondAttr.Knowledge),
				i_know_level = this.GetAttrRankTier(ESolarSchoolSecondAttr.Knowledge),
				i_wise_score = playerData.GetAttr(ESolarSchoolSecondAttr.Thinking),
				i_wise_level = this.GetAttrRankTier(ESolarSchoolSecondAttr.Thinking),
				i_art_score = playerData.GetAttr(ESolarSchoolSecondAttr.Art),
				i_art_level = this.GetAttrRankTier(ESolarSchoolSecondAttr.Art),
				i_health_score = playerData.GetAttr(ESolarSchoolSecondAttr.Physique),
				i_health_level = this.GetAttrRankTier(ESolarSchoolSecondAttr.Physique),
				i_emo_score = playerData.GetAttr(ESolarSchoolSecondAttr.Emotion),
				i_emo_level = this.GetAttrRankTier(ESolarSchoolSecondAttr.Emotion),
				i_money = playerData.GetAttr(ESolarSchoolSecondAttr.Money),
				i_level_a = playerData.GetInfluenceLevel(ESolarSchoolInfluence.StudentCouncil),
				i_level_b = playerData.GetInfluenceLevel(ESolarSchoolInfluence.LeagueOfSocieties)
			};
		}

		// Token: 0x06038732 RID: 231218 RVA: 0x00FC9B00 File Offset: 0x00FC7D00
		private int GetAttrRankTier(ESolarSchoolSecondAttr attr)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(attr);
			if (attrConfig != null)
			{
				return SolarSchoolUtils.CalcAttrRankTier(attrConfig.Value, instance.PlayerData.GetAttr(attr));
			}
			return 0;
		}

		// Token: 0x06038733 RID: 231219 RVA: 0x00FC9B40 File Offset: 0x00FC7D40
		private void Report(SolarSchoolLogData logData)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (!instance.IsInGamePlay)
			{
				return;
			}
			logData.i_activity_id = instance.ActivityId;
			logData.i_trace_id = instance.TraceId;
			logData.i_round = instance.CycleCount;
			logData.i_wave = instance.TimeData.DayIndex;
			LogReportController.Instance.LogReport(logData);
		}
	}
}
