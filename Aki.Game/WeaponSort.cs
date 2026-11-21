using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000D59 RID: 3417
[NullableContext(1)]
[Nullable(0)]
public class WeaponSort : CommonSort<EWeaponSortWayType>
{
	// Token: 0x06008C64 RID: 35940 RVA: 0x002A8480 File Offset: 0x002A6680
	private int SortLevel(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(itemDataBase.GetUniqueId());
		WeaponInstance weaponDataByIncId2 = WeaponModel.Instance.GetWeaponDataByIncId(itemDataBase2.GetUniqueId());
		int num = (weaponDataByIncId != null) ? weaponDataByIncId.GetLevel() : 0;
		int num2 = (weaponDataByIncId2 != null) ? weaponDataByIncId2.GetLevel() : 0;
		if (num != num2)
		{
			return (num2 - num) * (isAscending ? -1 : 1);
		}
		int num3 = (weaponDataByIncId != null) ? weaponDataByIncId.GetResonanceLevel() : 0;
		int num4 = (weaponDataByIncId2 != null) ? weaponDataByIncId2.GetResonanceLevel() : 0;
		if (num3 != num4)
		{
			return (num4 - num3) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C65 RID: 35941 RVA: 0x002A8520 File Offset: 0x002A6720
	private int SortBreachLevel(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(itemDataBase.GetUniqueId());
		WeaponInstance weaponDataByIncId2 = WeaponModel.Instance.GetWeaponDataByIncId(itemDataBase2.GetUniqueId());
		int num = (weaponDataByIncId != null) ? weaponDataByIncId.GetBreachLevel() : 0;
		int num2 = (weaponDataByIncId2 != null) ? weaponDataByIncId2.GetBreachLevel() : 0;
		if (num != num2)
		{
			return (num2 - num) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C66 RID: 35942 RVA: 0x002A8590 File Offset: 0x002A6790
	private int SortResonanceLevel(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(itemDataBase.GetUniqueId());
		WeaponInstance weaponDataByIncId2 = WeaponModel.Instance.GetWeaponDataByIncId(itemDataBase2.GetUniqueId());
		int num = (weaponDataByIncId != null) ? weaponDataByIncId.GetResonanceLevel() : 0;
		int num2 = (weaponDataByIncId2 != null) ? weaponDataByIncId2.GetResonanceLevel() : 0;
		if (num != num2)
		{
			return (num2 - num) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C67 RID: 35943 RVA: 0x002A8600 File Offset: 0x002A6800
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		if (itemDataBase.GetQuality() != itemDataBase2.GetQuality())
		{
			return (itemDataBase2.GetQuality() - itemDataBase.GetQuality()) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C68 RID: 35944 RVA: 0x002A8640 File Offset: 0x002A6840
	private int SortLock(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		if (itemDataBase.GetIsLock() != itemDataBase2.GetIsLock())
		{
			int num = (itemDataBase.GetIsLock() > false) ? 1 : 0;
			int num2 = (itemDataBase2.GetIsLock() > false) ? 1 : 0;
			return -1 * (num - num2);
		}
		return 0;
	}

	// Token: 0x06008C69 RID: 35945 RVA: 0x002A8684 File Offset: 0x002A6884
	private int SortExp(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemData = a as ItemDataBase;
		ItemDataBase itemData2 = b as ItemDataBase;
		int weaponItemBaseExp = WeaponModel.Instance.GetWeaponItemBaseExp(itemData);
		int weaponItemBaseExp2 = WeaponModel.Instance.GetWeaponItemBaseExp(itemData2);
		if (weaponItemBaseExp != weaponItemBaseExp2)
		{
			return (weaponItemBaseExp2 - weaponItemBaseExp) * (isAscending ? -1 : 1);
		}
		return 0;
	}

	// Token: 0x06008C6A RID: 35946 RVA: 0x002A86C8 File Offset: 0x002A68C8
	private int SortUniqueId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		return ((b as ItemDataBase).GetUniqueId() - itemDataBase.GetUniqueId()) * (isAscending ? -1 : 1);
	}

	// Token: 0x06008C6B RID: 35947 RVA: 0x002A86F8 File Offset: 0x002A68F8
	private int SortConfigId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		return ((b as ItemDataBase).GetConfigId() - itemDataBase.GetConfigId()) * (isAscending ? -1 : 1);
	}

	// Token: 0x06008C6C RID: 35948 RVA: 0x002A8728 File Offset: 0x002A6928
	private int SortExpFirst(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		bool flag = itemDataBase.GetType().GetValueOrDefault() == InventoryDefine.EItemType.WeaponMaterial;
		bool flag2 = itemDataBase2.GetType().GetValueOrDefault() == InventoryDefine.EItemType.WeaponMaterial;
		if (flag != flag2)
		{
			int num = (flag > false) ? 1 : 0;
			return ((flag2 > false) ? 1 : 0) - num;
		}
		return 0;
	}

	// Token: 0x06008C6D RID: 35949 RVA: 0x002A8778 File Offset: 0x002A6978
	private int SortWeaponExpItemType(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemData = a as ItemDataBase;
		ItemDataBase itemData2 = b as ItemDataBase;
		EWeaponExpItemType? weaponExpItemType = this.GetWeaponExpItemType(itemData);
		EWeaponExpItemType? weaponExpItemType2 = this.GetWeaponExpItemType(itemData2);
		if (weaponExpItemType == null || weaponExpItemType2 == null)
		{
			return 0;
		}
		EWeaponExpItemType? eweaponExpItemType = weaponExpItemType;
		EWeaponExpItemType? eweaponExpItemType2 = weaponExpItemType2;
		if (!(eweaponExpItemType.GetValueOrDefault() == eweaponExpItemType2.GetValueOrDefault() & eweaponExpItemType != null == (eweaponExpItemType2 != null)))
		{
			return weaponExpItemType.Value - weaponExpItemType2.Value;
		}
		return 0;
	}

	// Token: 0x06008C6E RID: 35950 RVA: 0x002A87F4 File Offset: 0x002A69F4
	private int SortWeaponFirst(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		ItemDataBase itemDataBase2 = b as ItemDataBase;
		bool flag = itemDataBase.GetType().GetValueOrDefault() == InventoryDefine.EItemType.Weapon;
		bool flag2 = itemDataBase2.GetType().GetValueOrDefault() == InventoryDefine.EItemType.Weapon;
		if (flag != flag2)
		{
			int num = (flag > false) ? 1 : 0;
			return ((flag2 > false) ? 1 : 0) - num;
		}
		return 0;
	}

	// Token: 0x06008C6F RID: 35951 RVA: 0x002A8844 File Offset: 0x002A6A44
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EWeaponSortWayType.Level, new TSortResult(this.SortLevel));
		this.SortMap.Add(EWeaponSortWayType.Quality, new TSortResult(this.SortQuality));
		this.SortMap.Add(EWeaponSortWayType.Lock, new TSortResult(this.SortLock));
		this.SortMap.Add(EWeaponSortWayType.Exp, new TSortResult(this.SortExp));
		this.SortMap.Add(EWeaponSortWayType.UniqueId, new TSortResult(this.SortUniqueId));
		this.SortMap.Add(EWeaponSortWayType.BreachLevel, new TSortResult(this.SortBreachLevel));
		this.SortMap.Add(EWeaponSortWayType.ResonanceLevel, new TSortResult(this.SortResonanceLevel));
		this.SortMap.Add(EWeaponSortWayType.ConfigId, new TSortResult(this.SortConfigId));
		this.SortMap.Add(EWeaponSortWayType.ExpFirst, new TSortResult(this.SortExpFirst));
		this.SortMap.Add(EWeaponSortWayType.WeaponExpItemType, new TSortResult(this.SortWeaponExpItemType));
		this.SortMap.Add(EWeaponSortWayType.WeaponFirst, new TSortResult(this.SortWeaponFirst));
	}

	// Token: 0x06008C70 RID: 35952 RVA: 0x002A895C File Offset: 0x002A6B5C
	private EWeaponExpItemType? GetWeaponExpItemType(ItemDataBase itemData)
	{
		if (itemData == null)
		{
			return null;
		}
		InventoryDefine.EItemType? type = itemData.GetType();
		if (type.GetValueOrDefault() == InventoryDefine.EItemType.WeaponMaterial)
		{
			return new EWeaponExpItemType?(EWeaponExpItemType.ExpItem);
		}
		if (type.GetValueOrDefault() != InventoryDefine.EItemType.Weapon)
		{
			return null;
		}
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(itemData.GetUniqueId());
		if (weaponDataByIncId != null && weaponDataByIncId.HasWeaponCultivated())
		{
			return new EWeaponExpItemType?(EWeaponExpItemType.CultivatedWeapon);
		}
		return new EWeaponExpItemType?(EWeaponExpItemType.OriginalWeapon);
	}
}
