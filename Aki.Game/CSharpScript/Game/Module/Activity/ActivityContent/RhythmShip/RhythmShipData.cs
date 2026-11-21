using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x02005181 RID: 20865
	[NullableContext(1)]
	[Nullable(0)]
	public class RhythmShipData : ActivityBaseData
	{
		// Token: 0x060341BA RID: 213434 RVA: 0x00E933F4 File Offset: 0x00E915F4
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

		// Token: 0x060341BB RID: 213435 RVA: 0x00E9369C File Offset: 0x00E9189C
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

		// Token: 0x060341BC RID: 213436 RVA: 0x00E93740 File Offset: 0x00E91940
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

		// Token: 0x060341BD RID: 213437 RVA: 0x00E9380C File Offset: 0x00E91A0C
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

		// Token: 0x060341BE RID: 213438 RVA: 0x00E9387C File Offset: 0x00E91A7C
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

		// Token: 0x060341BF RID: 213439 RVA: 0x00E93978 File Offset: 0x00E91B78
		public override bool GetExDataRedPointShowState()
		{
			return this.GetGotoRhythmShipBtnRedDotActive() || this.GetCanTaskGetReward(0) || this.GetCanTaskGetReward(1);
		}

		// Token: 0x060341C0 RID: 213440 RVA: 0x00E93994 File Offset: 0x00E91B94
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

		// Token: 0x060341C1 RID: 213441 RVA: 0x00E939F8 File Offset: 0x00E91BF8
		public bool IsRecommendQuestFinish()
		{
			int recommendQuestId = this.GetRecommendQuestId();
			return recommendQuestId == 0 || QuestNewModel.Instance.CheckQuestFinished(recommendQuestId);
		}

		// Token: 0x060341C2 RID: 213442 RVA: 0x00E93A1C File Offset: 0x00E91C1C
		public string GetRecommendQuestIdTips()
		{
			RhythmActivity? rhythmActivity;
			return ((RhythmShipConfig.Instance.GetRhythmShipActivity(base.Id) != null) ? rhythmActivity.GetValueOrDefault().RecommendQuestTips : null) ?? "";
		}

		// Token: 0x060341C3 RID: 213443 RVA: 0x00E93A60 File Offset: 0x00E91C60
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

		// Token: 0x0401B972 RID: 113010
		public int CurrentRole;

		// Token: 0x0401B973 RID: 113011
		public List<int> RoleUnlockList = new List<int>();

		// Token: 0x0401B974 RID: 113012
		public Dictionary<int, ConditionTask> TaskInfoMap = new Dictionary<int, ConditionTask>();

		// Token: 0x0401B975 RID: 113013
		public Dictionary<int, ConditionTask> LimitTaskInfoMap = new Dictionary<int, ConditionTask>();

		// Token: 0x0401B976 RID: 113014
		public Dictionary<int, RhythmSubLevelPb> SubLevelInfoMap = new Dictionary<int, RhythmSubLevelPb>();

		// Token: 0x0401B977 RID: 113015
		public Dictionary<int, long> PlanetOpenTime = new Dictionary<int, long>();

		// Token: 0x0401B978 RID: 113016
		[Nullable(2)]
		public RhythmRedDotPb RedDotInfo;

		// Token: 0x0401B979 RID: 113017
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RhythmPlayerRankingInfo> FriendLevelRatingInfoList;

		// Token: 0x0401B97A RID: 113018
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RhythmPlayerRankingSubLevelInfo> SelfLevelRatingInfoList;

		// Token: 0x0401B97B RID: 113019
		public List<int> TaskTabList = new List<int>();
	}
}
