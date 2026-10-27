using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x0200184B RID: 6219
[NullableContext(1)]
[Nullable(0)]
public class WeaponHandBookFilter : CommonFilter
{
	// Token: 0x0600B62C RID: 46636 RVA: 0x00293298 File Offset: 0x00291498
	protected object GetWeaponType(object data, Dictionary<int, string> currentSelectMap)
	{
		int itemId = (int)data;
		return WeaponConfig.Instance.GetWeaponConfigByItemId(itemId).Value.WeaponType;
	}

	// Token: 0x0600B62D RID: 46637 RVA: 0x002932CC File Offset: 0x002914CC
	protected object GetItemQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		int itemId = (int)data;
		return WeaponConfig.Instance.GetWeaponConfigByItemId(itemId).Value.QualityId;
	}

	// Token: 0x0600B62E RID: 46638 RVA: 0x00293300 File Offset: 0x00291500
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Weapon, new TFilterConfig(this.GetWeaponType));
		this.FilterMap.Add(FilterDefine.EFilterType.ItemQuality, new TFilterConfig(this.GetItemQuality));
	}
}
