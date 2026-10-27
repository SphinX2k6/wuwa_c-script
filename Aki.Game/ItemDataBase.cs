using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001FB5 RID: 8117
public abstract class ItemDataBase
{
	// Token: 0x0600FD97 RID: 64919 RVA: 0x003D90DF File Offset: 0x003D72DF
	public ItemDataBase(int configId, int count, InventoryDefine.EItemDataType itemDataType)
	{
		this.ConfigId = configId;
		this.Count = count;
		this.ItemDataType = itemDataType;
	}

	// Token: 0x0600FD98 RID: 64920 RVA: 0x003D90FC File Offset: 0x003D72FC
	public int GetConfigId()
	{
		return this.ConfigId;
	}

	// Token: 0x0600FD99 RID: 64921 RVA: 0x003D9104 File Offset: 0x003D7304
	public virtual int GetUniqueId()
	{
		return 0;
	}

	// Token: 0x0600FD9A RID: 64922 RVA: 0x003D9107 File Offset: 0x003D7307
	public void SetCount(int count)
	{
		this.LastCount = this.Count;
		this.Count = count;
	}

	// Token: 0x0600FD9B RID: 64923 RVA: 0x003D911C File Offset: 0x003D731C
	public int GetCount()
	{
		return this.Count;
	}

	// Token: 0x0600FD9C RID: 64924 RVA: 0x003D9124 File Offset: 0x003D7324
	public int GetLastCount()
	{
		return this.LastCount;
	}

	// Token: 0x0600FD9D RID: 64925 RVA: 0x003D912C File Offset: 0x003D732C
	public InventoryDefine.EItemDataType GetItemDataType()
	{
		return this.ItemDataType;
	}

	// Token: 0x0600FD9E RID: 64926 RVA: 0x003D9134 File Offset: 0x003D7334
	public TypeInfo? GetItemTypeConfig()
	{
		InventoryDefine.EItemType? type = this.GetType();
		if (type == null)
		{
			return null;
		}
		return InventoryConfig.Instance.GetItemTypeConfig((int)type.Value);
	}

	// Token: 0x0600FD9F RID: 64927 RVA: 0x003D916C File Offset: 0x003D736C
	public bool CanLock()
	{
		TypeInfo? itemTypeConfig = this.GetItemTypeConfig();
		return itemTypeConfig != null && itemTypeConfig.Value.Lock;
	}

	// Token: 0x0600FDA0 RID: 64928 RVA: 0x003D919C File Offset: 0x003D739C
	public bool CanDeprecate()
	{
		TypeInfo? itemTypeConfig = this.GetItemTypeConfig();
		return itemTypeConfig != null && itemTypeConfig.Value.Deprecate;
	}

	// Token: 0x0600FDA1 RID: 64929 RVA: 0x003D91CC File Offset: 0x003D73CC
	public QualityInfo GetQualityConfig()
	{
		int quality = this.GetQuality();
		return InventoryConfig.Instance.GetItemQualityConfig(quality).Value;
	}

	// Token: 0x0600FDA2 RID: 64930 RVA: 0x003D91F3 File Offset: 0x003D73F3
	public virtual bool GetIsLock()
	{
		return false;
	}

	// Token: 0x0600FDA3 RID: 64931 RVA: 0x003D91F6 File Offset: 0x003D73F6
	public virtual bool GetIsDeprecated()
	{
		return false;
	}

	// Token: 0x0600FDA4 RID: 64932 RVA: 0x003D91F9 File Offset: 0x003D73F9
	public virtual bool GetIsShowUseButton()
	{
		return false;
	}

	// Token: 0x0600FDA5 RID: 64933 RVA: 0x003D91FC File Offset: 0x003D73FC
	public virtual bool IsBuffEquipItem()
	{
		return false;
	}

	// Token: 0x0600FDA6 RID: 64934 RVA: 0x003D91FF File Offset: 0x003D73FF
	public virtual bool IsBuffEquippedItem()
	{
		return false;
	}

	// Token: 0x0600FDA7 RID: 64935 RVA: 0x003D9202 File Offset: 0x003D7402
	public virtual bool IsBuffItem()
	{
		return false;
	}

	// Token: 0x0600FDA8 RID: 64936 RVA: 0x003D9205 File Offset: 0x003D7405
	public bool IsShowInInventory()
	{
		return this.OnIsShowInInventory();
	}

	// Token: 0x0600FDA9 RID: 64937 RVA: 0x003D9210 File Offset: 0x003D7410
	protected virtual bool OnIsShowInInventory()
	{
		InventoryDefine.EItemType? type = this.GetType();
		InventoryDefine.EItemType eitemType = InventoryDefine.EItemType.Virtual;
		return !(type.GetValueOrDefault() == eitemType & type != null);
	}

	// Token: 0x0600FDAA RID: 64938
	[NullableContext(1)]
	public abstract TItemConfig GetConfig();

	// Token: 0x0600FDAB RID: 64939
	public abstract InventoryDefine.EItemMainTypeId? GetMainType();

	// Token: 0x0600FDAC RID: 64940
	public new abstract InventoryDefine.EItemType? GetType();

	// Token: 0x0600FDAD RID: 64941
	public abstract int GetSortIndex();

	// Token: 0x0600FDAE RID: 64942
	public abstract Span<int> GetItemAccess();

	// Token: 0x0600FDAF RID: 64943
	public abstract int GetQuality();

	// Token: 0x0600FDB0 RID: 64944
	public abstract int GetMaxStackCount();

	// Token: 0x0600FDB1 RID: 64945
	public abstract int GetUseCountLimit();

	// Token: 0x0600FDB2 RID: 64946
	public abstract InventoryDefine.ERedDotDisableRule GetRedDotDisableRule();

	// Token: 0x0600FDB3 RID: 64947
	public abstract bool HasRedDot();

	// Token: 0x0600FDB4 RID: 64948
	public abstract bool IsValid();

	// Token: 0x0600FDB5 RID: 64949
	[NullableContext(2)]
	public abstract InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode);

	// Token: 0x04007590 RID: 30096
	protected readonly int ConfigId;

	// Token: 0x04007591 RID: 30097
	protected int Count;

	// Token: 0x04007592 RID: 30098
	protected int LastCount;

	// Token: 0x04007593 RID: 30099
	protected InventoryDefine.EItemDataType ItemDataType;
}
