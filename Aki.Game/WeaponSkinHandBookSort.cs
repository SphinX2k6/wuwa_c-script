using System;
using System.Runtime.CompilerServices;

// Token: 0x02000D56 RID: 3414
public class WeaponSkinHandBookSort : CommonSort<EWeaponSkinHandBookSortWayType>
{
	// Token: 0x06008C61 RID: 35937 RVA: 0x002A83E4 File Offset: 0x002A65E4
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

	// Token: 0x06008C62 RID: 35938 RVA: 0x002A845E File Offset: 0x002A665E
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EWeaponSkinHandBookSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
