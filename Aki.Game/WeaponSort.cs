using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020018A0 RID: 6304
[NullableContext(1)]
[Nullable(0)]
public class WeaponSort : CommonSort<EWeaponSortWayType>
{
	// Token: 0x0600B87B RID: 47227 RVA: 0x0029DD64 File Offset: 0x0029BF64
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

	// Token: 0x0600B87C RID: 47228 RVA: 0x0029DE04 File Offset: 0x0029C004
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

	// Token: 0x0600B87D RID: 47229 RVA: 0x0029DE74 File Offset: 0x0029C074
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

	// Token: 0x0600B87E RID: 47230 RVA: 0x0029DEE4 File Offset: 0x0029C0E4
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

	// Token: 0x0600B87F RID: 47231 RVA: 0x0029DF24 File Offset: 0x0029C124
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

	// Token: 0x0600B880 RID: 47232 RVA: 0x0029DF68 File Offset: 0x0029C168
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

	// Token: 0x0600B881 RID: 47233 RVA: 0x0029DFAC File Offset: 0x0029C1AC
	private int SortUniqueId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		return ((b as ItemDataBase).GetUniqueId() - itemDataBase.GetUniqueId()) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B882 RID: 47234 RVA: 0x0029DFDC File Offset: 0x0029C1DC
	private int SortConfigId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		ItemDataBase itemDataBase = a as ItemDataBase;
		return ((b as ItemDataBase).GetConfigId() - itemDataBase.GetConfigId()) * (isAscending ? -1 : 1);
	}

	// Token: 0x0600B883 RID: 47235 RVA: 0x0029E00C File Offset: 0x0029C20C
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

	// Token: 0x0600B884 RID: 47236 RVA: 0x0029E05C File Offset: 0x0029C25C
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

	// Token: 0x0600B885 RID: 47237 RVA: 0x0029E0D8 File Offset: 0x0029C2D8
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

	// Token: 0x0600B886 RID: 47238 RVA: 0x0029E128 File Offset: 0x0029C328
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

	// Token: 0x0600B887 RID: 47239 RVA: 0x0029E240 File Offset: 0x0029C440
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
