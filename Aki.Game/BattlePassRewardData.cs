using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001810 RID: 6160
[NullableContext(1)]
[Nullable(0)]
public class BattlePassRewardData
{
	// Token: 0x0600F1E8 RID: 61928 RVA: 0x00471343 File Offset: 0x0046F543
	public BattlePassRewardData(int? level)
	{
		this.Level = level;
	}

	// Token: 0x0600F1E9 RID: 61929 RVA: 0x00471374 File Offset: 0x0046F574
	public bool IsThisType(EBattlePassItemType type)
	{
		foreach (BattlePassRewardItem battlePassRewardItem in this.FreeRewardItem)
		{
			EBattlePassItemType? itemType = battlePassRewardItem.ItemType;
			if (itemType.GetValueOrDefault() == type & itemType != null)
			{
				return true;
			}
		}
		foreach (BattlePassRewardItem battlePassRewardItem2 in this.PayRewardItem)
		{
			EBattlePassItemType? itemType = battlePassRewardItem2.ItemType;
			if (itemType.GetValueOrDefault() == type & itemType != null)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F1EA RID: 61930 RVA: 0x0047143C File Offset: 0x0046F63C
	public int GetItemCount(BattlePassType type, int itemId)
	{
		if (type == BattlePassType.Free)
		{
			return this.GetFreeRewardItem(itemId).Item.Value.Count;
		}
		return this.GetPayRewardItem(itemId).Item.Value.Count;
	}

	// Token: 0x0600F1EB RID: 61931 RVA: 0x00471470 File Offset: 0x0046F670
	[NullableContext(2)]
	public BattlePassRewardItem GetFreeRewardItem(int itemId)
	{
		foreach (BattlePassRewardItem battlePassRewardItem in this.FreeRewardItem)
		{
			if (battlePassRewardItem.Item.Value.ItemData.ItemId == itemId)
			{
				return battlePassRewardItem;
			}
		}
		return null;
	}

	// Token: 0x0600F1EC RID: 61932 RVA: 0x004714DC File Offset: 0x0046F6DC
	[NullableContext(2)]
	public BattlePassRewardItem GetPayRewardItem(int itemId)
	{
		foreach (BattlePassRewardItem battlePassRewardItem in this.PayRewardItem)
		{
			if (battlePassRewardItem.Item.Value.ItemData.ItemId == itemId)
			{
				return battlePassRewardItem;
			}
		}
		return null;
	}

	// Token: 0x04008859 RID: 34905
	public List<BattlePassRewardItem> FreeRewardItem = new List<BattlePassRewardItem>();

	// Token: 0x0400885A RID: 34906
	public List<BattlePassRewardItem> PayRewardItem = new List<BattlePassRewardItem>();

	// Token: 0x0400885B RID: 34907
	public int? Level = new int?(0);
}
