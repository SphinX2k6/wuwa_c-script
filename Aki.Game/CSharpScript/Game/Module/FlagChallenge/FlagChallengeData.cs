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
	// Token: 0x02005A26 RID: 23078
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeData
	{
		// Token: 0x17008BD7 RID: 35799
		// (get) Token: 0x0603A8A3 RID: 239779 RVA: 0x00DEEE21 File Offset: 0x00DED021
		// (set) Token: 0x0603A8A4 RID: 239780 RVA: 0x00DEEE29 File Offset: 0x00DED029
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

		// Token: 0x0603A8A5 RID: 239781 RVA: 0x00DEEE32 File Offset: 0x00DED032
		public void ParseActivityData(FlagChallengeActivityInfo activityData)
		{
			this.InitData();
			this.ParseTaskData(activityData.ConditionTasks);
			this.ParseLevelData(activityData.FlagChallengeLevelInfos);
			this.ParseStrongHoldData(activityData.FlagStrongholdInfos);
			this.ParseRoleLevelData(activityData.FlagChallengeRoleLevelInfo);
			this.PostParseActivityData();
		}

		// Token: 0x0603A8A6 RID: 239782 RVA: 0x00DEEE70 File Offset: 0x00DED070
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

		// Token: 0x0603A8A7 RID: 239783 RVA: 0x00DEEEE4 File Offset: 0x00DED0E4
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

		// Token: 0x0603A8A8 RID: 239784 RVA: 0x00DEEF0E File Offset: 0x00DED10E
		public int? GetMainViewSelectLevelId()
		{
			return this.MainViewSelectLevelId;
		}

		// Token: 0x0603A8A9 RID: 239785 RVA: 0x00DEEF16 File Offset: 0x00DED116
		public void SetMainViewSelectLevelId(int? id)
		{
			this.MainViewSelectLevelId = id;
		}

		// Token: 0x0603A8AA RID: 239786 RVA: 0x00DEEF20 File Offset: 0x00DED120
		private void ParseTaskData(IList<ConditionTask> tasks)
		{
			foreach (ConditionTask task in tasks)
			{
				this.UpdateTaskData(task);
			}
		}

		// Token: 0x0603A8AB RID: 239787 RVA: 0x00DEEF68 File Offset: 0x00DED168
		public void UpdateTaskData(ConditionTask task)
		{
			this.GetOrCreateTaskData(task.Id).Refresh(task);
		}

		// Token: 0x0603A8AC RID: 239788 RVA: 0x00DEEF7C File Offset: 0x00DED17C
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

		// Token: 0x0603A8AD RID: 239789 RVA: 0x00DEEFA8 File Offset: 0x00DED1A8
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

		// Token: 0x0603A8AE RID: 239790 RVA: 0x00DEF004 File Offset: 0x00DED204
		public List<FlagChallengeTaskData> GetTaskDataList()
		{
			this.TaskDataList.Sort(new Comparison<FlagChallengeTaskData>(this.SortTaskData));
			return this.TaskDataList;
		}

		// Token: 0x0603A8AF RID: 239791 RVA: 0x00DEF024 File Offset: 0x00DED224
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

		// Token: 0x0603A8B0 RID: 239792 RVA: 0x00DEF080 File Offset: 0x00DED280
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

		// Token: 0x0603A8B1 RID: 239793 RVA: 0x00DEF0F0 File Offset: 0x00DED2F0
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

		// Token: 0x0603A8B2 RID: 239794 RVA: 0x00DEF158 File Offset: 0x00DED358
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

		// Token: 0x0603A8B3 RID: 239795 RVA: 0x00DEF1BC File Offset: 0x00DED3BC
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

		// Token: 0x0603A8B4 RID: 239796 RVA: 0x00DEF210 File Offset: 0x00DED410
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

		// Token: 0x0603A8B5 RID: 239797 RVA: 0x00DEF26C File Offset: 0x00DED46C
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

		// Token: 0x0603A8B6 RID: 239798 RVA: 0x00DEF2EC File Offset: 0x00DED4EC
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

		// Token: 0x0603A8B7 RID: 239799 RVA: 0x00DEF354 File Offset: 0x00DED554
		[NullableContext(2)]
		public FlagChallengeLevelData GetLevelData(int id)
		{
			FlagChallengeLevelData result;
			this.LevelDataMap.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x0603A8B8 RID: 239800 RVA: 0x00DEF374 File Offset: 0x00DED574
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

		// Token: 0x0603A8B9 RID: 239801 RVA: 0x00DEF3E0 File Offset: 0x00DED5E0
		private int SortLevelData(FlagChallengeLevelData a, FlagChallengeLevelData b)
		{
			return a.Id - b.Id;
		}

		// Token: 0x0603A8BA RID: 239802 RVA: 0x00DEF3F0 File Offset: 0x00DED5F0
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

		// Token: 0x0603A8BB RID: 239803 RVA: 0x00DEF454 File Offset: 0x00DED654
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

		// Token: 0x0603A8BC RID: 239804 RVA: 0x00DEF4B0 File Offset: 0x00DED6B0
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

		// Token: 0x0603A8BD RID: 239805 RVA: 0x00DEF55C File Offset: 0x00DED75C
		[NullableContext(2)]
		public FlagChallengeAreaData GetAreaData(int areaId)
		{
			FlagChallengeAreaData result;
			this.AreaMap.TryGetValue(areaId, out result);
			return result;
		}

		// Token: 0x0603A8BE RID: 239806 RVA: 0x00DEF57C File Offset: 0x00DED77C
		public List<FlagChallengeAreaData> GetLevelAreaDataList(int levelId)
		{
			List<FlagChallengeAreaData> list;
			this.Level2Areas.TryGetValue(levelId, out list);
			return list ?? new List<FlagChallengeAreaData>();
		}

		// Token: 0x0603A8BF RID: 239807 RVA: 0x00DEF5A4 File Offset: 0x00DED7A4
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

		// Token: 0x0603A8C0 RID: 239808 RVA: 0x00DEF608 File Offset: 0x00DED808
		private void ParseStrongHoldData(IList<FlagStrongholdInfo> strongholds)
		{
			foreach (FlagStrongholdInfo flagStrongholdInfo in strongholds)
			{
				this.UpdateStrongholdData(FlagChallengeConfig.Instance.GetStrongholdConfig(flagStrongholdInfo.Id).Value.ChallengeLevelId, flagStrongholdInfo);
			}
			EventSystem.Instance.Emit(EEventName.OnFlagChallengeUpdateStrongholdData);
		}

		// Token: 0x0603A8C1 RID: 239809 RVA: 0x00DEF680 File Offset: 0x00DED880
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

		// Token: 0x0603A8C2 RID: 239810 RVA: 0x00DEF73C File Offset: 0x00DED93C
		[NullableContext(2)]
		public FlagChallengeStrongholdData GetStrongholdData(int strongholdId)
		{
			FlagChallengeStrongholdData result;
			this.StrongholdMap.TryGetValue(strongholdId, out result);
			return result;
		}

		// Token: 0x0603A8C3 RID: 239811 RVA: 0x00DEF75C File Offset: 0x00DED95C
		public List<FlagChallengeStrongholdData> GetLevelStrongholdDataList(int levelId)
		{
			List<FlagChallengeStrongholdData> list;
			this.Level2Strongholds.TryGetValue(levelId, out list);
			return list ?? new List<FlagChallengeStrongholdData>();
		}

		// Token: 0x0603A8C4 RID: 239812 RVA: 0x00DEF784 File Offset: 0x00DED984
		public List<FlagChallengeStrongholdData> GetAreaStrongholdDataList(int areaId)
		{
			List<FlagChallengeStrongholdData> list;
			this.Area2Strongholds.TryGetValue(areaId, out list);
			return list ?? new List<FlagChallengeStrongholdData>();
		}

		// Token: 0x0603A8C5 RID: 239813 RVA: 0x00DEF7AC File Offset: 0x00DED9AC
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

		// Token: 0x0603A8C6 RID: 239814 RVA: 0x00DEF7D4 File Offset: 0x00DED9D4
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

		// Token: 0x0603A8C7 RID: 239815 RVA: 0x00DEF8AC File Offset: 0x00DEDAAC
		private void InitRoleLevelData()
		{
			this.LevelInfo = new FlagChallengeRoleLevelInfo
			{
				Level = 0,
				Exp = 0
			};
		}

		// Token: 0x0603A8C8 RID: 239816 RVA: 0x00DEF8C7 File Offset: 0x00DEDAC7
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

		// Token: 0x0603A8C9 RID: 239817 RVA: 0x00DEF8F0 File Offset: 0x00DEDAF0
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

		// Token: 0x0603A8CA RID: 239818 RVA: 0x00DEF9B8 File Offset: 0x00DEDBB8
		public int GetFixedLevel()
		{
			return this.LevelInfo.Level;
		}

		// Token: 0x0603A8CB RID: 239819 RVA: 0x00DEF9C5 File Offset: 0x00DEDBC5
		public int GetFixedLevelExp()
		{
			return this.LevelInfo.Exp;
		}

		// Token: 0x0603A8CC RID: 239820 RVA: 0x00DEF9D2 File Offset: 0x00DEDBD2
		public int GetTempLevel()
		{
			return 0;
		}

		// Token: 0x0603A8CD RID: 239821 RVA: 0x00DEF9D5 File Offset: 0x00DEDBD5
		public int GetTempLevelExp()
		{
			return 0;
		}

		// Token: 0x0603A8CE RID: 239822 RVA: 0x00DEF9D8 File Offset: 0x00DEDBD8
		public int GetTotalLevel()
		{
			return this.LevelInfo.Level;
		}

		// Token: 0x0603A8CF RID: 239823 RVA: 0x00DEF9E5 File Offset: 0x00DEDBE5
		public int GetTotalLevelExp()
		{
			return this.LevelInfo.Exp;
		}

		// Token: 0x0603A8D0 RID: 239824 RVA: 0x00DEF9F4 File Offset: 0x00DEDBF4
		private void InitFormationInfo()
		{
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FlagChallengeFormationRoleIds, null);
			if (player != null)
			{
				this.FormationRoleIdSet = player;
			}
		}

		// Token: 0x0603A8D1 RID: 239825 RVA: 0x00DEFA17 File Offset: 0x00DEDC17
		public void SaveFormationInfo(HashSet<int> roleIdSet)
		{
			this.FormationRoleIdSet = new HashSet<int>(roleIdSet);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.FlagChallengeFormationRoleIds, this.FormationRoleIdSet);
		}

		// Token: 0x0603A8D2 RID: 239826 RVA: 0x00DEFA36 File Offset: 0x00DEDC36
		public HashSet<int> GetFormationInfo()
		{
			return this.FormationRoleIdSet;
		}

		// Token: 0x0603A8D3 RID: 239827 RVA: 0x00DEFA40 File Offset: 0x00DEDC40
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

		// Token: 0x0603A8D4 RID: 239828 RVA: 0x00DEFB3C File Offset: 0x00DEDD3C
		[NullableContext(2)]
		public FlagChallengeBuffData GetBuffData(int id)
		{
			FlagChallengeBuffData result;
			this.BuffDataMap.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x0603A8D5 RID: 239829 RVA: 0x00DEFB59 File Offset: 0x00DEDD59
		public List<FlagChallengeBuffData> GetBuffDataList()
		{
			return this.BuffDataList;
		}

		// Token: 0x0603A8D6 RID: 239830 RVA: 0x00DEFB64 File Offset: 0x00DEDD64
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

		// Token: 0x0603A8D7 RID: 239831 RVA: 0x00DEFBE8 File Offset: 0x00DEDDE8
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

		// Token: 0x0603A8D8 RID: 239832 RVA: 0x00DEFC5C File Offset: 0x00DEDE5C
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

		// Token: 0x0603A8D9 RID: 239833 RVA: 0x00DEFCAC File Offset: 0x00DEDEAC
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

		// Token: 0x0603A8DA RID: 239834 RVA: 0x00DEFD40 File Offset: 0x00DEDF40
		public List<FlagChallengeBuffActiveTipsInfo> GetBuffActiveTipsList()
		{
			return this.BuffActiveTipsList;
		}

		// Token: 0x0603A8DB RID: 239835 RVA: 0x00DEFD48 File Offset: 0x00DEDF48
		public void ClearBuffActiveTipsList()
		{
			this.BuffActiveTipsList.Clear();
		}

		// Token: 0x0603A8DC RID: 239836 RVA: 0x00DEFD55 File Offset: 0x00DEDF55
		private ServerStorageSet GetNewlyUnlockedLevelIds()
		{
			return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FlagChallengeNewlyUnlockedLevelIds) as ServerStorageSet;
		}

		// Token: 0x0603A8DD RID: 239837 RVA: 0x00DEFD68 File Offset: 0x00DEDF68
		public bool HasLevelNewlyUnlocked()
		{
			return this.GetNewlyUnlockedLevelIds().Size() > 0;
		}

		// Token: 0x0603A8DE RID: 239838 RVA: 0x00DEFD78 File Offset: 0x00DEDF78
		public bool IsLevelNewlyUnlocked(int levelId)
		{
			return this.GetNewlyUnlockedLevelIds().Has(levelId);
		}

		// Token: 0x0603A8DF RID: 239839 RVA: 0x00DEFD88 File Offset: 0x00DEDF88
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

		// Token: 0x0603A8E0 RID: 239840 RVA: 0x00DEFDE0 File Offset: 0x00DEDFE0
		public bool HasBuffNewlyUnlocked()
		{
			return (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FlagChallengeNewlyUnlockedBuff) as ServerStorageBoolean).Get().GetValueOrDefault();
		}

		// Token: 0x0603A8E1 RID: 239841 RVA: 0x00DEFE0C File Offset: 0x00DEE00C
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

		// Token: 0x0603A8E2 RID: 239842 RVA: 0x00DEFE6F File Offset: 0x00DEE06F
		public ServerStorageSet GetNewlyUnlockedBuffIds()
		{
			return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FlagChallengeNewlyUnlockedBuffIds) as ServerStorageSet;
		}

		// Token: 0x0603A8E3 RID: 239843 RVA: 0x00DEFE82 File Offset: 0x00DEE082
		public bool IsBuffNewlyUnlocked(int buffId)
		{
			return this.GetNewlyUnlockedBuffIds().Has(buffId);
		}

		// Token: 0x0603A8E4 RID: 239844 RVA: 0x00DEFE90 File Offset: 0x00DEE090
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

		// Token: 0x0603A8E5 RID: 239845 RVA: 0x00DEFED2 File Offset: 0x00DEE0D2
		public void ClearBuffNewlyUnlocked()
		{
			this.GetNewlyUnlockedBuffIds().Overwrite(new HashSet<int>());
		}

		// Token: 0x0401E7C5 RID: 124869
		private readonly List<FlagChallengeTaskData> TaskDataList = new List<FlagChallengeTaskData>();

		// Token: 0x0401E7C6 RID: 124870
		private readonly List<FlagChallengeLevelData> LevelDataList = new List<FlagChallengeLevelData>();

		// Token: 0x0401E7C7 RID: 124871
		private readonly Dictionary<int, FlagChallengeLevelData> LevelDataMap = new Dictionary<int, FlagChallengeLevelData>();

		// Token: 0x0401E7C8 RID: 124872
		private FlagChallengeRoleLevelInfo LevelInfo;

		// Token: 0x0401E7C9 RID: 124873
		private bool IsInited;

		// Token: 0x0401E7CA RID: 124874
		private int ActivityIdIntl;

		// Token: 0x0401E7CB RID: 124875
		private HashSet<int> FormationRoleIdSet = new HashSet<int>();

		// Token: 0x0401E7CC RID: 124876
		private readonly List<FlagChallengeBuffData> BuffDataList = new List<FlagChallengeBuffData>();

		// Token: 0x0401E7CD RID: 124877
		private readonly Dictionary<int, FlagChallengeBuffData> BuffDataMap = new Dictionary<int, FlagChallengeBuffData>();

		// Token: 0x0401E7CE RID: 124878
		private readonly List<FlagChallengeBuffActiveTipsInfo> BuffActiveTipsList = new List<FlagChallengeBuffActiveTipsInfo>();

		// Token: 0x0401E7CF RID: 124879
		private readonly Dictionary<int, List<FlagChallengeStrongholdData>> Level2Strongholds = new Dictionary<int, List<FlagChallengeStrongholdData>>();

		// Token: 0x0401E7D0 RID: 124880
		private readonly Dictionary<int, FlagChallengeStrongholdData> StrongholdMap = new Dictionary<int, FlagChallengeStrongholdData>();

		// Token: 0x0401E7D1 RID: 124881
		private readonly Dictionary<int, List<FlagChallengeAreaData>> Level2Areas = new Dictionary<int, List<FlagChallengeAreaData>>();

		// Token: 0x0401E7D2 RID: 124882
		private readonly Dictionary<int, FlagChallengeAreaData> AreaMap = new Dictionary<int, FlagChallengeAreaData>();

		// Token: 0x0401E7D3 RID: 124883
		private readonly Dictionary<int, List<FlagChallengeStrongholdData>> Area2Strongholds = new Dictionary<int, List<FlagChallengeStrongholdData>>();

		// Token: 0x0401E7D4 RID: 124884
		private readonly Dictionary<int, int> MarkId2StrongholdId = new Dictionary<int, int>();

		// Token: 0x0401E7D5 RID: 124885
		private int? MainViewSelectLevelId;
	}
}
