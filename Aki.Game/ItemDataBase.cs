using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001477 RID: 5239
public abstract class ItemDataBase
{
	// Token: 0x0600D1BD RID: 53693 RVA: 0x003E4ABB File Offset: 0x003E2CBB
	public ItemDataBase(int configId, int count, InventoryDefine.EItemDataType itemDataType)
	{
		this.ConfigId = configId;
		this.Count = count;
		this.ItemDataType = itemDataType;
	}

	// Token: 0x0600D1BE RID: 53694 RVA: 0x003E4AD8 File Offset: 0x003E2CD8
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600D1BF RID: 53695 RVA: 0x003E4AE0 File Offset: 0x003E2CE0
	public virtual int GetUniqueId()
	{
		return 0;
	}

	// Token: 0x0600D1C0 RID: 53696 RVA: 0x003E4AE3 File Offset: 0x003E2CE3
	public void SetCount(int count)
	{
		this.LastCount = this.Count;
		this.Count = count;
	}

	// Token: 0x0600D1C1 RID: 53697 RVA: 0x003E4AF8 File Offset: 0x003E2CF8
	public int GetCount()
	{
		return this.Count;
	}

	// Token: 0x0600D1C2 RID: 53698 RVA: 0x003E4B00 File Offset: 0x003E2D00
	public int GetLastCount()
	{
		return this.LastCount;
	}

	// Token: 0x0600D1C3 RID: 53699 RVA: 0x003E4B08 File Offset: 0x003E2D08
	public InventoryDefine.EItemDataType GetItemDataType()
	{
		return this.ItemDataType;
	}

	// Token: 0x0600D1C4 RID: 53700 RVA: 0x003E4B10 File Offset: 0x003E2D10
	public TypeInfo? GetItemTypeConfig()
	{
		InventoryDefine.EItemType? type = this.GetType();
		if (type == null)
		{
			return null;
		}
		return InventoryConfig.Instance.GetItemTypeConfig((int)type.Value);
	}

	// Token: 0x0600D1C5 RID: 53701 RVA: 0x003E4B48 File Offset: 0x003E2D48
	public bool CanLock()
	{
		TypeInfo? itemTypeConfig = this.GetItemTypeConfig();
		return itemTypeConfig != null && itemTypeConfig.Value.Lock;
	}

	// Token: 0x0600D1C6 RID: 53702 RVA: 0x003E4B78 File Offset: 0x003E2D78
	public bool CanDeprecate()
	{
		TypeInfo? itemTypeConfig = this.GetItemTypeConfig();
		return itemTypeConfig != null && itemTypeConfig.Value.Deprecate;
	}

	// Token: 0x0600D1C7 RID: 53703 RVA: 0x003E4BA8 File Offset: 0x003E2DA8
	public QualityInfo GetQualityConfig()
	{
		int quality = this.GetQuality();
		return InventoryConfig.Instance.GetItemQualityConfig(quality).Value;
	}

	// Token: 0x0600D1C8 RID: 53704 RVA: 0x003E4BCF File Offset: 0x003E2DCF
	public virtual bool GetIsLock()
	{
		return false;
	}

	// Token: 0x0600D1C9 RID: 53705 RVA: 0x003E4BD2 File Offset: 0x003E2DD2
	public virtual bool GetIsDeprecated()
	{
		return false;
	}

	// Token: 0x0600D1CA RID: 53706 RVA: 0x003E4BD5 File Offset: 0x003E2DD5
	public virtual bool GetIsShowUseButton()
	{
		return false;
	}

	// Token: 0x0600D1CB RID: 53707 RVA: 0x003E4BD8 File Offset: 0x003E2DD8
	public virtual bool IsBuffEquipItem()
	{
		return false;
	}

	// Token: 0x0600D1CC RID: 53708 RVA: 0x003E4BDB File Offset: 0x003E2DDB
	public virtual bool IsBuffEquippedItem()
	{
		return false;
	}

	// Token: 0x0600D1CD RID: 53709 RVA: 0x003E4BDE File Offset: 0x003E2DDE
	public virtual bool IsBuffItem()
	{
		return false;
	}

	// Token: 0x0600D1CE RID: 53710 RVA: 0x003E4BE1 File Offset: 0x003E2DE1
	public bool IsShowInInventory()
	{
		return this.OnIsShowInInventory();
	}

	// Token: 0x0600D1CF RID: 53711 RVA: 0x003E4BEC File Offset: 0x003E2DEC
	protected virtual bool OnIsShowInInventory()
	{
		InventoryDefine.EItemType? type = this.GetType();
		InventoryDefine.EItemType eitemType = InventoryDefine.EItemType.Virtual;
		return !(type.GetValueOrDefault() == eitemType & type != null);
	}

	// Token: 0x0600D1D0 RID: 53712
	[NullableContext(1)]
	public abstract TItemConfig GetConfig();

	// Token: 0x0600D1D1 RID: 53713
	public abstract InventoryDefine.EItemMainTypeId? GetMainType();

	// Token: 0x0600D1D2 RID: 53714
	public new abstract InventoryDefine.EItemType? GetType();

	// Token: 0x0600D1D3 RID: 53715
	public abstract int GetSortIndex();

	// Token: 0x0600D1D4 RID: 53716
	public abstract Span<int> GetItemAccess();

	// Token: 0x0600D1D5 RID: 53717
	public abstract int GetQuality();

	// Token: 0x0600D1D6 RID: 53718
	public abstract int GetMaxStackCount();

	// Token: 0x0600D1D7 RID: 53719
	public abstract int GetUseCountLimit();

	// Token: 0x0600D1D8 RID: 53720
	public abstract InventoryDefine.ERedDotDisableRule GetRedDotDisableRule();

	// Token: 0x0600D1D9 RID: 53721
	public abstract bool HasRedDot();

	// Token: 0x0600D1DA RID: 53722
	public abstract bool IsValid();

	// Token: 0x0600D1DB RID: 53723
	[NullableContext(2)]
	public abstract InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode);

	// Token: 0x04007672 RID: 30322
	protected readonly int ConfigId;

	// Token: 0x04007673 RID: 30323
	protected int Count;

	// Token: 0x04007674 RID: 30324
	protected int LastCount;

	// Token: 0x04007675 RID: 30325
	protected InventoryDefine.EItemDataType ItemDataType;
}
