using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D54 RID: 3412
public class WeaponHandBookSort : CommonSort<EWeaponHandBookSortWayType>
{
	// Token: 0x06008C5E RID: 35934 RVA: 0x002A8334 File Offset: 0x002A6534
	[NullableContext(2)]
	private int SortQuality(object a, object b, bool isAscending, [Nullable(new byte[]
	{
		2,
		1
	})] object[] parameters = null)
	{
		int num2;
		if (a is int)
		{
			int num = (int)a;
			num2 = num;
		}
		else
		{
			num2 = 0;
		}
		int num3 = num2;
		int num5;
		if (b is int)
		{
			int num4 = (int)b;
			num5 = num4;
		}
		else
		{
			num5 = 0;
		}
		int num6 = num5;
		int qualityId = WeaponConfig.Instance.GetWeaponConfigByItemId(num3).Value.QualityId;
		int qualityId2 = WeaponConfig.Instance.GetWeaponConfigByItemId(num6).Value.QualityId;
		if (qualityId != qualityId2)
		{
			return (qualityId - qualityId2) * (isAscending ? 1 : -1);
		}
		return num6 - num3;
	}

	// Token: 0x06008C5F RID: 35935 RVA: 0x002A83C2 File Offset: 0x002A65C2
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EWeaponHandBookSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
