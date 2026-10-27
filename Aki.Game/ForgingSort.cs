using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Forging;

// Token: 0x02001888 RID: 6280
[NullableContext(1)]
[Nullable(0)]
public class ForgingSort : CommonSort<EForgingSortWayType>
{
	// Token: 0x0600B7F9 RID: 47097 RVA: 0x0029A5A4 File Offset: 0x002987A4
	private int SortMake(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IWeaponForgingData weaponForgingData = a as IWeaponForgingData;
		if (weaponForgingData == null)
		{
			return 0;
		}
		IWeaponForgingData weaponForgingData2 = b as IWeaponForgingData;
		if (weaponForgingData2 == null)
		{
			return 0;
		}
		int num = (ForgingController.Instance.CheckCanForgingOrCanUnlock(weaponForgingData.ItemId) > false) ? 1 : 0;
		int num2 = (ForgingController.Instance.CheckCanForgingOrCanUnlock(weaponForgingData2.ItemId) > false) ? 1 : 0;
		if (num == 1 && num == num2)
		{
			if (weaponForgingData.IsUnlock != weaponForgingData2.IsUnlock)
			{
				return (weaponForgingData.IsUnlock - weaponForgingData2.IsUnlock) * (isAscending ? -1 : 1);
			}
			return weaponForgingData.SortId - weaponForgingData2.SortId;
		}
		else
		{
			if (num != 0 || num != num2)
			{
				return (num2 - num) * (isAscending ? -1 : 1);
			}
			if (weaponForgingData.IsUnlock != weaponForgingData2.IsUnlock)
			{
				return (weaponForgingData2.IsUnlock - weaponForgingData.IsUnlock) * (isAscending ? -1 : 1);
			}
			return weaponForgingData.SortId - weaponForgingData2.SortId;
		}
	}

	// Token: 0x0600B7FA RID: 47098 RVA: 0x0029A670 File Offset: 0x00298870
	private int SortType(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IWeaponForgingData weaponForgingData = a as IWeaponForgingData;
		if (weaponForgingData == null)
		{
			return 0;
		}
		IWeaponForgingData weaponForgingData2 = b as IWeaponForgingData;
		if (weaponForgingData2 == null)
		{
			return 0;
		}
		if (weaponForgingData2.WeaponType != weaponForgingData.WeaponType)
		{
			return (weaponForgingData2.WeaponType - weaponForgingData.WeaponType) * (isAscending ? -1 : 1);
		}
		return weaponForgingData.SortId - weaponForgingData2.SortId;
	}

	// Token: 0x0600B7FB RID: 47099 RVA: 0x0029A6C8 File Offset: 0x002988C8
	private int SortId(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] param = null)
	{
		IWeaponForgingData weaponForgingData = a as IWeaponForgingData;
		if (weaponForgingData == null)
		{
			return 0;
		}
		IWeaponForgingData weaponForgingData2 = b as IWeaponForgingData;
		if (weaponForgingData2 == null)
		{
			return 0;
		}
		if (weaponForgingData.ItemId != weaponForgingData2.ItemId)
		{
			return (weaponForgingData2.ItemId - weaponForgingData.ItemId) * (isAscending ? -1 : 1);
		}
		return weaponForgingData.SortId - weaponForgingData2.SortId;
	}

	// Token: 0x0600B7FC RID: 47100 RVA: 0x0029A720 File Offset: 0x00298920
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EForgingSortWayType.Make, new TSortResult(this.SortMake));
		this.SortMap.Add(EForgingSortWayType.Type, new TSortResult(this.SortType));
		this.SortMap.Add(EForgingSortWayType.Id, new TSortResult(this.SortId));
	}
}
