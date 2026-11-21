using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02001113 RID: 4371
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateRewardData
{
	// Token: 0x0600AED3 RID: 44755 RVA: 0x00337E14 File Offset: 0x00336014
	public RewardItemData[] GetRewardItemList()
	{
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (KeyValuePair<int, int> keyValuePair in this.RewardContent)
		{
			list.Add(new RewardItemData(keyValuePair.Key, keyValuePair.Value, null, EDropItemType.Normal));
		}
		return list.ToArray();
	}

	// Token: 0x0600AED4 RID: 44756 RVA: 0x00337E90 File Offset: 0x00336090
	public bool GetIfResonantGift()
	{
		foreach (KeyValuePair<int, int> keyValuePair in this.RewardContent)
		{
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(keyValuePair.Key);
			if (itemConfig != null && itemConfig.GetValueOrDefault().ItemType == 11)
			{
				int num2;
				int num = itemConfig.Value.Parameters().TryGetValue(2, out num2) ? num2 : 0;
				if (num != 0)
				{
					GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(num);
					if (giftPackageConfig != null && giftPackageConfig.GetValueOrDefault().Type == GiftType.ResonantChainOptional)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600AED5 RID: 44757 RVA: 0x00337F74 File Offset: 0x00336174
	public bool GetIfCyclic()
	{
		return this.CycleCount != 0;
	}

	// Token: 0x0600AED6 RID: 44758 RVA: 0x00337F80 File Offset: 0x00336180
	public int GetCyclicPendingClaimCount(int currentGachaNum, int baseGachaNum)
	{
		if (!this.GetIfCyclic())
		{
			return 0;
		}
		if (this.GachaNum <= 0)
		{
			return 0;
		}
		int num = baseGachaNum + this.GachaNum;
		if (currentGachaNum < num)
		{
			return 0;
		}
		int val = (int)Math.Floor((double)(currentGachaNum - baseGachaNum) / (double)this.GachaNum);
		int val2 = (this.CycleCount == -1) ? int.MaxValue : this.CycleCount;
		int num2 = Math.Min(val, val2) - this.CycleRewardedTimes;
		if (num2 <= 0)
		{
			return 0;
		}
		return num2;
	}

	// Token: 0x040064E0 RID: 25824
	public int Id;

	// Token: 0x040064E1 RID: 25825
	public int GroupId;

	// Token: 0x040064E2 RID: 25826
	public int GachaNum;

	// Token: 0x040064E3 RID: 25827
	public readonly Dictionary<int, int> RewardContent = new Dictionary<int, int>();

	// Token: 0x040064E4 RID: 25828
	public EGachaAccumulateRewardStatus Status;

	// Token: 0x040064E5 RID: 25829
	public bool IsBigReward;

	// Token: 0x040064E6 RID: 25830
	public int CycleCount;

	// Token: 0x040064E7 RID: 25831
	public int CycleRewardedTimes;

	// Token: 0x040064E8 RID: 25832
	public bool IsPreView;
}
