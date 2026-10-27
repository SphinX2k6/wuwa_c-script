using System;
using System.Runtime.CompilerServices;

// Token: 0x0200189B RID: 6299
public class WeaponHandBookSort : CommonSort<EWeaponHandBookSortWayType>
{
	// Token: 0x0600B875 RID: 47221 RVA: 0x0029DC18 File Offset: 0x0029BE18
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

	// Token: 0x0600B876 RID: 47222 RVA: 0x0029DCA6 File Offset: 0x0029BEA6
	protected override void OnInitSortMap()
	{
		this.SortMap.Add(EWeaponHandBookSortWayType.Quality, new TSortResult(this.SortQuality));
	}
}
