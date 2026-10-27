using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FilterDefine;

// Token: 0x02001844 RID: 6212
[NullableContext(1)]
[Nullable(0)]
public class PinballWeaponFilter : CommonFilter
{
	// Token: 0x0600B608 RID: 46600 RVA: 0x0029293C File Offset: 0x00290B3C
	protected object GetPinballWeaponType(object data, Dictionary<int, string> currentSelectMap)
	{
		PinballWeaponData pinballWeaponData = (PinballWeaponData)data;
		return PinballConfig.Instance.GetPinballWeaponConfigById(pinballWeaponData.Id).Value.Type;
	}

	// Token: 0x0600B609 RID: 46601 RVA: 0x00292978 File Offset: 0x00290B78
	protected object GetPinballWeaponQuality(object data, Dictionary<int, string> currentSelectMap)
	{
		PinballWeaponData pinballWeaponData = (PinballWeaponData)data;
		return PinballConfig.Instance.GetPinballWeaponConfigById(pinballWeaponData.Id).Value.QualityId;
	}

	// Token: 0x0600B60A RID: 46602 RVA: 0x002929B1 File Offset: 0x00290BB1
	protected override void OnInitFilterMap()
	{
		this.FilterMap.Add(FilterDefine.EFilterType.PinballWeaponType, new TFilterConfig(this.GetPinballWeaponType));
		this.FilterMap.Add(FilterDefine.EFilterType.PinballWeaponQuality, new TFilterConfig(this.GetPinballWeaponQuality));
	}
}
