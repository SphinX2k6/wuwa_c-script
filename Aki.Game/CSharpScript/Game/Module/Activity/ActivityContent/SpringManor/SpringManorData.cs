using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006038 RID: 24632
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorData : ActivityBaseData
	{
		// Token: 0x0603E57E RID: 255358 RVA: 0x00F0E780 File Offset: 0x00F0C980
		protected override void PhraseEx(ActivityData data)
		{
			SpringManorModel instance = SpringManorModel.Instance;
			if (instance != null)
			{
				instance.SetActivityId(base.Id);
			}
			SpringFestivalActivityInfo springFestivalActivityInfo = data.SpringFestivalActivityInfo;
			if (springFestivalActivityInfo == null)
			{
				return;
			}
			this.ParseAtmosphere(springFestivalActivityInfo);
			this.ParseSkipEntryList(springFestivalActivityInfo.SpringSkipEntries);
			this.ParseUnlockedFunctionIdList(springFestivalActivityInfo.SpringFunctionIds);
			this.ParseRewardTaskInfo(springFestivalActivityInfo.ConditionTasks);
			this.ParseRewardScoreIdList(springFestivalActivityInfo.RewardScoreIds);
			this.ParseGuessJokerGameData(springFestivalActivityInfo.JokerLevelInfos);
			this.ParseDrinksGameData(springFestivalActivityInfo.DrinkMixData);
			int mapIdByActivityId = SpringManorConfig.Instance.GetMapIdByActivityId(base.Id);
			FurnitureController.Instance.UpdateData(base.Id, mapIdByActivityId, springFestivalActivityInfo.AreaInfos.ToArray<AreaInfo>(), springFestivalActivityInfo.UnlockFurnitures.ToArray<int>());
			this.ParseBrochureInfos(springFestivalActivityInfo.OneBrochureInfos);
		}

		// Token: 0x0603E57F RID: 255359 RVA: 0x00F0E844 File Offset: 0x00F0CA44
		public void ParseSkipEntryList(RepeatedField<SpringSkipEntry> skipEntryList)
		{
			this.SkipEntryMap.Clear();
			foreach (SpringSkipEntry springSkipEntry in skipEntryList)
			{
				this.SkipEntryMap.Add(springSkipEntry.Id, springSkipEntry);
			}
		}

		// Token: 0x0603E580 RID: 255360 RVA: 0x00F0E8A4 File Offset: 0x00F0CAA4
		public void OnSkipEntryUpdateNotify(SpringSkipEntry skipEntry)
		{
			if (this.SkipEntryMap.ContainsKey(skipEntry.Id))
			{
				this.SkipEntryMap[skipEntry.Id] = skipEntry;
				return;
			}
			this.SkipEntryMap.Add(skipEntry.Id, skipEntry);
		}

		// Token: 0x0603E581 RID: 255361 RVA: 0x00F0E8E0 File Offset: 0x00F0CAE0
		public bool IsSkipEntryUnLock(int skipEntryId)
		{
			SpringSkipEntry springSkipEntry;
			return !this.SkipEntryMap.TryGetValue(skipEntryId, out springSkipEntry) || springSkipEntry == null || springSkipEntry.UnLock;
		}

		// Token: 0x0603E582 RID: 255362 RVA: 0x00F0E90C File Offset: 0x00F0CB0C
		public bool IsSkipEntryFinish(int skipEntryId)
		{
			SpringSkipEntry springSkipEntry;
			return this.SkipEntryMap.TryGetValue(skipEntryId, out springSkipEntry) && springSkipEntry != null && springSkipEntry.Finish;
		}

		// Token: 0x0603E583 RID: 255363 RVA: 0x00F0E938 File Offset: 0x00F0CB38
		private void ParseRewardScoreIdList(RepeatedField<int> rewardScoreIds)
		{
			foreach (int item in rewardScoreIds)
			{
				this.ScoreRewardClaimedSet.Add(item);
			}
		}

		// Token: 0x0603E584 RID: 255364 RVA: 0x00F0E988 File Offset: 0x00F0CB88
		public void OnScoreRewardClaimed(List<int> scoreRewardIdList)
		{
			foreach (int item in scoreRewardIdList)
			{
				this.ScoreRewardClaimedSet.Add(item);
			}
		}

		// Token: 0x0603E585 RID: 255365 RVA: 0x00F0E9DC File Offset: 0x00F0CBDC
		public int GetCurrentMilestone()
		{
			if (this.MilestoneItemId == 0)
			{
				this.MilestoneItemId = SpringManorModel.Instance.GetActivityConfig().ScoreItemId;
			}
			return InventoryModel.Instance.GetItemCountByConfigId(this.MilestoneItemId, 0);
		}

		// Token: 0x0603E586 RID: 255366 RVA: 0x00F0EA1A File Offset: 0x00F0CC1A
		public bool IsScoreRewardReceived(int scoreRewardId)
		{
			return this.ScoreRewardClaimedSet.Contains(scoreRewardId);
		}

		// Token: 0x0603E587 RID: 255367 RVA: 0x00F0EA28 File Offset: 0x00F0CC28
		public bool IsScoreRewardCanReceived(int scoreRewardId)
		{
			if (this.IsScoreRewardReceived(scoreRewardId))
			{
				return false;
			}
			SpringFestivalScoreReward? scoreRewardConfigById = SpringManorConfig.Instance.GetScoreRewardConfigById(scoreRewardId);
			return this.GetCurrentMilestone() >= scoreRewardConfigById.Value.Score;
		}

		// Token: 0x0603E588 RID: 255368 RVA: 0x00F0EA68 File Offset: 0x00F0CC68
		public List<int> GetCanClaimedScoreRewardList()
		{
			List<int> list = new List<int>();
			foreach (SpringFestivalScoreReward springFestivalScoreReward in SpringManorConfig.Instance.GetScoreRewardConfigListByActivityId(base.Id))
			{
				if (this.IsScoreRewardCanReceived(springFestivalScoreReward.Id))
				{
					list.Add(springFestivalScoreReward.Id);
				}
			}
			return list;
		}

		// Token: 0x0603E589 RID: 255369 RVA: 0x00F0EADC File Offset: 0x00F0CCDC
		public bool HasAnyScoreRewardCanClaim()
		{
			return this.GetCanClaimedScoreRewardList().Count > 0;
		}

		// Token: 0x0603E58A RID: 255370 RVA: 0x00F0EAEC File Offset: 0x00F0CCEC
		private void ParseRewardTaskInfo(RepeatedField<ConditionTask> rewardTaskInfo)
		{
			this.RewardTaskMap.Clear();
			foreach (ConditionTask taskData in rewardTaskInfo)
			{
				ActivitySpringManorTaskData activitySpringManorTaskData = new ActivitySpringManorTaskData();
				activitySpringManorTaskData.Refresh(taskData);
				if (this.RewardTaskMap.ContainsKey(activitySpringManorTaskData.Id))
				{
					this.RewardTaskMap[activitySpringManorTaskData.Id] = activitySpringManorTaskData;
				}
				else
				{
					this.RewardTaskMap.Add(activitySpringManorTaskData.Id, activitySpringManorTaskData);
				}
			}
		}

		// Token: 0x0603E58B RID: 255371 RVA: 0x00F0EB80 File Offset: 0x00F0CD80
		public void OnTaskUpdateNotify(ConditionTask conditionTask)
		{
			ActivitySpringManorTaskData rewardTaskData = this.GetRewardTaskData(conditionTask.Id);
			if (rewardTaskData != null)
			{
				rewardTaskData.Refresh(conditionTask);
				return;
			}
			ActivitySpringManorTaskData activitySpringManorTaskData = new ActivitySpringManorTaskData();
			activitySpringManorTaskData.Refresh(conditionTask);
			this.RewardTaskMap.Add(activitySpringManorTaskData.Id, activitySpringManorTaskData);
		}

		// Token: 0x0603E58C RID: 255372 RVA: 0x00F0EBC4 File Offset: 0x00F0CDC4
		public void OnRewardTaskClaimed(List<int> claimedTaskIdList)
		{
			foreach (int taskId in claimedTaskIdList)
			{
				ActivitySpringManorTaskData rewardTaskData = this.GetRewardTaskData(taskId);
				if (rewardTaskData != null)
				{
					rewardTaskData.Status = EActivityTaskState.FinishedAndClaimed;
				}
			}
		}

		// Token: 0x0603E58D RID: 255373 RVA: 0x00F0EC20 File Offset: 0x00F0CE20
		[NullableContext(2)]
		public ActivitySpringManorTaskData GetRewardTaskData(int taskId)
		{
			ActivitySpringManorTaskData result;
			if (this.RewardTaskMap.TryGetValue(taskId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603E58E RID: 255374 RVA: 0x00F0EC40 File Offset: 0x00F0CE40
		public bool IsTaskCanClaim(int taskId)
		{
			ActivitySpringManorTaskData activitySpringManorTaskData;
			return this.RewardTaskMap.TryGetValue(taskId, out activitySpringManorTaskData) && activitySpringManorTaskData.Status == EActivityTaskState.FinishedAndUnclaimed;
		}

		// Token: 0x0603E58F RID: 255375 RVA: 0x00F0EC68 File Offset: 0x00F0CE68
		public List<int> GetTabCanClaimableTaskId(int tabId)
		{
			List<int> rewardTaskListByTabId = this.GetRewardTaskListByTabId(tabId);
			List<int> list = new List<int>();
			foreach (int num in rewardTaskListByTabId)
			{
				if (this.IsTaskCanClaim(num))
				{
					list.Add(num);
				}
			}
			return list;
		}

		// Token: 0x0603E590 RID: 255376 RVA: 0x00F0ECCC File Offset: 0x00F0CECC
		public bool IsTabHasAnyClaimable(int tabId)
		{
			foreach (int taskId in this.GetRewardTaskListByTabId(tabId))
			{
				if (this.IsTaskCanClaim(taskId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E591 RID: 255377 RVA: 0x00F0ED2C File Offset: 0x00F0CF2C
		public bool HasAnyClaimable()
		{
			foreach (int tabId in SpringManorModel.Instance.GetRewardTaskTabList())
			{
				if (this.IsTabHasAnyClaimable(tabId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E592 RID: 255378 RVA: 0x00F0ED8C File Offset: 0x00F0CF8C
		public List<int> GetRewardTaskListByTabId(int tabId)
		{
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, ActivitySpringManorTaskData> keyValuePair in this.RewardTaskMap)
			{
				ActivitySpringManorTaskData value = keyValuePair.Value;
				SpringFestivalReward? rewardTaskConfigById = SpringManorConfig.Instance.GetRewardTaskConfigById(value.Id);
				if (rewardTaskConfigById != null && rewardTaskConfigById.Value.TabId == tabId)
				{
					list.Add(value.Id);
				}
			}
			return list;
		}

		// Token: 0x0603E593 RID: 255379 RVA: 0x00F0EE24 File Offset: 0x00F0D024
		public int GetTotalRewardTaskProgress()
		{
			int num = 0;
			foreach (int tabId in SpringManorModel.Instance.GetRewardTaskTabList())
			{
				List<int> rewardTaskListByTabId = this.GetRewardTaskListByTabId(tabId);
				num += rewardTaskListByTabId.Count;
			}
			return num;
		}

		// Token: 0x0603E594 RID: 255380 RVA: 0x00F0EE88 File Offset: 0x00F0D088
		public int GetCurrentRewardTaskProgress()
		{
			int num = 0;
			foreach (int tabId in SpringManorModel.Instance.GetRewardTaskTabList())
			{
				foreach (int taskId in this.GetRewardTaskListByTabId(tabId))
				{
					ActivitySpringManorTaskData rewardTaskData = this.GetRewardTaskData(taskId);
					if (rewardTaskData != null && rewardTaskData.Status == EActivityTaskState.FinishedAndClaimed)
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0603E595 RID: 255381 RVA: 0x00F0EF34 File Offset: 0x00F0D134
		public int GetAtmosphere()
		{
			return this.CurrentAtmosphere;
		}

		// Token: 0x0603E596 RID: 255382 RVA: 0x00F0EF3C File Offset: 0x00F0D13C
		public int GetAtmosphereLevel()
		{
			return this.AtmosphereLevel;
		}

		// Token: 0x0603E597 RID: 255383 RVA: 0x00F0EF44 File Offset: 0x00F0D144
		public void OnAtmosphereUpdateNotify(int newAtmosphere, int newLevel)
		{
			this.CurrentAtmosphere = newAtmosphere;
			if (newLevel > this.AtmosphereLevel)
			{
				this.AtmosphereLevel = newLevel;
			}
		}

		// Token: 0x0603E598 RID: 255384 RVA: 0x00F0EF60 File Offset: 0x00F0D160
		private void ParseAtmosphere(SpringFestivalActivityInfo activityData)
		{
			foreach (int item in activityData.RewardLevelIds)
			{
				this.ClaimedLevelRewardSet.Add(item);
			}
			this.AtmosphereLevel = activityData.AtmosphereLevel;
			this.CurrentAtmosphere = activityData.Atmosphere;
		}

		// Token: 0x0603E599 RID: 255385 RVA: 0x00F0EFCC File Offset: 0x00F0D1CC
		public void OnAtmosphereLevelRewardUpdateNotify(List<int> levelIdList)
		{
			foreach (int item in levelIdList)
			{
				this.ClaimedLevelRewardSet.Add(item);
			}
		}

		// Token: 0x0603E59A RID: 255386 RVA: 0x00F0F020 File Offset: 0x00F0D220
		public bool IsLevelRewardClaimed(int level)
		{
			return this.ClaimedLevelRewardSet.Contains(level);
		}

		// Token: 0x0603E59B RID: 255387 RVA: 0x00F0F030 File Offset: 0x00F0D230
		public bool IsLevelCanReceive(int level)
		{
			if (this.IsLevelRewardClaimed(level))
			{
				return false;
			}
			AtmosphereLevel? atmosphereLevel;
			int? num = (SpringManorModel.Instance.GetLevelConfig(level) != null) ? new int?(atmosphereLevel.GetValueOrDefault().DropId) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					return level <= this.GetAtmosphereLevel();
				}
			}
			return false;
		}

		// Token: 0x0603E59C RID: 255388 RVA: 0x00F0F0B0 File Offset: 0x00F0D2B0
		public bool HasAnyLevelCanReceive()
		{
			int maxLevel = SpringManorModel.Instance.GetMaxLevel();
			for (int i = 1; i <= maxLevel; i++)
			{
				if (this.IsLevelCanReceive(i))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E59D RID: 255389 RVA: 0x00F0F0E0 File Offset: 0x00F0D2E0
		private void ParseUnlockedFunctionIdList(RepeatedField<int> unlockedFunctionIdList)
		{
			this.UnlockedFunctionSet.Clear();
			foreach (int item in unlockedFunctionIdList)
			{
				this.UnlockedFunctionSet.Add((ESpringFunctionType)item);
			}
		}

		// Token: 0x0603E59E RID: 255390 RVA: 0x00F0F13C File Offset: 0x00F0D33C
		public void OnFunctionUpdateNotify(int functionId)
		{
			this.UnlockedFunctionSet.Add((ESpringFunctionType)functionId);
		}

		// Token: 0x0603E59F RID: 255391 RVA: 0x00F0F14B File Offset: 0x00F0D34B
		public bool IsFunctionUnlocked(ESpringFunctionType functionType)
		{
			if (functionType == ESpringFunctionType.Gameplay)
			{
				return this.HasAnyGameUnlocked();
			}
			return this.UnlockedFunctionSet.Contains(functionType);
		}

		// Token: 0x0603E5A0 RID: 255392 RVA: 0x00F0F164 File Offset: 0x00F0D364
		public bool HasAnyGameUnlocked()
		{
			foreach (ESpringFunctionType functionType in SpringManorDefine.gameTypeList)
			{
				if (this.IsFunctionUnlocked(functionType))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E5A1 RID: 255393 RVA: 0x00F0F1C0 File Offset: 0x00F0D3C0
		public void ParseGuessJokerGameData(RepeatedField<Aki.Protocol.GuessJokerLevelInfo> guessJokerGameData)
		{
			this.GuessJokerGameDataMap.Clear();
			foreach (Aki.Protocol.GuessJokerLevelInfo guessJokerLevelInfo in guessJokerGameData)
			{
				global::GuessJokerLevelInfo value = new global::GuessJokerLevelInfo
				{
					LevelId = guessJokerLevelInfo.LevelId,
					Unlock = guessJokerLevelInfo.UnLock,
					FirstPass = guessJokerLevelInfo.LevelPass,
					RewardGet = guessJokerLevelInfo.RewardGet,
					PlayerWin = guessJokerLevelInfo.PlayerWin
				};
				if (this.GuessJokerGameDataMap.ContainsKey(guessJokerLevelInfo.LevelId))
				{
					this.GuessJokerGameDataMap[guessJokerLevelInfo.LevelId] = value;
				}
				else
				{
					this.GuessJokerGameDataMap.Add(guessJokerLevelInfo.LevelId, value);
				}
			}
			EventSystem.Instance.Emit(EEventName.OnGuessJokerRedDotNotify);
		}

		// Token: 0x0603E5A2 RID: 255394 RVA: 0x00F0F2A0 File Offset: 0x00F0D4A0
		public void UpdateGuessJokerGameData(RepeatedField<Aki.Protocol.GuessJokerLevelInfo> data)
		{
			bool flag = false;
			bool flag2 = false;
			foreach (Aki.Protocol.GuessJokerLevelInfo guessJokerLevelInfo in data)
			{
				IGuessJokerLevelInfo guessJokerLevelInfo2;
				if (this.GuessJokerGameDataMap.TryGetValue(guessJokerLevelInfo.LevelId, out guessJokerLevelInfo2))
				{
					if (!guessJokerLevelInfo2.Unlock && guessJokerLevelInfo.UnLock)
					{
						flag = true;
					}
					if (!guessJokerLevelInfo2.FirstPass && guessJokerLevelInfo.LevelPass && !guessJokerLevelInfo.RewardGet)
					{
						flag2 = true;
						HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.GuessJokerFirstFinishAnim, null) ?? new HashSet<int>();
						hashSet.Add(guessJokerLevelInfo.LevelId);
						LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.GuessJokerFirstFinishAnim, hashSet);
					}
					guessJokerLevelInfo2.Unlock = guessJokerLevelInfo.UnLock;
					guessJokerLevelInfo2.RewardGet = guessJokerLevelInfo.RewardGet;
					guessJokerLevelInfo2.FirstPass = guessJokerLevelInfo.LevelPass;
					guessJokerLevelInfo2.PlayerWin = guessJokerLevelInfo.PlayerWin;
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.GuessJokerCard;
					ELogAuthor author = ELogAuthor.LRC;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 1);
					defaultInterpolatedStringHandler.AppendLiteral("UpdateGuessJokerGameData.");
					defaultInterpolatedStringHandler.AppendFormatted<int>(guessJokerLevelInfo.LevelId);
					defaultInterpolatedStringHandler.AppendLiteral("失败，因为：数据不存在");
					instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			if (flag || flag2)
			{
				EventSystem.Instance.Emit(EEventName.OnGuessJokerRedDotNotify);
			}
		}

		// Token: 0x0603E5A3 RID: 255395 RVA: 0x00F0F40C File Offset: 0x00F0D60C
		[NullableContext(2)]
		public IGuessJokerLevelInfo GetGuessJokerGameData(int levelId)
		{
			IGuessJokerLevelInfo result;
			if (this.GuessJokerGameDataMap.TryGetValue(levelId, out result))
			{
				return result;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GuessJokerCard;
			ELogAuthor author = ELogAuthor.LRC;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(33, 1);
			defaultInterpolatedStringHandler.AppendLiteral("GetGuessJokerGameData.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(levelId);
			defaultInterpolatedStringHandler.AppendLiteral("失败，因为：数据不存在");
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x0603E5A4 RID: 255396 RVA: 0x00F0F478 File Offset: 0x00F0D678
		public int GetGuessJokerCurrentProgress()
		{
			int num = 0;
			foreach (KeyValuePair<int, IGuessJokerLevelInfo> keyValuePair in this.GuessJokerGameDataMap)
			{
				if (keyValuePair.Value.RewardGet)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0603E5A5 RID: 255397 RVA: 0x00F0F4DC File Offset: 0x00F0D6DC
		public int GetGuessJokerTotalProgress()
		{
			return this.GuessJokerGameDataMap.Count;
		}

		// Token: 0x0603E5A6 RID: 255398 RVA: 0x00F0F4EC File Offset: 0x00F0D6EC
		public void UpdateLevelGetReward(int levelId)
		{
			IGuessJokerLevelInfo guessJokerGameData = this.GetGuessJokerGameData(levelId);
			if (guessJokerGameData != null)
			{
				guessJokerGameData.RewardGet = true;
				EventSystem.Instance.Emit(EEventName.OnGuessJokerRedDotNotify);
			}
		}

		// Token: 0x0603E5A7 RID: 255399 RVA: 0x00F0F51C File Offset: 0x00F0D71C
		[NullableContext(2)]
		private void ParseDrinksGameData(DrinkMixData data)
		{
			if (data == null)
			{
				return;
			}
			foreach (DrinkMixRole drinkMixRole in data.RoleLevelInfo)
			{
				DrinksMixRoleInfo value = new DrinksMixRoleInfo
				{
					RoleId = drinkMixRole.RoleId,
					FirstPass = drinkMixRole.FirstPass,
					MaxLike = drinkMixRole.MaxLike,
					RewardGet = drinkMixRole.RewardGet
				};
				if (this.DrinksRoleDataMap.ContainsKey(drinkMixRole.RoleId))
				{
					this.DrinksRoleDataMap[drinkMixRole.RoleId] = value;
				}
				else
				{
					this.DrinksRoleDataMap.Add(drinkMixRole.RoleId, value);
				}
			}
			EventSystem.Instance.Emit(EEventName.OnDrinksUnlockClickedNotify);
		}

		// Token: 0x0603E5A8 RID: 255400 RVA: 0x00F0F5E8 File Offset: 0x00F0D7E8
		public int GetDrinksCurrentProgress()
		{
			int num = 0;
			foreach (KeyValuePair<int, IDrinksMixRoleInfo> keyValuePair in this.DrinksRoleDataMap)
			{
				if (keyValuePair.Value.RewardGet)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0603E5A9 RID: 255401 RVA: 0x00F0F64C File Offset: 0x00F0D84C
		public int GetDrinksTotalProgress()
		{
			return DrinksConfig.Instance.GetAllInvite().Count;
		}

		// Token: 0x0603E5AA RID: 255402 RVA: 0x00F0F65D File Offset: 0x00F0D85D
		public Dictionary<int, IDrinksMixRoleInfo> GetDrinksProgressMap()
		{
			return this.DrinksRoleDataMap;
		}

		// Token: 0x0603E5AB RID: 255403 RVA: 0x00F0F668 File Offset: 0x00F0D868
		public void ParseBrochureInfos(RepeatedField<OneBrochureInfo> data)
		{
			this.InitTargetTypeBookItemData(EBrochureType.Character);
			this.InitTargetTypeBookItemData(EBrochureType.EasterEggBook);
			this.InitTargetTypeBookItemData(EBrochureType.Brochure);
			if (data == null)
			{
				return;
			}
			foreach (OneBrochureInfo oneBrochureInfo in data)
			{
				int brochureId = oneBrochureInfo.BrochureId;
				List<int> brochureUnlockIds = this.BrochureUnlockIds;
				if (brochureUnlockIds != null)
				{
					brochureUnlockIds.Add(brochureId);
				}
				foreach (BookItemInfo bookItemInfo in oneBrochureInfo.BookItemInfos)
				{
					if (this.BookItemMap.ContainsKey(bookItemInfo.BookItemId))
					{
						this.BookItemMap[bookItemInfo.BookItemId] = bookItemInfo;
					}
					else
					{
						this.BookItemMap.Add(bookItemInfo.BookItemId, bookItemInfo);
					}
				}
			}
			EventSystem.Instance.Emit(EEventName.OnBrochureBookItemStateUpdate);
		}

		// Token: 0x0603E5AC RID: 255404 RVA: 0x00F0F760 File Offset: 0x00F0D960
		public void InitTargetTypeBookItemData(EBrochureType brochureType)
		{
			SpringManorConfig instance = SpringManorConfig.Instance;
			Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureByActivityAndType(base.Id, brochureType) : null;
			if (brochure == null)
			{
				return;
			}
			for (int i = 0; i < brochure.Value.BookItemIdsLength; i++)
			{
				int num = brochure.Value.BookItemIds(i);
				BookItemInfo value = new BookItemInfo
				{
					BookItemId = num,
					BookItemState = BookItemState.BookItemLock
				};
				if (this.BookItemMap.ContainsKey(num))
				{
					this.BookItemMap[num] = value;
				}
				else
				{
					this.BookItemMap.Add(num, value);
				}
			}
		}

		// Token: 0x0603E5AD RID: 255405 RVA: 0x00F0F806 File Offset: 0x00F0DA06
		public void AddUnlockBrochureId(int id)
		{
			if (this.BrochureUnlockIds == null)
			{
				return;
			}
			List<int> brochureUnlockIds = this.BrochureUnlockIds;
			if (brochureUnlockIds == null)
			{
				return;
			}
			brochureUnlockIds.Add(id);
		}

		// Token: 0x0603E5AE RID: 255406 RVA: 0x00F0F822 File Offset: 0x00F0DA22
		public void SetBookItemDataById(int id, BookItemInfo info)
		{
			if (info == null)
			{
				return;
			}
			if (this.BookItemMap.ContainsKey(id))
			{
				this.BookItemMap[id] = info;
				return;
			}
			this.BookItemMap.Add(id, info);
		}

		// Token: 0x0603E5AF RID: 255407 RVA: 0x00F0F854 File Offset: 0x00F0DA54
		[NullableContext(2)]
		public BookItemInfo GetBookItemDataById(int id)
		{
			if (!this.BookItemMap.ContainsKey(id))
			{
				return null;
			}
			BookItemInfo result;
			if (this.BookItemMap.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0603E5B0 RID: 255408 RVA: 0x00F0F884 File Offset: 0x00F0DA84
		public void SetTargetBookItemState(int id, BookItemState state)
		{
			BookItemInfo bookItemDataById = this.GetBookItemDataById(id);
			if (bookItemDataById != null)
			{
				bookItemDataById.BookItemState = state;
			}
		}

		// Token: 0x0603E5B1 RID: 255409 RVA: 0x00F0F8A4 File Offset: 0x00F0DAA4
		public EBrochureState GetBookItemStateById(int id)
		{
			BookItemInfo bookItemDataById = this.GetBookItemDataById(id);
			if (bookItemDataById != null)
			{
				return this.SwitchBookItemState(bookItemDataById.BookItemState);
			}
			return EBrochureState.None;
		}

		// Token: 0x0603E5B2 RID: 255410 RVA: 0x00F0F8CA File Offset: 0x00F0DACA
		public EBrochureState SwitchBookItemState(BookItemState state)
		{
			switch (state)
			{
			case BookItemState.BookItemLock:
				return EBrochureState.Lock;
			case BookItemState.BookItemUnlock:
				return EBrochureState.Unlock;
			case BookItemState.BookItemRewarded:
				return EBrochureState.Rewarded;
			default:
				return EBrochureState.None;
			}
		}

		// Token: 0x0603E5B3 RID: 255411 RVA: 0x00F0F8E8 File Offset: 0x00F0DAE8
		public int GetNextLockBookItemId(int currentItemId)
		{
			SpringManorConfig instance = SpringManorConfig.Instance;
			Brochure? brochure = (instance != null) ? instance.GetSpringManorBrochureByActivityAndType(base.Id, EBrochureType.Brochure) : null;
			if (brochure == null)
			{
				return 0;
			}
			int num = 0;
			for (int i = brochure.Value.BookItemIdsLength - 1; i >= 0; i--)
			{
				int num2 = brochure.Value.BookItemIds(i);
				if (num2 == currentItemId && num > 0)
				{
					break;
				}
				if (this.GetBookItemStateById(num2) == EBrochureState.Lock)
				{
					num = num2;
				}
			}
			return num;
		}

		// Token: 0x0603E5B4 RID: 255412 RVA: 0x00F0F96A File Offset: 0x00F0DB6A
		public void ReadFirstOpenRedDot()
		{
			ActivityModel instance = ActivityModel.Instance;
			if (instance != null)
			{
				instance.SaveActivityData(base.Id, 0, 0, 0, 1);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x0603E5B5 RID: 255413 RVA: 0x00F0F99C File Offset: 0x00F0DB9C
		public bool HasActivityRedDot()
		{
			ActivityModel instance = ActivityModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetActivityCacheData(base.Id, 0, 0, 0, 0)) : null;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					return this.HasRewardRedDot() || this.HasAtmosphereRedDot() || this.HasAnySubQuestRedDot() || DrinksModel.Instance.CheckRedDot() || GuessJokerGamePlayModel.Instance.CheckRedDot() || FurnitureModel.Instance.CheckFurnitureEntranceRedDot() || SpringManorModel.Instance.CheckAnyBookItemRedDot();
				}
			}
			return true;
		}

		// Token: 0x0603E5B6 RID: 255414 RVA: 0x00F0FA40 File Offset: 0x00F0DC40
		public bool HasRewardRedDot()
		{
			return this.HasAnyClaimable() || this.HasAnyScoreRewardCanClaim();
		}

		// Token: 0x0603E5B7 RID: 255415 RVA: 0x00F0FA52 File Offset: 0x00F0DC52
		public bool HasAtmosphereRedDot()
		{
			return this.HasAnyLevelCanReceive();
		}

		// Token: 0x0603E5B8 RID: 255416 RVA: 0x00F0FA5C File Offset: 0x00F0DC5C
		public bool HasAnySubQuestRedDot()
		{
			foreach (int questId in SpringManorModel.Instance.GetSubQuestList())
			{
				if (this.HasSubQuestRedDot(questId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603E5B9 RID: 255417 RVA: 0x00F0FABC File Offset: 0x00F0DCBC
		public bool HasSubQuestRedDot(int questId)
		{
			ActivityModel instance = ActivityModel.Instance;
			return ((instance != null) ? new int?(instance.GetActivityCacheData(base.Id, 0, 1, questId, 0)) : null).GetValueOrDefault() != 1;
		}

		// Token: 0x0603E5BA RID: 255418 RVA: 0x00F0FAFF File Offset: 0x00F0DCFF
		public void ReadSubQuestRedDot(int questId)
		{
			ActivityModel instance = ActivityModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SaveActivityData(base.Id, 1, questId, 0, 1);
		}

		// Token: 0x0603E5BB RID: 255419 RVA: 0x00F0FB1A File Offset: 0x00F0DD1A
		public override bool GetExDataRedPointShowState()
		{
			return this.HasActivityRedDot();
		}

		// Token: 0x0603E5BC RID: 255420 RVA: 0x00F0FB24 File Offset: 0x00F0DD24
		protected override bool GetExDataFinishShowState()
		{
			foreach (ESpringFunctionType key in SpringManorDefine.gameTypeList)
			{
				SpringManorGameHandleBase springManorGameHandleBase;
				if (SpringManorGameHandleDefine.springManorGameHandleDefine.TryGetValue(key, out springManorGameHandleBase) && springManorGameHandleBase.GetCurrentProgress() < springManorGameHandleBase.GetTotalProgress())
				{
					return false;
				}
			}
			foreach (KeyValuePair<int, ActivitySpringManorTaskData> keyValuePair in this.RewardTaskMap)
			{
				if (keyValuePair.Value.Status != EActivityTaskState.FinishedAndClaimed)
				{
					return false;
				}
			}
			if (SpringManorModel.Instance.GetScoreRewardConfigList().Count > this.ScoreRewardClaimedSet.Count)
			{
				return false;
			}
			int maxLevel = SpringManorModel.Instance.GetMaxLevel();
			return this.ClaimedLevelRewardSet.Count >= maxLevel;
		}

		// Token: 0x04020915 RID: 133397
		private readonly Dictionary<int, SpringSkipEntry> SkipEntryMap = new Dictionary<int, SpringSkipEntry>();

		// Token: 0x04020916 RID: 133398
		private readonly HashSet<int> ScoreRewardClaimedSet = new HashSet<int>();

		// Token: 0x04020917 RID: 133399
		private int MilestoneItemId;

		// Token: 0x04020918 RID: 133400
		private readonly Dictionary<int, ActivitySpringManorTaskData> RewardTaskMap = new Dictionary<int, ActivitySpringManorTaskData>();

		// Token: 0x04020919 RID: 133401
		private int CurrentAtmosphere;

		// Token: 0x0402091A RID: 133402
		private int AtmosphereLevel;

		// Token: 0x0402091B RID: 133403
		private readonly HashSet<int> ClaimedLevelRewardSet = new HashSet<int>();

		// Token: 0x0402091C RID: 133404
		private readonly HashSet<ESpringFunctionType> UnlockedFunctionSet = new HashSet<ESpringFunctionType>();

		// Token: 0x0402091D RID: 133405
		private readonly Dictionary<int, IGuessJokerLevelInfo> GuessJokerGameDataMap = new Dictionary<int, IGuessJokerLevelInfo>();

		// Token: 0x0402091E RID: 133406
		private readonly Dictionary<int, IDrinksMixRoleInfo> DrinksRoleDataMap = new Dictionary<int, IDrinksMixRoleInfo>();

		// Token: 0x0402091F RID: 133407
		private readonly Dictionary<int, BookItemInfo> BookItemMap = new Dictionary<int, BookItemInfo>();

		// Token: 0x04020920 RID: 133408
		[Nullable(2)]
		private readonly List<int> BrochureUnlockIds = new List<int>();
	}
}
