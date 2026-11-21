using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001476 RID: 5238
public class CommonItemData : ItemDataBase
{
	// Token: 0x0600D1A6 RID: 53670 RVA: 0x003E47AE File Offset: 0x003E29AE
	public CommonItemData(int configId, int uniqueId, int count, InventoryDefine.EItemDataType itemDataType, long? endTime = null) : base(configId, count, itemDataType)
	{
		this.UniqueId = uniqueId;
		this.EndTime = endTime.GetValueOrDefault();
	}

	// Token: 0x0600D1A7 RID: 53671 RVA: 0x003E47D0 File Offset: 0x003E29D0
	[NullableContext(2)]
	public override TItemConfig GetConfig()
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(this.ConfigId);
		if (itemConfig == null)
		{
			return null;
		}
		return itemConfig.GetValueOrDefault();
	}

	// Token: 0x0600D1A8 RID: 53672 RVA: 0x003E4805 File Offset: 0x003E2A05
	public override int GetUniqueId()
	{
		return this.UniqueId;
	}

	// Token: 0x0600D1A9 RID: 53673 RVA: 0x003E4810 File Offset: 0x003E2A10
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return null;
		}
		return new InventoryDefine.EItemMainTypeId?((InventoryDefine.EItemMainTypeId)config.As<ItemInfo>().Value.MainTypeId);
	}

	// Token: 0x0600D1AA RID: 53674 RVA: 0x003E484C File Offset: 0x003E2A4C
	public override InventoryDefine.EItemType? GetType()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return null;
		}
		return new InventoryDefine.EItemType?((InventoryDefine.EItemType)config.As<ItemInfo>().Value.ItemType);
	}

	// Token: 0x0600D1AB RID: 53675 RVA: 0x003E4888 File Offset: 0x003E2A88
	public override int GetMaxStackCount()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return 0;
		}
		if (config == null)
		{
			return 0;
		}
		return config.As<ItemInfo>().Value.MaxStackableNum;
	}

	// Token: 0x0600D1AC RID: 53676 RVA: 0x003E48BC File Offset: 0x003E2ABC
	public override int GetQuality()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return 0;
		}
		return config.As<ItemInfo>().Value.QualityId;
	}

	// Token: 0x0600D1AD RID: 53677 RVA: 0x003E48EC File Offset: 0x003E2AEC
	public override int GetSortIndex()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return 0;
		}
		return config.As<ItemInfo>().Value.SortIndex;
	}

	// Token: 0x0600D1AE RID: 53678 RVA: 0x003E491C File Offset: 0x003E2B1C
	public override Span<int> GetItemAccess()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return default(Span<int>);
		}
		return config.As<ItemInfo>().Value.GetItemAccessBytes();
	}

	// Token: 0x0600D1AF RID: 53679 RVA: 0x003E4954 File Offset: 0x003E2B54
	public Span<int> GetShowTypeList()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return Span<int>.Empty;
		}
		return config.As<ItemInfo>().Value.GetShowTypesBytes();
	}

	// Token: 0x0600D1B0 RID: 53680 RVA: 0x003E4988 File Offset: 0x003E2B88
	public override int GetUseCountLimit()
	{
		return this.GetConfig().As<ItemInfo>().Value.UseCountLimit;
	}

	// Token: 0x0600D1B1 RID: 53681 RVA: 0x003E49B0 File Offset: 0x003E2BB0
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.GetConfig().As<ItemInfo>().Value.RedDotDisableRule;
	}

	// Token: 0x0600D1B2 RID: 53682 RVA: 0x003E49D8 File Offset: 0x003E2BD8
	public override bool HasRedDot()
	{
		int configId = base.GetConfigId();
		return InventoryModel.Instance.IsCommonItemHasRedDot(configId, 0);
	}

	// Token: 0x0600D1B3 RID: 53683 RVA: 0x003E49F8 File Offset: 0x003E2BF8
	public void SetEndTime(long endTime)
	{
		this.EndTime = endTime;
	}

	// Token: 0x0600D1B4 RID: 53684 RVA: 0x003E4A01 File Offset: 0x003E2C01
	public bool IsLimitTimeItem()
	{
		return this.EndTime > 0L && !this.IsOverTime();
	}

	// Token: 0x0600D1B5 RID: 53685 RVA: 0x003E4A18 File Offset: 0x003E2C18
	public long GetEndTime()
	{
		return this.EndTime;
	}

	// Token: 0x0600D1B6 RID: 53686 RVA: 0x003E4A20 File Offset: 0x003E2C20
	public bool IsOverTime()
	{
		return this.EndTime > 0L && (double)this.EndTime <= TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x0600D1B7 RID: 53687 RVA: 0x003E4A44 File Offset: 0x003E2C44
	public override bool IsValid()
	{
		return !this.IsOverTime();
	}

	// Token: 0x0600D1B8 RID: 53688 RVA: 0x003E4A4F File Offset: 0x003E2C4F
	public override bool IsBuffEquipItem()
	{
		return BuffItemConfig.Instance.IsEquipBuffItem(this.ConfigId);
	}

	// Token: 0x0600D1B9 RID: 53689 RVA: 0x003E4A61 File Offset: 0x003E2C61
	public override bool IsBuffEquippedItem()
	{
		return this.IsBuffEquipItem() && BuffItemModel.Instance.IsEquippedBuffItem(this.ConfigId);
	}

	// Token: 0x0600D1BA RID: 53690 RVA: 0x003E4A7D File Offset: 0x003E2C7D
	public override bool IsBuffItem()
	{
		return BuffItemConfig.Instance.IsBuffItem(this.ConfigId);
	}

	// Token: 0x0600D1BB RID: 53691 RVA: 0x003E4A90 File Offset: 0x003E2C90
	public override bool GetIsShowUseButton()
	{
		return this.GetConfig().As<ItemInfo>().Value.ShowUseButton;
	}

	// Token: 0x0600D1BC RID: 53692 RVA: 0x003E4AB8 File Offset: 0x003E2CB8
	[NullableContext(2)]
	public override InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode)
	{
		return null;
	}

	// Token: 0x04007670 RID: 30320
	protected readonly int UniqueId;

	// Token: 0x04007671 RID: 30321
	protected long EndTime;
}
