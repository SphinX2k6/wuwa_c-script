using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x0200184C RID: 6220
[NullableContext(1)]
[Nullable(0)]
public class WeaponSkinHandBookFilter : CommonFilter
{
	// Token: 0x0600B630 RID: 46640 RVA: 0x0029333C File Offset: 0x0029153C
	protected object GetWeaponType(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		return WeaponConfig.Instance.GetWeaponSkinConfig(id).WeaponSkinType;
	}

	// Token: 0x0600B631 RID: 46641 RVA: 0x00293368 File Offset: 0x00291568
	protected object GetItemQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		int id = (int)data;
		return WeaponConfig.Instance.GetWeaponSkinConfig(id).QualityId;
	}

	// Token: 0x0600B632 RID: 46642 RVA: 0x00293394 File Offset: 0x00291594
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Weapon, new TFilterConfig(this.GetWeaponType));
		this.FilterMap.Add(FilterDefine.EFilterType.ItemQuality, new TFilterConfig(this.GetItemQuality));
	}
}
