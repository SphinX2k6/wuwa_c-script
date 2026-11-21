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
	// Token: 0x02004FB6 RID: 20406
	[NullableContext(1)]
	[Nullable(0)]
	public class SpringManorData : ActivityBaseData
	{
		// Token: 0x06033242 RID: 209474 RVA: 0x00E55544 File Offset: 0x00E53744
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

		// Token: 0x06033243 RID: 209475 RVA: 0x00E55608 File Offset: 0x00E53808
		public void ParseSkipEntryList(RepeatedField<SpringSkipEntry> skipEntryList)
		{
			this.SkipEntryMap.Clear();
			foreach (SpringSkipEntry springSkipEntry in skipEntryList)
			{
				this.SkipEntryMap.Add(springSkipEntry.Id, springSkipEntry);
			}
		}

		// Token: 0x06033244 RID: 209476 RVA: 0x00E55668 File Offset: 0x00E53868
		public void OnSkipEntryUpdateNotify(SpringSkipEntry skipEntry)
		{
			if (this.SkipEntryMap.ContainsKey(skipEntry.Id))
			{
				this.SkipEntryMap[skipEntry.Id] = skipEntry;
				return;
			}
			this.SkipEntryMap.Add(skipEntry.Id, skipEntry);
		}

		// Token: 0x06033245 RID: 209477 RVA: 0x00E556A4 File Offset: 0x00E538A4
		public bool IsSkipEntryUnLock(int skipEntryId)
		{
			SpringSkipEntry springSkipEntry;
			return !this.SkipEntryMap.TryGetValue(skipEntryId, out springSkipEntry) || springSkipEntry == null || springSkipEntry.UnLock;
		}

		// Token: 0x06033246 RID: 209478 RVA: 0x00E556D0 File Offset: 0x00E538D0
		public bool IsSkipEntryFinish(int skipEntryId)
		{
			SpringSkipEntry springSkipEntry;
			return this.SkipEntryMap.TryGetValue(skipEntryId, out springSkipEntry) && springSkipEntry != null && springSkipEntry.Finish;
		}

		// Token: 0x06033247 RID: 209479 RVA: 0x00E556FC File Offset: 0x00E538FC
		private void ParseRewardScoreIdList(RepeatedField<int> rewardScoreIds)
		{
			foreach (int item in rewardScoreIds)
			{
				this.ScoreRewardClaimedSet.Add(item);
			}
		}

		// Token: 0x06033248 RID: 209480 RVA: 0x00E5574C File Offset: 0x00E5394C
		public void OnScoreRewardClaimed(List<int> scoreRewardIdList)
		{
			foreach (int item in scoreRewardIdList)
			{
				this.ScoreRewardClaimedSet.Add(item);
			}
		}

		// Token: 0x06033249 RID: 209481 RVA: 0x00E557A0 File Offset: 0x00E539A0
		public int GetCurrentMilestone()
		{
			if (this.MilestoneItemId == 0)
			{
				this.MilestoneItemId = SpringManorModel.Instance.GetActivityConfig().ScoreItemId;
			}
			return InventoryModel.Instance.GetItemCountByConfigId(this.MilestoneItemId, 0);
		}

		// Token: 0x0603324A RID: 209482 RVA: 0x00E557DE File Offset: 0x00E539DE
		public bool IsScoreRewardReceived(int scoreRewardId)
		{
			return this.ScoreRewardClaimedSet.Contains(scoreRewardId);
		}

		// Token: 0x0603324B RID: 209483 RVA: 0x00E557EC File Offset: 0x00E539EC
		public bool IsScoreRewardCanReceived(int scoreRewardId)
		{
			if (this.IsScoreRewardReceived(scoreRewardId))
			{
				return false;
			}
			SpringFestivalScoreReward? scoreRewardConfigById = SpringManorConfig.Instance.GetScoreRewardConfigById(scoreRewardId);
			return this.GetCurrentMilestone() >= scoreRewardConfigById.Value.Score;
		}

		// Token: 0x0603324C RID: 209484 RVA: 0x00E5582C File Offset: 0x00E53A2C
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

		// Token: 0x0603324D RID: 209485 RVA: 0x00E558A0 File Offset: 0x00E53AA0
		public bool HasAnyScoreRewardCanClaim()
		{
			return this.GetCanClaimedScoreRewardList().Count > 0;
		}

		// Token: 0x0603324E RID: 209486 RVA: 0x00E558B0 File Offset: 0x00E53AB0
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

		// Token: 0x0603324F RID: 209487 RVA: 0x00E55944 File Offset: 0x00E53B44
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

		// Token: 0x06033250 RID: 209488 RVA: 0x00E55988 File Offset: 0x00E53B88
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

		// Token: 0x06033251 RID: 209489 RVA: 0x00E559E4 File Offset: 0x00E53BE4
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

		// Token: 0x06033252 RID: 209490 RVA: 0x00E55A04 File Offset: 0x00E53C04
		public bool IsTaskCanClaim(int taskId)
		{
			ActivitySpringManorTaskData activitySpringManorTaskData;
			return this.RewardTaskMap.TryGetValue(taskId, out activitySpringManorTaskData) && activitySpringManorTaskData.Status == EActivityTaskState.FinishedAndUnclaimed;
		}

		// Token: 0x06033253 RID: 209491 RVA: 0x00E55A2C File Offset: 0x00E53C2C
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

		// Token: 0x06033254 RID: 209492 RVA: 0x00E55A90 File Offset: 0x00E53C90
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

		// Token: 0x06033255 RID: 209493 RVA: 0x00E55AF0 File Offset: 0x00E53CF0
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

		// Token: 0x06033256 RID: 209494 RVA: 0x00E55B50 File Offset: 0x00E53D50
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

		// Token: 0x06033257 RID: 209495 RVA: 0x00E55BE8 File Offset: 0x00E53DE8
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

		// Token: 0x06033258 RID: 209496 RVA: 0x00E55C4C File Offset: 0x00E53E4C
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

		// Token: 0x06033259 RID: 209497 RVA: 0x00E55CF8 File Offset: 0x00E53EF8
		public int GetAtmosphere()
		{
			return this.CurrentAtmosphere;
		}

		// Token: 0x0603325A RID: 209498 RVA: 0x00E55D00 File Offset: 0x00E53F00
		public int GetAtmosphereLevel()
		{
			return this.AtmosphereLevel;
		}

		// Token: 0x0603325B RID: 209499 RVA: 0x00E55D08 File Offset: 0x00E53F08
		public void OnAtmosphereUpdateNotify(int newAtmosphere, int newLevel)
		{
			this.CurrentAtmosphere = newAtmosphere;
			if (newLevel > this.AtmosphereLevel)
			{
				this.AtmosphereLevel = newLevel;
			}
		}

		// Token: 0x0603325C RID: 209500 RVA: 0x00E55D24 File Offset: 0x00E53F24
		private void ParseAtmosphere(SpringFestivalActivityInfo activityData)
		{
			foreach (int item in activityData.RewardLevelIds)
			{
				this.ClaimedLevelRewardSet.Add(item);
			}
			this.AtmosphereLevel = activityData.AtmosphereLevel;
			this.CurrentAtmosphere = activityData.Atmosphere;
		}

		// Token: 0x0603325D RID: 209501 RVA: 0x00E55D90 File Offset: 0x00E53F90
		public void OnAtmosphereLevelRewardUpdateNotify(List<int> levelIdList)
		{
			foreach (int item in levelIdList)
			{
				this.ClaimedLevelRewardSet.Add(item);
			}
		}

		// Token: 0x0603325E RID: 209502 RVA: 0x00E55DE4 File Offset: 0x00E53FE4
		public bool IsLevelRewardClaimed(int level)
		{
			return this.ClaimedLevelRewardSet.Contains(level);
		}

		// Token: 0x0603325F RID: 209503 RVA: 0x00E55DF4 File Offset: 0x00E53FF4
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

		// Token: 0x06033260 RID: 209504 RVA: 0x00E55E74 File Offset: 0x00E54074
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

		// Token: 0x06033261 RID: 209505 RVA: 0x00E55EA4 File Offset: 0x00E540A4
		private void ParseUnlockedFunctionIdList(RepeatedField<int> unlockedFunctionIdList)
		{
			this.UnlockedFunctionSet.Clear();
			foreach (int item in unlockedFunctionIdList)
			{
				this.UnlockedFunctionSet.Add((ESpringFunctionType)item);
			}
		}

		// Token: 0x06033262 RID: 209506 RVA: 0x00E55F00 File Offset: 0x00E54100
		public void OnFunctionUpdateNotify(int functionId)
		{
			this.UnlockedFunctionSet.Add((ESpringFunctionType)functionId);
		}

		// Token: 0x06033263 RID: 209507 RVA: 0x00E55F0F File Offset: 0x00E5410F
		public bool IsFunctionUnlocked(ESpringFunctionType functionType)
		{
			if (functionType == ESpringFunctionType.Gameplay)
			{
				return this.HasAnyGameUnlocked();
			}
			return this.UnlockedFunctionSet.Contains(functionType);
		}

		// Token: 0x06033264 RID: 209508 RVA: 0x00E55F28 File Offset: 0x00E54128
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

		// Token: 0x06033265 RID: 209509 RVA: 0x00E55F84 File Offset: 0x00E54184
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

		// Token: 0x06033266 RID: 209510 RVA: 0x00E56064 File Offset: 0x00E54264
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

		// Token: 0x06033267 RID: 209511 RVA: 0x00E561D0 File Offset: 0x00E543D0
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

		// Token: 0x06033268 RID: 209512 RVA: 0x00E5623C File Offset: 0x00E5443C
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

		// Token: 0x06033269 RID: 209513 RVA: 0x00E562A0 File Offset: 0x00E544A0
		public int GetGuessJokerTotalProgress()
		{
			return this.GuessJokerGameDataMap.Count;
		}

		// Token: 0x0603326A RID: 209514 RVA: 0x00E562B0 File Offset: 0x00E544B0
		public void UpdateLevelGetReward(int levelId)
		{
			IGuessJokerLevelInfo guessJokerGameData = this.GetGuessJokerGameData(levelId);
			if (guessJokerGameData != null)
			{
				guessJokerGameData.RewardGet = true;
				EventSystem.Instance.Emit(EEventName.OnGuessJokerRedDotNotify);
			}
		}

		// Token: 0x0603326B RID: 209515 RVA: 0x00E562E0 File Offset: 0x00E544E0
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

		// Token: 0x0603326C RID: 209516 RVA: 0x00E563AC File Offset: 0x00E545AC
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

		// Token: 0x0603326D RID: 209517 RVA: 0x00E56410 File Offset: 0x00E54610
		public int GetDrinksTotalProgress()
		{
			return DrinksConfig.Instance.GetAllInvite().Count;
		}

		// Token: 0x0603326E RID: 209518 RVA: 0x00E56421 File Offset: 0x00E54621
		public Dictionary<int, IDrinksMixRoleInfo> GetDrinksProgressMap()
		{
			return this.DrinksRoleDataMap;
		}

		// Token: 0x0603326F RID: 209519 RVA: 0x00E5642C File Offset: 0x00E5462C
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

		// Token: 0x06033270 RID: 209520 RVA: 0x00E56524 File Offset: 0x00E54724
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

		// Token: 0x06033271 RID: 209521 RVA: 0x00E565CA File Offset: 0x00E547CA
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

		// Token: 0x06033272 RID: 209522 RVA: 0x00E565E6 File Offset: 0x00E547E6
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

		// Token: 0x06033273 RID: 209523 RVA: 0x00E56618 File Offset: 0x00E54818
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

		// Token: 0x06033274 RID: 209524 RVA: 0x00E56648 File Offset: 0x00E54848
		public void SetTargetBookItemState(int id, BookItemState state)
		{
			BookItemInfo bookItemDataById = this.GetBookItemDataById(id);
			if (bookItemDataById != null)
			{
				bookItemDataById.BookItemState = state;
			}
		}

		// Token: 0x06033275 RID: 209525 RVA: 0x00E56668 File Offset: 0x00E54868
		public EBrochureState GetBookItemStateById(int id)
		{
			BookItemInfo bookItemDataById = this.GetBookItemDataById(id);
			if (bookItemDataById != null)
			{
				return this.SwitchBookItemState(bookItemDataById.BookItemState);
			}
			return EBrochureState.None;
		}

		// Token: 0x06033276 RID: 209526 RVA: 0x00E5668E File Offset: 0x00E5488E
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

		// Token: 0x06033277 RID: 209527 RVA: 0x00E566AC File Offset: 0x00E548AC
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

		// Token: 0x06033278 RID: 209528 RVA: 0x00E5672E File Offset: 0x00E5492E
		public void ReadFirstOpenRedDot()
		{
			ActivityModel instance = ActivityModel.Instance;
			if (instance != null)
			{
				instance.SaveActivityData(base.Id, 0, 0, 0, 1);
			}
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06033279 RID: 209529 RVA: 0x00E56760 File Offset: 0x00E54960
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

		// Token: 0x0603327A RID: 209530 RVA: 0x00E56804 File Offset: 0x00E54A04
		public bool HasRewardRedDot()
		{
			return this.HasAnyClaimable() || this.HasAnyScoreRewardCanClaim();
		}

		// Token: 0x0603327B RID: 209531 RVA: 0x00E56816 File Offset: 0x00E54A16
		public bool HasAtmosphereRedDot()
		{
			return this.HasAnyLevelCanReceive();
		}

		// Token: 0x0603327C RID: 209532 RVA: 0x00E56820 File Offset: 0x00E54A20
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

		// Token: 0x0603327D RID: 209533 RVA: 0x00E56880 File Offset: 0x00E54A80
		public bool HasSubQuestRedDot(int questId)
		{
			ActivityModel instance = ActivityModel.Instance;
			return ((instance != null) ? new int?(instance.GetActivityCacheData(base.Id, 0, 1, questId, 0)) : null).GetValueOrDefault() != 1;
		}

		// Token: 0x0603327E RID: 209534 RVA: 0x00E568C3 File Offset: 0x00E54AC3
		public void ReadSubQuestRedDot(int questId)
		{
			ActivityModel instance = ActivityModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SaveActivityData(base.Id, 1, questId, 0, 1);
		}

		// Token: 0x0603327F RID: 209535 RVA: 0x00E568DE File Offset: 0x00E54ADE
		public override bool GetExDataRedPointShowState()
		{
			return this.HasActivityRedDot();
		}

		// Token: 0x06033280 RID: 209536 RVA: 0x00E568E8 File Offset: 0x00E54AE8
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

		// Token: 0x0401B242 RID: 111170
		private readonly Dictionary<int, SpringSkipEntry> SkipEntryMap = new Dictionary<int, SpringSkipEntry>();

		// Token: 0x0401B243 RID: 111171
		private readonly HashSet<int> ScoreRewardClaimedSet = new HashSet<int>();

		// Token: 0x0401B244 RID: 111172
		private int MilestoneItemId;

		// Token: 0x0401B245 RID: 111173
		private readonly Dictionary<int, ActivitySpringManorTaskData> RewardTaskMap = new Dictionary<int, ActivitySpringManorTaskData>();

		// Token: 0x0401B246 RID: 111174
		private int CurrentAtmosphere;

		// Token: 0x0401B247 RID: 111175
		private int AtmosphereLevel;

		// Token: 0x0401B248 RID: 111176
		private readonly HashSet<int> ClaimedLevelRewardSet = new HashSet<int>();

		// Token: 0x0401B249 RID: 111177
		private readonly HashSet<ESpringFunctionType> UnlockedFunctionSet = new HashSet<ESpringFunctionType>();

		// Token: 0x0401B24A RID: 111178
		private readonly Dictionary<int, IGuessJokerLevelInfo> GuessJokerGameDataMap = new Dictionary<int, IGuessJokerLevelInfo>();

		// Token: 0x0401B24B RID: 111179
		private readonly Dictionary<int, IDrinksMixRoleInfo> DrinksRoleDataMap = new Dictionary<int, IDrinksMixRoleInfo>();

		// Token: 0x0401B24C RID: 111180
		private readonly Dictionary<int, BookItemInfo> BookItemMap = new Dictionary<int, BookItemInfo>();

		// Token: 0x0401B24D RID: 111181
		[Nullable(2)]
		private readonly List<int> BrochureUnlockIds = new List<int>();
	}
}
