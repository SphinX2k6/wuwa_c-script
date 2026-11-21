using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000D05 RID: 3333
[NullableContext(1)]
[Nullable(0)]
public class WeaponSkinHandBookFilter : CommonFilter
{
	// Token: 0x06008A19 RID: 35353 RVA: 0x0029DA4C File Offset: 0x0029BC4C
	protected object GetWeaponType(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		return WeaponConfig.Instance.GetWeaponSkinConfig(id).WeaponSkinType;
	}

	// Token: 0x06008A1A RID: 35354 RVA: 0x0029DA78 File Offset: 0x0029BC78
	protected object GetItemQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		return WeaponConfig.Instance.GetWeaponSkinConfig(id).QualityId;
	}

	// Token: 0x06008A1B RID: 35355 RVA: 0x0029DAA4 File Offset: 0x0029BCA4
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Weapon, new TFilterConfig(this.GetWeaponType));
		this.FilterMap.Add(FilterDefine.EFilterType.ItemQuality, new TFilterConfig(this.GetItemQuality));
	}
}
