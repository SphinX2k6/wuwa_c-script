using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000D04 RID: 3332
[NullableContext(1)]
[Nullable(0)]
public class WeaponHandBookFilter : CommonFilter
{
	// Token: 0x06008A15 RID: 35349 RVA: 0x0029D9A8 File Offset: 0x0029BBA8
	protected object GetWeaponType(object data, Dictionary<int, string> currentSelectMap)
	{
		int itemId = (int)data;
		return WeaponConfig.Instance.GetWeaponConfigByItemId(itemId).Value.WeaponType;
	}

	// Token: 0x06008A16 RID: 35350 RVA: 0x0029D9DC File Offset: 0x0029BBDC
	protected object GetItemQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		int itemId = (int)data;
		return WeaponConfig.Instance.GetWeaponConfigByItemId(itemId).Value.QualityId;
	}

	// Token: 0x06008A17 RID: 35351 RVA: 0x0029DA10 File Offset: 0x0029BC10
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.Weapon, new TFilterConfig(this.GetWeaponType));
		this.FilterMap.Add(FilterDefine.EFilterType.ItemQuality, new TFilterConfig(this.GetItemQuality));
	}
}
