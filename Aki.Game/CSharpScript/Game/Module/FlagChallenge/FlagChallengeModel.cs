using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A40 RID: 23104
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class FlagChallengeModel : ModelBase
	{
		// Token: 0x0603A984 RID: 240004 RVA: 0x00DF21A4 File Offset: 0x00DF03A4
		public void ParseActivityData(int activityId, FlagChallengeActivityInfo activityData)
		{
			FlagChallengeData flagChallengeData;
			if (!this.FlagChallengeDataMap.TryGetValue(activityId, out flagChallengeData))
			{
				flagChallengeData = new FlagChallengeData();
				flagChallengeData.ActivityId = activityId;
				this.FlagChallengeDataMap[activityId] = flagChallengeData;
			}
			flagChallengeData.ParseActivityData(activityData);
			this.UpdateTeleportData(activityData.UnlockTeleporterId);
		}

		// Token: 0x0603A985 RID: 240005 RVA: 0x00DF21F0 File Offset: 0x00DF03F0
		[NullableContext(2)]
		public FlagChallengeData GetFlagChallengeData(int activityId)
		{
			FlagChallengeData result;
			this.FlagChallengeDataMap.TryGetValue(activityId, out result);
			return result;
		}

		// Token: 0x0603A986 RID: 240006 RVA: 0x00DF2210 File Offset: 0x00DF0410
		public void UpdateTaskData(IList<ConditionTask> tasks)
		{
			foreach (ConditionTask conditionTask in tasks)
			{
				FlagChallengeData flagChallengeData = this.GetFlagChallengeData(FlagChallengeConfig.Instance.GetTaskConfig(conditionTask.Id).Value.ActivityId);
				if (flagChallengeData != null)
				{
					flagChallengeData.UpdateTaskData(conditionTask);
				}
			}
		}

		// Token: 0x0603A987 RID: 240007 RVA: 0x00DF2284 File Offset: 0x00DF0484
		public void UpdateLevelData(IList<FlagChallengeLevelInfo> levels)
		{
			foreach (FlagChallengeLevelInfo flagChallengeLevelInfo in levels)
			{
				FlagChallengeData flagChallengeData = this.GetFlagChallengeData(FlagChallengeConfig.Instance.GetLevelConfig(flagChallengeLevelInfo.Id).Value.ActivityId);
				if (flagChallengeData != null)
				{
					flagChallengeData.UpdateLevelData(flagChallengeLevelInfo);
				}
			}
		}

		// Token: 0x0603A988 RID: 240008 RVA: 0x00DF22F8 File Offset: 0x00DF04F8
		public void UpdateStrongholdData(IList<FlagStrongholdInfo> strongholds)
		{
			foreach (FlagStrongholdInfo flagStrongholdInfo in strongholds)
			{
				FlagStronghold? strongholdConfig = FlagChallengeConfig.Instance.GetStrongholdConfig(flagStrongholdInfo.Id);
				FlagChallengeLevel? levelConfig = FlagChallengeConfig.Instance.GetLevelConfig(strongholdConfig.Value.ChallengeLevelId);
				FlagChallengeData flagChallengeData = this.GetFlagChallengeData(levelConfig.Value.ActivityId);
				if (flagChallengeData != null)
				{
					flagChallengeData.UpdateStrongholdData(levelConfig.Value.Id, flagStrongholdInfo);
				}
			}
			EventSystem.Instance.Emit(EEventName.OnFlagChallengeUpdateStrongholdData);
		}

		// Token: 0x0603A989 RID: 240009 RVA: 0x00DF23A8 File Offset: 0x00DF05A8
		[NullableContext(2)]
		public FlagChallengeStrongholdData GetStrongholdData(int strongholdId)
		{
			FlagStronghold? strongholdConfig = FlagChallengeConfig.Instance.GetStrongholdConfig(strongholdId);
			FlagChallengeData flagChallengeData = this.GetFlagChallengeData(FlagChallengeConfig.Instance.GetLevelConfig(strongholdConfig.Value.ChallengeLevelId).Value.ActivityId);
			if (flagChallengeData == null)
			{
				return null;
			}
			return flagChallengeData.GetStrongholdData(strongholdId);
		}

		// Token: 0x0603A98A RID: 240010 RVA: 0x00DF23FC File Offset: 0x00DF05FC
		public void UpdateRoleLevelData(int activityId, FlagChallengeRoleLevelInfo roleLevel)
		{
			this.GetFlagChallengeData(activityId).UpdateRoleLevelData(roleLevel);
		}

		// Token: 0x0603A98B RID: 240011 RVA: 0x00DF240B File Offset: 0x00DF060B
		public bool CheckActivityTabRedoDotState(int activityId)
		{
			return this.HasCanReceiveTask(activityId) || this.HasNewUnlockLevel(activityId);
		}

		// Token: 0x0603A98C RID: 240012 RVA: 0x00DF2420 File Offset: 0x00DF0620
		public bool HasCanReceiveTask(int activityId)
		{
			FlagChallengeData flagChallengeData = this.GetFlagChallengeData(activityId);
			return flagChallengeData != null && flagChallengeData.HasCanReceiveTask();
		}

		// Token: 0x0603A98D RID: 240013 RVA: 0x00DF2440 File Offset: 0x00DF0640
		public void SaveFormationInfo(int activityId, HashSet<int> roleIdSet)
		{
			FlagChallengeData flagChallengeData = this.GetFlagChallengeData(activityId);
			if (flagChallengeData == null)
			{
				return;
			}
			flagChallengeData.SaveFormationInfo(roleIdSet);
		}

		// Token: 0x0603A98E RID: 240014 RVA: 0x00DF2454 File Offset: 0x00DF0654
		public bool HasNewUnlockLevel(int activityId)
		{
			FlagChallengeData flagChallengeData = this.GetFlagChallengeData(activityId);
			return flagChallengeData != null && flagChallengeData.HasLevelNewlyUnlocked();
		}

		// Token: 0x0603A98F RID: 240015 RVA: 0x00DF2474 File Offset: 0x00DF0674
		public EFlagChallengeLevelDiffType GetLevelDiffType(int activityId, int compareLevel, int? playerLevel = null)
		{
			int num = (playerLevel ?? this.GetFixedLevel(activityId)) - compareLevel;
			IReadOnlyList<FlagChallengeLevelDiffShow> levelDiffShowConfigList = FlagChallengeConfig.Instance.GetLevelDiffShowConfigList();
			EFlagChallengeLevelDiffType eflagChallengeLevelDiffType = EFlagChallengeLevelDiffType.Easy;
			if (levelDiffShowConfigList == null)
			{
				return eflagChallengeLevelDiffType;
			}
			foreach (FlagChallengeLevelDiffShow flagChallengeLevelDiffShow in levelDiffShowConfigList)
			{
				if (num >= flagChallengeLevelDiffShow.LevelDiffLower && num < flagChallengeLevelDiffShow.LevelDiffUpper)
				{
					eflagChallengeLevelDiffType = (EFlagChallengeLevelDiffType)flagChallengeLevelDiffShow.LevelPattern;
					if (eflagChallengeLevelDiffType > EFlagChallengeLevelDiffType.Hard)
					{
						eflagChallengeLevelDiffType = EFlagChallengeLevelDiffType.Hard;
						break;
					}
					if (eflagChallengeLevelDiffType < EFlagChallengeLevelDiffType.Easy)
					{
						eflagChallengeLevelDiffType = EFlagChallengeLevelDiffType.Easy;
						break;
					}
					break;
				}
			}
			return eflagChallengeLevelDiffType;
		}

		// Token: 0x0603A990 RID: 240016 RVA: 0x00DF2518 File Offset: 0x00DF0718
		[NullableContext(2)]
		public int GetLevelRecommendStrongholdId(int activityId, int levelId, int[] preferAreaIds = null)
		{
			FlagChallengeData flagChallengeData = this.GetFlagChallengeData(activityId);
			if (preferAreaIds != null)
			{
				foreach (int areaId in preferAreaIds)
				{
					if (!flagChallengeData.IsAreaAllBossStrongholdPass(areaId))
					{
						return this.GetAreaRecommendStrongholdId(activityId, areaId);
					}
				}
			}
			List<FlagChallengeAreaData> levelAreaDataList = flagChallengeData.GetLevelAreaDataList(levelId);
			int count = levelAreaDataList.Count;
			for (int j = 0; j < levelAreaDataList.Count; j++)
			{
				FlagChallengeAreaData flagChallengeAreaData = levelAreaDataList[j];
				if (!flagChallengeData.IsAreaAllBossStrongholdPass(flagChallengeAreaData.Id) || j == count - 1)
				{
					return this.GetAreaRecommendStrongholdId(activityId, flagChallengeAreaData.Id);
				}
			}
			return flagChallengeData.GetLevelStrongholdDataList(levelId)[0].Id;
		}

		// Token: 0x0603A991 RID: 240017 RVA: 0x00DF25C4 File Offset: 0x00DF07C4
		public int GetAreaRecommendStrongholdId(int activityId, int areaId)
		{
			List<FlagChallengeStrongholdData> areaStrongholdDataList = this.GetFlagChallengeData(activityId).GetAreaStrongholdDataList(areaId);
			bool flag = false;
			int? num = null;
			foreach (FlagChallengeStrongholdData flagChallengeStrongholdData in areaStrongholdDataList)
			{
				if (!flagChallengeStrongholdData.IsBossStronghold())
				{
					if (!flagChallengeStrongholdData.IsPass)
					{
						if (flagChallengeStrongholdData.IsUnlocked())
						{
							return flagChallengeStrongholdData.Id;
						}
						flag = true;
					}
					else
					{
						num = new int?(flagChallengeStrongholdData.Id);
					}
				}
			}
			if (flag && num != null)
			{
				return num.Value;
			}
			foreach (FlagChallengeStrongholdData flagChallengeStrongholdData2 in areaStrongholdDataList)
			{
				if (flagChallengeStrongholdData2.IsBossStronghold())
				{
					if (!flagChallengeStrongholdData2.IsPass)
					{
						if (flagChallengeStrongholdData2.IsUnlocked())
						{
							return flagChallengeStrongholdData2.Id;
						}
					}
					else
					{
						num = new int?(flagChallengeStrongholdData2.Id);
					}
				}
			}
			if (num != null)
			{
				return num.Value;
			}
			return areaStrongholdDataList[0].Id;
		}

		// Token: 0x0603A992 RID: 240018 RVA: 0x00DF26FC File Offset: 0x00DF08FC
		public int? GetRecommendLevel(int activityId, bool fallbackToDefault = true)
		{
			List<FlagChallengeLevelData> levelDataList = this.GetFlagChallengeData(activityId).GetLevelDataList(false);
			FlagChallengeLevelData flagChallengeLevelData = null;
			foreach (FlagChallengeLevelData flagChallengeLevelData2 in levelDataList)
			{
				if (flagChallengeLevelData2.IsUnlocked())
				{
					return new int?(flagChallengeLevelData2.Id);
				}
				if (flagChallengeLevelData2.IsCompleted())
				{
					flagChallengeLevelData = flagChallengeLevelData2;
				}
			}
			if (fallbackToDefault)
			{
				return new int?((flagChallengeLevelData != null) ? flagChallengeLevelData.Id : levelDataList[0].Id);
			}
			return null;
		}

		// Token: 0x0603A993 RID: 240019 RVA: 0x00DF27A4 File Offset: 0x00DF09A4
		public int GetFixedLevel(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetFixedLevel();
			}
			return this.GetFlagChallengeData(activityId).GetFixedLevel();
		}

		// Token: 0x0603A994 RID: 240020 RVA: 0x00DF27C9 File Offset: 0x00DF09C9
		public int GetFixedLevelExp(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetFixedLevelExp();
			}
			return this.GetFlagChallengeData(activityId).GetFixedLevelExp();
		}

		// Token: 0x0603A995 RID: 240021 RVA: 0x00DF27EE File Offset: 0x00DF09EE
		public int GetCalculatedLevel(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetCalculatedLevel();
			}
			return this.GetFlagChallengeData(activityId).GetFixedLevel();
		}

		// Token: 0x0603A996 RID: 240022 RVA: 0x00DF2813 File Offset: 0x00DF0A13
		public int GetCalculatedLevelExp(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetCalculatedLevelExp();
			}
			return this.GetFlagChallengeData(activityId).GetFixedLevelExp();
		}

		// Token: 0x0603A997 RID: 240023 RVA: 0x00DF2838 File Offset: 0x00DF0A38
		public int GetTempLevel(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetTempLevel();
			}
			return this.GetFlagChallengeData(activityId).GetTempLevel();
		}

		// Token: 0x0603A998 RID: 240024 RVA: 0x00DF285D File Offset: 0x00DF0A5D
		public int GetTempLevelExp(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetTempLevelExp();
			}
			return this.GetFlagChallengeData(activityId).GetTempLevelExp();
		}

		// Token: 0x0603A999 RID: 240025 RVA: 0x00DF2882 File Offset: 0x00DF0A82
		public int GetTotalLevel(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetTotalLevel();
			}
			return this.GetFlagChallengeData(activityId).GetTotalLevel();
		}

		// Token: 0x0603A99A RID: 240026 RVA: 0x00DF28A7 File Offset: 0x00DF0AA7
		public int GetTotalLevelExp(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetTotalLevelExp();
			}
			return this.GetFlagChallengeData(activityId).GetTotalLevelExp();
		}

		// Token: 0x0603A99B RID: 240027 RVA: 0x00DF28CC File Offset: 0x00DF0ACC
		public int GetLevelExp(int activityId, int level)
		{
			Dictionary<int, int> dictionary;
			if (!this.LevelExpCache.TryGetValue(activityId, out dictionary))
			{
				dictionary = new Dictionary<int, int>();
				this.LevelExpCache[activityId] = dictionary;
			}
			int result;
			if (dictionary.TryGetValue(level, out result))
			{
				return result;
			}
			FlagChallengeRoleLevel? roleLevelConfigByActivityIdAndLevel = FlagChallengeConfig.Instance.GetRoleLevelConfigByActivityIdAndLevel(activityId, level);
			dictionary[level] = roleLevelConfigByActivityIdAndLevel.Value.Experience;
			return roleLevelConfigByActivityIdAndLevel.Value.Experience;
		}

		// Token: 0x0603A99C RID: 240028 RVA: 0x00DF293C File Offset: 0x00DF0B3C
		public int GetMaxLevel(int activityId)
		{
			int num;
			if (!this.MaxLevelCache.TryGetValue(activityId, out num))
			{
				num = FlagChallengeConfig.Instance.GetRoleLevelConfigListByActivityId(activityId).Count - 1;
				this.MaxLevelCache[activityId] = num;
			}
			return num;
		}

		// Token: 0x0603A99D RID: 240029 RVA: 0x00DF297C File Offset: 0x00DF0B7C
		public int GetMaxLevelExp(int activityId)
		{
			int experience;
			if (!this.MaxLevelExpCache.TryGetValue(activityId, out experience))
			{
				int maxLevel = this.GetMaxLevel(activityId);
				experience = FlagChallengeConfig.Instance.GetRoleLevelConfigByActivityIdAndLevel(activityId, maxLevel).Value.Experience;
				this.MaxLevelExpCache[activityId] = experience;
			}
			return experience;
		}

		// Token: 0x0603A99E RID: 240030 RVA: 0x00DF29CC File Offset: 0x00DF0BCC
		public int GetTargetLevelUpExp(int activityId, int? targetLevel = null)
		{
			int num = targetLevel ?? this.GetFixedLevel(activityId);
			int maxLevel = this.GetMaxLevel(activityId);
			if (num >= maxLevel)
			{
				num = maxLevel - 1;
			}
			int levelExp = this.GetLevelExp(activityId, num);
			int levelExp2 = this.GetLevelExp(activityId, num + 1);
			return Math.Max(0, levelExp2 - levelExp);
		}

		// Token: 0x0603A99F RID: 240031 RVA: 0x00DF2A24 File Offset: 0x00DF0C24
		public int GetTargetLevelExp(int activityId, int? targetLevel = null, int? targetLevelExp = null)
		{
			int num = targetLevel ?? this.GetFixedLevel(activityId);
			int num2 = targetLevelExp ?? this.GetFixedLevelExp(activityId);
			if (num == 1 || num == 0)
			{
				return num2;
			}
			if (num == this.GetMaxLevel(activityId))
			{
				return this.GetTargetLevelUpExp(activityId, new int?(num));
			}
			int levelExp = this.GetLevelExp(activityId, num);
			return Math.Max(0, num2 - levelExp);
		}

		// Token: 0x0603A9A0 RID: 240032 RVA: 0x00DF2A9C File Offset: 0x00DF0C9C
		public float GetTargetLevelExpProgress(int activityId, int? targetLevel = null, int? targetLevelExp = null)
		{
			int num = targetLevel ?? this.GetFixedLevel(activityId);
			if (num == this.GetMaxLevel(activityId))
			{
				return 1f;
			}
			int targetLevelExp2 = this.GetTargetLevelExp(activityId, targetLevel, targetLevelExp);
			int targetLevelUpExp = this.GetTargetLevelUpExp(activityId, new int?(num));
			if (targetLevelUpExp != 0)
			{
				return (float)targetLevelExp2 / (float)targetLevelUpExp;
			}
			return 0f;
		}

		// Token: 0x0603A9A1 RID: 240033 RVA: 0x00DF2AFB File Offset: 0x00DF0CFB
		public bool IsReachTargetLevel(int activityId, int targetLv)
		{
			return this.GetTotalLevel(activityId) >= targetLv;
		}

		// Token: 0x0603A9A2 RID: 240034 RVA: 0x00DF2B0C File Offset: 0x00DF0D0C
		public void UpdateTeleportData(IList<int> teleportIds)
		{
			foreach (int item in teleportIds)
			{
				this.UnlockedTeleportId.Add(item);
			}
		}

		// Token: 0x0603A9A3 RID: 240035 RVA: 0x00DF2B5C File Offset: 0x00DF0D5C
		public bool IsTeleportUnlock(int teleportId)
		{
			return this.UnlockedTeleportId.Contains(teleportId);
		}

		// Token: 0x0603A9A4 RID: 240036 RVA: 0x00DF2B6C File Offset: 0x00DF0D6C
		public List<FlagChallengeBuffAddItemData> GetAllRoleAttrAddList(int activityId)
		{
			int totalLevel = this.GetTotalLevel(activityId);
			IReadOnlyList<FlagChallengeRoleGrowth> roleGrowthConfigListByActivityId = FlagChallengeConfig.Instance.GetRoleGrowthConfigListByActivityId(activityId);
			if (roleGrowthConfigListByActivityId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "未找到角色成长配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return new List<FlagChallengeBuffAddItemData>();
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < roleGrowthConfigListByActivityId.Count; i++)
			{
				FlagChallengeRoleGrowth flagChallengeRoleGrowth = roleGrowthConfigListByActivityId[i];
				if (totalLevel <= flagChallengeRoleGrowth.Level)
				{
					break;
				}
				FlagChallengeRoleGrowth? flagChallengeRoleGrowth2 = (i + 1 < roleGrowthConfigListByActivityId.Count) ? new FlagChallengeRoleGrowth?(roleGrowthConfigListByActivityId[i + 1]) : null;
				int num4 = (flagChallengeRoleGrowth2 != null) ? (Math.Min(totalLevel, flagChallengeRoleGrowth2.Value.Level) - flagChallengeRoleGrowth.Level) : (totalLevel - flagChallengeRoleGrowth.Level);
				num += flagChallengeRoleGrowth.LifeMaxRatio * num4;
				num2 += flagChallengeRoleGrowth.AtkRatio * num4;
				num3 += flagChallengeRoleGrowth.DefRatio * num4;
			}
			IReadOnlyList<int> allAttrAddIdList = FlagChallengeConfig.Instance.GetAllAttrAddIdList();
			List<int> list = new List<int>
			{
				num,
				num2,
				num3
			};
			List<FlagChallengeBuffAddItemData> list2 = new List<FlagChallengeBuffAddItemData>();
			for (int j = 0; j < list.Count; j++)
			{
				int num5 = list[j];
				int id = allAttrAddIdList[j];
				PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(id);
				List<FlagChallengeBuffAddItemData> list3 = list2;
				FlagChallengeBuffAddItemData flagChallengeBuffAddItemData = new FlagChallengeBuffAddItemData();
				flagChallengeBuffAddItemData.IconPath = (((propertyIndexInfo != null) ? propertyIndexInfo.GetValueOrDefault().Icon : null) ?? "");
				flagChallengeBuffAddItemData.NameKey = (((propertyIndexInfo != null) ? propertyIndexInfo.GetValueOrDefault().Name : null) ?? "");
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("+");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num5 / 100);
				defaultInterpolatedStringHandler.AppendLiteral("%");
				flagChallengeBuffAddItemData.Value = defaultInterpolatedStringHandler.ToStringAndClear();
				list3.Add(flagChallengeBuffAddItemData);
			}
			return list2;
		}

		// Token: 0x0603A9A5 RID: 240037 RVA: 0x00DF2D94 File Offset: 0x00DF0F94
		public unsafe string GetAllRoleAttrAddDesc(int activityId)
		{
			IReadOnlyList<FlagChallengeRoleGrowth> roleGrowthConfigListByActivityId = FlagChallengeConfig.Instance.GetRoleGrowthConfigListByActivityId(activityId);
			if (roleGrowthConfigListByActivityId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FlagChallenge;
				ELogAuthor author = ELogAuthor.LJS;
				string message = "未找到角色成长配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return "";
			}
			int num = this.GetTotalLevel(activityId) + 1;
			FlagChallengeRoleGrowth? flagChallengeRoleGrowth = null;
			for (int i = roleGrowthConfigListByActivityId.Count - 1; i >= 0; i--)
			{
				FlagChallengeRoleGrowth value = roleGrowthConfigListByActivityId[i];
				if (num > value.Level)
				{
					flagChallengeRoleGrowth = new FlagChallengeRoleGrowth?(value);
					break;
				}
			}
			if (flagChallengeRoleGrowth == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.FlagChallenge;
				ELogAuthor author2 = ELogAuthor.LJS;
				string message2 = "未找到角色成长等级区间";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActivityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Level", num);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return "";
			}
			int value2 = flagChallengeRoleGrowth.Value.LifeMaxRatio / 100;
			int value3 = flagChallengeRoleGrowth.Value.AtkRatio / 100;
			int value4 = flagChallengeRoleGrowth.Value.DefRatio / 100;
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Morale_32_Buff_KeepLevel", null);
			string[] array = new string[3];
			int num2 = 0;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value3);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			array[num2] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num3 = 1;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			array[num3] = defaultInterpolatedStringHandler.ToStringAndClear();
			int num4 = 2;
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value4);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			array[num4] = defaultInterpolatedStringHandler.ToStringAndClear();
			return StringUtils.Format(localTextNew, array);
		}

		// Token: 0x17008BF2 RID: 35826
		// (get) Token: 0x0603A9A6 RID: 240038 RVA: 0x00DF2F67 File Offset: 0x00DF1167
		public static FlagChallengeModel Instance
		{
			get
			{
				return FlagChallengeModel._Instance;
			}
		}

		// Token: 0x0603A9A7 RID: 240039 RVA: 0x00DF2F6E File Offset: 0x00DF116E
		public static FlagChallengeModel GetOrCreateInstance()
		{
			if (FlagChallengeModel._Instance == null)
			{
				FlagChallengeModel.CreateInstance();
			}
			return FlagChallengeModel._Instance;
		}

		// Token: 0x0603A9A8 RID: 240040 RVA: 0x00DF2F82 File Offset: 0x00DF1182
		public static bool CreateInstance()
		{
			if (FlagChallengeModel._Instance != null)
			{
				return true;
			}
			FlagChallengeModel._Instance = new FlagChallengeModel();
			return true;
		}

		// Token: 0x0603A9A9 RID: 240041 RVA: 0x00DF2F98 File Offset: 0x00DF1198
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A9AA RID: 240042 RVA: 0x00DF2F9A File Offset: 0x00DF119A
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeModel._Instance = null;
		}

		// Token: 0x0603A9AB RID: 240043 RVA: 0x00DF2FA2 File Offset: 0x00DF11A2
		static FlagChallengeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeModel.CreateStaticDefaultValue), new Action(FlagChallengeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E873 RID: 125043
		private readonly Dictionary<int, FlagChallengeData> FlagChallengeDataMap = new Dictionary<int, FlagChallengeData>();

		// Token: 0x0401E874 RID: 125044
		private readonly Dictionary<int, Dictionary<int, int>> LevelExpCache = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x0401E875 RID: 125045
		private readonly Dictionary<int, int> MaxLevelCache = new Dictionary<int, int>();

		// Token: 0x0401E876 RID: 125046
		private readonly Dictionary<int, int> MaxLevelExpCache = new Dictionary<int, int>();

		// Token: 0x0401E877 RID: 125047
		private readonly HashSet<int> UnlockedTeleportId = new HashSet<int>();

		// Token: 0x0401E878 RID: 125048
		[Nullable(2)]
		private static FlagChallengeModel _Instance;
	}
}
