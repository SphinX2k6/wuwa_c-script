using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

// Token: 0x02001125 RID: 4389
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerData : ActivityBaseData
{
	// Token: 0x06007315 RID: 29461 RVA: 0x0017A6A8 File Offset: 0x001788A8
	protected override void PhraseEx(ActivityData data)
	{
		this.HardLevelDataMap.Clear();
		this.NormalLevelDataMap.Clear();
		this.RoleLockData.Clear();
		this.UpdateLevelInfosAndNotify(data.BabelActivityInfo.BabelActivityLevelInfos);
		this.NormalQuest.Clear();
		foreach (ActivityTask activityTask in data.BabelActivityInfo.ActivityTasks)
		{
			this.NormalQuest[activityTask.Id] = activityTask;
		}
		this.DailyQuest.Clear();
		foreach (ActivityTask activityTask2 in data.BabelActivityInfo.DailyActivityTask)
		{
			this.DailyQuest[activityTask2.Id] = activityTask2;
		}
		this.BuffUnlock.Clear();
		foreach (BabelActivityBuffInfo babelActivityBuffInfo in data.BabelActivityInfo.BabelActivityBuffInfos)
		{
			this.BuffUnlock[babelActivityBuffInfo.BabelBuffId] = babelActivityBuffInfo.DifficultUnlock;
		}
		this.DeTermUnlock.Clear();
		foreach (BabelActivityDeTermInfo babelActivityDeTermInfo in data.BabelActivityInfo.BabelActivityDeTermInfos)
		{
			this.DeTermUnlock[babelActivityDeTermInfo.DeTermId] = babelActivityDeTermInfo.DifficultUnlock;
		}
		this.CurrentItemCount = data.BabelActivityInfo.ActivityItemNum;
		if (UiManager.Instance.IsViewOpen(EUiViewName.BabelTowerQuestView))
		{
			UiManager.Instance.CloseView(EUiViewName.BabelTowerQuestView, null);
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06007316 RID: 29462 RVA: 0x0017A8A4 File Offset: 0x00178AA4
	public void UpdateLevelInfosAndNotify(IEnumerable<BabelActivityLevelInfo> levelInfos)
	{
		HashSet<EBabelTowerDifficulty> hashSet = new HashSet<EBabelTowerDifficulty>();
		foreach (BabelActivityLevelInfo babelActivityLevelInfo in levelInfos)
		{
			if (BabelTowerConfig.Instance.GetBabelTowerLevelConfig(babelActivityLevelInfo.LevelsId).IsDifficult)
			{
				this.HardLevelDataMap[babelActivityLevelInfo.LevelsId] = babelActivityLevelInfo;
				hashSet.Add(EBabelTowerDifficulty.Hard);
			}
			else
			{
				this.NormalLevelDataMap[babelActivityLevelInfo.LevelsId] = babelActivityLevelInfo;
				hashSet.Add(EBabelTowerDifficulty.Normal);
			}
			this.RoleLockData[babelActivityLevelInfo.LevelsId] = new List<int>(babelActivityLevelInfo.LimitWeaponTypes);
		}
		this.UpdateAllLevelRoleIds();
		foreach (BabelActivityLevelInfo babelActivityLevelInfo2 in levelInfos)
		{
			EventSystem.Instance.Emit<int>(EEventName.BabelTowerLevelRedDotUpdate, babelActivityLevelInfo2.LevelsId);
		}
		foreach (EBabelTowerDifficulty p in hashSet)
		{
			EventSystem.Instance.Emit<int>(EEventName.BabelTowerDifficultyRedDotUpdate, (int)p);
		}
	}

	// Token: 0x06007317 RID: 29463 RVA: 0x0017A9F0 File Offset: 0x00178BF0
	public void UpdateAllLevelRoleIds()
	{
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in this.NormalLevelDataMap)
		{
			this.<UpdateAllLevelRoleIds>g__FixList|12_0(keyValuePair.Value.RoleSelection);
			this.<UpdateAllLevelRoleIds>g__FixList|12_0(keyValuePair.Value.MaxPassRoleSelection);
		}
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair2 in this.HardLevelDataMap)
		{
			this.<UpdateAllLevelRoleIds>g__FixList|12_0(keyValuePair2.Value.RoleSelection);
			this.<UpdateAllLevelRoleIds>g__FixList|12_0(keyValuePair2.Value.MaxPassRoleSelection);
		}
	}

	// Token: 0x06007318 RID: 29464 RVA: 0x0017AAC0 File Offset: 0x00178CC0
	public int CheckMainCharacterCorrect(int roleId)
	{
		if (roleId <= 0)
		{
			return roleId;
		}
		RoleModel instance = RoleModel.Instance;
		if (roleId < 100000)
		{
			if (!instance.IsMainRole(roleId))
			{
				return roleId;
			}
			return instance.GetCurSelectMainRoleId().GetValueOrDefault(roleId);
		}
		else
		{
			TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(roleId);
			int num = (trialRoleConfig != null) ? trialRoleConfig.GetValueOrDefault().ParentId : 0;
			if (num <= 0 || !instance.IsMainRole(num))
			{
				return roleId;
			}
			TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(trialRoleConfig.Value.GroupId);
			if (trialRoleConfigByGroupId == null)
			{
				return 0;
			}
			return trialRoleConfigByGroupId.GetValueOrDefault().Id;
		}
	}

	// Token: 0x06007319 RID: 29465 RVA: 0x0017AB6C File Offset: 0x00178D6C
	[NullableContext(2)]
	public string GetNextLevelOpenTimeText()
	{
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in this.NormalLevelDataMap)
		{
			long num = MathUtils.Instance.LongToNumber(keyValuePair.Value.UnlockTime);
			if (serverTimeStamp < (double)num)
			{
				return TimeUtil.Instance.GetRemainTimeDataFormat((double)((long)(((double)num - serverTimeStamp) * TimeUtil.Instance.Millisecond))).CountDownText;
			}
		}
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair2 in this.HardLevelDataMap)
		{
			long num2 = MathUtils.Instance.LongToNumber(keyValuePair2.Value.UnlockTime);
			if (serverTimeStamp < (double)num2)
			{
				return TimeUtil.Instance.GetRemainTimeDataFormat((double)((long)(((double)num2 - serverTimeStamp) * TimeUtil.Instance.Millisecond))).CountDownText;
			}
		}
		return null;
	}

	// Token: 0x0600731A RID: 29466 RVA: 0x0017AC8C File Offset: 0x00178E8C
	public string GetNormalLevelPassText()
	{
		int num = 0;
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in this.NormalLevelDataMap)
		{
			if (keyValuePair.Value.IsFinished)
			{
				num++;
			}
		}
		return num.ToString() + "/" + this.NormalLevelDataMap.Count.ToString();
	}

	// Token: 0x0600731B RID: 29467 RVA: 0x0017AD10 File Offset: 0x00178F10
	public string GetHardLevelStarText()
	{
		int num = 0;
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in this.HardLevelDataMap)
		{
			num += keyValuePair.Value.PassStar;
		}
		return num.ToString() ?? "";
	}

	// Token: 0x0600731C RID: 29468 RVA: 0x0017AD80 File Offset: 0x00178F80
	public bool GetBuffIsLock(int buffId)
	{
		bool flag;
		return !this.BuffUnlock.TryGetValue(buffId, out flag) || !flag;
	}

	// Token: 0x0600731D RID: 29469 RVA: 0x0017ADA4 File Offset: 0x00178FA4
	public int GetBuffIsUse(int buffId)
	{
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in this.HardLevelDataMap)
		{
			if (keyValuePair.Value.MaxPassBuffSelection != null && keyValuePair.Value.MaxPassBuffSelection.Contains(buffId))
			{
				return keyValuePair.Key;
			}
		}
		return -1;
	}

	// Token: 0x0600731E RID: 29470 RVA: 0x0017AE20 File Offset: 0x00179020
	public bool GetDeTermIsLock(int deTerm)
	{
		bool flag;
		return !this.DeTermUnlock.TryGetValue(deTerm, out flag) || !flag;
	}

	// Token: 0x0600731F RID: 29471 RVA: 0x0017AE44 File Offset: 0x00179044
	public bool GetDeTermIsUse(int levelId, int deTerm)
	{
		BabelActivityLevelInfo babelActivityLevelInfo = null;
		BabelActivityLevelInfo babelActivityLevelInfo2;
		BabelActivityLevelInfo babelActivityLevelInfo3;
		if (this.NormalLevelDataMap.TryGetValue(levelId, out babelActivityLevelInfo2))
		{
			babelActivityLevelInfo = babelActivityLevelInfo2;
		}
		else if (this.HardLevelDataMap.TryGetValue(levelId, out babelActivityLevelInfo3))
		{
			babelActivityLevelInfo = babelActivityLevelInfo3;
		}
		return babelActivityLevelInfo != null && babelActivityLevelInfo.BabelDeTermId.Contains(deTerm);
	}

	// Token: 0x06007320 RID: 29472 RVA: 0x0017AE8C File Offset: 0x0017908C
	[NullableContext(2)]
	public BabelActivityLevelInfo GetLevelInfo(int levelId)
	{
		BabelActivityLevelInfo result;
		if (this.NormalLevelDataMap.TryGetValue(levelId, out result))
		{
			return result;
		}
		BabelActivityLevelInfo result2;
		if (this.HardLevelDataMap.TryGetValue(levelId, out result2))
		{
			return result2;
		}
		return null;
	}

	// Token: 0x06007321 RID: 29473 RVA: 0x0017AEC0 File Offset: 0x001790C0
	public bool GetQuestAnyRedDot()
	{
		foreach (KeyValuePair<int, ActivityTask> keyValuePair in this.DailyQuest)
		{
			if (keyValuePair.Value.Status == ActivityTaskState.ActivityTaskFinish)
			{
				return true;
			}
		}
		foreach (KeyValuePair<int, ActivityTask> keyValuePair2 in this.NormalQuest)
		{
			if (keyValuePair2.Value.Status == ActivityTaskState.ActivityTaskFinish)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007322 RID: 29474 RVA: 0x0017AF70 File Offset: 0x00179170
	public bool GetDifficultyNewLevelRedDot(int difficulty)
	{
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in ((difficulty == 0) ? this.NormalLevelDataMap : this.HardLevelDataMap))
		{
			if ((double)MathUtils.Instance.LongToNumber(keyValuePair.Value.UnlockTime) <= serverTimeStamp)
			{
				Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.BabelTowerNewLevelHasClick, null);
				bool flag;
				if (player == null || !player.TryGetValue(keyValuePair.Key, out flag) || !flag)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06007323 RID: 29475 RVA: 0x0017B018 File Offset: 0x00179218
	public bool GetNewLevelRedDot(int levelId)
	{
		BabelActivityLevelInfo babelActivityLevelInfo;
		if (!(BabelTowerConfig.Instance.GetBabelTowerLevelConfig(levelId).IsDifficult ? this.HardLevelDataMap : this.NormalLevelDataMap).TryGetValue(levelId, out babelActivityLevelInfo))
		{
			return false;
		}
		if (TimeUtil.Instance.GetServerTimeStamp() < (double)MathUtils.Instance.LongToNumber(babelActivityLevelInfo.UnlockTime))
		{
			return false;
		}
		Dictionary<int, bool> player = LocalStorage.GetPlayer<Dictionary<int, bool>>(ELocalStoragePlayerKey.BabelTowerNewLevelHasClick, null);
		bool flag;
		return player == null || !player.TryGetValue(levelId, out flag) || !flag;
	}

	// Token: 0x06007324 RID: 29476 RVA: 0x0017B090 File Offset: 0x00179290
	public int GetNewLevel()
	{
		long num = 0L;
		double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		int result = 0;
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in this.NormalLevelDataMap)
		{
			long num2 = MathUtils.Instance.LongToNumber(keyValuePair.Value.UnlockTime);
			if ((double)num2 <= serverTimeStamp && num < num2)
			{
				result = keyValuePair.Key;
				num = num2;
			}
		}
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair2 in this.HardLevelDataMap)
		{
			long num3 = MathUtils.Instance.LongToNumber(keyValuePair2.Value.UnlockTime);
			if ((double)num3 <= serverTimeStamp && num < num3)
			{
				result = keyValuePair2.Key;
				num = num3;
			}
		}
		return result;
	}

	// Token: 0x06007325 RID: 29477 RVA: 0x0017B188 File Offset: 0x00179388
	public bool GetQuestTabRedDot(int tabIndex)
	{
		foreach (KeyValuePair<int, ActivityTask> keyValuePair in this.NormalQuest)
		{
			BabelTowerTask babelTowerNormalQuest = BabelTowerConfig.Instance.GetBabelTowerNormalQuest(keyValuePair.Key);
			BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(babelTowerNormalQuest.LevelId);
			if (babelTowerLevelConfig.IsDifficult && tabIndex == 1)
			{
				if (keyValuePair.Value.Status == ActivityTaskState.ActivityTaskFinish)
				{
					return true;
				}
			}
			else if (!babelTowerLevelConfig.IsDifficult && tabIndex == 0 && keyValuePair.Value.Status == ActivityTaskState.ActivityTaskFinish)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007326 RID: 29478 RVA: 0x0017B240 File Offset: 0x00179440
	public List<int> GetDailyDeTerm()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, ActivityTask> keyValuePair in this.DailyQuest)
		{
			if (keyValuePair.Value.Status == ActivityTaskState.ActivityTaskRunning)
			{
				int[] showDeTermArray = BabelTowerConfig.Instance.GetBabelTowerDailyQuest(keyValuePair.Key).GetShowDeTermArray();
				if (showDeTermArray != null)
				{
					list.AddRange(showDeTermArray);
				}
			}
		}
		return list;
	}

	// Token: 0x06007327 RID: 29479 RVA: 0x0017B2C8 File Offset: 0x001794C8
	public List<int> GetDailyLevel()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, ActivityTask> keyValuePair in this.DailyQuest)
		{
			if (keyValuePair.Value.Status == ActivityTaskState.ActivityTaskRunning)
			{
				list.Add(BabelTowerConfig.Instance.GetBabelTowerDailyQuest(keyValuePair.Key).JumpToLevelId);
			}
		}
		return list;
	}

	// Token: 0x06007328 RID: 29480 RVA: 0x0017B348 File Offset: 0x00179548
	public override bool GetExDataRedPointShowState()
	{
		return this.GetQuestAnyRedDot() || this.GetDifficultyNewLevelRedDot(0) || this.GetDifficultyNewLevelRedDot(1);
	}

	// Token: 0x06007329 RID: 29481 RVA: 0x0017B364 File Offset: 0x00179564
	protected override bool GetExDataFinishShowState()
	{
		if (this.NormalQuest.Count <= 0 && this.DailyQuest.Count <= 0)
		{
			return false;
		}
		using (Dictionary<int, ActivityTask>.ValueCollection.Enumerator enumerator = this.NormalQuest.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status != ActivityTaskState.ActivityTaskTaken)
				{
					return false;
				}
			}
		}
		using (Dictionary<int, ActivityTask>.ValueCollection.Enumerator enumerator = this.DailyQuest.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status != ActivityTaskState.ActivityTaskTaken)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600732A RID: 29482 RVA: 0x0017B42C File Offset: 0x0017962C
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"Finished",
		"Total"
	})]
	public ValueTuple<int, int> GetNormalQuestCount()
	{
		int num = 0;
		foreach (KeyValuePair<int, ActivityTask> keyValuePair in this.NormalQuest)
		{
			if (keyValuePair.Value.Status == ActivityTaskState.ActivityTaskTaken)
			{
				num++;
			}
		}
		return new ValueTuple<int, int>(num, this.NormalQuest.Count);
	}

	// Token: 0x0600732B RID: 29483 RVA: 0x0017B4A0 File Offset: 0x001796A0
	public List<int> GetFinishedTaskIds()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, ActivityTask> keyValuePair in this.NormalQuest)
		{
			if (keyValuePair.Value.Status == ActivityTaskState.ActivityTaskFinish)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x0600732C RID: 29484 RVA: 0x0017B510 File Offset: 0x00179710
	public void SetRawFriendData(List<PublicBabelTowerInfo> data)
	{
		this.RawFriendData = data;
	}

	// Token: 0x0600732D RID: 29485 RVA: 0x0017B519 File Offset: 0x00179719
	public List<PublicBabelTowerInfo> GetRawFriendData()
	{
		return this.RawFriendData;
	}

	// Token: 0x0600732E RID: 29486 RVA: 0x0017B521 File Offset: 0x00179721
	[NullableContext(2)]
	public void SetRawSelfData(PublicBabelTowerInfo data)
	{
		this.RawSelfData = data;
	}

	// Token: 0x0600732F RID: 29487 RVA: 0x0017B52A File Offset: 0x0017972A
	[NullableContext(2)]
	public PublicBabelTowerInfo GetRawSelfData()
	{
		return this.RawSelfData;
	}

	// Token: 0x06007330 RID: 29488 RVA: 0x0017B532 File Offset: 0x00179732
	public bool GetSelfShowName()
	{
		PublicBabelTowerInfo rawSelfData = this.RawSelfData;
		return rawSelfData == null || rawSelfData.ShowName;
	}

	// Token: 0x06007331 RID: 29489 RVA: 0x0017B545 File Offset: 0x00179745
	public void SetSelfShowName(bool showName)
	{
		if (this.RawSelfData != null)
		{
			this.RawSelfData.ShowName = showName;
		}
	}

	// Token: 0x06007332 RID: 29490 RVA: 0x0017B55C File Offset: 0x0017975C
	public List<int> GetAllRankLevelIds()
	{
		List<int> list = new List<int>
		{
			-1
		};
		foreach (BabelTowerLevel babelTowerLevel in BabelTowerConfig.Instance.GetAllBabelTowerDifficultLevel(base.Id))
		{
			list.Add(babelTowerLevel.Id);
		}
		list.Sort((int a, int b) => a - b);
		return list;
	}

	// Token: 0x06007333 RID: 29491 RVA: 0x0017B5EC File Offset: 0x001797EC
	public int GetLevelPassTime(int levelId)
	{
		PublicBabelTowerInfo rawSelfData = this.RawSelfData;
		if (((rawSelfData != null) ? rawSelfData.ChallengeInfo : null) == null)
		{
			return 0;
		}
		PublicBabelTowerChallengeInfo publicBabelTowerChallengeInfo = rawSelfData.ChallengeInfo.FirstOrDefault((PublicBabelTowerChallengeInfo c) => c.ChallengeId == levelId);
		if (publicBabelTowerChallengeInfo == null)
		{
			return 0;
		}
		return publicBabelTowerChallengeInfo.UseTime;
	}

	// Token: 0x06007334 RID: 29492 RVA: 0x0017B63F File Offset: 0x0017983F
	public void ClearMyRankData()
	{
		this.RawSelfData = null;
	}

	// Token: 0x06007335 RID: 29493 RVA: 0x0017B648 File Offset: 0x00179848
	public void SaveOldRankData(int levelId, int levelRank, int totalRank)
	{
		this.OldLevelRankMap[levelId] = levelRank;
		this.OldTotalRank = totalRank;
	}

	// Token: 0x06007336 RID: 29494 RVA: 0x0017B660 File Offset: 0x00179860
	public void CacheAllOldRanks()
	{
		foreach (int num in this.HardLevelDataMap.Keys)
		{
			this.OldLevelRankMap[num] = this.CalcMyRankFromRawData(true, num);
		}
		this.OldTotalRank = this.CalcMyRankFromRawData(false, -1);
	}

	// Token: 0x06007337 RID: 29495 RVA: 0x0017B6D4 File Offset: 0x001798D4
	public int GetOldLevelRank(int levelId)
	{
		int result;
		if (!this.OldLevelRankMap.TryGetValue(levelId, out result))
		{
			return -1;
		}
		return result;
	}

	// Token: 0x06007338 RID: 29496 RVA: 0x0017B6F4 File Offset: 0x001798F4
	public int GetOldTotalRank()
	{
		return this.OldTotalRank;
	}

	// Token: 0x06007339 RID: 29497 RVA: 0x0017B6FC File Offset: 0x001798FC
	public int CalcMyRankFromRawData(bool isLevelRank, int levelId)
	{
		BabelTowerData.<>c__DisplayClass48_0 CS$<>8__locals1 = new BabelTowerData.<>c__DisplayClass48_0();
		CS$<>8__locals1.isLevelRank = isLevelRank;
		CS$<>8__locals1.levelId = levelId;
		if (this.RawSelfData == null)
		{
			return -1;
		}
		ValueTuple<int, int> valueTuple = CS$<>8__locals1.<CalcMyRankFromRawData>g__GetScore|0(this.RawSelfData);
		if (valueTuple.Item2 <= 0)
		{
			return -1;
		}
		int playerId = this.RawSelfData.PlayerId;
		int num = 0;
		foreach (PublicBabelTowerInfo publicBabelTowerInfo in this.RawFriendData)
		{
			ValueTuple<int, int> valueTuple2 = CS$<>8__locals1.<CalcMyRankFromRawData>g__GetScore|0(publicBabelTowerInfo);
			if (valueTuple2.Item2 > 0)
			{
				bool flag;
				if (valueTuple2.Item1 != valueTuple.Item1)
				{
					flag = (valueTuple2.Item1 > valueTuple.Item1);
				}
				else if (valueTuple2.Item2 != valueTuple.Item2)
				{
					flag = (valueTuple2.Item2 < valueTuple.Item2);
				}
				else
				{
					flag = (publicBabelTowerInfo.PlayerId < playerId);
				}
				if (flag)
				{
					num++;
				}
			}
		}
		return num + 1;
	}

	// Token: 0x0600733A RID: 29498 RVA: 0x0017B800 File Offset: 0x00179A00
	public int GetSelfHeadId()
	{
		return PersonalModel.Instance.GetHeadPhotoId();
	}

	// Token: 0x0600733B RID: 29499 RVA: 0x0017B80C File Offset: 0x00179A0C
	[NullableContext(0)]
	[return: TupleElementNames(new string[]
	{
		"TitleId",
		"TitleStarLevel"
	})]
	public ValueTuple<int, int> GetSelfTitleInfo()
	{
		PersonalModel instance = PersonalModel.Instance;
		int dressedPlayerTitleId = instance.GetDressedPlayerTitleId();
		if (dressedPlayerTitleId > 0)
		{
			return new ValueTuple<int, int>(dressedPlayerTitleId, instance.GetDressedPlayerTitleLevel());
		}
		PublicBabelTowerInfo rawSelfData = this.RawSelfData;
		int item = (rawSelfData != null) ? rawSelfData.TitleId : 0;
		PublicBabelTowerInfo rawSelfData2 = this.RawSelfData;
		return new ValueTuple<int, int>(item, (rawSelfData2 != null) ? rawSelfData2.TitleExtraParam : 0);
	}

	// Token: 0x0600733D RID: 29501 RVA: 0x0017B8D8 File Offset: 0x00179AD8
	[NullableContext(2)]
	[CompilerGenerated]
	private void <UpdateAllLevelRoleIds>g__FixList|12_0(RepeatedField<int> list)
	{
		if (list == null)
		{
			return;
		}
		for (int i = 0; i < list.Count; i++)
		{
			list[i] = this.CheckMainCharacterCorrect(list[i]);
		}
	}

	// Token: 0x0400351E RID: 13598
	private readonly Dictionary<int, int> OldLevelRankMap = new Dictionary<int, int>();

	// Token: 0x0400351F RID: 13599
	private int OldTotalRank;

	// Token: 0x04003520 RID: 13600
	public Dictionary<int, BabelActivityLevelInfo> NormalLevelDataMap = new Dictionary<int, BabelActivityLevelInfo>();

	// Token: 0x04003521 RID: 13601
	public Dictionary<int, BabelActivityLevelInfo> HardLevelDataMap = new Dictionary<int, BabelActivityLevelInfo>();

	// Token: 0x04003522 RID: 13602
	public Dictionary<int, ActivityTask> NormalQuest = new Dictionary<int, ActivityTask>();

	// Token: 0x04003523 RID: 13603
	public Dictionary<int, ActivityTask> DailyQuest = new Dictionary<int, ActivityTask>();

	// Token: 0x04003524 RID: 13604
	public Dictionary<int, bool> BuffUnlock = new Dictionary<int, bool>();

	// Token: 0x04003525 RID: 13605
	public Dictionary<int, bool> DeTermUnlock = new Dictionary<int, bool>();

	// Token: 0x04003526 RID: 13606
	public Dictionary<int, List<int>> RoleLockData = new Dictionary<int, List<int>>();

	// Token: 0x04003527 RID: 13607
	public int CurrentItemCount;

	// Token: 0x04003528 RID: 13608
	private List<PublicBabelTowerInfo> RawFriendData = new List<PublicBabelTowerInfo>();

	// Token: 0x04003529 RID: 13609
	[Nullable(2)]
	private PublicBabelTowerInfo RawSelfData;
}
