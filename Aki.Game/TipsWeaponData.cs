using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D92 RID: 3474
[NullableContext(1)]
[Nullable(0)]
public class TipsWeaponData : ItemTipsData
{
	// Token: 0x06008E89 RID: 36489 RVA: 0x002AE7E4 File Offset: 0x002AC9E4
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

	// Token: 0x06008E8A RID: 36490 RVA: 0x002AEC27 File Offset: 0x002ACE27
	protected override bool OnIsShowIconBig()
	{
		return true;
	}

	// Token: 0x04005554 RID: 21844
	public string WeaponType = "";

	// Token: 0x04005555 RID: 21845
	public int WeaponLevel;

	// Token: 0x04005556 RID: 21846
	public int WeaponLimitLevel;

	// Token: 0x04005557 RID: 21847
	public int BreachLevel;

	// Token: 0x04005558 RID: 21848
	public int BreachMaxLevel;

	// Token: 0x04005559 RID: 21849
	public int WeaponStage;

	// Token: 0x0400555A RID: 21850
	public string WeaponSkillName = "";

	// Token: 0x0400555B RID: 21851
	public string WeaponEffect = "";

	// Token: 0x0400555C RID: 21852
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] WeaponEffectParam;

	// Token: 0x0400555D RID: 21853
	public string WeaponDescription = "";

	// Token: 0x0400555E RID: 21854
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public ITipsAttributeItemData[] AttributeData;

	// Token: 0x0400555F RID: 21855
	public bool IsEquip;

	// Token: 0x04005560 RID: 21856
	public int? EquippedId;
}
