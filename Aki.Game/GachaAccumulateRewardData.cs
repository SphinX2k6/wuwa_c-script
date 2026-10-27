using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02001C54 RID: 7252
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateRewardData
{
	// Token: 0x0600DABD RID: 55997 RVA: 0x0032CA0C File Offset: 0x0032AC0C
	public RewardItemData[] GetRewardItemList()
	{
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (KeyValuePair<int, int> keyValuePair in this.RewardContent)
		{
			list.Add(new RewardItemData(keyValuePair.Key, keyValuePair.Value, null, EDropItemType.Normal));
		}
		return list.ToArray();
	}

	// Token: 0x0600DABE RID: 55998 RVA: 0x0032CA88 File Offset: 0x0032AC88
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

	// Token: 0x0600DABF RID: 55999 RVA: 0x0032CB6C File Offset: 0x0032AD6C
	public bool GetIfCyclic()
	{
		return this.CycleCount != 0;
	}

	// Token: 0x0600DAC0 RID: 56000 RVA: 0x0032CB78 File Offset: 0x0032AD78
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

	// Token: 0x0400640E RID: 25614
	public int Id;

	// Token: 0x0400640F RID: 25615
	public int GroupId;

	// Token: 0x04006410 RID: 25616
	public int GachaNum;

	// Token: 0x04006411 RID: 25617
	public readonly Dictionary<int, int> RewardContent = new Dictionary<int, int>();

	// Token: 0x04006412 RID: 25618
	public EGachaAccumulateRewardStatus Status;

	// Token: 0x04006413 RID: 25619
	public bool IsBigReward;

	// Token: 0x04006414 RID: 25620
	public int CycleCount;

	// Token: 0x04006415 RID: 25621
	public int CycleRewardedTimes;

	// Token: 0x04006416 RID: 25622
	public bool IsPreView;
}
