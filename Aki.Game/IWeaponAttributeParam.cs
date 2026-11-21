using System;
using Aki.Config;

// Token: 0x02002264 RID: 8804
public interface IWeaponAttributeParam
{
	// Token: 0x17002106 RID: 8454
	// (get) Token: 0x06015C77 RID: 89207
	// (set) Token: 0x06015C78 RID: 89208
	ConfigPropValue PropId { get; set; }

	// Token: 0x17002107 RID: 8455
	// (get) Token: 0x06015C79 RID: 89209
	// (set) Token: 0x06015C7A RID: 89210
	int CurveId { get; set; }
}
