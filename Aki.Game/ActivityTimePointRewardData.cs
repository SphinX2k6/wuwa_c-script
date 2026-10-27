using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001520 RID: 5408
[NullableContext(1)]
[Nullable(0)]
public class ActivityTimePointRewardData : ActivityBaseData
{
	// Token: 0x06009A37 RID: 39479 RVA: 0x00215AFC File Offset: 0x00213CFC
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

	// Token: 0x06009A38 RID: 39480 RVA: 0x00215BD8 File Offset: 0x00213DD8
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

	// Token: 0x06009A39 RID: 39481 RVA: 0x00215CCC File Offset: 0x00213ECC
	public void SaveClickRedDotState()
	{
		ActivityModel.Instance.SaveActivityData(base.Id, 100, 0, 0, 1);
	}

	// Token: 0x06009A3A RID: 39482 RVA: 0x00215CE3 File Offset: 0x00213EE3
	public override bool GetExDataRedPointShowState()
	{
		return this.IsExitsRewardToGet() || base.GetExDataRedPointShowState();
	}

	// Token: 0x06009A3B RID: 39483 RVA: 0x00215CF8 File Offset: 0x00213EF8
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

	// Token: 0x06009A3C RID: 39484 RVA: 0x00215D68 File Offset: 0x00213F68
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

	// Token: 0x06009A3D RID: 39485 RVA: 0x00215DC8 File Offset: 0x00213FC8
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

	// Token: 0x06009A3E RID: 39486 RVA: 0x00215E03 File Offset: 0x00214003
	public List<TimePointRewardData> GetRewardDataList()
	{
		List<TimePointRewardData> list = new List<TimePointRewardData>(this.RewardDataMap.Values);
		list.Sort((TimePointRewardData a, TimePointRewardData b) => a.Id - b.Id);
		return list;
	}

	// Token: 0x040043E4 RID: 17380
	public const int CLICKKEY = 100;

	// Token: 0x040043E5 RID: 17381
	private readonly Dictionary<int, TimePointRewardData> RewardDataMap = new Dictionary<int, TimePointRewardData>();
}
