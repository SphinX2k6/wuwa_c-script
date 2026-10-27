using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200232B RID: 9003
[NullableContext(1)]
[Nullable(0)]
public class BattlePassRewardData
{
	// Token: 0x06011D38 RID: 73016 RVA: 0x0046427F File Offset: 0x0046247F
	public BattlePassRewardData(int? level)
	{
		this.Level = level;
	}

	// Token: 0x06011D39 RID: 73017 RVA: 0x004642B0 File Offset: 0x004624B0
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

	// Token: 0x06011D3A RID: 73018 RVA: 0x00464378 File Offset: 0x00462578
	public int GetItemCount(BattlePassType type, int itemId)
	{
		if (type == BattlePassType.Free)
		{
			return this.GetFreeRewardItem(itemId).Item.Value.Count;
		}
		return this.GetPayRewardItem(itemId).Item.Value.Count;
	}

	// Token: 0x06011D3B RID: 73019 RVA: 0x004643AC File Offset: 0x004625AC
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

	// Token: 0x06011D3C RID: 73020 RVA: 0x00464418 File Offset: 0x00462618
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

	// Token: 0x04008716 RID: 34582
	public List<BattlePassRewardItem> FreeRewardItem = new List<BattlePassRewardItem>();

	// Token: 0x04008717 RID: 34583
	public List<BattlePassRewardItem> PayRewardItem = new List<BattlePassRewardItem>();

	// Token: 0x04008718 RID: 34584
	public int? Level = new int?(0);
}
