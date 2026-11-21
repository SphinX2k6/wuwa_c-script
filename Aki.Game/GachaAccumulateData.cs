using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02001115 RID: 4373
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateData
{
	// Token: 0x17001203 RID: 4611
	// (get) Token: 0x0600AED9 RID: 44761 RVA: 0x00338018 File Offset: 0x00336218
	public bool HasClaimable
	{
		get
		{
			if (this.GroupData == null)
			{
				return false;
			}
			int cyclicBaseGachaNum = this.GetCyclicBaseGachaNum();
			foreach (GachaAccumulateRewardData gachaAccumulateRewardData in this.GroupData.RewardInfos)
			{
				if (gachaAccumulateRewardData.GetIfCyclic())
				{
					if (gachaAccumulateRewardData.GetCyclicPendingClaimCount(this.CurGachaNum, cyclicBaseGachaNum) > 0)
					{
						return true;
					}
				}
				else if (gachaAccumulateRewardData.Status == EGachaAccumulateRewardStatus.CanClaim)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x0600AEDA RID: 44762 RVA: 0x003380A8 File Offset: 0x003362A8
	public List<int> CollectAllClaimableRewardIds()
	{
		List<int> list = new List<int>();
		if (this.GroupData == null)
		{
			return list;
		}
		int cyclicBaseGachaNum = this.GetCyclicBaseGachaNum();
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in this.GroupData.RewardInfos)
		{
			if (!gachaAccumulateRewardData.GetIfResonantGift())
			{
				if (gachaAccumulateRewardData.GetIfCyclic())
				{
					if (gachaAccumulateRewardData.GetCyclicPendingClaimCount(this.CurGachaNum, cyclicBaseGachaNum) > 0)
					{
						list.Add(gachaAccumulateRewardData.Id);
					}
				}
				else if (gachaAccumulateRewardData.Status == EGachaAccumulateRewardStatus.CanClaim)
				{
					list.Add(gachaAccumulateRewardData.Id);
				}
			}
		}
		return list;
	}

	// Token: 0x17001204 RID: 4612
	// (get) Token: 0x0600AEDB RID: 44763 RVA: 0x00338154 File Offset: 0x00336354
	public int CurGachaNum
	{
		get
		{
			GachaAccumulateGroupData groupData = this.GroupData;
			if (groupData == null)
			{
				return 0;
			}
			return groupData.CurGachaNum;
		}
	}

	// Token: 0x0600AEDC RID: 44764 RVA: 0x00338168 File Offset: 0x00336368
	public double GetCurrentGachaProgress()
	{
		GachaAccumulateGroupData groupData = this.GroupData;
		int num = (groupData != null && groupData.RewardInfos.Count > 0) ? this.GroupData.RewardInfos[this.GroupData.RewardInfos.Count - 1].GachaNum : 0;
		if (num == 0)
		{
			return 0.0;
		}
		return (double)this.CurGachaNum / (double)num;
	}

	// Token: 0x0600AEDD RID: 44765 RVA: 0x003381D4 File Offset: 0x003363D4
	[NullableContext(0)]
	public ValueTuple<int, int> GetProgress()
	{
		int num = 0;
		GachaAccumulateGroupData groupData = this.GroupData;
		List<GachaAccumulateRewardData> list = ((groupData != null) ? groupData.RewardInfos : null) ?? new List<GachaAccumulateRewardData>();
		int cyclicBaseGachaNum = this.GetCyclicBaseGachaNum();
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in list)
		{
			if (gachaAccumulateRewardData.GetIfCyclic())
			{
				num += gachaAccumulateRewardData.GetCyclicPendingClaimCount(this.CurGachaNum, cyclicBaseGachaNum);
			}
			else if (gachaAccumulateRewardData.Status != EGachaAccumulateRewardStatus.NotReached)
			{
				num++;
			}
		}
		return new ValueTuple<int, int>(num, list.Count);
	}

	// Token: 0x0600AEDE RID: 44766 RVA: 0x00338278 File Offset: 0x00336478
	[NullableContext(2)]
	public RewardItemData GetTipsShowReward()
	{
		GachaAccumulateGroupData groupData = this.GroupData;
		List<GachaAccumulateRewardData> list = ((groupData != null) ? groupData.RewardInfos : null) ?? new List<GachaAccumulateRewardData>();
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in list)
		{
			if (!gachaAccumulateRewardData.GetIfCyclic() && gachaAccumulateRewardData.Status == EGachaAccumulateRewardStatus.NotReached)
			{
				RewardItemData[] rewardItemList = gachaAccumulateRewardData.GetRewardItemList();
				return (rewardItemList.Length != 0) ? rewardItemList[0] : null;
			}
		}
		GachaAccumulateRewardData gachaAccumulateRewardData2 = list.Find((GachaAccumulateRewardData r) => r.GetIfCyclic());
		bool flag = this.CurGachaNum >= this.GetCyclicBaseGachaNum();
		if (gachaAccumulateRewardData2 != null && (gachaAccumulateRewardData2.IsPreView || flag))
		{
			RewardItemData[] rewardItemList2 = gachaAccumulateRewardData2.GetRewardItemList();
			if (rewardItemList2.Length == 0)
			{
				return null;
			}
			return rewardItemList2[0];
		}
		else
		{
			List<GachaAccumulateRewardData> list2 = new List<GachaAccumulateRewardData>();
			foreach (GachaAccumulateRewardData gachaAccumulateRewardData3 in list)
			{
				if (!gachaAccumulateRewardData3.GetIfCyclic())
				{
					list2.Add(gachaAccumulateRewardData3);
				}
			}
			if (list2.Count == 0)
			{
				return null;
			}
			RewardItemData[] rewardItemList3 = list2[list2.Count - 1].GetRewardItemList();
			if (rewardItemList3.Length == 0)
			{
				return null;
			}
			return rewardItemList3[0];
		}
		RewardItemData result;
		return result;
	}

	// Token: 0x0600AEDF RID: 44767 RVA: 0x003383E0 File Offset: 0x003365E0
	public bool GetIfFinishAll()
	{
		GachaAccumulateGroupData groupData = this.GroupData;
		using (List<GachaAccumulateRewardData>.Enumerator enumerator = (((groupData != null) ? groupData.RewardInfos : null) ?? new List<GachaAccumulateRewardData>()).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EGachaAccumulateRewardStatus.NotReached)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600AEE0 RID: 44768 RVA: 0x00338450 File Offset: 0x00336650
	public int GetUnTakeRewardNum()
	{
		int num = 0;
		GachaAccumulateGroupData groupData = this.GroupData;
		using (List<GachaAccumulateRewardData>.Enumerator enumerator = (((groupData != null) ? groupData.RewardInfos : null) ?? new List<GachaAccumulateRewardData>()).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == EGachaAccumulateRewardStatus.CanClaim)
				{
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600AEE1 RID: 44769 RVA: 0x003384C0 File Offset: 0x003366C0
	public bool GetIfTakeAllReward()
	{
		using (List<GachaAccumulateRewardData>.Enumerator enumerator = this.GroupData.RewardInfos.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status != EGachaAccumulateRewardStatus.Claimed)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600AEE2 RID: 44770 RVA: 0x00338520 File Offset: 0x00336720
	public int GetNextRewardNeedGachaNum()
	{
		if (this.GroupData == null)
		{
			return 0;
		}
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in this.GroupData.RewardInfos)
		{
			if (!gachaAccumulateRewardData.GetIfCyclic() && gachaAccumulateRewardData.Status == EGachaAccumulateRewardStatus.NotReached)
			{
				return gachaAccumulateRewardData.GachaNum - this.CurGachaNum;
			}
		}
		int cyclicBaseGachaNum = this.GetCyclicBaseGachaNum();
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData2 in this.GroupData.RewardInfos)
		{
			if (gachaAccumulateRewardData2.GetIfCyclic() && gachaAccumulateRewardData2.GachaNum > 0 && !this.IsCyclicAchievedFull(gachaAccumulateRewardData2))
			{
				int gachaNum = gachaAccumulateRewardData2.GachaNum;
				int num = (this.CurGachaNum - cyclicBaseGachaNum) % gachaNum;
				return (num == 0) ? gachaNum : (gachaNum - num);
			}
		}
		return 0;
	}

	// Token: 0x0600AEE3 RID: 44771 RVA: 0x0033862C File Offset: 0x0033682C
	public int GetCyclicBaseGachaNum()
	{
		int num = 0;
		GachaAccumulateGroupData groupData = this.GroupData;
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in (((groupData != null) ? groupData.RewardInfos : null) ?? new List<GachaAccumulateRewardData>()))
		{
			if (!gachaAccumulateRewardData.GetIfCyclic() && gachaAccumulateRewardData.GachaNum > num)
			{
				num = gachaAccumulateRewardData.GachaNum;
			}
		}
		return num;
	}

	// Token: 0x0600AEE4 RID: 44772 RVA: 0x003386A8 File Offset: 0x003368A8
	public bool IsCyclicExhausted(GachaAccumulateRewardData reward)
	{
		return reward.GetIfCyclic() && reward.CycleCount != -1 && reward.CycleRewardedTimes >= reward.CycleCount;
	}

	// Token: 0x0600AEE5 RID: 44773 RVA: 0x003386D0 File Offset: 0x003368D0
	public int GetCyclicAchievedTimes(GachaAccumulateRewardData reward)
	{
		if (!reward.GetIfCyclic() || reward.GachaNum <= 0)
		{
			return 0;
		}
		int cyclicBaseGachaNum = this.GetCyclicBaseGachaNum();
		if (this.CurGachaNum < cyclicBaseGachaNum)
		{
			return 0;
		}
		return (int)Math.Floor((double)(this.CurGachaNum - cyclicBaseGachaNum) / (double)reward.GachaNum);
	}

	// Token: 0x0600AEE6 RID: 44774 RVA: 0x00338719 File Offset: 0x00336919
	public bool IsCyclicAchievedFull(GachaAccumulateRewardData reward)
	{
		return reward.GetIfCyclic() && reward.CycleCount != -1 && this.GetCyclicAchievedTimes(reward) >= reward.CycleCount;
	}

	// Token: 0x0600AEE7 RID: 44775 RVA: 0x00338740 File Offset: 0x00336940
	public bool GetIfAllRewardAchieved()
	{
		if (this.GroupData == null)
		{
			return false;
		}
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in this.GroupData.RewardInfos)
		{
			if (gachaAccumulateRewardData.GetIfCyclic())
			{
				if (gachaAccumulateRewardData.CycleCount == -1)
				{
					return false;
				}
				if (!this.IsCyclicAchievedFull(gachaAccumulateRewardData))
				{
					return false;
				}
			}
			else if (gachaAccumulateRewardData.Status == EGachaAccumulateRewardStatus.NotReached)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600AEE8 RID: 44776 RVA: 0x003387CC File Offset: 0x003369CC
	public bool GetIfTakeAllRewardIncludingCyclic()
	{
		if (this.GroupData == null)
		{
			return false;
		}
		foreach (GachaAccumulateRewardData gachaAccumulateRewardData in this.GroupData.RewardInfos)
		{
			if (gachaAccumulateRewardData.GetIfCyclic())
			{
				if (gachaAccumulateRewardData.CycleCount == -1)
				{
					return false;
				}
				if (!this.IsCyclicExhausted(gachaAccumulateRewardData))
				{
					return false;
				}
			}
			else if (gachaAccumulateRewardData.Status != EGachaAccumulateRewardStatus.Claimed)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x040064EC RID: 25836
	public int AccumulateId;

	// Token: 0x040064ED RID: 25837
	[Nullable(2)]
	public GachaAccumulateGroupData GroupData;
}
