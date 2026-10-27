using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020018D9 RID: 6361
[NullableContext(1)]
[Nullable(0)]
public class TipsWeaponData : ItemTipsData
{
	// Token: 0x0600BAA0 RID: 47776 RVA: 0x002A4068 File Offset: 0x002A2268
	public TipsWeaponData(ItemTipsParam data) : base(data)
	{
		AttributeItemData attributeItemData = InventoryModel.Instance.GetAttributeItemData(this.IncId);
		WeaponConf? weaponConf = (this.IncId != 0) ? attributeItemData.GetConfig().As<WeaponConf>() : InventoryConfig.Instance.GetWeaponItemConfig(this.ConfigId);
		if (weaponConf == null)
		{
			return;
		}
		WeaponInstance weaponInstance = (this.IncId != 0) ? WeaponModel.Instance.GetWeaponDataByIncId(this.IncId) : null;
		WeaponConf? weaponConf2 = (weaponInstance != null) ? weaponInstance.GetWeaponConfig() : WeaponConfig.Instance.GetWeaponConfigByItemId(weaponConf.Value.ItemId);
		int num = (weaponInstance != null) ? weaponInstance.GetBreachLevel() : 0;
		int num2 = (weaponInstance != null) ? weaponInstance.GetResonanceLevel() : 1;
		WeaponBreach? weaponBreach = (weaponInstance != null) ? weaponInstance.GetBreachConfig() : WeaponConfig.Instance.GetWeaponBreach(weaponConf2.Value.BreachId, num);
		int breachId = weaponConf2.Value.BreachId;
		WeaponReson? weaponResonanceConfig = WeaponConfig.Instance.GetWeaponResonanceConfig(weaponConf2.Value.ResonId, num2);
		this.ItemType = EItemTipsType.Weapon;
		this.WeaponType = WeaponConfig.Instance.GetWeaponTypeName(weaponConf2.Value.WeaponType);
		int num3 = (weaponInstance != null) ? weaponInstance.GetLevel() : 1;
		int levelLimit = weaponBreach.Value.LevelLimit;
		this.WeaponLevel = num3;
		this.WeaponLimitLevel = levelLimit;
		this.BreachLevel = num;
		int weaponBreachMaxLevel = WeaponModel.Instance.GetWeaponBreachMaxLevel(breachId);
		this.BreachMaxLevel = weaponBreachMaxLevel;
		this.WeaponStage = num2;
		this.WeaponSkillName = weaponResonanceConfig.Value.Name;
		this.WeaponEffect = weaponConf2.Value.Desc;
		string[] weaponConfigDescParams = WeaponModel.Instance.GetWeaponConfigDescParams(weaponConf2.Value, num2);
		this.WeaponEffectParam = weaponConfigDescParams;
		this.WeaponDescription = weaponConf2.Value.AttributesDescription;
		List<ITipsAttributeItemData> list = new List<ITipsAttributeItemData>();
		int id = weaponConf2.Value.FirstPropId.Value.Id;
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(id);
		float curveValue = WeaponModel.Instance.GetCurveValue(weaponConf2.Value.FirstCurve, weaponConf2.Value.FirstPropId.Value.Value, num3, num);
		TipsAttributeItemData item = new TipsAttributeItemData
		{
			Id = id,
			IsMainAttribute = true,
			Name = propertyIndexInfo.Value.Name,
			IconPath = propertyIndexInfo.Value.Icon,
			Value = (double)curveValue,
			IsRatio = weaponConf2.Value.FirstPropId.Value.IsRatio
		};
		int id2 = weaponConf2.Value.SecondPropId.Value.Id;
		propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(id2);
		float curveValue2 = WeaponModel.Instance.GetCurveValue(weaponConf2.Value.SecondCurve, weaponConf2.Value.SecondPropId.Value.Value, num3, num);
		TipsAttributeItemData item2 = new TipsAttributeItemData
		{
			Id = id2,
			IsMainAttribute = true,
			Name = propertyIndexInfo.Value.Name,
			IconPath = propertyIndexInfo.Value.Icon,
			Value = (double)curveValue2,
			IsRatio = weaponConf2.Value.SecondPropId.Value.IsRatio
		};
		list.Add(item);
		list.Add(item2);
		this.AttributeData = list.ToArray();
		if (weaponInstance != null)
		{
			this.EquippedId = new int?(weaponInstance.GetRoleId());
			int? equippedId = this.EquippedId;
			int num4 = 0;
			this.IsEquip = !(equippedId.GetValueOrDefault() == num4 & equippedId != null);
		}
	}

	// Token: 0x0600BAA1 RID: 47777 RVA: 0x002A44AB File Offset: 0x002A26AB
	protected override bool OnIsShowIconBig()
	{
		return true;
	}

	// Token: 0x040054A9 RID: 21673
	public string WeaponType = "";

	// Token: 0x040054AA RID: 21674
	public int WeaponLevel;

	// Token: 0x040054AB RID: 21675
	public int WeaponLimitLevel;

	// Token: 0x040054AC RID: 21676
	public int BreachLevel;

	// Token: 0x040054AD RID: 21677
	public int BreachMaxLevel;

	// Token: 0x040054AE RID: 21678
	public int WeaponStage;

	// Token: 0x040054AF RID: 21679
	public string WeaponSkillName = "";

	// Token: 0x040054B0 RID: 21680
	public string WeaponEffect = "";

	// Token: 0x040054B1 RID: 21681
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] WeaponEffectParam;

	// Token: 0x040054B2 RID: 21682
	public string WeaponDescription = "";

	// Token: 0x040054B3 RID: 21683
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ITipsAttributeItemData[] AttributeData;

	// Token: 0x040054B4 RID: 21684
	public bool IsEquip;

	// Token: 0x040054B5 RID: 21685
	public int? EquippedId;
}
