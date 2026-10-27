using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001FB4 RID: 8116
public class CommonItemData : ItemDataBase
{
	// Token: 0x0600FD80 RID: 64896 RVA: 0x003D8DD2 File Offset: 0x003D6FD2
	public CommonItemData(int configId, int uniqueId, int count, InventoryDefine.EItemDataType itemDataType, long? endTime = null) : base(configId, count, itemDataType)
	{
		this.UniqueId = uniqueId;
		this.EndTime = endTime.GetValueOrDefault();
	}

	// Token: 0x0600FD81 RID: 64897 RVA: 0x003D8DF4 File Offset: 0x003D6FF4
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

	// Token: 0x0600FD82 RID: 64898 RVA: 0x003D8E29 File Offset: 0x003D7029
	public override int GetUniqueId()
	{
		return this.UniqueId;
	}

	// Token: 0x0600FD83 RID: 64899 RVA: 0x003D8E34 File Offset: 0x003D7034
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return null;
		}
		return new InventoryDefine.EItemMainTypeId?((InventoryDefine.EItemMainTypeId)config.As<ItemInfo>().Value.MainTypeId);
	}

	// Token: 0x0600FD84 RID: 64900 RVA: 0x003D8E70 File Offset: 0x003D7070
	public override InventoryDefine.EItemType? GetType()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return null;
		}
		return new InventoryDefine.EItemType?((InventoryDefine.EItemType)config.As<ItemInfo>().Value.ItemType);
	}

	// Token: 0x0600FD85 RID: 64901 RVA: 0x003D8EAC File Offset: 0x003D70AC
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

	// Token: 0x0600FD86 RID: 64902 RVA: 0x003D8EE0 File Offset: 0x003D70E0
	public override int GetQuality()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return 0;
		}
		return config.As<ItemInfo>().Value.QualityId;
	}

	// Token: 0x0600FD87 RID: 64903 RVA: 0x003D8F10 File Offset: 0x003D7110
	public override int GetSortIndex()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return 0;
		}
		return config.As<ItemInfo>().Value.SortIndex;
	}

	// Token: 0x0600FD88 RID: 64904 RVA: 0x003D8F40 File Offset: 0x003D7140
	public override Span<int> GetItemAccess()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return default(Span<int>);
		}
		return config.As<ItemInfo>().Value.GetItemAccessBytes();
	}

	// Token: 0x0600FD89 RID: 64905 RVA: 0x003D8F78 File Offset: 0x003D7178
	public Span<int> GetShowTypeList()
	{
		TItemConfig config = this.GetConfig();
		if (config == null)
		{
			return Span<int>.Empty;
		}
		return config.As<ItemInfo>().Value.GetShowTypesBytes();
	}

	// Token: 0x0600FD8A RID: 64906 RVA: 0x003D8FAC File Offset: 0x003D71AC
	public override int GetUseCountLimit()
	{
		return this.GetConfig().As<ItemInfo>().Value.UseCountLimit;
	}

	// Token: 0x0600FD8B RID: 64907 RVA: 0x003D8FD4 File Offset: 0x003D71D4
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.GetConfig().As<ItemInfo>().Value.RedDotDisableRule;
	}

	// Token: 0x0600FD8C RID: 64908 RVA: 0x003D8FFC File Offset: 0x003D71FC
	public override bool HasRedDot()
	{
		int configId = base.GetConfigId();
		return InventoryModel.Instance.IsCommonItemHasRedDot(configId, 0);
	}

	// Token: 0x0600FD8D RID: 64909 RVA: 0x003D901C File Offset: 0x003D721C
	public void SetEndTime(long endTime)
	{
		this.EndTime = endTime;
	}

	// Token: 0x0600FD8E RID: 64910 RVA: 0x003D9025 File Offset: 0x003D7225
	public bool IsLimitTimeItem()
	{
		return this.EndTime > 0L && !this.IsOverTime();
	}

	// Token: 0x0600FD8F RID: 64911 RVA: 0x003D903C File Offset: 0x003D723C
	public long GetEndTime()
	{
		return this.EndTime;
	}

	// Token: 0x0600FD90 RID: 64912 RVA: 0x003D9044 File Offset: 0x003D7244
	public bool IsOverTime()
	{
		return this.EndTime > 0L && (double)this.EndTime <= TimeUtil.Instance.GetServerTimeStamp();
	}

	// Token: 0x0600FD91 RID: 64913 RVA: 0x003D9068 File Offset: 0x003D7268
	public override bool IsValid()
	{
		return !this.IsOverTime();
	}

	// Token: 0x0600FD92 RID: 64914 RVA: 0x003D9073 File Offset: 0x003D7273
	public override bool IsBuffEquipItem()
	{
		return BuffItemConfig.Instance.IsEquipBuffItem(this.ConfigId);
	}

	// Token: 0x0600FD93 RID: 64915 RVA: 0x003D9085 File Offset: 0x003D7285
	public override bool IsBuffEquippedItem()
	{
		return this.IsBuffEquipItem() && BuffItemModel.Instance.IsEquippedBuffItem(this.ConfigId);
	}

	// Token: 0x0600FD94 RID: 64916 RVA: 0x003D90A1 File Offset: 0x003D72A1
	public override bool IsBuffItem()
	{
		return BuffItemConfig.Instance.IsBuffItem(this.ConfigId);
	}

	// Token: 0x0600FD95 RID: 64917 RVA: 0x003D90B4 File Offset: 0x003D72B4
	public override bool GetIsShowUseButton()
	{
		return this.GetConfig().As<ItemInfo>().Value.ShowUseButton;
	}

	// Token: 0x0600FD96 RID: 64918 RVA: 0x003D90DC File Offset: 0x003D72DC
	[NullableContext(2)]
	public override InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode)
	{
		return null;
	}

	// Token: 0x0400758E RID: 30094
	protected readonly int UniqueId;

	// Token: 0x0400758F RID: 30095
	protected long EndTime;
}
