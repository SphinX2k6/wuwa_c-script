using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200147A RID: 5242
[NullableContext(1)]
[Nullable(0)]
public class WeaponItemData : AttributeItemData
{
	// Token: 0x0600D200 RID: 53760 RVA: 0x003E5020 File Offset: 0x003E3220
	public WeaponItemData(int configId, int uniqueId, int functionValue, InventoryDefine.EItemDataType itemDataType) : base(configId, uniqueId, functionValue, itemDataType)
	{
	}

	// Token: 0x0600D201 RID: 53761 RVA: 0x003E5030 File Offset: 0x003E3230
	public override TItemConfig GetConfig()
	{
		WeaponConf? weaponItemConfig = InventoryConfig.Instance.GetWeaponItemConfig(this.ConfigId);
		if (weaponItemConfig == null)
		{
			return null;
		}
		return weaponItemConfig.GetValueOrDefault();
	}

	// Token: 0x1700138A RID: 5002
	// (get) Token: 0x0600D202 RID: 53762 RVA: 0x003E5068 File Offset: 0x003E3268
	public WeaponConf WeaponConfig
	{
		get
		{
			return this.GetConfig().As<WeaponConf>().Value;
		}
	}

	// Token: 0x0600D203 RID: 53763 RVA: 0x003E5088 File Offset: 0x003E3288
	public override InventoryDefine.EItemMainTypeId? GetMainType()
	{
		return new InventoryDefine.EItemMainTypeId?(InventoryDefine.EItemMainTypeId.Weapon);
	}

	// Token: 0x0600D204 RID: 53764 RVA: 0x003E5090 File Offset: 0x003E3290
	public override InventoryDefine.EItemType? GetType()
	{
		return new InventoryDefine.EItemType?(InventoryDefine.EItemType.Weapon);
	}

	// Token: 0x0600D205 RID: 53765 RVA: 0x003E5098 File Offset: 0x003E3298
	public override int GetQuality()
	{
		return this.WeaponConfig.QualityId;
	}

	// Token: 0x0600D206 RID: 53766 RVA: 0x003E50B4 File Offset: 0x003E32B4
	public override int GetSortIndex()
	{
		return this.WeaponConfig.SortIndex;
	}

	// Token: 0x0600D207 RID: 53767 RVA: 0x003E50D0 File Offset: 0x003E32D0
	[NullableContext(0)]
	public override Span<int> GetItemAccess()
	{
		return this.WeaponConfig.GetItemAccessBytes();
	}

	// Token: 0x0600D208 RID: 53768 RVA: 0x003E50EB File Offset: 0x003E32EB
	public override int GetMaxStackCount()
	{
		return 1;
	}

	// Token: 0x0600D209 RID: 53769 RVA: 0x003E50EE File Offset: 0x003E32EE
	public override string GetDefaultDownText()
	{
		return ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("LevelShow"), null) ?? "";
	}

	// Token: 0x0600D20A RID: 53770 RVA: 0x003E5110 File Offset: 0x003E3310
	public override InventoryDefine.ERedDotDisableRule GetRedDotDisableRule()
	{
		return (InventoryDefine.ERedDotDisableRule)this.WeaponConfig.RedDotDisableRule;
	}

	// Token: 0x0600D20B RID: 53771 RVA: 0x003E512C File Offset: 0x003E332C
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
