using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x020054C0 RID: 21696
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityMatchThreeData : ActivityBaseData
	{
		// Token: 0x06035C48 RID: 220232 RVA: 0x00F05380 File Offset: 0x00F03580
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

		// Token: 0x06035C49 RID: 220233 RVA: 0x00F053FC File Offset: 0x00F035FC
		private void InvalidateChapterCache()
		{
			this.CachedRegularChaptersComplete = null;
		}

		// Token: 0x06035C4A RID: 220234 RVA: 0x00F0540C File Offset: 0x00F0360C
		public bool CheckChallengeComplete(int challengeId)
		{
			MatchThreeLevelInfo matchThreeLevelInfo;
			return this.ChallengeState.TryGetValue(challengeId, out matchThreeLevelInfo) && matchThreeLevelInfo.FirstPass;
		}

		// Token: 0x06035C4B RID: 220235 RVA: 0x00F05434 File Offset: 0x00F03634
		public bool CheckChallengeIsOpen(int challengeId)
		{
			MatchThreeLevelInfo matchThreeLevelInfo;
			return this.ChallengeState.TryGetValue(challengeId, out matchThreeLevelInfo) && TimeUtil.Instance.GetServerTime() >= (double)matchThreeLevelInfo.UnlockTime;
		}

		// Token: 0x06035C4C RID: 220236 RVA: 0x00F0546C File Offset: 0x00F0366C
		[NullableContext(2)]
		public MatchThreeLevelInfo GetLevelInfo(int challengeId)
		{
			MatchThreeLevelInfo result;
			this.ChallengeState.TryGetValue(challengeId, out result);
			return result;
		}

		// Token: 0x06035C4D RID: 220237 RVA: 0x00F0548C File Offset: 0x00F0368C
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

		// Token: 0x06035C4E RID: 220238 RVA: 0x00F054FC File Offset: 0x00F036FC
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

		// Token: 0x06035C4F RID: 220239 RVA: 0x00F05560 File Offset: 0x00F03760
		private bool IsChallengeCountedInProgress(int challengeId)
		{
			MatchThreeLevel? levelConfig = this.GetLevelConfig(challengeId);
			return levelConfig != null && (!levelConfig.Value.EndLess || this.IsEndlessLevelVisible(levelConfig.Value));
		}

		// Token: 0x06035C50 RID: 220240 RVA: 0x00F055A0 File Offset: 0x00F037A0
		protected override bool GetExDataFinishShowState()
		{
			int displayChallengeCount = this.GetDisplayChallengeCount();
			return displayChallengeCount > 0 && this.GetCompleteChallengeCount() == displayChallengeCount;
		}

		// Token: 0x06035C51 RID: 220241 RVA: 0x00F055C4 File Offset: 0x00F037C4
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

		// Token: 0x06035C52 RID: 220242 RVA: 0x00F05624 File Offset: 0x00F03824
		public IReadOnlyList<int> GetAllLevelIds()
		{
			List<int> list = new List<int>(this.ChallengeState.Keys);
			list.Sort();
			return list;
		}

		// Token: 0x06035C53 RID: 220243 RVA: 0x00F0563C File Offset: 0x00F0383C
		public MatchThreeLevel? GetLevelConfig(int levelId)
		{
			return ActivityMatchThreeConfig.Instance.GetLevelConfig(levelId);
		}

		// Token: 0x06035C54 RID: 220244 RVA: 0x00F0564C File Offset: 0x00F0384C
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

		// Token: 0x06035C55 RID: 220245 RVA: 0x00F05700 File Offset: 0x00F03900
		public bool IsRoleUnlocked(int roleId)
		{
			MatchThreeRole? roleConfig = ActivityMatchThreeConfig.Instance.GetRoleConfig(roleId);
			return roleConfig != null && this.IsRoleUnlocked(roleConfig.Value);
		}

		// Token: 0x06035C56 RID: 220246 RVA: 0x00F05734 File Offset: 0x00F03934
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

		// Token: 0x06035C57 RID: 220247 RVA: 0x00F05784 File Offset: 0x00F03984
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

		// Token: 0x06035C58 RID: 220248 RVA: 0x00F057F4 File Offset: 0x00F039F4
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

		// Token: 0x06035C59 RID: 220249 RVA: 0x00F058C8 File Offset: 0x00F03AC8
		public int GetCachedSelectedRoleId(int chapter)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 2, chapter, 0);
		}

		// Token: 0x06035C5A RID: 220250 RVA: 0x00F058DE File Offset: 0x00F03ADE
		public void SaveSelectedRoleId(int chapter, int roleId)
		{
			if (chapter <= 0 || roleId <= 0)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 2, chapter, 0, roleId);
		}

		// Token: 0x06035C5B RID: 220251 RVA: 0x00F05900 File Offset: 0x00F03B00
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

		// Token: 0x06035C5C RID: 220252 RVA: 0x00F05980 File Offset: 0x00F03B80
		private bool HasShownRoleUnlockTip(int roleId)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 3, roleId, 0) > 0;
		}

		// Token: 0x06035C5D RID: 220253 RVA: 0x00F05999 File Offset: 0x00F03B99
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

		// Token: 0x06035C5E RID: 220254 RVA: 0x00F059CA File Offset: 0x00F03BCA
		public bool HasNewRoleRedDot(int roleId)
		{
			return roleId > 0 && this.IsRoleUnlocked(roleId) && this.HasShownRoleUnlockTip(roleId) && ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 4, roleId, 0) <= 0;
		}

		// Token: 0x06035C5F RID: 220255 RVA: 0x00F05A00 File Offset: 0x00F03C00
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

		// Token: 0x06035C60 RID: 220256 RVA: 0x00F05A60 File Offset: 0x00F03C60
		public void MarkNewRoleRedDotClicked(int roleId)
		{
			if (roleId <= 0 || !this.HasNewRoleRedDot(roleId))
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 4, roleId, 0, 1);
			EventSystem.Instance.Emit(EEventName.OnMatchThreeRoleNewRedDotUpdate);
		}

		// Token: 0x06035C61 RID: 220257 RVA: 0x00F05A94 File Offset: 0x00F03C94
		public bool HasSelectRoleBtnRedDot()
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 5, 0, 0) > 0;
		}

		// Token: 0x06035C62 RID: 220258 RVA: 0x00F05AAD File Offset: 0x00F03CAD
		public void ActivateSelectRoleBtnRedDot()
		{
			ActivityModel.Instance.SaveActivityData(base.Id, 5, 0, 0, 1);
		}

		// Token: 0x06035C63 RID: 220259 RVA: 0x00F05AC3 File Offset: 0x00F03CC3
		public void MarkSelectRoleBtnRedDotClicked()
		{
			if (!this.HasSelectRoleBtnRedDot())
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 5, 0, 0, 0);
			EventSystem.Instance.Emit(EEventName.OnMatchThreeRoleNewRedDotUpdate);
		}

		// Token: 0x06035C64 RID: 220260 RVA: 0x00F05AF4 File Offset: 0x00F03CF4
		public bool IsEndlessChapterVisible(MatchThreeChapterSelectData chapterData)
		{
			if (!chapterData.IsEndless)
			{
				return true;
			}
			MatchThreeLevel? levelConfig = this.GetLevelConfig(chapterData.PrimaryLevelId);
			return levelConfig != null && this.IsEndlessLevelVisible(levelConfig.Value);
		}

		// Token: 0x06035C65 RID: 220261 RVA: 0x00F05B30 File Offset: 0x00F03D30
		public bool IsEndlessLevelVisible(MatchThreeLevel levelConfig)
		{
			return !levelConfig.EndLess || (this.AreAllRegularChaptersComplete() && this.CheckChallengeIsOpen(levelConfig.Id));
		}

		// Token: 0x06035C66 RID: 220262 RVA: 0x00F05B54 File Offset: 0x00F03D54
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

		// Token: 0x06035C67 RID: 220263 RVA: 0x00F05C84 File Offset: 0x00F03E84
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

		// Token: 0x06035C68 RID: 220264 RVA: 0x00F05D6C File Offset: 0x00F03F6C
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

		// Token: 0x06035C69 RID: 220265 RVA: 0x00F05E14 File Offset: 0x00F04014
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

		// Token: 0x06035C6A RID: 220266 RVA: 0x00F05E70 File Offset: 0x00F04070
		public bool CheckChapterPreUnlocked(MatchThreeChapterSelectData chapterData)
		{
			MatchThreeLevel? levelConfig = this.GetLevelConfig(chapterData.PrimaryLevelId);
			int chapter = (levelConfig != null) ? levelConfig.GetValueOrDefault().PreChapter : Math.Max(chapterData.Chapter - 1, 0);
			return this.CheckChapterNormalComplete(chapter);
		}

		// Token: 0x06035C6B RID: 220267 RVA: 0x00F05EBC File Offset: 0x00F040BC
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

		// Token: 0x06035C6C RID: 220268 RVA: 0x00F05F5C File Offset: 0x00F0415C
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

		// Token: 0x06035C6D RID: 220269 RVA: 0x00F05F78 File Offset: 0x00F04178
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

		// Token: 0x06035C6E RID: 220270 RVA: 0x00F05FA4 File Offset: 0x00F041A4
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

		// Token: 0x06035C6F RID: 220271 RVA: 0x00F06010 File Offset: 0x00F04210
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"CompleteCount",
			"TotalCount"
		})]
		public ValueTuple<int, int> GetChapterProgress([Nullable(1)] MatchThreeChapterSelectData chapterData)
		{
			int num = 0;
			for (int i = 0; i < chapterData.LevelIds.Count; i++)
			{
				if (this.CheckChallengeComplete(chapterData.LevelIds[i]))
				{
					num++;
				}
			}
			return new ValueTuple<int, int>(num, chapterData.LevelIds.Count);
		}

		// Token: 0x06035C70 RID: 220272 RVA: 0x00F06060 File Offset: 0x00F04260
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

		// Token: 0x06035C71 RID: 220273 RVA: 0x00F060E0 File Offset: 0x00F042E0
		public int GetEndlessBestScore(int levelId)
		{
			MatchThreeLevelInfo levelInfo = this.GetLevelInfo(levelId);
			if (levelInfo == null || !levelInfo.HasScore)
			{
				return 0;
			}
			return levelInfo.Score;
		}

		// Token: 0x06035C72 RID: 220274 RVA: 0x00F06108 File Offset: 0x00F04308
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

		// Token: 0x06035C73 RID: 220275 RVA: 0x00F06194 File Offset: 0x00F04394
		public bool CheckChapterRedPointShow(MatchThreeChapterSelectData chapterData)
		{
			EMatchThreeChapterState chapterState = this.GetChapterState(chapterData);
			bool flag = chapterState - EMatchThreeChapterState.TimeLocked <= 1;
			return !flag && !this.IsChapterFullyComplete(chapterData) && !this.CheckChapterClicked(chapterData.Chapter);
		}

		// Token: 0x06035C74 RID: 220276 RVA: 0x00F061D4 File Offset: 0x00F043D4
		public bool CheckChapterClicked(int chapter)
		{
			return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, 1, chapter, 0) == 1;
		}

		// Token: 0x06035C75 RID: 220277 RVA: 0x00F061ED File Offset: 0x00F043ED
		public void MarkChapterClicked(int chapter)
		{
			if (chapter <= 0 || this.CheckChapterClicked(chapter))
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(base.Id, 1, chapter, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
		}

		// Token: 0x06035C76 RID: 220278 RVA: 0x00F06228 File Offset: 0x00F04428
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

		// Token: 0x06035C77 RID: 220279 RVA: 0x00F062C8 File Offset: 0x00F044C8
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

		// Token: 0x06035C78 RID: 220280 RVA: 0x00F0631C File Offset: 0x00F0451C
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

		// Token: 0x06035C79 RID: 220281 RVA: 0x00F06384 File Offset: 0x00F04584
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

		// Token: 0x06035C7A RID: 220282 RVA: 0x00F063C0 File Offset: 0x00F045C0
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

		// Token: 0x06035C7B RID: 220283 RVA: 0x00F063F4 File Offset: 0x00F045F4
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

		// Token: 0x06035C7C RID: 220284 RVA: 0x00F06430 File Offset: 0x00F04630
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

		// Token: 0x06035C7D RID: 220285 RVA: 0x00F06468 File Offset: 0x00F04668
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

		// Token: 0x06035C7E RID: 220286 RVA: 0x00F06510 File Offset: 0x00F04710
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

		// Token: 0x0401C742 RID: 116546
		private readonly Dictionary<int, MatchThreeLevelInfo> ChallengeState = new Dictionary<int, MatchThreeLevelInfo>();

		// Token: 0x0401C743 RID: 116547
		private bool BuildingChapterSelectDataList;

		// Token: 0x0401C744 RID: 116548
		private bool? CachedRegularChaptersComplete;
	}
}
