using System;
using System.Runtime.CompilerServices;

// Token: 0x0200189D RID: 6301
public class WeaponSkinHandBookSort : CommonSort<EWeaponSkinHandBookSortWayType>
{
	// Token: 0x0600B878 RID: 47224 RVA: 0x0029DCC8 File Offset: 0x0029BEC8
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
		int id = num2;
		int num4;
		if (b is int)
		{
			int num3 = (int)b;
			num4 = num3;
		}
		else
		{
			num4 = 0;
		}
		int id2 = num4;
		int qualityId = WeaponConfig.Instance.GetWeaponSkinConfig(id).QualityId;
		int qualityId2 = WeaponConfig.Instance.GetWeaponSkinConfig(id2).QualityId;
		if (qualityId != qualityId2)
		{
			return (qualityId - qualityId2) * (isAscending ? 1 : -1);
		}
		return 0;
	}

	// Token: 0x0600B879 RID: 47225 RVA: 0x0029DD42 File Offset: 0x0029BF42
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EWeaponSkinHandBookSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
