using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020006A7 RID: 1703
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingLevelEntryData
{
	// Token: 0x06004E42 RID: 20034 RVA: 0x001A5E3C File Offset: 0x001A403C
	public ActivityCorniceMeetingLevelEntryData(CorniceLevelPlayEnrty data, int playId)
	{
		this.LevelPlayId = playId;
		this.MaxScore = data.MaxScore;
		this.RemainTime = data.RemainingTime;
		this.UnlockTime = data.UnlockTime;
		foreach (int key in data.GetRewardScoreIndexList)
		{
			this.RewardedMap[key] = true;
		}
	}

	// Token: 0x06004E43 RID: 20035 RVA: 0x001A5ECC File Offset: 0x001A40CC
	public bool IsUnlock()
	{
		if (this.UnlockTime != 0L)
		{
			return TimeUtil.Instance.GetServerTimeStamp() >= (double)this.UnlockTime;
		}
		return this.UnlockTime == 0L;
	}

	// Token: 0x06004E44 RID: 20036 RVA: 0x001A5EF7 File Offset: 0x001A40F7
	public bool IsRewarded(int score)
	{
		return this.RewardedMap.ContainsKey(score);
	}

	// Token: 0x06004E45 RID: 20037 RVA: 0x001A5F05 File Offset: 0x001A4105
	public bool IsAllFinished()
	{
		return this.MaxScore >= this.GetMaxScoreConfig();
	}

	// Token: 0x06004E46 RID: 20038 RVA: 0x001A5F18 File Offset: 0x001A4118
	public void UpdateData(CorniceLevelPlayEnrty data)
	{
		this.MaxScore = data.MaxScore;
		this.UnlockTime = data.UnlockTime;
		foreach (int key in data.GetRewardScoreIndexList)
		{
			this.RewardedMap[key] = true;
		}
	}

	// Token: 0x06004E47 RID: 20039 RVA: 0x001A5F84 File Offset: 0x001A4184
	public void UpdateRewarded(int score)
	{
		this.RewardedMap[score] = true;
	}

	// Token: 0x06004E48 RID: 20040 RVA: 0x001A5F94 File Offset: 0x001A4194
	public string GetBackgroundPath()
	{
		return ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId).Value.BackgroundTexture;
	}

	// Token: 0x06004E49 RID: 20041 RVA: 0x001A5FC4 File Offset: 0x001A41C4
	public string GetTitle()
	{
		return ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId).Value.Title;
	}

	// Token: 0x06004E4A RID: 20042 RVA: 0x001A5FF4 File Offset: 0x001A41F4
	public int GetMarkId()
	{
		return ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId).Value.MarkId;
	}

	// Token: 0x06004E4B RID: 20043 RVA: 0x001A6024 File Offset: 0x001A4224
	public int GetMaxScoreConfig()
	{
		return ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId).Value.MaxScore;
	}

	// Token: 0x06004E4C RID: 20044 RVA: 0x001A6054 File Offset: 0x001A4254
	public bool IsRewardAllFinished()
	{
		CorniceChallenge? corniceMeetingChallengeConfig = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId);
		return corniceMeetingChallengeConfig != null && corniceMeetingChallengeConfig.Value.RewardListLength == this.RewardedMap.Count;
	}

	// Token: 0x06004E4D RID: 20045 RVA: 0x001A609C File Offset: 0x001A429C
	public List<int> GetRewardList()
	{
		CorniceChallenge? corniceMeetingChallengeConfig = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId);
		List<int> list = new List<int>();
		if (corniceMeetingChallengeConfig != null)
		{
			for (int i = 0; i < corniceMeetingChallengeConfig.Value.RewardListLength; i++)
			{
				list.Add(corniceMeetingChallengeConfig.Value.RewardList(i).Value.Item1);
			}
		}
		return list;
	}

	// Token: 0x06004E4E RID: 20046 RVA: 0x001A610C File Offset: 0x001A430C
	public IntPair GetRewardPair(int index)
	{
		CorniceChallenge? corniceMeetingChallengeConfig = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId);
		if (corniceMeetingChallengeConfig == null || index < 0 || index >= corniceMeetingChallengeConfig.Value.RewardListLength)
		{
			return default(IntPair);
		}
		return corniceMeetingChallengeConfig.Value.RewardList(index).Value;
	}

	// Token: 0x06004E4F RID: 20047 RVA: 0x001A616B File Offset: 0x001A436B
	public bool GetRedDot()
	{
		return this.IsUnlock() && (this.GetChallengeNewLocalRedDot() || this.GetScoreRedDot());
	}

	// Token: 0x06004E50 RID: 20048 RVA: 0x001A618C File Offset: 0x001A438C
	public bool GetScoreRedDot()
	{
		CorniceChallenge? corniceMeetingChallengeConfig = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId);
		bool result = false;
		if (corniceMeetingChallengeConfig != null)
		{
			for (int i = 0; i < corniceMeetingChallengeConfig.Value.RewardListLength; i++)
			{
				if (this.MaxScore >= corniceMeetingChallengeConfig.Value.RewardList(i).Value.Item1 && !this.RewardedMap.ContainsKey(i))
				{
					result = true;
					break;
				}
			}
		}
		return result;
	}

	// Token: 0x06004E51 RID: 20049 RVA: 0x001A620C File Offset: 0x001A440C
	public void SetChallengeLocalRedDot(bool state)
	{
		ActivityModel.Instance.SaveActivityData(ActivityCorniceMeetingController.Instance.ActivityId, this.LevelPlayId, 0, 0, (state > false) ? 1 : 0);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActivityCorniceMeetingController.Instance.ActivityId);
	}

	// Token: 0x06004E52 RID: 20050 RVA: 0x001A6248 File Offset: 0x001A4448
	public bool GetChallengeNewLocalRedDot()
	{
		return ActivityModel.Instance.GetActivityCacheData(ActivityCorniceMeetingController.Instance.ActivityId, 1, this.LevelPlayId, 0, 0) == 1;
	}

	// Token: 0x040038D0 RID: 14544
	public int LevelPlayId;

	// Token: 0x040038D1 RID: 14545
	public int MaxScore;

	// Token: 0x040038D2 RID: 14546
	public int RemainTime;

	// Token: 0x040038D3 RID: 14547
	public long UnlockTime;

	// Token: 0x040038D4 RID: 14548
	public int CurrentScore;

	// Token: 0x040038D5 RID: 14549
	public Dictionary<int, bool> RewardedMap = new Dictionary<int, bool>();
}
