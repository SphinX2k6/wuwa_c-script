using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02000CFD RID: 3325
[NullableContext(1)]
[Nullable(0)]
public class PinballWeaponFilter : CommonFilter
{
	// Token: 0x060089F3 RID: 35315 RVA: 0x0029D074 File Offset: 0x0029B274
	protected object GetPinballWeaponType(object data, Dictionary<int, string> currentSelectMap)
	{
		PinballWeaponData pinballWeaponData = (PinballWeaponData)data;
		return PinballConfig.Instance.GetPinballWeaponConfigById(pinballWeaponData.Id).Value.Type;
	}

	// Token: 0x060089F4 RID: 35316 RVA: 0x0029D0B0 File Offset: 0x0029B2B0
	protected object GetPinballWeaponQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		PinballWeaponData pinballWeaponData = (PinballWeaponData)data;
		return PinballConfig.Instance.GetPinballWeaponConfigById(pinballWeaponData.Id).Value.QualityId;
	}

	// Token: 0x060089F5 RID: 35317 RVA: 0x0029D0E9 File Offset: 0x0029B2E9
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.PinballWeaponType, new TFilterConfig(this.GetPinballWeaponType));
		this.FilterMap.Add(FilterDefine.EFilterType.PinballWeaponQuality, new TFilterConfig(this.GetPinballWeaponQuality));
	}
}
