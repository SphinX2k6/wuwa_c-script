using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Reward;

// Token: 0x020006A8 RID: 1704
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingData : ActivityBaseData
{
	// Token: 0x06004E53 RID: 20051 RVA: 0x001A626C File Offset: 0x001A446C
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

	// Token: 0x06004E54 RID: 20052 RVA: 0x001A6324 File Offset: 0x001A4524
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

	// Token: 0x06004E55 RID: 20053 RVA: 0x001A636C File Offset: 0x001A456C
	public void UpdateRewarded(int levelPlayId, int score)
	{
		ActivityCorniceMeetingLevelEntryData activityCorniceMeetingLevelEntryData;
		if (this.LevelEntryMap.TryGetValue(levelPlayId, out activityCorniceMeetingLevelEntryData))
		{
			activityCorniceMeetingLevelEntryData.UpdateRewarded(score);
		}
	}

	// Token: 0x06004E56 RID: 20054 RVA: 0x001A6390 File Offset: 0x001A4590
	[NullableContext(2)]
	public ActivityCorniceMeetingLevelEntryData GetLevelEntryData(int levelPlayId)
	{
		ActivityCorniceMeetingLevelEntryData result;
		this.LevelEntryMap.TryGetValue(levelPlayId, out result);
		return result;
	}

	// Token: 0x06004E57 RID: 20055 RVA: 0x001A63B0 File Offset: 0x001A45B0
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

	// Token: 0x06004E58 RID: 20056 RVA: 0x001A6444 File Offset: 0x001A4644
	public int GetSelectLevelPlayIdIndex()
	{
		return this.GetLevelPlayIdList(true).IndexOf(this.CurrentSelectLevelPlayId);
	}

	// Token: 0x06004E59 RID: 20057 RVA: 0x001A6458 File Offset: 0x001A4658
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

	// Token: 0x06004E5A RID: 20058 RVA: 0x001A6590 File Offset: 0x001A4790
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

	// Token: 0x06004E5B RID: 20059 RVA: 0x001A65D0 File Offset: 0x001A47D0
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

	// Token: 0x06004E5C RID: 20060 RVA: 0x001A6668 File Offset: 0x001A4868
	public bool GetIsShow(int levelPlayId)
	{
		ActivityCorniceMeetingLevelEntryData levelEntryData = this.GetLevelEntryData(levelPlayId);
		return levelEntryData != null && levelEntryData.IsUnlock() && this.CheckIfInShowTime() && base.GetPreGuideQuestFinishState();
	}

	// Token: 0x06004E5D RID: 20061 RVA: 0x001A669C File Offset: 0x001A489C
	public override bool CheckIfInShowTime()
	{
		if (base.BeginOpenTime == 0L && base.EndOpenTime == 0L)
		{
			return true;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= (double)base.BeginOpenTime && serverTime <= (double)base.EndOpenTime;
	}

	// Token: 0x06004E5E RID: 20062 RVA: 0x001A66E0 File Offset: 0x001A48E0
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

	// Token: 0x06004E5F RID: 20063 RVA: 0x001A6770 File Offset: 0x001A4970
	public void SavePreQuestRedDot(int preQuestId)
	{
		ActivityModel.Instance.SaveActivityData(base.Id, preQuestId, 0, 0, 1);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06004E60 RID: 20064 RVA: 0x001A679C File Offset: 0x001A499C
	public void RefreshAllLevelEntryDataRedDot()
	{
		foreach (int p in this.GetLevelPlayIdList(true))
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCorniceMeetingRedDot, p);
		}
	}

	// Token: 0x17000A9D RID: 2717
	// (get) Token: 0x06004E61 RID: 20065 RVA: 0x001A67FC File Offset: 0x001A49FC
	public bool NeedTailQuest
	{
		get
		{
			return base.Id == 102400001;
		}
	}

	// Token: 0x17000A9E RID: 2718
	// (get) Token: 0x06004E62 RID: 20066 RVA: 0x001A680B File Offset: 0x001A4A0B
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

	// Token: 0x06004E63 RID: 20067 RVA: 0x001A6828 File Offset: 0x001A4A28
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

	// Token: 0x040038D6 RID: 14550
	private const int FIRST_VERSION_ACTIVITY_ID = 102400001;

	// Token: 0x040038D7 RID: 14551
	public Dictionary<int, ActivityCorniceMeetingLevelEntryData> LevelEntryMap = new Dictionary<int, ActivityCorniceMeetingLevelEntryData>();

	// Token: 0x040038D8 RID: 14552
	public int CurrentSelectLevelPlayId;

	// Token: 0x040038D9 RID: 14553
	public long UnlockTime;
}
