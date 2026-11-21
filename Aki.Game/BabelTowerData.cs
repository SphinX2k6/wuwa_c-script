using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

// Token: 0x020005D9 RID: 1497
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerData : ActivityBaseData
{
	// Token: 0x060046AB RID: 18091 RVA: 0x00183138 File Offset: 0x00181338
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

	// Token: 0x060046AC RID: 18092 RVA: 0x00183334 File Offset: 0x00181534
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

	// Token: 0x060046AD RID: 18093 RVA: 0x00183480 File Offset: 0x00181680
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

	// Token: 0x060046AE RID: 18094 RVA: 0x00183550 File Offset: 0x00181750
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

	// Token: 0x060046AF RID: 18095 RVA: 0x001835FC File Offset: 0x001817FC
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

	// Token: 0x060046B0 RID: 18096 RVA: 0x0018371C File Offset: 0x0018191C
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

	// Token: 0x060046B1 RID: 18097 RVA: 0x001837A0 File Offset: 0x001819A0
	public string GetHardLevelStarText()
	{
		int num = 0;
		foreach (KeyValuePair<int, BabelActivityLevelInfo> keyValuePair in this.HardLevelDataMap)
		{
			num += keyValuePair.Value.PassStar;
		}
		return num.ToString() ?? "";
	}

	// Token: 0x060046B2 RID: 18098 RVA: 0x00183810 File Offset: 0x00181A10
	public bool GetBuffIsLock(int buffId)
	{
		bool flag;
		return !this.BuffUnlock.TryGetValue(buffId, out flag) || !flag;
	}

	// Token: 0x060046B3 RID: 18099 RVA: 0x00183834 File Offset: 0x00181A34
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

	// Token: 0x060046B4 RID: 18100 RVA: 0x001838B0 File Offset: 0x00181AB0
	public bool GetDeTermIsLock(int deTerm)
	{
		bool flag;
		return !this.DeTermUnlock.TryGetValue(deTerm, out flag) || !flag;
	}

	// Token: 0x060046B5 RID: 18101 RVA: 0x001838D4 File Offset: 0x00181AD4
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

	// Token: 0x060046B6 RID: 18102 RVA: 0x0018391C File Offset: 0x00181B1C
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

	// Token: 0x060046B7 RID: 18103 RVA: 0x00183950 File Offset: 0x00181B50
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

	// Token: 0x060046B8 RID: 18104 RVA: 0x00183A00 File Offset: 0x00181C00
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

	// Token: 0x060046B9 RID: 18105 RVA: 0x00183AA8 File Offset: 0x00181CA8
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

	// Token: 0x060046BA RID: 18106 RVA: 0x00183B20 File Offset: 0x00181D20
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

	// Token: 0x060046BB RID: 18107 RVA: 0x00183C18 File Offset: 0x00181E18
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

	// Token: 0x060046BC RID: 18108 RVA: 0x00183CD0 File Offset: 0x00181ED0
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

	// Token: 0x060046BD RID: 18109 RVA: 0x00183D58 File Offset: 0x00181F58
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

	// Token: 0x060046BE RID: 18110 RVA: 0x00183DD8 File Offset: 0x00181FD8
	public override bool GetExDataRedPointShowState()
	{
		return this.GetQuestAnyRedDot() || this.GetDifficultyNewLevelRedDot(0) || this.GetDifficultyNewLevelRedDot(1);
	}

	// Token: 0x060046BF RID: 18111 RVA: 0x00183DF4 File Offset: 0x00181FF4
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

	// Token: 0x060046C0 RID: 18112 RVA: 0x00183EBC File Offset: 0x001820BC
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

	// Token: 0x060046C1 RID: 18113 RVA: 0x00183F30 File Offset: 0x00182130
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

	// Token: 0x060046C2 RID: 18114 RVA: 0x00183FA0 File Offset: 0x001821A0
	public void SetRawFriendData(List<PublicBabelTowerInfo> data)
	{
		this.RawFriendData = data;
	}

	// Token: 0x060046C3 RID: 18115 RVA: 0x00183FA9 File Offset: 0x001821A9
	public List<PublicBabelTowerInfo> GetRawFriendData()
	{
		return this.RawFriendData;
	}

	// Token: 0x060046C4 RID: 18116 RVA: 0x00183FB1 File Offset: 0x001821B1
	[NullableContext(2)]
	public void SetRawSelfData(PublicBabelTowerInfo data)
	{
		this.RawSelfData = data;
	}

	// Token: 0x060046C5 RID: 18117 RVA: 0x00183FBA File Offset: 0x001821BA
	[NullableContext(2)]
	public PublicBabelTowerInfo GetRawSelfData()
	{
		return this.RawSelfData;
	}

	// Token: 0x060046C6 RID: 18118 RVA: 0x00183FC2 File Offset: 0x001821C2
	public bool GetSelfShowName()
	{
		PublicBabelTowerInfo rawSelfData = this.RawSelfData;
		return rawSelfData == null || rawSelfData.ShowName;
	}

	// Token: 0x060046C7 RID: 18119 RVA: 0x00183FD5 File Offset: 0x001821D5
	public void SetSelfShowName(bool showName)
	{
		if (this.RawSelfData != null)
		{
			this.RawSelfData.ShowName = showName;
		}
	}

	// Token: 0x060046C8 RID: 18120 RVA: 0x00183FEC File Offset: 0x001821EC
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

	// Token: 0x060046C9 RID: 18121 RVA: 0x0018407C File Offset: 0x0018227C
	public int GetLevelPassTime(int levelId)
	{
		PublicBabelTowerInfo rawSelfData = this.RawSelfData;
		if (((rawSelfData != null) ? rawSelfData.ChallengeInfo : null) == null)
		{
			return 0;
		}
		RepeatedField<PublicBabelTowerChallengeInfo> challengeInfo = rawSelfData.ChallengeInfo;
		for (int i = 0; i < challengeInfo.Count; i++)
		{
			if (challengeInfo[i].ChallengeId == levelId)
			{
				return challengeInfo[i].UseTime;
			}
		}
		return 0;
	}

	// Token: 0x060046CA RID: 18122 RVA: 0x001840D5 File Offset: 0x001822D5
	public void ClearMyRankData()
	{
		this.RawSelfData = null;
	}

	// Token: 0x060046CB RID: 18123 RVA: 0x001840DE File Offset: 0x001822DE
	public void SaveOldRankData(int levelId, int levelRank, int totalRank)
	{
		this.OldLevelRankMap[levelId] = levelRank;
		this.OldTotalRank = totalRank;
	}

	// Token: 0x060046CC RID: 18124 RVA: 0x001840F4 File Offset: 0x001822F4
	public void CacheAllOldRanks()
	{
		foreach (int num in this.HardLevelDataMap.Keys)
		{
			this.OldLevelRankMap[num] = this.CalcMyRankFromRawData(true, num);
		}
		this.OldTotalRank = this.CalcMyRankFromRawData(false, -1);
	}

	// Token: 0x060046CD RID: 18125 RVA: 0x00184168 File Offset: 0x00182368
	public int GetOldLevelRank(int levelId)
	{
		int result;
		if (!this.OldLevelRankMap.TryGetValue(levelId, out result))
		{
			return -1;
		}
		return result;
	}

	// Token: 0x060046CE RID: 18126 RVA: 0x00184188 File Offset: 0x00182388
	public int GetOldTotalRank()
	{
		return this.OldTotalRank;
	}

	// Token: 0x060046CF RID: 18127 RVA: 0x00184190 File Offset: 0x00182390
	public int CalcMyRankFromRawData(bool isLevelRank, int levelId)
	{
		BabelTowerData.<>c__DisplayClass48_0 CS$<>8__locals1;
		CS$<>8__locals1.isLevelRank = isLevelRank;
		CS$<>8__locals1.levelId = levelId;
		if (this.RawSelfData == null)
		{
			return -1;
		}
		ValueTuple<int, int> valueTuple = BabelTowerData.<CalcMyRankFromRawData>g__GetScore|48_0(this.RawSelfData, ref CS$<>8__locals1);
		if (valueTuple.Item2 <= 0)
		{
			return -1;
		}
		int playerId = this.RawSelfData.PlayerId;
		int num = 0;
		foreach (PublicBabelTowerInfo publicBabelTowerInfo in this.RawFriendData)
		{
			ValueTuple<int, int> valueTuple2 = BabelTowerData.<CalcMyRankFromRawData>g__GetScore|48_0(publicBabelTowerInfo, ref CS$<>8__locals1);
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

	// Token: 0x060046D0 RID: 18128 RVA: 0x00184290 File Offset: 0x00182490
	public int GetSelfHeadId()
	{
		return PersonalModel.Instance.GetHeadPhotoId();
	}

	// Token: 0x060046D1 RID: 18129 RVA: 0x0018429C File Offset: 0x0018249C
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

	// Token: 0x060046D3 RID: 18131 RVA: 0x00184368 File Offset: 0x00182568
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

	// Token: 0x060046D4 RID: 18132 RVA: 0x001843A0 File Offset: 0x001825A0
	[NullableContext(0)]
	[CompilerGenerated]
	[return: TupleElementNames(new string[]
	{
		"Star",
		"Time"
	})]
	internal static ValueTuple<int, int> <CalcMyRankFromRawData>g__GetScore|48_0([Nullable(1)] PublicBabelTowerInfo proto, ref BabelTowerData.<>c__DisplayClass48_0 A_1)
	{
		RepeatedField<PublicBabelTowerChallengeInfo> challengeInfo = proto.ChallengeInfo;
		if (A_1.isLevelRank)
		{
			for (int i = 0; i < challengeInfo.Count; i++)
			{
				PublicBabelTowerChallengeInfo publicBabelTowerChallengeInfo = challengeInfo[i];
				if (publicBabelTowerChallengeInfo.ChallengeId == A_1.levelId)
				{
					return new ValueTuple<int, int>(publicBabelTowerChallengeInfo.Star, publicBabelTowerChallengeInfo.UseTime);
				}
			}
			return new ValueTuple<int, int>(0, 0);
		}
		int num = 0;
		int num2 = 0;
		foreach (PublicBabelTowerChallengeInfo publicBabelTowerChallengeInfo2 in challengeInfo)
		{
			num += publicBabelTowerChallengeInfo2.Star;
			num2 += publicBabelTowerChallengeInfo2.UseTime;
		}
		return new ValueTuple<int, int>(num, num2);
	}

	// Token: 0x040035B7 RID: 13751
	private readonly Dictionary<int, int> OldLevelRankMap = new Dictionary<int, int>();

	// Token: 0x040035B8 RID: 13752
	private int OldTotalRank;

	// Token: 0x040035B9 RID: 13753
	public Dictionary<int, BabelActivityLevelInfo> NormalLevelDataMap = new Dictionary<int, BabelActivityLevelInfo>();

	// Token: 0x040035BA RID: 13754
	public Dictionary<int, BabelActivityLevelInfo> HardLevelDataMap = new Dictionary<int, BabelActivityLevelInfo>();

	// Token: 0x040035BB RID: 13755
	public Dictionary<int, ActivityTask> NormalQuest = new Dictionary<int, ActivityTask>();

	// Token: 0x040035BC RID: 13756
	public Dictionary<int, ActivityTask> DailyQuest = new Dictionary<int, ActivityTask>();

	// Token: 0x040035BD RID: 13757
	public Dictionary<int, bool> BuffUnlock = new Dictionary<int, bool>();

	// Token: 0x040035BE RID: 13758
	public Dictionary<int, bool> DeTermUnlock = new Dictionary<int, bool>();

	// Token: 0x040035BF RID: 13759
	public Dictionary<int, List<int>> RoleLockData = new Dictionary<int, List<int>>();

	// Token: 0x040035C0 RID: 13760
	public int CurrentItemCount;

	// Token: 0x040035C1 RID: 13761
	private List<PublicBabelTowerInfo> RawFriendData = new List<PublicBabelTowerInfo>();

	// Token: 0x040035C2 RID: 13762
	[Nullable(2)]
	private PublicBabelTowerInfo RawSelfData;
}
