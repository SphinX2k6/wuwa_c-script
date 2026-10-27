using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02001C56 RID: 7254
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateData
{
	// Token: 0x170011DD RID: 4573
	// (get) Token: 0x0600DAC3 RID: 56003 RVA: 0x0032CC10 File Offset: 0x0032AE10
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

	// Token: 0x0600DAC4 RID: 56004 RVA: 0x0032CCA0 File Offset: 0x0032AEA0
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

	// Token: 0x170011DE RID: 4574
	// (get) Token: 0x0600DAC5 RID: 56005 RVA: 0x0032CD4C File Offset: 0x0032AF4C
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

	// Token: 0x0600DAC6 RID: 56006 RVA: 0x0032CD60 File Offset: 0x0032AF60
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

	// Token: 0x0600DAC7 RID: 56007 RVA: 0x0032CDCC File Offset: 0x0032AFCC
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

	// Token: 0x0600DAC8 RID: 56008 RVA: 0x0032CE70 File Offset: 0x0032B070
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
			List<GachaAccumulateRewardData> list2 = (from r in list
			where !r.GetIfCyclic()
			select r).ToList<GachaAccumulateRewardData>();
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

	// Token: 0x0600DAC9 RID: 56009 RVA: 0x0032CFB4 File Offset: 0x0032B1B4
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

	// Token: 0x0600DACA RID: 56010 RVA: 0x0032D024 File Offset: 0x0032B224
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

	// Token: 0x0600DACB RID: 56011 RVA: 0x0032D094 File Offset: 0x0032B294
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

	// Token: 0x0600DACC RID: 56012 RVA: 0x0032D0F4 File Offset: 0x0032B2F4
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

	// Token: 0x0600DACD RID: 56013 RVA: 0x0032D200 File Offset: 0x0032B400
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

	// Token: 0x0600DACE RID: 56014 RVA: 0x0032D27C File Offset: 0x0032B47C
	public bool IsCyclicExhausted(GachaAccumulateRewardData reward)
	{
		return reward.GetIfCyclic() && reward.CycleCount != -1 && reward.CycleRewardedTimes >= reward.CycleCount;
	}

	// Token: 0x0600DACF RID: 56015 RVA: 0x0032D2A4 File Offset: 0x0032B4A4
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

	// Token: 0x0600DAD0 RID: 56016 RVA: 0x0032D2ED File Offset: 0x0032B4ED
	public bool IsCyclicAchievedFull(GachaAccumulateRewardData reward)
	{
		return reward.GetIfCyclic() && reward.CycleCount != -1 && this.GetCyclicAchievedTimes(reward) >= reward.CycleCount;
	}

	// Token: 0x0600DAD1 RID: 56017 RVA: 0x0032D314 File Offset: 0x0032B514
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

	// Token: 0x0600DAD2 RID: 56018 RVA: 0x0032D3A0 File Offset: 0x0032B5A0
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

	// Token: 0x0400641A RID: 25626
	public int AccumulateId;

	// Token: 0x0400641B RID: 25627
	[Nullable(2)]
	public GachaAccumulateGroupData GroupData;
}
