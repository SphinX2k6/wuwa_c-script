using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020011F3 RID: 4595
[NullableContext(1)]
[Nullable(0)]
public class ActivityCorniceMeetingLevelEntryData
{
	// Token: 0x06007AAB RID: 31403 RVA: 0x0019D194 File Offset: 0x0019B394
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

	// Token: 0x06007AAC RID: 31404 RVA: 0x0019D224 File Offset: 0x0019B424
	public bool IsUnlock()
	{
		if (this.UnlockTime != 0L)
		{
			return TimeUtil.Instance.GetServerTimeStamp() >= (double)this.UnlockTime;
		}
		return this.UnlockTime == 0L;
	}

	// Token: 0x06007AAD RID: 31405 RVA: 0x0019D24F File Offset: 0x0019B44F
	public bool IsRewarded(int score)
	{
		return this.RewardedMap.ContainsKey(score);
	}

	// Token: 0x06007AAE RID: 31406 RVA: 0x0019D25D File Offset: 0x0019B45D
	public bool IsAllFinished()
	{
		return this.MaxScore >= this.GetMaxScoreConfig();
	}

	// Token: 0x06007AAF RID: 31407 RVA: 0x0019D270 File Offset: 0x0019B470
	public void UpdateData(CorniceLevelPlayEnrty data)
	{
		this.MaxScore = data.MaxScore;
		this.UnlockTime = data.UnlockTime;
		foreach (int key in data.GetRewardScoreIndexList)
		{
			this.RewardedMap[key] = true;
		}
	}

	// Token: 0x06007AB0 RID: 31408 RVA: 0x0019D2DC File Offset: 0x0019B4DC
	public void UpdateRewarded(int score)
	{
		this.RewardedMap[score] = true;
	}

	// Token: 0x06007AB1 RID: 31409 RVA: 0x0019D2EC File Offset: 0x0019B4EC
	public string GetBackgroundPath()
	{
		return ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId).Value.BackgroundTexture;
	}

	// Token: 0x06007AB2 RID: 31410 RVA: 0x0019D31C File Offset: 0x0019B51C
	public string GetTitle()
	{
		return ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId).Value.Title;
	}

	// Token: 0x06007AB3 RID: 31411 RVA: 0x0019D34C File Offset: 0x0019B54C
	public int GetMarkId()
	{
		return ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId).Value.MarkId;
	}

	// Token: 0x06007AB4 RID: 31412 RVA: 0x0019D37C File Offset: 0x0019B57C
	public int GetMaxScoreConfig()
	{
		return ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId).Value.MaxScore;
	}

	// Token: 0x06007AB5 RID: 31413 RVA: 0x0019D3AC File Offset: 0x0019B5AC
	public bool IsRewardAllFinished()
	{
		CorniceChallenge? corniceMeetingChallengeConfig = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId);
		return corniceMeetingChallengeConfig != null && corniceMeetingChallengeConfig.Value.RewardListLength == this.RewardedMap.Count;
	}

	// Token: 0x06007AB6 RID: 31414 RVA: 0x0019D3F4 File Offset: 0x0019B5F4
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

	// Token: 0x06007AB7 RID: 31415 RVA: 0x0019D464 File Offset: 0x0019B664
	public IntPair GetRewardPair(int index)
	{
		CorniceChallenge? corniceMeetingChallengeConfig = ActivityCorniceMeetingConfig.Instance.GetCorniceMeetingChallengeConfig(this.LevelPlayId);
		if (corniceMeetingChallengeConfig == null || index < 0 || index >= corniceMeetingChallengeConfig.Value.RewardListLength)
		{
			return default(IntPair);
		}
		return corniceMeetingChallengeConfig.Value.RewardList(index).Value;
	}

	// Token: 0x06007AB8 RID: 31416 RVA: 0x0019D4C3 File Offset: 0x0019B6C3
	public bool GetRedDot()
	{
		return this.IsUnlock() && (this.GetChallengeNewLocalRedDot() || this.GetScoreRedDot());
	}

	// Token: 0x06007AB9 RID: 31417 RVA: 0x0019D4E4 File Offset: 0x0019B6E4
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

	// Token: 0x06007ABA RID: 31418 RVA: 0x0019D564 File Offset: 0x0019B764
	public void SetChallengeLocalRedDot(bool state)
	{
		ActivityModel.Instance.SaveActivityData(ActivityCorniceMeetingController.Instance.ActivityId, this.LevelPlayId, 0, 0, (state > false) ? 1 : 0);
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActivityCorniceMeetingController.Instance.ActivityId);
	}

	// Token: 0x06007ABB RID: 31419 RVA: 0x0019D5A0 File Offset: 0x0019B7A0
	public bool GetChallengeNewLocalRedDot()
	{
		return ActivityModel.Instance.GetActivityCacheData(ActivityCorniceMeetingController.Instance.ActivityId, 1, this.LevelPlayId, 0, 0) == 1;
	}

	// Token: 0x04003837 RID: 14391
	public int LevelPlayId;

	// Token: 0x04003838 RID: 14392
	public int MaxScore;

	// Token: 0x04003839 RID: 14393
	public int RemainTime;

	// Token: 0x0400383A RID: 14394
	public long UnlockTime;

	// Token: 0x0400383B RID: 14395
	public int CurrentScore;

	// Token: 0x0400383C RID: 14396
	public Dictionary<int, bool> RewardedMap = new Dictionary<int, bool>();
}
