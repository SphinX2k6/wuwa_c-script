using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x02006542 RID: 25922
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMatchThreeData : ActivityBaseData
	{
		// Token: 0x06040F83 RID: 266115 RVA: 0x00FBE398 File Offset: 0x00FBC598
		protected override void PhraseEx(ActivityData data)
		{
			MatchThreeActivityInfo matchThreeActivityInfo = data.MatchThreeActivityInfo;
			RepeatedField<MatchThreeLevelInfo> repeatedField = (matchThreeActivityInfo != null) ? matchThreeActivityInfo.MatchThreeLevelInfos : null;
			if (repeatedField == null)
			{
				return;
			}
			this.ChallengeState.Clear();
			foreach (MatchThreeLevelInfo matchThreeLevelInfo in repeatedField)
			{
				this.ChallengeState[matchThreeLevelInfo.Id] = matchThreeLevelInfo;
			}
			this.InvalidateChapterCache();
		}

		// Token: 0x06040F84 RID: 266116 RVA: 0x00FBE414 File Offset: 0x00FBC614
		private void InvalidateChapterCache()
		{
			this.CachedRegularChaptersComplete = null;
		}

		// Token: 0x06040F85 RID: 266117 RVA: 0x00FBE424 File Offset: 0x00FBC624
		public bool CheckChallengeComplete(int challengeId)
		{
			MatchThreeLevelInfo matchThreeLevelInfo;
			return this.ChallengeState.TryGetValue(challengeId, out matchThreeLevelInfo) && matchThreeLevelInfo.FirstPass;
		}

		// Token: 0x06040F86 RID: 266118 RVA: 0x00FBE44C File Offset: 0x00FBC64C
		public bool CheckChallengeIsOpen(int challengeId)
		{
			MatchThreeLevelInfo matchThreeLevelInfo;
			return this.ChallengeState.TryGetValue(challengeId, out matchThreeLevelInfo) && TimeUtil.Instance.GetServerTime() >= (double)matchThreeLevelInfo.UnlockTime;
		}

		// Token: 0x06040F87 RID: 266119 RVA: 0x00FBE484 File Offset: 0x00FBC684
		[NullableContext(2)]
		public MatchThreeLevelInfo GetLevelInfo(int challengeId)
		{
			MatchThreeLevelInfo result;
			this.ChallengeState.TryGetValue(challengeId, out result);
			return result;
		}

		// Token: 0x06040F88 RID: 266120 RVA: 0x00FBE4A4 File Offset: 0x00FBC6A4
		public int GetCompleteChallengeCount()
		{
			int num = 0;
			foreach (KeyValuePair<int, MatchThreeLevelInfo> keyValuePair in this.ChallengeState)
			{
				if (keyValuePair.Value.FirstPass && this.IsChallengeCountedInProgress(keyValuePair.Key))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06040F89 RID: 266121 RVA: 0x00FBE514 File Offset: 0x00FBC714
		public int GetDisplayChallengeCount()
		{
			int num = 0;
			foreach (int challengeId in this.ChallengeState.Keys)
			{
				if (this.IsChallengeCountedInProgress(challengeId))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06040F8A RID: 266122 RVA: 0x00FBE578 File Offset: 0x00FBC778
		private bool IsChallengeCountedInProgress(int challengeId)
		{
			MatchThreeLevel? levelConfig = this.GetLevelConfig(challengeId);
			return levelConfig != null && (!levelConfig.Value.EndLess || this.IsEndlessLevelVisible(levelConfig.Value));
		}

		// Token: 0x06040F8B RID: 266123 RVA: 0x00FBE5B8 File Offset: 0x00FBC7B8
		protected override bool GetExDataFinishShowState()
		{
			int displayChallengeCount = this.GetDisplayChallengeCount();
			return displayChallengeCount > 0 && this.GetCompleteChallengeCount() == displayChallengeCount;
		}

		// Token: 0x06040F8C RID: 266124 RVA: 0x00FBE5DC File Offset: 0x00FBC7DC
		public override bool GetExDataRedPointShowState()
		{
			if (!base.GetPreGuideQuestFinishState())
			{
				return false;
			}
			foreach (MatchThreeChapterSelectData chapterData in this.GetChapterSelectDataList())
			{
				if (this.CheckChapterRedPointShow(chapterData))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06040F8D RID: 266125 RVA: 0x00FBE63C File Offset: 0x00FBC83C
		public IReadOnlyList<int> GetAllLevelIds()
		{
			return (from id in this.ChallengeState.Keys
			orderby id
			select id).ToList<int>();
		}

		// Token: 0x06040F8E RID: 266126 RVA: 0x00FBE672 File Offset: 0x00FBC872
		public MatchThreeLevel? GetLevelConfig(int levelId)
		{
			return ActivityMatchThreeConfig.Instance.GetLevelConfig(levelId);
		}

		// Token: 0x06040F8F RID: 266127 RVA: 0x00FBE680 File Offset: 0x00FBC880
		public IReadOnlyList<MatchThreeChapterSelectData> GetChapterSelectDataList()
		{
			if (this.BuildingChapterSelectDataList)
			{
				return Array.Empty<MatchThreeChapterSelectData>();
			}
			this.BuildingChapterSelectDataList = true;
			IReadOnlyList<MatchThreeChapterSelectData> result;
			try
			{
				IReadOnlyList<MatchThreeChapterSelectData> chapterSelectDataList = ActivityMatchThreeConfig.Instance.GetChapterSelectDataList(this.GetAllLevelIds());
				if (chapterSelectDataList.Count == 0)
				{
					result = chapterSelectDataList;
				}
				else
				{
					List<MatchThreeChapterSelectData> list = new List<MatchThreeChapterSelectData>(chapterSelectDataList.Count);
					foreach (MatchThreeChapterSelectData matchThreeChapterSelectData in chapterSelectDataList)
					{
						if (!matchThreeChapterSelectData.IsEndless || this.IsEndlessChapterVisible(matchThreeChapterSelectData))
						{
							list.Add(matchThreeChapterSelectData);
						}
					}
					result = list;
				}
			}
			finally
			{
				this.BuildingChapterSelectDataList = false;
			}
			return result;
		}

		// Token: 0x06040F90 RID: 266128 RVA: 0x00FBE734 File Offset: 0x00FBC934
		public bool IsRoleUnlocked(int roleId)
		{
			MatchThreeRole? roleConfig = ActivityMatchThreeConfig.Instance.GetRoleConfig(roleId);
			return roleConfig != null && this.IsRoleUnlocked(roleConfig.Value);
		}

		// Token: 0x06040F91 RID: 266129 RVA: 0x00FBE768 File Offset: 0x00FBC968
		public bool IsRoleUnlocked(MatchThreeRole roleConfig)
		{
			if (roleConfig.PreLevel <= 0)
			{
				return true;
			}
			MatchThreeLevel? levelConfig = this.GetLevelConfig(roleConfig.PreLevel);
			if (levelConfig == null)
			{
				return false;
			}
			int chapter = levelConfig.Value.Chapter;
			return chapter > 0 && this.IsChapterUnlocked(chapter);
		}

		// Token: 0x06040F92 RID: 266130 RVA: 0x00FBE7B8 File Offset: 0x00FBC9B8
		public bool IsChapterUnlocked(int chapter)
		{
			if (chapter <= 0)
			{
				return true;
			}
			foreach (MatchThreeChapterSelectData matchThreeChapterSelectData in ActivityMatchThreeConfig.Instance.GetChapterSelectDataList(this.GetAllLevelIds()))
			{
				if (matchThreeChapterSelectData.Chapter == chapter)
				{
					return this.GetChapterLockReason(matchThreeChapterSelectData) == EMatchThreeChapterLockReason.None;
				}
			}
			return false;
		}

		// Token: 0x06040F93 RID: 266131 RVA: 0x00FBE828 File Offset: 0x00FBCA28
		public int ResolvePreferredRoleId(int levelId)
		{
			MatchThreeLevel? levelConfig = this.GetLevelConfig(levelId);
			int chapter = (levelConfig != null) ? levelConfig.GetValueOrDefault().Chapter : 0;
			int cachedSelectedRoleId = this.GetCachedSelectedRoleId(chapter);
			if (cachedSelectedRoleId > 0 && this.IsRoleUnlocked(cachedSelectedRoleId))
			{
				return cachedSelectedRoleId;
			}
			int num = (levelConfig != null) ? levelConfig.GetValueOrDefault().DefaultRole : 0;
			if (num > 0 && this.IsRoleUnlocked(num))
			{
				return num;
			}
			foreach (MatchThreeRole roleConfig in ActivityMatchThreeConfig.Instance.GetAllRoleConfigs())
			{
				if (this.IsRoleUnlocked(roleConfig))
				{
					return roleConfig.Id;
				}
			}
			return 0;
		}

		// Token: 0x06040F94 RID: 266132 RVA: 0x00FBE8FC File Offset: 0x00FBCAFC
		public int GetCachedSelectedRoleId(int chapter)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 2, chapter, 0);
		}

		// Token: 0x06040F95 RID: 266133 RVA: 0x00FBE912 File Offset: 0x00FBCB12
		public void SaveSelectedRoleId(int chapter, int roleId)
		{
			if (chapter <= 0 || roleId <= 0)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 2, chapter, 0, roleId);
		}

		// Token: 0x06040F96 RID: 266134 RVA: 0x00FBE934 File Offset: 0x00FBCB34
		public IReadOnlyList<int> GetPendingUnlockTipRoleIds()
		{
			List<int> list = new List<int>();
			foreach (MatchThreeRole roleConfig in ActivityMatchThreeConfig.Instance.GetAllRoleConfigs())
			{
				if (roleConfig.PreLevel > 0 && this.IsRoleUnlocked(roleConfig) && !this.HasShownRoleUnlockTip(roleConfig.Id))
				{
					list.Add(roleConfig.Id);
				}
			}
			return list;
		}

		// Token: 0x06040F97 RID: 266135 RVA: 0x00FBE9B4 File Offset: 0x00FBCBB4
		private bool HasShownRoleUnlockTip(int roleId)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, roleId, 0) > 0;
		}

		// Token: 0x06040F98 RID: 266136 RVA: 0x00FBE9CD File Offset: 0x00FBCBCD
		public void MarkRoleUnlockTipShown(int roleId)
		{
			if (roleId <= 0)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 3, roleId, 0, 1);
			this.ActivateSelectRoleBtnRedDot();
			EventSystem.Instance.Emit(EEventName.OnMatchThreeRoleNewRedDotUpdate);
		}

		// Token: 0x06040F99 RID: 266137 RVA: 0x00FBE9FE File Offset: 0x00FBCBFE
		public bool HasNewRoleRedDot(int roleId)
		{
			return roleId > 0 && this.IsRoleUnlocked(roleId) && this.HasShownRoleUnlockTip(roleId) && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, roleId, 0) <= 0;
		}

		// Token: 0x06040F9A RID: 266138 RVA: 0x00FBEA34 File Offset: 0x00FBCC34
		public bool HasAnyNewRoleRedDot()
		{
			foreach (MatchThreeRole matchThreeRole in ActivityMatchThreeConfig.Instance.GetAllRoleConfigs())
			{
				if (this.HasNewRoleRedDot(matchThreeRole.Id))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06040F9B RID: 266139 RVA: 0x00FBEA94 File Offset: 0x00FBCC94
		public void MarkNewRoleRedDotClicked(int roleId)
		{
			if (roleId <= 0 || !this.HasNewRoleRedDot(roleId))
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 4, roleId, 0, 1);
			EventSystem.Instance.Emit(EEventName.OnMatchThreeRoleNewRedDotUpdate);
		}

		// Token: 0x06040F9C RID: 266140 RVA: 0x00FBEAC8 File Offset: 0x00FBCCC8
		public bool HasSelectRoleBtnRedDot()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, 0, 0) > 0;
		}

		// Token: 0x06040F9D RID: 266141 RVA: 0x00FBEAE1 File Offset: 0x00FBCCE1
		public void ActivateSelectRoleBtnRedDot()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 5, 0, 0, 1);
		}

		// Token: 0x06040F9E RID: 266142 RVA: 0x00FBEAF7 File Offset: 0x00FBCCF7
		public void MarkSelectRoleBtnRedDotClicked()
		{
			if (!this.HasSelectRoleBtnRedDot())
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 5, 0, 0, 0);
			EventSystem.Instance.Emit(EEventName.OnMatchThreeRoleNewRedDotUpdate);
		}

		// Token: 0x06040F9F RID: 266143 RVA: 0x00FBEB28 File Offset: 0x00FBCD28
		public bool IsEndlessChapterVisible(MatchThreeChapterSelectData chapterData)
		{
			if (!chapterData.IsEndless)
			{
				return true;
			}
			MatchThreeLevel? levelConfig = this.GetLevelConfig(chapterData.PrimaryLevelId);
			return levelConfig != null && this.IsEndlessLevelVisible(levelConfig.Value);
		}

		// Token: 0x06040FA0 RID: 266144 RVA: 0x00FBEB64 File Offset: 0x00FBCD64
		public bool IsEndlessLevelVisible(MatchThreeLevel levelConfig)
		{
			return !levelConfig.EndLess || (this.AreAllRegularChaptersComplete() && this.CheckChallengeIsOpen(levelConfig.Id));
		}

		// Token: 0x06040FA1 RID: 266145 RVA: 0x00FBEB88 File Offset: 0x00FBCD88
		public bool AreAllRegularChaptersComplete()
		{
			if (this.CachedRegularChaptersComplete != null)
			{
				return this.CachedRegularChaptersComplete.Value;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int levelId in this.ChallengeState.Keys)
			{
				MatchThreeLevel? levelConfig = this.GetLevelConfig(levelId);
				if (levelConfig != null)
				{
					MatchThreeLevel valueOrDefault = levelConfig.GetValueOrDefault();
					if (!valueOrDefault.EndLess && valueOrDefault.Chapter > 0)
					{
						hashSet.Add(levelConfig.Value.Chapter);
					}
				}
			}
			if (hashSet.Count == 0)
			{
				this.CachedRegularChaptersComplete = new bool?(false);
				return false;
			}
			foreach (int chapter in hashSet)
			{
				if (!this.CheckChapterNormalComplete(chapter))
				{
					this.CachedRegularChaptersComplete = new bool?(false);
					return false;
				}
			}
			this.CachedRegularChaptersComplete = new bool?(true);
			return true;
		}

		// Token: 0x06040FA2 RID: 266146 RVA: 0x00FBECB8 File Offset: 0x00FBCEB8
		public bool CheckChapterNormalComplete(int chapter)
		{
			if (chapter <= 0)
			{
				return true;
			}
			MatchThreeLevel? matchThreeLevel = null;
			foreach (int levelId in this.ChallengeState.Keys)
			{
				MatchThreeLevel? levelConfig = this.GetLevelConfig(levelId);
				if (levelConfig != null)
				{
					int chapter2 = levelConfig.GetValueOrDefault().Chapter;
					if (chapter2 == chapter && !levelConfig.Value.EndLess && (matchThreeLevel == null || levelConfig.Value.Difficulty < matchThreeLevel.Value.Difficulty))
					{
						matchThreeLevel = levelConfig;
					}
				}
			}
			return matchThreeLevel != null && this.CheckChallengeComplete(matchThreeLevel.Value.Id);
		}

		// Token: 0x06040FA3 RID: 266147 RVA: 0x00FBEDA0 File Offset: 0x00FBCFA0
		public bool CheckChapterAllDifficultiesComplete(int chapter)
		{
			if (chapter <= 0)
			{
				return true;
			}
			bool result = false;
			foreach (int num in this.ChallengeState.Keys)
			{
				MatchThreeLevel? levelConfig = this.GetLevelConfig(num);
				if (levelConfig != null)
				{
					int chapter2 = levelConfig.GetValueOrDefault().Chapter;
					if (chapter2 == chapter && !levelConfig.Value.EndLess)
					{
						result = true;
						if (!this.CheckChallengeComplete(num))
						{
							return false;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06040FA4 RID: 266148 RVA: 0x00FBEE48 File Offset: 0x00FBD048
		public bool CheckChapterTimeUnlocked(MatchThreeChapterSelectData chapterData)
		{
			foreach (int challengeId in chapterData.LevelIds)
			{
				if (this.CheckChallengeIsOpen(challengeId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06040FA5 RID: 266149 RVA: 0x00FBEEA4 File Offset: 0x00FBD0A4
		public bool CheckChapterPreUnlocked(MatchThreeChapterSelectData chapterData)
		{
			MatchThreeLevel? levelConfig = this.GetLevelConfig(chapterData.PrimaryLevelId);
			int chapter = (levelConfig != null) ? levelConfig.GetValueOrDefault().PreChapter : Math.Max(chapterData.Chapter - 1, 0);
			return this.CheckChapterNormalComplete(chapter);
		}

		// Token: 0x06040FA6 RID: 266150 RVA: 0x00FBEEF0 File Offset: 0x00FBD0F0
		public bool CheckPreChallengeComplete(int challengeId)
		{
			MatchThreeLevel? levelConfig = this.GetLevelConfig(challengeId);
			if (levelConfig == null)
			{
				return false;
			}
			int chapter = (levelConfig.Value.PreChapter > 0) ? levelConfig.Value.PreChapter : Math.Max(levelConfig.Value.Chapter - 1, 0);
			return this.CheckChapterNormalComplete(chapter) && (levelConfig.Value.Difficulty <= 0 || levelConfig.Value.EndLess || this.CheckChapterNormalComplete(levelConfig.Value.Chapter));
		}

		// Token: 0x06040FA7 RID: 266151 RVA: 0x00FBEF90 File Offset: 0x00FBD190
		public EMatchThreeChapterLockReason GetChapterLockReason(MatchThreeChapterSelectData chapterData)
		{
			if (!this.CheckChapterTimeUnlocked(chapterData))
			{
				return EMatchThreeChapterLockReason.Time;
			}
			if (!this.CheckChapterPreUnlocked(chapterData))
			{
				return EMatchThreeChapterLockReason.PreChapter;
			}
			return EMatchThreeChapterLockReason.None;
		}

		// Token: 0x06040FA8 RID: 266152 RVA: 0x00FBEFAC File Offset: 0x00FBD1AC
		public EMatchThreeChapterState GetChapterState(MatchThreeChapterSelectData chapterData)
		{
			EMatchThreeChapterLockReason chapterLockReason = this.GetChapterLockReason(chapterData);
			if (chapterLockReason != EMatchThreeChapterLockReason.None)
			{
				if (chapterLockReason != EMatchThreeChapterLockReason.Time)
				{
					return EMatchThreeChapterState.PreLocked;
				}
				return EMatchThreeChapterState.TimeLocked;
			}
			else
			{
				if (!this.IsChapterFullyComplete(chapterData))
				{
					return EMatchThreeChapterState.InProgress;
				}
				return EMatchThreeChapterState.Completed;
			}
		}

		// Token: 0x06040FA9 RID: 266153 RVA: 0x00FBEFD8 File Offset: 0x00FBD1D8
		public bool IsChapterFullyComplete(MatchThreeChapterSelectData chapterData)
		{
			foreach (int challengeId in chapterData.LevelIds)
			{
				if (!this.CheckChallengeComplete(challengeId))
				{
					return false;
				}
			}
			return chapterData.LevelIds.Count > 0;
		}

		// Token: 0x06040FAA RID: 266154 RVA: 0x00FBF044 File Offset: 0x00FBD244
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"CompleteCount",
			"TotalCount"
		})]
		public ValueTuple<int, int> GetChapterProgress([Nullable(1)] MatchThreeChapterSelectData chapterData)
		{
			return new ValueTuple<int, int>(chapterData.LevelIds.Count(new Func<int, bool>(this.CheckChallengeComplete)), chapterData.LevelIds.Count);
		}

		// Token: 0x06040FAB RID: 266155 RVA: 0x00FBF070 File Offset: 0x00FBD270
		public int GetEndlessBestScore(MatchThreeChapterSelectData chapterData)
		{
			if (!chapterData.IsEndless)
			{
				return 0;
			}
			foreach (int key in chapterData.LevelIds)
			{
				MatchThreeLevelInfo matchThreeLevelInfo;
				if (this.ChallengeState.TryGetValue(key, out matchThreeLevelInfo))
				{
					return matchThreeLevelInfo.HasScore ? matchThreeLevelInfo.Score : 0;
				}
			}
			return 0;
		}

		// Token: 0x06040FAC RID: 266156 RVA: 0x00FBF0F0 File Offset: 0x00FBD2F0
		public int GetEndlessBestScore(int levelId)
		{
			MatchThreeLevelInfo levelInfo = this.GetLevelInfo(levelId);
			if (levelInfo == null || !levelInfo.HasScore)
			{
				return 0;
			}
			return levelInfo.Score;
		}

		// Token: 0x06040FAD RID: 266157 RVA: 0x00FBF118 File Offset: 0x00FBD318
		public string GetUnlockDesc(int challengeId)
		{
			MatchThreeLevelInfo matchThreeLevelInfo;
			if (!this.ChallengeState.TryGetValue(challengeId, out matchThreeLevelInfo))
			{
				return string.Empty;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			if (serverTime >= (double)matchThreeLevelInfo.UnlockTime)
			{
				return string.Empty;
			}
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat3((double)matchThreeLevelInfo.UnlockTime - serverTime).CountDownText;
			if (string.IsNullOrEmpty(countDownText))
			{
				return string.Empty;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("MatchThree_TimeCountdown", null);
			if (string.IsNullOrEmpty(localTextNew))
			{
				return countDownText;
			}
			return StringUtils.Format(localTextNew, new string[]
			{
				countDownText
			});
		}

		// Token: 0x06040FAE RID: 266158 RVA: 0x00FBF1A4 File Offset: 0x00FBD3A4
		public bool CheckChapterRedPointShow(MatchThreeChapterSelectData chapterData)
		{
			EMatchThreeChapterState chapterState = this.GetChapterState(chapterData);
			bool flag = chapterState - EMatchThreeChapterState.TimeLocked <= 1;
			return !flag && !this.IsChapterFullyComplete(chapterData) && !this.CheckChapterClicked(chapterData.Chapter);
		}

		// Token: 0x06040FAF RID: 266159 RVA: 0x00FBF1E4 File Offset: 0x00FBD3E4
		public bool CheckChapterClicked(int chapter)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, chapter, 0) == 1;
		}

		// Token: 0x06040FB0 RID: 266160 RVA: 0x00FBF1FD File Offset: 0x00FBD3FD
		public void MarkChapterClicked(int chapter)
		{
			if (chapter <= 0 || this.CheckChapterClicked(chapter))
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 1, chapter, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06040FB1 RID: 266161 RVA: 0x00FBF238 File Offset: 0x00FBD438
		public int GetAutoFocusChapterIndex(IReadOnlyList<MatchThreeChapterSelectData> chapterList)
		{
			if (chapterList.Count == 0)
			{
				return 0;
			}
			int num = this.FindEarliestUnlockedIncompleteSimpleIndex(chapterList);
			if (num >= 0)
			{
				return num;
			}
			int num2 = this.FindUnlockedEndlessIndex(chapterList);
			bool flag = num2 >= 0;
			bool flag2 = flag && this.CheckChallengeComplete(chapterList[num2].PrimaryLevelId);
			int num3 = this.FindEarliestUnlockedIncompleteHardIndex(chapterList);
			if (this.AreAllRegularChaptersComplete())
			{
				if (flag && !flag2)
				{
					return num2;
				}
				if (num3 >= 0)
				{
					return num3;
				}
				if (flag)
				{
					return num2;
				}
				return chapterList.Count - 1;
			}
			else
			{
				if (num3 >= 0)
				{
					return num3;
				}
				int num4 = this.FindLastUnlockedIndex(chapterList);
				if (num4 < 0)
				{
					return chapterList.Count - 1;
				}
				return num4;
			}
		}

		// Token: 0x06040FB2 RID: 266162 RVA: 0x00FBF2D8 File Offset: 0x00FBD4D8
		private int FindEarliestUnlockedIncompleteSimpleIndex(IReadOnlyList<MatchThreeChapterSelectData> chapterList)
		{
			for (int i = 0; i < chapterList.Count; i++)
			{
				MatchThreeChapterSelectData matchThreeChapterSelectData = chapterList[i];
				if (!matchThreeChapterSelectData.IsEndless && this.GetChapterLockReason(matchThreeChapterSelectData) == EMatchThreeChapterLockReason.None && matchThreeChapterSelectData.NormalLevelId > 0 && !this.CheckChallengeComplete(matchThreeChapterSelectData.NormalLevelId))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06040FB3 RID: 266163 RVA: 0x00FBF32C File Offset: 0x00FBD52C
		private int FindEarliestUnlockedIncompleteHardIndex(IReadOnlyList<MatchThreeChapterSelectData> chapterList)
		{
			for (int i = 0; i < chapterList.Count; i++)
			{
				MatchThreeChapterSelectData matchThreeChapterSelectData = chapterList[i];
				if (!matchThreeChapterSelectData.IsEndless && this.GetChapterLockReason(matchThreeChapterSelectData) == EMatchThreeChapterLockReason.None && (matchThreeChapterSelectData.NormalLevelId <= 0 || this.CheckChallengeComplete(matchThreeChapterSelectData.NormalLevelId)) && matchThreeChapterSelectData.HardLevelId > 0 && !this.CheckChallengeComplete(matchThreeChapterSelectData.HardLevelId))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06040FB4 RID: 266164 RVA: 0x00FBF394 File Offset: 0x00FBD594
		private int FindUnlockedEndlessIndex(IReadOnlyList<MatchThreeChapterSelectData> chapterList)
		{
			for (int i = 0; i < chapterList.Count; i++)
			{
				MatchThreeChapterSelectData matchThreeChapterSelectData = chapterList[i];
				if (matchThreeChapterSelectData.IsEndless && this.GetChapterLockReason(matchThreeChapterSelectData) == EMatchThreeChapterLockReason.None)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06040FB5 RID: 266165 RVA: 0x00FBF3D0 File Offset: 0x00FBD5D0
		private int FindLastUnlockedIndex(IReadOnlyList<MatchThreeChapterSelectData> chapterList)
		{
			for (int i = chapterList.Count - 1; i >= 0; i--)
			{
				if (this.GetChapterLockReason(chapterList[i]) == EMatchThreeChapterLockReason.None)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06040FB6 RID: 266166 RVA: 0x00FBF404 File Offset: 0x00FBD604
		public void UpdateChallengeFirstPass(int challengeId, bool firstPass)
		{
			MatchThreeLevelInfo matchThreeLevelInfo;
			if (!this.ChallengeState.TryGetValue(challengeId, out matchThreeLevelInfo))
			{
				return;
			}
			matchThreeLevelInfo.FirstPass = firstPass;
			this.InvalidateChapterCache();
			EventSystem.Instance.Emit<int>(EEventName.OnMatchThreeChallengeStateUpdate, challengeId);
		}

		// Token: 0x06040FB7 RID: 266167 RVA: 0x00FBF440 File Offset: 0x00FBD640
		public void UpdateEndlessScore(int challengeId, int score)
		{
			MatchThreeLevelInfo matchThreeLevelInfo;
			if (!this.ChallengeState.TryGetValue(challengeId, out matchThreeLevelInfo))
			{
				return;
			}
			matchThreeLevelInfo.Score = score;
			EventSystem.Instance.Emit<int>(EEventName.OnMatchThreeChallengeStateUpdate, challengeId);
		}

		// Token: 0x06040FB8 RID: 266168 RVA: 0x00FBF478 File Offset: 0x00FBD678
		public int GmUnlockAllLevels()
		{
			if (this.ChallengeState.Count == 0)
			{
				return 0;
			}
			foreach (MatchThreeLevelInfo matchThreeLevelInfo in this.ChallengeState.Values)
			{
				matchThreeLevelInfo.UnlockTime = 0L;
				matchThreeLevelInfo.FirstPass = true;
			}
			this.InvalidateChapterCache();
			EventSystem.Instance.Emit<int>(EEventName.OnMatchThreeChallengeStateUpdate, 0);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			return this.ChallengeState.Count;
		}

		// Token: 0x06040FB9 RID: 266169 RVA: 0x00FBF520 File Offset: 0x00FBD720
		public bool GmUnlockLevel(int levelId)
		{
			if (levelId <= 0)
			{
				return false;
			}
			MatchThreeLevelInfo matchThreeLevelInfo;
			if (!this.ChallengeState.TryGetValue(levelId, out matchThreeLevelInfo))
			{
				if (this.GetLevelConfig(levelId) == null)
				{
					return false;
				}
				matchThreeLevelInfo = new MatchThreeLevelInfo
				{
					Id = levelId,
					UnlockTime = 0L,
					FirstPass = true
				};
				this.ChallengeState[levelId] = matchThreeLevelInfo;
			}
			else
			{
				matchThreeLevelInfo.UnlockTime = 0L;
				matchThreeLevelInfo.FirstPass = true;
			}
			this.InvalidateChapterCache();
			EventSystem.Instance.Emit<int>(EEventName.OnMatchThreeChallengeStateUpdate, levelId);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
			return true;
		}

		// Token: 0x04021E11 RID: 138769
		private readonly Dictionary<int, MatchThreeLevelInfo> ChallengeState = new Dictionary<int, MatchThreeLevelInfo>();

		// Token: 0x04021E12 RID: 138770
		private bool BuildingChapterSelectDataList;

		// Token: 0x04021E13 RID: 138771
		private bool? CachedRegularChaptersComplete;
	}
}
