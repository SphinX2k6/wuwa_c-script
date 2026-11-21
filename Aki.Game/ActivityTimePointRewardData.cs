using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020009D8 RID: 2520
[NullableContext(1)]
[Nullable(0)]
public class ActivityTimePointRewardData : ActivityBaseData
{
	// Token: 0x06006E15 RID: 28181 RVA: 0x0021F898 File Offset: 0x0021DA98
	protected override void PhraseEx(ActivityData data)
	{
		this.RewardDataMap.Clear();
		TimePointRewardActivityData timePointRewardActivityData = data.TimePointRewardActivityData;
		if (timePointRewardActivityData == null)
		{
			return;
		}
		foreach (OneTimePointRewardActivityData oneTimePointRewardActivityData in timePointRewardActivityData.Rewards)
		{
			TimePointRewardData timePointRewardData = new TimePointRewardData();
			timePointRewardData.Id = oneTimePointRewardActivityData.Id;
			timePointRewardData.RewardTime = oneTimePointRewardActivityData.RewardTime;
			timePointRewardData.HasClaimed = oneTimePointRewardActivityData.Rewarded;
			timePointRewardData.HasUnlock = oneTimePointRewardActivityData.CanGetReward;
			timePointRewardData.CurrentCheckInCount = oneTimePointRewardActivityData.Task.Current;
			timePointRewardData.ConditionCount = oneTimePointRewardActivityData.Task.Target;
			this.RewardDataMap[oneTimePointRewardActivityData.Id] = timePointRewardData;
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06006E16 RID: 28182 RVA: 0x0021F974 File Offset: 0x0021DB74
	public void OnTimePointRewardUpdate(TimePointRewardActivityData response, int ActId)
	{
		if (response == null)
		{
			return;
		}
		foreach (OneTimePointRewardActivityData oneTimePointRewardActivityData in response.Rewards)
		{
			TimePointRewardData timePointRewardData;
			if (this.RewardDataMap.ContainsKey(oneTimePointRewardActivityData.Id))
			{
				timePointRewardData = this.RewardDataMap[oneTimePointRewardActivityData.Id];
			}
			else
			{
				timePointRewardData = new TimePointRewardData();
				this.RewardDataMap[oneTimePointRewardActivityData.Id] = timePointRewardData;
			}
			timePointRewardData.Id = oneTimePointRewardActivityData.Id;
			timePointRewardData.RewardTime = oneTimePointRewardActivityData.RewardTime;
			timePointRewardData.HasClaimed = oneTimePointRewardActivityData.Rewarded;
			timePointRewardData.HasUnlock = oneTimePointRewardActivityData.CanGetReward;
			timePointRewardData.CurrentCheckInCount = oneTimePointRewardActivityData.Task.Current;
			timePointRewardData.ConditionCount = oneTimePointRewardActivityData.Task.Target;
		}
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, ActId);
	}

	// Token: 0x06006E17 RID: 28183 RVA: 0x0021FA68 File Offset: 0x0021DC68
	public void SaveClickRedDotState()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
	}

	// Token: 0x06006E18 RID: 28184 RVA: 0x0021FA7F File Offset: 0x0021DC7F
	public override bool GetExDataRedPointShowState()
	{
		return this.IsExitsRewardToGet() || base.GetExDataRedPointShowState();
	}

	// Token: 0x06006E19 RID: 28185 RVA: 0x0021FA94 File Offset: 0x0021DC94
	protected override bool GetExDataFinishShowState()
	{
		if (this.RewardDataMap.Count <= 0)
		{
			return false;
		}
		using (Dictionary<int, TimePointRewardData>.ValueCollection.Enumerator enumerator = this.RewardDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.RewardState != ETimePointRewardState.UnlockAndClaimed)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x06006E1A RID: 28186 RVA: 0x0021FB04 File Offset: 0x0021DD04
	private bool IsExitsRewardToGet()
	{
		using (Dictionary<int, TimePointRewardData>.ValueCollection.Enumerator enumerator = this.RewardDataMap.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.RewardState == ETimePointRewardState.UnlockAndUnClaimed)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06006E1B RID: 28187 RVA: 0x0021FB64 File Offset: 0x0021DD64
	public void SetRewardToGotState(int id)
	{
		TimePointRewardData timePointRewardData;
		if (!this.RewardDataMap.TryGetValue(id, out timePointRewardData))
		{
			return;
		}
		timePointRewardData.HasClaimed = true;
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, base.Id);
	}

	// Token: 0x06006E1C RID: 28188 RVA: 0x0021FB9F File Offset: 0x0021DD9F
	public List<TimePointRewardData> GetRewardDataList()
	{
		List<TimePointRewardData> list = new List<TimePointRewardData>(this.RewardDataMap.Values);
		list.Sort((TimePointRewardData a, TimePointRewardData b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x0400448A RID: 17546
	public const int CLICKKEY = 100;

	// Token: 0x0400448B RID: 17547
	private readonly Dictionary<int, TimePointRewardData> RewardDataMap = new Dictionary<int, TimePointRewardData>();
}
