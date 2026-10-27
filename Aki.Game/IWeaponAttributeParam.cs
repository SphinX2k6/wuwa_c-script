using System;
using Aki.Config;

// Token: 0x02002D0A RID: 11530
public interface IWeaponAttributeParam
{
	// Token: 0x170020AB RID: 8363
	// (get) Token: 0x060183D6 RID: 99286
	// (set) Token: 0x060183D7 RID: 99287
	ConfigPropValue PropId { get; set; }

	// Token: 0x170020AC RID: 8364
	// (get) Token: 0x060183D8 RID: 99288
	// (set) Token: 0x060183D9 RID: 99289
	int CurveId { get; set; }
}
