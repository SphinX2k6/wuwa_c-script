using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A1C RID: 18972
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class FlagChallengeModel : ModelBase
	{
		// Token: 0x0602F8CD RID: 194765 RVA: 0x00D42728 File Offset: 0x00D40928
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

		// Token: 0x0602F8CE RID: 194766 RVA: 0x00D42774 File Offset: 0x00D40974
		[NullableContext(2)]
		public FlagChallengeData GetFlagChallengeData(int activityId)
		{
			FlagChallengeData result;
			this.FlagChallengeDataMap.TryGetValue(activityId, out result);
			return result;
		}

		// Token: 0x0602F8CF RID: 194767 RVA: 0x00D42794 File Offset: 0x00D40994
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

		// Token: 0x0602F8D0 RID: 194768 RVA: 0x00D42808 File Offset: 0x00D40A08
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

		// Token: 0x0602F8D1 RID: 194769 RVA: 0x00D4287C File Offset: 0x00D40A7C
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

		// Token: 0x0602F8D2 RID: 194770 RVA: 0x00D4292C File Offset: 0x00D40B2C
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

		// Token: 0x0602F8D3 RID: 194771 RVA: 0x00D42980 File Offset: 0x00D40B80
		public void UpdateRoleLevelData(int activityId, FlagChallengeRoleLevelInfo roleLevel)
		{
			this.GetFlagChallengeData(activityId).UpdateRoleLevelData(roleLevel);
		}

		// Token: 0x0602F8D4 RID: 194772 RVA: 0x00D4298F File Offset: 0x00D40B8F
		public bool CheckActivityTabRedoDotState(int activityId)
		{
			return this.HasCanReceiveTask(activityId) || this.HasNewUnlockLevel(activityId);
		}

		// Token: 0x0602F8D5 RID: 194773 RVA: 0x00D429A4 File Offset: 0x00D40BA4
		public bool HasCanReceiveTask(int activityId)
		{
			FlagChallengeData flagChallengeData = this.GetFlagChallengeData(activityId);
			return flagChallengeData != null && flagChallengeData.HasCanReceiveTask();
		}

		// Token: 0x0602F8D6 RID: 194774 RVA: 0x00D429C4 File Offset: 0x00D40BC4
		public void SaveFormationInfo(int activityId, HashSet<int> roleIdSet)
		{
			FlagChallengeData flagChallengeData = this.GetFlagChallengeData(activityId);
			if (flagChallengeData == null)
			{
				return;
			}
			flagChallengeData.SaveFormationInfo(roleIdSet);
		}

		// Token: 0x0602F8D7 RID: 194775 RVA: 0x00D429D8 File Offset: 0x00D40BD8
		public bool HasNewUnlockLevel(int activityId)
		{
			FlagChallengeData flagChallengeData = this.GetFlagChallengeData(activityId);
			return flagChallengeData != null && flagChallengeData.HasLevelNewlyUnlocked();
		}

		// Token: 0x0602F8D8 RID: 194776 RVA: 0x00D429F8 File Offset: 0x00D40BF8
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

		// Token: 0x0602F8D9 RID: 194777 RVA: 0x00D42A9C File Offset: 0x00D40C9C
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

		// Token: 0x0602F8DA RID: 194778 RVA: 0x00D42B48 File Offset: 0x00D40D48
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

		// Token: 0x0602F8DB RID: 194779 RVA: 0x00D42C80 File Offset: 0x00D40E80
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

		// Token: 0x0602F8DC RID: 194780 RVA: 0x00D42D28 File Offset: 0x00D40F28
		public int GetFixedLevel(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetFixedLevel();
			}
			return this.GetFlagChallengeData(activityId).GetFixedLevel();
		}

		// Token: 0x0602F8DD RID: 194781 RVA: 0x00D42D4D File Offset: 0x00D40F4D
		public int GetFixedLevelExp(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetFixedLevelExp();
			}
			return this.GetFlagChallengeData(activityId).GetFixedLevelExp();
		}

		// Token: 0x0602F8DE RID: 194782 RVA: 0x00D42D72 File Offset: 0x00D40F72
		public int GetCalculatedLevel(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetCalculatedLevel();
			}
			return this.GetFlagChallengeData(activityId).GetFixedLevel();
		}

		// Token: 0x0602F8DF RID: 194783 RVA: 0x00D42D97 File Offset: 0x00D40F97
		public int GetCalculatedLevelExp(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetCalculatedLevelExp();
			}
			return this.GetFlagChallengeData(activityId).GetFixedLevelExp();
		}

		// Token: 0x0602F8E0 RID: 194784 RVA: 0x00D42DBC File Offset: 0x00D40FBC
		public int GetTempLevel(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetTempLevel();
			}
			return this.GetFlagChallengeData(activityId).GetTempLevel();
		}

		// Token: 0x0602F8E1 RID: 194785 RVA: 0x00D42DE1 File Offset: 0x00D40FE1
		public int GetTempLevelExp(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetTempLevelExp();
			}
			return this.GetFlagChallengeData(activityId).GetTempLevelExp();
		}

		// Token: 0x0602F8E2 RID: 194786 RVA: 0x00D42E06 File Offset: 0x00D41006
		public int GetTotalLevel(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetTotalLevel();
			}
			return this.GetFlagChallengeData(activityId).GetTotalLevel();
		}

		// Token: 0x0602F8E3 RID: 194787 RVA: 0x00D42E2B File Offset: 0x00D4102B
		public int GetTotalLevelExp(int activityId)
		{
			if (FlagChallengeBattleModel.Instance.IsInFlagChallengeDungeon)
			{
				return FlagChallengeBattleModel.Instance.GetTotalLevelExp();
			}
			return this.GetFlagChallengeData(activityId).GetTotalLevelExp();
		}

		// Token: 0x0602F8E4 RID: 194788 RVA: 0x00D42E50 File Offset: 0x00D41050
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

		// Token: 0x0602F8E5 RID: 194789 RVA: 0x00D42EC0 File Offset: 0x00D410C0
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

		// Token: 0x0602F8E6 RID: 194790 RVA: 0x00D42F00 File Offset: 0x00D41100
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

		// Token: 0x0602F8E7 RID: 194791 RVA: 0x00D42F50 File Offset: 0x00D41150
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

		// Token: 0x0602F8E8 RID: 194792 RVA: 0x00D42FA8 File Offset: 0x00D411A8
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

		// Token: 0x0602F8E9 RID: 194793 RVA: 0x00D43020 File Offset: 0x00D41220
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

		// Token: 0x0602F8EA RID: 194794 RVA: 0x00D4307F File Offset: 0x00D4127F
		public bool IsReachTargetLevel(int activityId, int targetLv)
		{
			return this.GetTotalLevel(activityId) >= targetLv;
		}

		// Token: 0x0602F8EB RID: 194795 RVA: 0x00D43090 File Offset: 0x00D41290
		public void UpdateTeleportData(IList<int> teleportIds)
		{
			foreach (int item in teleportIds)
			{
				this.UnlockedTeleportId.Add(item);
			}
		}

		// Token: 0x0602F8EC RID: 194796 RVA: 0x00D430E0 File Offset: 0x00D412E0
		public bool IsTeleportUnlock(int teleportId)
		{
			return this.UnlockedTeleportId.Contains(teleportId);
		}

		// Token: 0x0602F8ED RID: 194797 RVA: 0x00D430F0 File Offset: 0x00D412F0
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

		// Token: 0x0602F8EE RID: 194798 RVA: 0x00D43318 File Offset: 0x00D41518
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

		// Token: 0x17005FC0 RID: 24512
		// (get) Token: 0x0602F8EF RID: 194799 RVA: 0x00D434EB File Offset: 0x00D416EB
		public static FlagChallengeModel Instance
		{
			get
			{
				return FlagChallengeModel._Instance;
			}
		}

		// Token: 0x0602F8F0 RID: 194800 RVA: 0x00D434F2 File Offset: 0x00D416F2
		public static FlagChallengeModel GetOrCreateInstance()
		{
			if (FlagChallengeModel._Instance == null)
			{
				FlagChallengeModel.CreateInstance();
			}
			return FlagChallengeModel._Instance;
		}

		// Token: 0x0602F8F1 RID: 194801 RVA: 0x00D43506 File Offset: 0x00D41706
		public static bool CreateInstance()
		{
			if (FlagChallengeModel._Instance != null)
			{
				return true;
			}
			FlagChallengeModel._Instance = new FlagChallengeModel();
			return true;
		}

		// Token: 0x0602F8F2 RID: 194802 RVA: 0x00D4351C File Offset: 0x00D4171C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F8F3 RID: 194803 RVA: 0x00D4351E File Offset: 0x00D4171E
		public static void ResetStaticDefaultValue()
		{
			FlagChallengeModel._Instance = null;
		}

		// Token: 0x0602F8F4 RID: 194804 RVA: 0x00D43526 File Offset: 0x00D41726
		static FlagChallengeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FlagChallengeModel.CreateStaticDefaultValue), new Action(FlagChallengeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401931A RID: 103194
		private readonly Dictionary<int, FlagChallengeData> FlagChallengeDataMap = new Dictionary<int, FlagChallengeData>();

		// Token: 0x0401931B RID: 103195
		private readonly Dictionary<int, Dictionary<int, int>> LevelExpCache = new Dictionary<int, Dictionary<int, int>>();

		// Token: 0x0401931C RID: 103196
		private readonly Dictionary<int, int> MaxLevelCache = new Dictionary<int, int>();

		// Token: 0x0401931D RID: 103197
		private readonly Dictionary<int, int> MaxLevelExpCache = new Dictionary<int, int>();

		// Token: 0x0401931E RID: 103198
		private readonly HashSet<int> UnlockedTeleportId = new HashSet<int>();

		// Token: 0x0401931F RID: 103199
		[Nullable(2)]
		private static FlagChallengeModel _Instance;
	}
}
