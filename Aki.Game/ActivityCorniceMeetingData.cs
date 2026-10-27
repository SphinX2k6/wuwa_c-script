using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x020011F4 RID: 4596
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingData : ActivityBaseData
{
	// Token: 0x06007ABC RID: 31420 RVA: 0x0019D5C4 File Offset: 0x0019B7C4
	protected override void PhraseEx(ActivityData data)
	{
		this.UnlockTime = data.CorniceMeetingData.QuestUnlockTime;
		foreach (KeyValuePair<int, CorniceLevelPlayEnrty> keyValuePair in data.CorniceMeetingData.CorninceDataList)
		{
			int key = keyValuePair.Key;
			CorniceLevelPlayEnrty value = keyValuePair.Value;
			if (this.CurrentSelectLevelPlayId == 0)
			{
				this.CurrentSelectLevelPlayId = key;
			}
			if (this.LevelEntryMap.ContainsKey(key))
			{
				this.LevelEntryMap[key].UpdateData(value);
			}
			else
			{
				this.LevelEntryMap[key] = new ActivityCorniceMeetingLevelEntryData(value, key);
			}
		}
		this.RefreshAllLevelEntryDataRedDot();
	}

	// Token: 0x06007ABD RID: 31421 RVA: 0x0019D67C File Offset: 0x0019B87C
	public List<int> GetLevelPlayIdList(bool isSort = true)
	{
		List<int> list = new List<int>(this.LevelEntryMap.Keys);
		if (isSort)
		{
			list.Sort(delegate(int a, int b)
			{
				CorniceChallenge? corniceMeetingChallengeConfig = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(a);
				CorniceChallenge? corniceMeetingChallengeConfig2 = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(b);
				if (corniceMeetingChallengeConfig == null || corniceMeetingChallengeConfig2 == null)
				{
					return 0;
				}
				return corniceMeetingChallengeConfig.Value.SortId - corniceMeetingChallengeConfig2.Value.SortId;
			});
		}
		return list;
	}

	// Token: 0x06007ABE RID: 31422 RVA: 0x0019D6C4 File Offset: 0x0019B8C4
	public void UpdateRewarded(int levelPlayId, int score)
	{
		ActivityCorniceMeetingLevelEntryData activityCorniceMeetingLevelEntryData;
		if (this.LevelEntryMap.TryGetValue(levelPlayId, out activityCorniceMeetingLevelEntryData))
		{
			activityCorniceMeetingLevelEntryData.UpdateRewarded(score);
		}
	}

	// Token: 0x06007ABF RID: 31423 RVA: 0x0019D6E8 File Offset: 0x0019B8E8
	[NullableContext(2)]
	public ActivityCorniceMeetingLevelEntryData GetLevelEntryData(int levelPlayId)
	{
		ActivityCorniceMeetingLevelEntryData result;
		this.LevelEntryMap.TryGetValue(levelPlayId, out result);
		return result;
	}

	// Token: 0x06007AC0 RID: 31424 RVA: 0x0019D708 File Offset: 0x0019B908
	public int GetDefaultSelectLevelPlayId()
	{
		List<int> levelPlayIdList = this.GetLevelPlayIdList(true);
		this.CurrentSelectLevelPlayId = ((levelPlayIdList.Count > 0) ? levelPlayIdList[0] : 0);
		foreach (int num in levelPlayIdList)
		{
			ActivityCorniceMeetingLevelEntryData levelEntryData = this.GetLevelEntryData(num);
			if (levelEntryData != null && levelEntryData.IsUnlock() && !levelEntryData.IsRewardAllFinished())
			{
				this.CurrentSelectLevelPlayId = num;
				break;
			}
		}
		return this.CurrentSelectLevelPlayId;
	}

	// Token: 0x06007AC1 RID: 31425 RVA: 0x0019D79C File Offset: 0x0019B99C
	public int GetSelectLevelPlayIdIndex()
	{
		return this.GetLevelPlayIdList(true).IndexOf(this.CurrentSelectLevelPlayId);
	}

	// Token: 0x06007AC2 RID: 31426 RVA: 0x0019D7B0 File Offset: 0x0019B9B0
	public List<TItem> GetScoreIndexPreviewItem(int levelPlayId, int score)
	{
		CorniceChallenge? corniceMeetingChallengeConfig = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(levelPlayId);
		if (corniceMeetingChallengeConfig == null)
		{
			return new List<TItem>();
		}
		IntPair? intPair = null;
		for (int i = 0; i < corniceMeetingChallengeConfig.Value.RewardListLength; i++)
		{
			IntPair value = corniceMeetingChallengeConfig.Value.RewardList(i).Value;
			if (value.Item1 == score)
			{
				intPair = new IntPair?(value);
				break;
			}
		}
		if (intPair == null)
		{
			return new List<TItem>();
		}
		int item = intPair.Value.Item2;
		List<TItem> list = new List<TItem>();
		if (item != 0)
		{
			DropPackage? dropPackage = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackage(item);
			if (dropPackage != null)
			{
				for (int j = 0; j < dropPackage.Value.DropPreviewLength; j++)
				{
					DicIntInt value2 = dropPackage.Value.DropPreview(j).Value;
					TItem item2 = new TItem
					{
						ItemData = new InventoryDefine.GetItemData(value2.Key, 0),
						Count = value2.Value
					};
					list.Add(item2);
				}
			}
		}
		return list;
	}

	// Token: 0x06007AC3 RID: 31427 RVA: 0x0019D8E8 File Offset: 0x0019BAE8
	public ECorniceMeetingRewardState GetRewardState(int levelPlayId, int index)
	{
		ActivityCorniceMeetingLevelEntryData levelEntryData = this.GetLevelEntryData(levelPlayId);
		if (levelEntryData == null)
		{
			return ECorniceMeetingRewardState.Unfinished;
		}
		if (levelEntryData.IsRewarded(index))
		{
			return ECorniceMeetingRewardState.Rewarded;
		}
		IntPair rewardPair = levelEntryData.GetRewardPair(index);
		if (levelEntryData.MaxScore < rewardPair.Item1)
		{
			return ECorniceMeetingRewardState.Unfinished;
		}
		return ECorniceMeetingRewardState.Finished;
	}

	// Token: 0x06007AC4 RID: 31428 RVA: 0x0019D928 File Offset: 0x0019BB28
	public bool IsUnlockTailQuest()
	{
		if (base.Id != 102400001)
		{
			return false;
		}
		bool flag = true;
		foreach (int levelPlayId in this.GetLevelPlayIdList(true))
		{
			ActivityCorniceMeetingLevelEntryData levelEntryData = this.GetLevelEntryData(levelPlayId);
			if (levelEntryData != null && levelEntryData.MaxScore == 0)
			{
				flag = false;
				break;
			}
		}
		if (this.UnlockTime == 0L)
		{
			return flag;
		}
		return TimeUtil.Instance.GetServerTimeStamp() >= (double)this.UnlockTime && flag;
	}

	// Token: 0x06007AC5 RID: 31429 RVA: 0x0019D9C0 File Offset: 0x0019BBC0
	public bool GetIsShow(int levelPlayId)
	{
		ActivityCorniceMeetingLevelEntryData levelEntryData = this.GetLevelEntryData(levelPlayId);
		return levelEntryData != null && levelEntryData.IsUnlock() && this.CheckIfInShowTime() && base.GetPreGuideQuestFinishState();
	}

	// Token: 0x06007AC6 RID: 31430 RVA: 0x0019D9F4 File Offset: 0x0019BBF4
	public override bool CheckIfInShowTime()
	{
		if (base.BeginOpenTime == 0L && base.EndOpenTime == 0L)
		{
			return true;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= (double)base.BeginOpenTime && serverTime <= (double)base.EndOpenTime;
	}

	// Token: 0x06007AC7 RID: 31431 RVA: 0x0019DA38 File Offset: 0x0019BC38
	public override bool GetExDataRedPointShowState()
	{
		if (base.GetPreGuideQuestFinishState())
		{
			using (List<int>.Enumerator enumerator = this.GetLevelPlayIdList(true).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int levelPlayId = enumerator.Current;
					ActivityCorniceMeetingLevelEntryData levelEntryData = this.GetLevelEntryData(levelPlayId);
					if (levelEntryData != null && levelEntryData.GetRedDot())
					{
						return true;
					}
				}
				return false;
			}
		}
		return ActivityModel.Instance.GetActivityCacheData(base.Id, 0, base.GetUnFinishPreGuideQuestId(), 0, 0) == 0;
	}

	// Token: 0x06007AC8 RID: 31432 RVA: 0x0019DAC8 File Offset: 0x0019BCC8
	public void SavePreQuestRedDot(int preQuestId)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, preQuestId, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06007AC9 RID: 31433 RVA: 0x0019DAF4 File Offset: 0x0019BCF4
	public void RefreshAllLevelEntryDataRedDot()
	{
		foreach (int p in this.GetLevelPlayIdList(true))
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCorniceMeetingRedDot, p);
		}
	}

	// Token: 0x17000A7D RID: 2685
	// (get) Token: 0x06007ACA RID: 31434 RVA: 0x0019DB54 File Offset: 0x0019BD54
	public bool NeedTailQuest
	{
		get
		{
			return base.Id == 102400001;
		}
	}

	// Token: 0x17000A7E RID: 2686
	// (get) Token: 0x06007ACB RID: 31435 RVA: 0x0019DB63 File Offset: 0x0019BD63
	public string TaskTitleTextId
	{
		get
		{
			if (base.Id != 102400001)
			{
				return "ActivityCorniceMeetingPointNeed_02";
			}
			return "ActivityCorniceMeetingPointNeed";
		}
	}

	// Token: 0x06007ACC RID: 31436 RVA: 0x0019DB80 File Offset: 0x0019BD80
	protected override bool GetExDataFinishShowState()
	{
		foreach (int levelPlayId in this.GetLevelPlayIdList(true))
		{
			ActivityCorniceMeetingLevelEntryData levelEntryData = this.GetLevelEntryData(levelPlayId);
			if (levelEntryData == null)
			{
				return false;
			}
			List<int> rewardList = levelEntryData.GetRewardList();
			for (int i = 0; i < rewardList.Count; i++)
			{
				if (this.GetRewardState(levelPlayId, i) != ECorniceMeetingRewardState.Rewarded)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0400383D RID: 14397
	private const int FIRST_VERSION_ACTIVITY_ID = 102400001;

	// Token: 0x0400383E RID: 14398
	public Dictionary<int, ActivityCorniceMeetingLevelEntryData> LevelEntryMap = new Dictionary<int, ActivityCorniceMeetingLevelEntryData>();

	// Token: 0x0400383F RID: 14399
	public int CurrentSelectLevelPlayId;

	// Token: 0x04003840 RID: 14400
	public long UnlockTime;
}
