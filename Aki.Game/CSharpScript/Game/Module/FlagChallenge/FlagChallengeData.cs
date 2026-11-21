using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A02 RID: 18946
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeData
	{
		// Token: 0x17005FA5 RID: 24485
		// (get) Token: 0x0602F7EC RID: 194540 RVA: 0x00D3F3A5 File Offset: 0x00D3D5A5
		// (set) Token: 0x0602F7ED RID: 194541 RVA: 0x00D3F3AD File Offset: 0x00D3D5AD
		public int ActivityId
		{
			get
			{
				return this.ActivityIdIntl;
			}
			set
			{
				this.ActivityIdIntl = value;
			}
		}

		// Token: 0x0602F7EE RID: 194542 RVA: 0x00D3F3B6 File Offset: 0x00D3D5B6
		public void ParseActivityData(FlagChallengeActivityInfo activityData)
		{
			this.InitData();
			this.ParseTaskData(activityData.ConditionTasks);
			this.ParseLevelData(activityData.FlagChallengeLevelInfos);
			this.ParseStrongHoldData(activityData.FlagStrongholdInfos);
			this.ParseRoleLevelData(activityData.FlagChallengeRoleLevelInfo);
			this.PostParseActivityData();
		}

		// Token: 0x0602F7EF RID: 194543 RVA: 0x00D3F3F4 File Offset: 0x00D3D5F4
		private void PostParseActivityData()
		{
			using (Dictionary<int, List<FlagChallengeStrongholdData>>.ValueCollection.Enumerator enumerator = this.Area2Strongholds.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.Sort((FlagChallengeStrongholdData a, FlagChallengeStrongholdData b) => a.StrongholdConfig.Index - b.StrongholdConfig.Index);
				}
			}
		}

		// Token: 0x0602F7F0 RID: 194544 RVA: 0x00D3F468 File Offset: 0x00D3D668
		private void InitData()
		{
			if (this.IsInited)
			{
				return;
			}
			this.IsInited = true;
			this.InitFormationInfo();
			this.InitBuffData();
			this.InitAreaData();
			this.InitRoleLevelData();
		}

		// Token: 0x0602F7F1 RID: 194545 RVA: 0x00D3F492 File Offset: 0x00D3D692
		public int? GetMainViewSelectLevelId()
		{
			return this.MainViewSelectLevelId;
		}

		// Token: 0x0602F7F2 RID: 194546 RVA: 0x00D3F49A File Offset: 0x00D3D69A
		public void SetMainViewSelectLevelId(int? id)
		{
			this.MainViewSelectLevelId = id;
		}

		// Token: 0x0602F7F3 RID: 194547 RVA: 0x00D3F4A4 File Offset: 0x00D3D6A4
		private void ParseTaskData(IList<ConditionTask> tasks)
		{
			foreach (ConditionTask task in tasks)
			{
				this.UpdateTaskData(task);
			}
		}

		// Token: 0x0602F7F4 RID: 194548 RVA: 0x00D3F4EC File Offset: 0x00D3D6EC
		public void UpdateTaskData(ConditionTask task)
		{
			this.GetOrCreateTaskData(task.Id).Refresh(task);
		}

		// Token: 0x0602F7F5 RID: 194549 RVA: 0x00D3F500 File Offset: 0x00D3D700
		private FlagChallengeTaskData GetOrCreateTaskData(int taskId)
		{
			FlagChallengeTaskData flagChallengeTaskData = this.GetTaskData(taskId);
			if (flagChallengeTaskData == null)
			{
				flagChallengeTaskData = new FlagChallengeTaskData(taskId);
				this.TaskDataList.Add(flagChallengeTaskData);
			}
			return flagChallengeTaskData;
		}

		// Token: 0x0602F7F6 RID: 194550 RVA: 0x00D3F52C File Offset: 0x00D3D72C
		[NullableContext(2)]
		public FlagChallengeTaskData GetTaskData(int id)
		{
			foreach (FlagChallengeTaskData flagChallengeTaskData in this.TaskDataList)
			{
				if (flagChallengeTaskData.Id == id)
				{
					return flagChallengeTaskData;
				}
			}
			return null;
		}

		// Token: 0x0602F7F7 RID: 194551 RVA: 0x00D3F588 File Offset: 0x00D3D788
		public List<FlagChallengeTaskData> GetTaskDataList()
		{
			this.TaskDataList.Sort(new Comparison<FlagChallengeTaskData>(this.SortTaskData));
			return this.TaskDataList;
		}

		// Token: 0x0602F7F8 RID: 194552 RVA: 0x00D3F5A8 File Offset: 0x00D3D7A8
		public bool HasCanReceiveTask()
		{
			using (List<FlagChallengeTaskData>.Enumerator enumerator = this.TaskDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.CanReceiveReward())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602F7F9 RID: 194553 RVA: 0x00D3F604 File Offset: 0x00D3D804
		public List<int> GetFinishedTaskIdList()
		{
			List<int> list = new List<int>();
			foreach (FlagChallengeTaskData flagChallengeTaskData in this.TaskDataList)
			{
				if (flagChallengeTaskData.CanReceiveReward() || flagChallengeTaskData.IsTaskReceived())
				{
					list.Add(flagChallengeTaskData.Id);
				}
			}
			return list;
		}

		// Token: 0x0602F7FA RID: 194554 RVA: 0x00D3F674 File Offset: 0x00D3D874
		public List<int> GetCanReceiveTaskIdList()
		{
			List<int> list = new List<int>();
			foreach (FlagChallengeTaskData flagChallengeTaskData in this.TaskDataList)
			{
				if (flagChallengeTaskData.CanReceiveReward())
				{
					list.Add(flagChallengeTaskData.Id);
				}
			}
			return list;
		}

		// Token: 0x0602F7FB RID: 194555 RVA: 0x00D3F6DC File Offset: 0x00D3D8DC
		private int SortTaskData(FlagChallengeTaskData a, FlagChallengeTaskData b)
		{
			if (a.CanReceiveReward() && !b.CanReceiveReward())
			{
				return -1;
			}
			if (!a.CanReceiveReward() && b.CanReceiveReward())
			{
				return 1;
			}
			if (!a.IsTaskReceived() && b.IsTaskReceived())
			{
				return -1;
			}
			if (a.IsTaskReceived() && !b.IsTaskReceived())
			{
				return 1;
			}
			return a.Id - b.Id;
		}

		// Token: 0x0602F7FC RID: 194556 RVA: 0x00D3F740 File Offset: 0x00D3D940
		public string GetTaskProgressText()
		{
			List<FlagChallengeTaskData> taskDataList = this.GetTaskDataList();
			List<int> finishedTaskIdList = this.GetFinishedTaskIdList();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(finishedTaskIdList.Count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskDataList.Count);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0602F7FD RID: 194557 RVA: 0x00D3F794 File Offset: 0x00D3D994
		public bool IsAllTaskReceived()
		{
			using (List<FlagChallengeTaskData>.Enumerator enumerator = this.GetTaskDataList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsTaskReceived())
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0602F7FE RID: 194558 RVA: 0x00D3F7F0 File Offset: 0x00D3D9F0
		private void ParseLevelData(IList<FlagChallengeLevelInfo> levels)
		{
			foreach (FlagChallengeLevelInfo level in levels)
			{
				this.UpdateLevelData(level);
			}
			List<FlagChallengeLevelData> levelDataList = this.GetLevelDataList(false);
			for (int i = 0; i < levelDataList.Count; i++)
			{
				levelDataList[i].Index = i + 1;
			}
			EventSystem.Instance.Emit(EEventName.OnFlagChallengeUpdateLevelData);
		}

		// Token: 0x0602F7FF RID: 194559 RVA: 0x00D3F870 File Offset: 0x00D3DA70
		public void UpdateLevelData(FlagChallengeLevelInfo level)
		{
			int id = level.Id;
			FlagChallengeLevelData flagChallengeLevelData;
			if (!this.LevelDataMap.TryGetValue(id, out flagChallengeLevelData))
			{
				flagChallengeLevelData = new FlagChallengeLevelData(id);
				this.LevelDataList.Add(flagChallengeLevelData);
				this.LevelDataMap[id] = flagChallengeLevelData;
			}
			else if (flagChallengeLevelData.IsLocked() && level.State == 1)
			{
				this.SetLevelNewlyUnlocked(id, true);
			}
			flagChallengeLevelData.Refresh(level);
		}

		// Token: 0x0602F800 RID: 194560 RVA: 0x00D3F8D8 File Offset: 0x00D3DAD8
		[NullableContext(2)]
		public FlagChallengeLevelData GetLevelData(int id)
		{
			FlagChallengeLevelData result;
			this.LevelDataMap.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x0602F801 RID: 194561 RVA: 0x00D3F8F8 File Offset: 0x00D3DAF8
		public List<FlagChallengeLevelData> GetLevelDataList(bool checkHiddenLevel = false)
		{
			this.LevelDataList.Sort(new Comparison<FlagChallengeLevelData>(this.SortLevelData));
			if (checkHiddenLevel)
			{
				List<FlagChallengeLevelData> list = new List<FlagChallengeLevelData>();
				for (int i = 0; i < this.LevelDataList.Count; i++)
				{
					FlagChallengeLevelData flagChallengeLevelData = this.LevelDataList[i];
					if (!flagChallengeLevelData.IsHidden())
					{
						list.Add(flagChallengeLevelData);
					}
				}
				return list;
			}
			return new List<FlagChallengeLevelData>(this.LevelDataList);
		}

		// Token: 0x0602F802 RID: 194562 RVA: 0x00D3F964 File Offset: 0x00D3DB64
		private int SortLevelData(FlagChallengeLevelData a, FlagChallengeLevelData b)
		{
			return a.Id - b.Id;
		}

		// Token: 0x0602F803 RID: 194563 RVA: 0x00D3F974 File Offset: 0x00D3DB74
		public bool IsAllLevelPassWithoutHidden()
		{
			foreach (FlagChallengeLevelData flagChallengeLevelData in this.GetLevelDataList(false))
			{
				if (!flagChallengeLevelData.IsHiddenLevel() && !flagChallengeLevelData.IsCompleted())
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602F804 RID: 194564 RVA: 0x00D3F9D8 File Offset: 0x00D3DBD8
		public bool IsAllLevelPass()
		{
			using (List<FlagChallengeLevelData>.Enumerator enumerator = this.GetLevelDataList(false).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.IsCompleted())
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0602F805 RID: 194565 RVA: 0x00D3FA34 File Offset: 0x00D3DC34
		private void InitAreaData()
		{
			foreach (FlagChallengeArea flagChallengeArea in (FlagChallengeConfig.Instance.GetAreaConfigList() ?? new List<FlagChallengeArea>()))
			{
				int id = flagChallengeArea.Id;
				FlagChallengeAreaData flagChallengeAreaData = new FlagChallengeAreaData(id, this.ActivityId);
				int levelId = flagChallengeAreaData.GetLevelId();
				List<FlagChallengeAreaData> list;
				if (!this.Level2Areas.TryGetValue(levelId, out list))
				{
					list = new List<FlagChallengeAreaData>();
					this.Level2Areas[levelId] = list;
				}
				list.Add(flagChallengeAreaData);
				this.AreaMap[id] = flagChallengeAreaData;
			}
		}

		// Token: 0x0602F806 RID: 194566 RVA: 0x00D3FAE0 File Offset: 0x00D3DCE0
		[NullableContext(2)]
		public FlagChallengeAreaData GetAreaData(int areaId)
		{
			FlagChallengeAreaData result;
			this.AreaMap.TryGetValue(areaId, out result);
			return result;
		}

		// Token: 0x0602F807 RID: 194567 RVA: 0x00D3FB00 File Offset: 0x00D3DD00
		public List<FlagChallengeAreaData> GetLevelAreaDataList(int levelId)
		{
			List<FlagChallengeAreaData> list;
			this.Level2Areas.TryGetValue(levelId, out list);
			return list ?? new List<FlagChallengeAreaData>();
		}

		// Token: 0x0602F808 RID: 194568 RVA: 0x00D3FB28 File Offset: 0x00D3DD28
		public bool IsAreaAllBossStrongholdPass(int areaId)
		{
			foreach (FlagChallengeStrongholdData flagChallengeStrongholdData in this.GetAreaStrongholdDataList(areaId))
			{
				if (flagChallengeStrongholdData.IsBossStronghold() && !flagChallengeStrongholdData.IsPass)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0602F809 RID: 194569 RVA: 0x00D3FB8C File Offset: 0x00D3DD8C
		private void ParseStrongHoldData(IList<FlagStrongholdInfo> strongholds)
		{
			foreach (FlagStrongholdInfo flagStrongholdInfo in strongholds)
			{
				this.UpdateStrongholdData(FlagChallengeConfig.Instance.GetStrongholdConfig(flagStrongholdInfo.Id).Value.ChallengeLevelId, flagStrongholdInfo);
			}
			EventSystem.Instance.Emit(EEventName.OnFlagChallengeUpdateStrongholdData);
		}

		// Token: 0x0602F80A RID: 194570 RVA: 0x00D3FC04 File Offset: 0x00D3DE04
		public void UpdateStrongholdData(int levelId, FlagStrongholdInfo stronghold)
		{
			int id = stronghold.Id;
			FlagChallengeStrongholdData flagChallengeStrongholdData;
			if (!this.StrongholdMap.TryGetValue(id, out flagChallengeStrongholdData))
			{
				flagChallengeStrongholdData = new FlagChallengeStrongholdData(id);
				this.StrongholdMap[id] = flagChallengeStrongholdData;
				this.MarkId2StrongholdId[flagChallengeStrongholdData.StrongholdConfig.MarkId] = id;
				List<FlagChallengeStrongholdData> list;
				if (!this.Level2Strongholds.TryGetValue(levelId, out list))
				{
					list = new List<FlagChallengeStrongholdData>();
					this.Level2Strongholds[levelId] = list;
				}
				list.Add(flagChallengeStrongholdData);
				int areaId = flagChallengeStrongholdData.StrongholdConfig.AreaId;
				List<FlagChallengeStrongholdData> list2;
				if (!this.Area2Strongholds.TryGetValue(areaId, out list2))
				{
					list2 = new List<FlagChallengeStrongholdData>();
					this.Area2Strongholds[areaId] = list2;
				}
				list2.Add(flagChallengeStrongholdData);
			}
			flagChallengeStrongholdData.Refresh(stronghold);
		}

		// Token: 0x0602F80B RID: 194571 RVA: 0x00D3FCC0 File Offset: 0x00D3DEC0
		[NullableContext(2)]
		public FlagChallengeStrongholdData GetStrongholdData(int strongholdId)
		{
			FlagChallengeStrongholdData result;
			this.StrongholdMap.TryGetValue(strongholdId, out result);
			return result;
		}

		// Token: 0x0602F80C RID: 194572 RVA: 0x00D3FCE0 File Offset: 0x00D3DEE0
		public List<FlagChallengeStrongholdData> GetLevelStrongholdDataList(int levelId)
		{
			List<FlagChallengeStrongholdData> list;
			this.Level2Strongholds.TryGetValue(levelId, out list);
			return list ?? new List<FlagChallengeStrongholdData>();
		}

		// Token: 0x0602F80D RID: 194573 RVA: 0x00D3FD08 File Offset: 0x00D3DF08
		public List<FlagChallengeStrongholdData> GetAreaStrongholdDataList(int areaId)
		{
			List<FlagChallengeStrongholdData> list;
			this.Area2Strongholds.TryGetValue(areaId, out list);
			return list ?? new List<FlagChallengeStrongholdData>();
		}

		// Token: 0x0602F80E RID: 194574 RVA: 0x00D3FD30 File Offset: 0x00D3DF30
		[NullableContext(2)]
		public FlagChallengeStrongholdData GetStrongholdDataByMarkId(int markId)
		{
			int strongholdId;
			if (!this.MarkId2StrongholdId.TryGetValue(markId, out strongholdId))
			{
				return null;
			}
			return this.GetStrongholdData(strongholdId);
		}

		// Token: 0x0602F80F RID: 194575 RVA: 0x00D3FD58 File Offset: 0x00D3DF58
		public int? GetEasierStrongholdId(int strongholdId)
		{
			FlagChallengeStrongholdData strongholdData = this.GetStrongholdData(strongholdId);
			if (strongholdData == null)
			{
				return null;
			}
			int challengeLevelId = strongholdData.StrongholdConfig.ChallengeLevelId;
			List<FlagChallengeStrongholdData> levelStrongholdDataList = this.GetLevelStrongholdDataList(challengeLevelId);
			int? result = null;
			foreach (FlagChallengeStrongholdData flagChallengeStrongholdData in levelStrongholdDataList)
			{
				if (flagChallengeStrongholdData.StrongholdConfig.MonsterLevel < strongholdData.StrongholdConfig.MonsterLevel && !flagChallengeStrongholdData.IsPass && (result == null || flagChallengeStrongholdData.StrongholdConfig.MonsterLevel < this.GetStrongholdData(result.Value).StrongholdConfig.MonsterLevel))
				{
					result = new int?(flagChallengeStrongholdData.Id);
				}
			}
			return result;
		}

		// Token: 0x0602F810 RID: 194576 RVA: 0x00D3FE30 File Offset: 0x00D3E030
		private void InitRoleLevelData()
		{
			this.LevelInfo = new FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
		}

		// Token: 0x0602F811 RID: 194577 RVA: 0x00D3FE4B File Offset: 0x00D3E04B
		[NullableContext(2)]
		private void ParseRoleLevelData(FlagChallengeRoleLevelInfo roleLevel)
		{
			if (roleLevel == null)
			{
				return;
			}
			this.LevelInfo.Level = roleLevel.PerLevel;
			this.LevelInfo.Exp = roleLevel.PerExp;
		}

		// Token: 0x0602F812 RID: 194578 RVA: 0x00D3FE74 File Offset: 0x00D3E074
		public void UpdateRoleLevelData(FlagChallengeRoleLevelInfo roleLevel)
		{
			int level = this.LevelInfo.Level;
			int perLevel = roleLevel.PerLevel;
			this.LevelInfo.Level = perLevel;
			this.LevelInfo.Exp = roleLevel.PerExp;
			if (level == perLevel)
			{
				return;
			}
			List<int> buffListByLevelRange = this.GetBuffListByLevelRange(level, perLevel);
			if (buffListByLevelRange != null && buffListByLevelRange.Count > 0)
			{
				this.SetBuffNewlyUnlocked(true);
				foreach (int buffId in buffListByLevelRange)
				{
					this.SetBuffNewlyUnlockedState(buffId, true);
				}
				EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeBuffNewlyUnlock, this.ActivityId);
				EventSystem.Instance.Emit(EEventName.OnFlagChallengeBattleBuffNewlyUnlock);
			}
		}

		// Token: 0x0602F813 RID: 194579 RVA: 0x00D3FF3C File Offset: 0x00D3E13C
		public int GetFixedLevel()
		{
			return this.LevelInfo.Level;
		}

		// Token: 0x0602F814 RID: 194580 RVA: 0x00D3FF49 File Offset: 0x00D3E149
		public int GetFixedLevelExp()
		{
			return this.LevelInfo.Exp;
		}

		// Token: 0x0602F815 RID: 194581 RVA: 0x00D3FF56 File Offset: 0x00D3E156
		public int GetTempLevel()
		{
			return 0;
		}

		// Token: 0x0602F816 RID: 194582 RVA: 0x00D3FF59 File Offset: 0x00D3E159
		public int GetTempLevelExp()
		{
			return 0;
		}

		// Token: 0x0602F817 RID: 194583 RVA: 0x00D3FF5C File Offset: 0x00D3E15C
		public int GetTotalLevel()
		{
			return this.LevelInfo.Level;
		}

		// Token: 0x0602F818 RID: 194584 RVA: 0x00D3FF69 File Offset: 0x00D3E169
		public int GetTotalLevelExp()
		{
			return this.LevelInfo.Exp;
		}

		// Token: 0x0602F819 RID: 194585 RVA: 0x00D3FF78 File Offset: 0x00D3E178
		private void InitFormationInfo()
		{
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FlagChallengeFormationRoleIds, null);
			if (player != null)
			{
				this.FormationRoleIdSet = player;
			}
		}

		// Token: 0x0602F81A RID: 194586 RVA: 0x00D3FF9B File Offset: 0x00D3E19B
		public void SaveFormationInfo(HashSet<int> roleIdSet)
		{
			this.FormationRoleIdSet = new HashSet<int>(roleIdSet);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FlagChallengeFormationRoleIds, this.FormationRoleIdSet);
		}

		// Token: 0x0602F81B RID: 194587 RVA: 0x00D3FFBA File Offset: 0x00D3E1BA
		public HashSet<int> GetFormationInfo()
		{
			return this.FormationRoleIdSet;
		}

		// Token: 0x0602F81C RID: 194588 RVA: 0x00D3FFC4 File Offset: 0x00D3E1C4
		private void InitBuffData()
		{
			foreach (FlagChallengeRoleBuff flagChallengeRoleBuff in (FlagChallengeConfig.Instance.GetRoleBuffConfigListByActivityId(this.ActivityId) ?? new List<FlagChallengeRoleBuff>()))
			{
				int id = flagChallengeRoleBuff.Id;
				FlagChallengeBuffData flagChallengeBuffData = new FlagChallengeBuffData(id);
				this.BuffDataMap[id] = flagChallengeBuffData;
				this.BuffDataList.Add(flagChallengeBuffData);
			}
			this.BuffDataList.Sort((FlagChallengeBuffData a, FlagChallengeBuffData b) => a.Id - b.Id);
			for (int i = 1; i < this.BuffDataList.Count; i++)
			{
				FlagChallengeBuffData flagChallengeBuffData2 = this.BuffDataList[i];
				FlagChallengeBuffData flagChallengeBuffData3 = this.BuffDataList[i - 1];
				flagChallengeBuffData2.SetStartLevel(flagChallengeBuffData3.GetEndLevel() + 1);
				flagChallengeBuffData2.SetIndex(i);
			}
		}

		// Token: 0x0602F81D RID: 194589 RVA: 0x00D400C0 File Offset: 0x00D3E2C0
		[NullableContext(2)]
		public FlagChallengeBuffData GetBuffData(int id)
		{
			FlagChallengeBuffData result;
			this.BuffDataMap.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x0602F81E RID: 194590 RVA: 0x00D400DD File Offset: 0x00D3E2DD
		public List<FlagChallengeBuffData> GetBuffDataList()
		{
			return this.BuffDataList;
		}

		// Token: 0x0602F81F RID: 194591 RVA: 0x00D400E8 File Offset: 0x00D3E2E8
		public FlagChallengeBuffData GetBuffDataByLevel(int level)
		{
			FlagChallengeBuffData flagChallengeBuffData = null;
			foreach (FlagChallengeBuffData flagChallengeBuffData2 in this.BuffDataList)
			{
				if (flagChallengeBuffData2.GetStartLevel() <= level && flagChallengeBuffData2.GetEndLevel() >= level)
				{
					flagChallengeBuffData = flagChallengeBuffData2;
					break;
				}
			}
			if (flagChallengeBuffData == null)
			{
				return this.BuffDataList[this.BuffDataList.Count - 1];
			}
			return flagChallengeBuffData;
		}

		// Token: 0x0602F820 RID: 194592 RVA: 0x00D4016C File Offset: 0x00D3E36C
		private List<int> GetBuffListByLevelRange(int oldLevel, int newLevel)
		{
			List<int> list = new List<int>();
			foreach (FlagChallengeBuffData flagChallengeBuffData in this.BuffDataList)
			{
				if (flagChallengeBuffData.GetEndLevel() > oldLevel && flagChallengeBuffData.GetEndLevel() <= newLevel)
				{
					list.Add(flagChallengeBuffData.Id);
				}
			}
			return list;
		}

		// Token: 0x0602F821 RID: 194593 RVA: 0x00D401E0 File Offset: 0x00D3E3E0
		public void CheckBuffStatusChange(int oldLevel, int newLevel)
		{
			List<FlagChallengeBuffActiveTipsInfo> buffActiveTipsInfoListByLv = this.GetBuffActiveTipsInfoListByLv(oldLevel, newLevel);
			if (buffActiveTipsInfoListByLv.Count <= 0)
			{
				return;
			}
			this.BuffActiveTipsList.AddRange(buffActiveTipsInfoListByLv);
			EUiViewName flagChallengeBuffActiveTips = EUiViewName.FlagChallengeBuffActiveTips;
			if (UiManager.Instance.IsViewOpen(flagChallengeBuffActiveTips))
			{
				return;
			}
			FlagChallengeController.Instance.OpenBuffActiveTipsView(this.ActivityId);
		}

		// Token: 0x0602F822 RID: 194594 RVA: 0x00D40230 File Offset: 0x00D3E430
		public List<FlagChallengeBuffActiveTipsInfo> GetBuffActiveTipsInfoListByLv(int oldLevel, int newLevel)
		{
			if (oldLevel >= newLevel)
			{
				return new List<FlagChallengeBuffActiveTipsInfo>();
			}
			List<FlagChallengeBuffActiveTipsInfo> list = new List<FlagChallengeBuffActiveTipsInfo>();
			foreach (FlagChallengeBuffData flagChallengeBuffData in this.GetBuffDataList())
			{
				if (oldLevel < flagChallengeBuffData.GetEndLevel())
				{
					if (newLevel < flagChallengeBuffData.GetEndLevel())
					{
						break;
					}
					list.Add(new FlagChallengeBuffActiveTipsInfo
					{
						BuffId = flagChallengeBuffData.Id,
						State = flagChallengeBuffData.GetBuffStatus()
					});
				}
			}
			return list;
		}

		// Token: 0x0602F823 RID: 194595 RVA: 0x00D402C4 File Offset: 0x00D3E4C4
		public List<FlagChallengeBuffActiveTipsInfo> GetBuffActiveTipsList()
		{
			return this.BuffActiveTipsList;
		}

		// Token: 0x0602F824 RID: 194596 RVA: 0x00D402CC File Offset: 0x00D3E4CC
		public void ClearBuffActiveTipsList()
		{
			this.BuffActiveTipsList.Clear();
		}

		// Token: 0x0602F825 RID: 194597 RVA: 0x00D402D9 File Offset: 0x00D3E4D9
		private ServerStorageSet GetNewlyUnlockedLevelIds()
		{
			return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FlagChallengeNewlyUnlockedLevelIds) as ServerStorageSet;
		}

		// Token: 0x0602F826 RID: 194598 RVA: 0x00D402EC File Offset: 0x00D3E4EC
		public bool HasLevelNewlyUnlocked()
		{
			return this.GetNewlyUnlockedLevelIds().Size() > 0;
		}

		// Token: 0x0602F827 RID: 194599 RVA: 0x00D402FC File Offset: 0x00D3E4FC
		public bool IsLevelNewlyUnlocked(int levelId)
		{
			return this.GetNewlyUnlockedLevelIds().Has(levelId);
		}

		// Token: 0x0602F828 RID: 194600 RVA: 0x00D4030C File Offset: 0x00D3E50C
		public void SetLevelNewlyUnlocked(int levelId, bool value)
		{
			ServerStorageSet newlyUnlockedLevelIds = this.GetNewlyUnlockedLevelIds();
			if (!value)
			{
				if (!newlyUnlockedLevelIds.Has(levelId))
				{
					return;
				}
				newlyUnlockedLevelIds.Remove(levelId);
			}
			else
			{
				newlyUnlockedLevelIds.Add(levelId);
			}
			EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeLevelNewlyUnlock, levelId);
			EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeTaskUpdate, this.ActivityId);
		}

		// Token: 0x0602F829 RID: 194601 RVA: 0x00D40364 File Offset: 0x00D3E564
		public bool HasBuffNewlyUnlocked()
		{
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FlagChallengeNewlyUnlockedBuff) as ServerStorageBoolean).Get().GetValueOrDefault();
		}

		// Token: 0x0602F82A RID: 194602 RVA: 0x00D40390 File Offset: 0x00D3E590
		public void SetBuffNewlyUnlocked(bool value)
		{
			ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FlagChallengeNewlyUnlockedBuff) as ServerStorageBoolean;
			if (serverStorageBoolean.Get().GetValueOrDefault() == value)
			{
				return;
			}
			serverStorageBoolean.Set(new bool?(value));
			EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeBuffNewlyUnlock, this.ActivityId);
			EventSystem.Instance.Emit(EEventName.OnFlagChallengeBattleBuffNewlyUnlock);
		}

		// Token: 0x0602F82B RID: 194603 RVA: 0x00D403F3 File Offset: 0x00D3E5F3
		public ServerStorageSet GetNewlyUnlockedBuffIds()
		{
			return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FlagChallengeNewlyUnlockedBuffIds) as ServerStorageSet;
		}

		// Token: 0x0602F82C RID: 194604 RVA: 0x00D40406 File Offset: 0x00D3E606
		public bool IsBuffNewlyUnlocked(int buffId)
		{
			return this.GetNewlyUnlockedBuffIds().Has(buffId);
		}

		// Token: 0x0602F82D RID: 194605 RVA: 0x00D40414 File Offset: 0x00D3E614
		public void SetBuffNewlyUnlockedState(int buffId, bool value)
		{
			ServerStorageSet newlyUnlockedBuffIds = this.GetNewlyUnlockedBuffIds();
			if (!value)
			{
				if (!newlyUnlockedBuffIds.Has(buffId))
				{
					return;
				}
				newlyUnlockedBuffIds.Remove(buffId);
			}
			else
			{
				newlyUnlockedBuffIds.Add(buffId);
			}
			EventSystem.Instance.Emit<int>(EEventName.OnFlagChallengeBuffNewlyUnlockHintChanged, buffId);
		}

		// Token: 0x0602F82E RID: 194606 RVA: 0x00D40456 File Offset: 0x00D3E656
		public void ClearBuffNewlyUnlocked()
		{
			this.GetNewlyUnlockedBuffIds().Overwrite(new HashSet<int>());
		}

		// Token: 0x0401926C RID: 103020
		private readonly List<FlagChallengeTaskData> TaskDataList = new List<FlagChallengeTaskData>();

		// Token: 0x0401926D RID: 103021
		private readonly List<FlagChallengeLevelData> LevelDataList = new List<FlagChallengeLevelData>();

		// Token: 0x0401926E RID: 103022
		private readonly Dictionary<int, FlagChallengeLevelData> LevelDataMap = new Dictionary<int, FlagChallengeLevelData>();

		// Token: 0x0401926F RID: 103023
		private FlagChallengeRoleLevelInfo LevelInfo;

		// Token: 0x04019270 RID: 103024
		private bool IsInited;

		// Token: 0x04019271 RID: 103025
		private int ActivityIdIntl;

		// Token: 0x04019272 RID: 103026
		private HashSet<int> FormationRoleIdSet = new HashSet<int>();

		// Token: 0x04019273 RID: 103027
		private readonly List<FlagChallengeBuffData> BuffDataList = new List<FlagChallengeBuffData>();

		// Token: 0x04019274 RID: 103028
		private readonly Dictionary<int, FlagChallengeBuffData> BuffDataMap = new Dictionary<int, FlagChallengeBuffData>();

		// Token: 0x04019275 RID: 103029
		private readonly List<FlagChallengeBuffActiveTipsInfo> BuffActiveTipsList = new List<FlagChallengeBuffActiveTipsInfo>();

		// Token: 0x04019276 RID: 103030
		private readonly Dictionary<int, List<FlagChallengeStrongholdData>> Level2Strongholds = new Dictionary<int, List<FlagChallengeStrongholdData>>();

		// Token: 0x04019277 RID: 103031
		private readonly Dictionary<int, FlagChallengeStrongholdData> StrongholdMap = new Dictionary<int, FlagChallengeStrongholdData>();

		// Token: 0x04019278 RID: 103032
		private readonly Dictionary<int, List<FlagChallengeAreaData>> Level2Areas = new Dictionary<int, List<FlagChallengeAreaData>>();

		// Token: 0x04019279 RID: 103033
		private readonly Dictionary<int, FlagChallengeAreaData> AreaMap = new Dictionary<int, FlagChallengeAreaData>();

		// Token: 0x0401927A RID: 103034
		private readonly Dictionary<int, List<FlagChallengeStrongholdData>> Area2Strongholds = new Dictionary<int, List<FlagChallengeStrongholdData>>();

		// Token: 0x0401927B RID: 103035
		private readonly Dictionary<int, int> MarkId2StrongholdId = new Dictionary<int, int>();

		// Token: 0x0401927C RID: 103036
		private int? MainViewSelectLevelId;
	}
}
