using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x02006203 RID: 25091
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipData : ActivityBaseData
	{
		// Token: 0x0603F4F9 RID: 259321 RVA: 0x00F4C49C File Offset: 0x00F4A69C
		protected override void PhraseEx(ActivityData data)
		{
			RhythmActivityPb rhythmActivityPb = data.RhythmActivityPb;
			this.CurrentRole = ((rhythmActivityPb != null) ? rhythmActivityPb.RhythmRoleId : 0);
			RhythmActivityPb rhythmActivityPb2 = data.RhythmActivityPb;
			RepeatedField<RhythmShipPlanetPb> repeatedField = (rhythmActivityPb2 != null) ? rhythmActivityPb2.RhythmShipPlanetPb : null;
			if (repeatedField != null)
			{
				foreach (RhythmShipPlanetPb planetInfo in repeatedField)
				{
					this.InitPlanetInfo(planetInfo);
				}
			}
			IEnumerable<int> rhythmShipPlanetIdListByType = RhythmShipConfig.Instance.GetRhythmShipPlanetIdListByType(1, base.Id);
			List<int> rhythmShipPlanetIdListByType2 = RhythmShipConfig.Instance.GetRhythmShipPlanetIdListByType(3, base.Id);
			List<int> list = new List<int>(rhythmShipPlanetIdListByType);
			list.AddRange(rhythmShipPlanetIdListByType2);
			foreach (int planet in list)
			{
				foreach (int num in RhythmShipConfig.Instance.GetRhythmShipLevelIdListByPlanet(planet))
				{
					List<int> value = RhythmShipConfig.Instance.GetRhythmShipSubLevelIdByLevelId(num) ?? new List<int>();
					RhythmShipModel.Instance.LevelSubLevelInfoMap[num] = value;
				}
			}
			RhythmActivityPb rhythmActivityPb3 = data.RhythmActivityPb;
			RepeatedField<RhythmTaskPb> repeatedField2 = (rhythmActivityPb3 != null) ? rhythmActivityPb3.RhythmTask : null;
			if (repeatedField2 != null)
			{
				foreach (RhythmTaskPb rhythmTaskPb in repeatedField2)
				{
					if (rhythmTaskPb.TaskType == RhythmTaskTypePb.Resident)
					{
						foreach (ConditionTask conditionTask in rhythmTaskPb.Task)
						{
							this.TaskInfoMap[conditionTask.Id] = conditionTask;
						}
					}
					if (rhythmTaskPb.TaskType == RhythmTaskTypePb.Limit)
					{
						foreach (ConditionTask conditionTask2 in rhythmTaskPb.Task)
						{
							this.LimitTaskInfoMap[conditionTask2.Id] = conditionTask2;
						}
					}
				}
			}
			RhythmActivityPb rhythmActivityPb4 = data.RhythmActivityPb;
			this.RoleUnlockList = new List<int>(((rhythmActivityPb4 != null) ? rhythmActivityPb4.UnlockedRole : null) ?? new RepeatedField<int>());
			RhythmActivityPb rhythmActivityPb5 = data.RhythmActivityPb;
			this.RedDotInfo = (((rhythmActivityPb5 != null) ? rhythmActivityPb5.RedDot : null) ?? RhythmRedDotPb.Create());
			this.InitTaskTabList();
		}

		// Token: 0x0603F4FA RID: 259322 RVA: 0x00F4C744 File Offset: 0x00F4A944
		private void InitPlanetInfo(RhythmShipPlanetPb planetInfo)
		{
			foreach (RhythmShipLevelPb rhythmShipLevelPb in planetInfo.RhythmShipLevelPb)
			{
				foreach (RhythmSubLevelPb rhythmSubLevelPb in rhythmShipLevelPb.RhythmSubLevelPb)
				{
					this.SubLevelInfoMap[rhythmSubLevelPb.SubLevelId] = rhythmSubLevelPb;
				}
			}
			this.PlanetOpenTime[planetInfo.PlanetId] = planetInfo.OpenTime;
		}

		// Token: 0x0603F4FB RID: 259323 RVA: 0x00F4C7E8 File Offset: 0x00F4A9E8
		private void InitTaskTabList()
		{
			this.TaskTabList = new List<int>();
			foreach (int id in RhythmShipConfig.Instance.GetRhythmShipTaskIdByTypeAndActivityId(0, RhythmShipModel.Instance.ActivityId))
			{
				RhythmTask? rhythmTask;
				int? num = (RhythmShipConfig.Instance.GetRhythmShipTaskById(id) != null) ? new int?(rhythmTask.GetValueOrDefault().TaskTab) : null;
				if (num != null && !this.TaskTabList.Contains(num.Value))
				{
					this.TaskTabList.Add(num.Value);
				}
			}
		}

		// Token: 0x0603F4FC RID: 259324 RVA: 0x00F4C8B4 File Offset: 0x00F4AAB4
		public bool GetCanTaskGetReward(int type)
		{
			foreach (KeyValuePair<int, ConditionTask> keyValuePair in ((type == 0) ? this.TaskInfoMap : this.LimitTaskInfoMap))
			{
				if (keyValuePair.Value.Status == ConditionTaskState.ConditionTaskFinish)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603F4FD RID: 259325 RVA: 0x00F4C924 File Offset: 0x00F4AB24
		public bool GetGotoRhythmShipBtnRedDotActive()
		{
			if (!base.IsUnLock())
			{
				return false;
			}
			foreach (KeyValuePair<int, List<int>> keyValuePair in RhythmShipModel.Instance.LevelSubLevelInfoMap)
			{
				int key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				RhythmShipLevel? rhythmShipLevelById = RhythmShipConfig.Instance.GetRhythmShipLevelById(key);
				if (RhythmShipConfig.Instance.GetRhythmShipPlanetById(rhythmShipLevelById.Value.Planet).Value.Type != 2)
				{
					foreach (int subLevelId in value)
					{
						if (RhythmShipModel.Instance.GetSubLevelRedDotActive(subLevelId))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0603F4FE RID: 259326 RVA: 0x00F4CA20 File Offset: 0x00F4AC20
		public override bool GetExDataRedPointShowState()
		{
			return this.GetGotoRhythmShipBtnRedDotActive() || this.GetCanTaskGetReward(0) || this.GetCanTaskGetReward(1);
		}

		// Token: 0x0603F4FF RID: 259327 RVA: 0x00F4CA3C File Offset: 0x00F4AC3C
		public int GetRecommendQuestId()
		{
			RhythmActivity? rhythmActivity;
			int? num = (RhythmShipConfig.Instance.GetRhythmShipActivity(base.Id) != null) ? new int?(rhythmActivity.GetValueOrDefault().RecommendQuestId) : null;
			if (num == null || num.Value == 0)
			{
				return 0;
			}
			return num.Value;
		}

		// Token: 0x0603F500 RID: 259328 RVA: 0x00F4CAA0 File Offset: 0x00F4ACA0
		public bool IsRecommendQuestFinish()
		{
			int recommendQuestId = this.GetRecommendQuestId();
			return recommendQuestId == 0 || QuestNewModel.Instance.CheckQuestFinished(recommendQuestId);
		}

		// Token: 0x0603F501 RID: 259329 RVA: 0x00F4CAC4 File Offset: 0x00F4ACC4
		public string GetRecommendQuestIdTips()
		{
			RhythmActivity? rhythmActivity;
			return ((RhythmShipConfig.Instance.GetRhythmShipActivity(base.Id) != null) ? rhythmActivity.GetValueOrDefault().RecommendQuestTips : null) ?? "";
		}

		// Token: 0x0603F502 RID: 259330 RVA: 0x00F4CB08 File Offset: 0x00F4AD08
		protected override bool GetExDataFinishShowState()
		{
			if (base.CheckIfInLimitTime())
			{
				foreach (KeyValuePair<int, ConditionTask> keyValuePair in this.LimitTaskInfoMap)
				{
					if (keyValuePair.Value.Status != ConditionTaskState.ConditionTaskTaken)
					{
						return false;
					}
				}
			}
			foreach (KeyValuePair<int, ConditionTask> keyValuePair2 in this.TaskInfoMap)
			{
				if (keyValuePair2.Value.Status != ConditionTaskState.ConditionTaskTaken)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04021043 RID: 135235
		public int CurrentRole;

		// Token: 0x04021044 RID: 135236
		public List<int> RoleUnlockList = new List<int>();

		// Token: 0x04021045 RID: 135237
		public Dictionary<int, ConditionTask> TaskInfoMap = new Dictionary<int, ConditionTask>();

		// Token: 0x04021046 RID: 135238
		public Dictionary<int, ConditionTask> LimitTaskInfoMap = new Dictionary<int, ConditionTask>();

		// Token: 0x04021047 RID: 135239
		public Dictionary<int, RhythmSubLevelPb> SubLevelInfoMap = new Dictionary<int, RhythmSubLevelPb>();

		// Token: 0x04021048 RID: 135240
		public Dictionary<int, long> PlanetOpenTime = new Dictionary<int, long>();

		// Token: 0x04021049 RID: 135241
		[Nullable(2)]
		public RhythmRedDotPb RedDotInfo;

		// Token: 0x0402104A RID: 135242
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RhythmPlayerRankingInfo> FriendLevelRatingInfoList;

		// Token: 0x0402104B RID: 135243
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RhythmPlayerRankingSubLevelInfo> SelfLevelRatingInfoList;

		// Token: 0x0402104C RID: 135244
		public List<int> TaskTabList = new List<int>();
	}
}
