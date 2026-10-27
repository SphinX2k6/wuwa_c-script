using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001FB8 RID: 8120
[NullableContext(1)]
[Nullable(0)]
public class WeaponItemData : AttributeItemData
{
	// Token: 0x0600FDDA RID: 64986 RVA: 0x003D9644 File Offset: 0x003D7844
	public WeaponItemData(int configId, int uniqueId, int functionValue, InventoryDefine.EItemDataType itemDataType) : base(configId, uniqueId, functionValue, itemDataType)
	{
	}

	// Token: 0x0600FDDB RID: 64987 RVA: 0x003D9654 File Offset: 0x003D7854
	public override TItemConfig GetConfig()
	{
		WeaponConf? weaponItemConfig = InventoryConfig.Instance.GetWeaponItemConfig(this.ConfigId);
		if (weaponItemConfig == null)
		{
			return null;
		}
		return weaponItemConfig.GetValueOrDefault();
	}

	// Token: 0x1700135E RID: 4958
	// (get) Token: 0x0600FDDC RID: 64988 RVA: 0x003D968C File Offset: 0x003D788C
	public WeaponConf WeaponConfig
	{
		get
		{
			return this.GetConfig().As<WeaponConf>().Value;
		}
	}

	// Token: 0x0600FDDD RID: 64989 RVA: 0x003D96AC File Offset: 0x003D78AC
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		return new InventoryDefine.EItemMainTypeId?(InventoryDefine.EItemMainTypeId.Weapon);
	}

	// Token: 0x0600FDDE RID: 64990 RVA: 0x003D96B4 File Offset: 0x003D78B4
	public override InventoryDefine.EItemType? GetType()
	{
		return new InventoryDefine.EItemType?(InventoryDefine.EItemType.Weapon);
	}

	// Token: 0x0600FDDF RID: 64991 RVA: 0x003D96BC File Offset: 0x003D78BC
	public override int GetQuality()
	{
		return this.WeaponConfig.QualityId;
	}

	// Token: 0x0600FDE0 RID: 64992 RVA: 0x003D96D8 File Offset: 0x003D78D8
	public override int GetSortIndex()
	{
		return this.WeaponConfig.SortIndex;
	}

	// Token: 0x0600FDE1 RID: 64993 RVA: 0x003D96F4 File Offset: 0x003D78F4
	[NullableContext(0)]
	public override Span<int> GetItemAccess()
	{
		return this.WeaponConfig.GetItemAccessBytes();
	}

	// Token: 0x0600FDE2 RID: 64994 RVA: 0x003D970F File Offset: 0x003D790F
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x0600FDE3 RID: 64995 RVA: 0x003D9712 File Offset: 0x003D7912
	public override string GetDefaultDownText()
	{
		return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("LevelShow"), null) ?? "";
	}

	// Token: 0x0600FDE4 RID: 64996 RVA: 0x003D9734 File Offset: 0x003D7934
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.WeaponConfig.RedDotDisableRule;
	}

	// Token: 0x0600FDE5 RID: 64997 RVA: 0x003D9750 File Offset: 0x003D7950
	public override InventoryDefine.IItemViewDataInfo GetItemViewDataInfo(ItemViewDefine.EItemOperationMode viewMode)
	{
		if (this.GetConfig() == null)
		{
			return null;
		}
		WeaponConf weaponConfig = this.WeaponConfig;
		InventoryModel instance = InventoryModel.Instance;
		int uniqueId = this.GetUniqueId();
		return new InventoryDefine.ItemViewDataInfo(weaponConfig.ItemId, 1, 0, weaponConfig.QualityId, this.GetIsLock(), this.GetIsDeprecated(), instance.IsNewAttributeItem(uniqueId), this.ItemDataType, this, instance.IsAttributeItemHasRedDot(uniqueId), viewMode, false, 0);
	}
}
