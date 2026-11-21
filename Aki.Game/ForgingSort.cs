using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Manufacture.Forging;

// Token: 0x02000D41 RID: 3393
[NullableContext(1)]
[Nullable(0)]
public class ForgingSort : CommonSort<EForgingSortWayType>
{
	// Token: 0x06008BE2 RID: 35810 RVA: 0x002A4CBC File Offset: 0x002A2EBC
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

	// Token: 0x06008BE3 RID: 35811 RVA: 0x002A4D88 File Offset: 0x002A2F88
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

	// Token: 0x06008BE4 RID: 35812 RVA: 0x002A4DE0 File Offset: 0x002A2FE0
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

	// Token: 0x06008BE5 RID: 35813 RVA: 0x002A4E38 File Offset: 0x002A3038
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EForgingSortWayType.Make, new TSortResult(this.SortMake));
		this.SortMap.Add(EForgingSortWayType.Type, new TSortResult(this.SortType));
		this.SortMap.Add(EForgingSortWayType.Id, new TSortResult(this.SortId));
	}
}
