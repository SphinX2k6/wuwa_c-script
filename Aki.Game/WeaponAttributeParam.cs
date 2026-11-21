using System;
using Aki.Config;

// Token: 0x02002265 RID: 8805
public class WeaponAttributeParam : IWeaponAttributeParam
{
	// Token: 0x17002108 RID: 8456
	// (get) Token: 0x06015C7B RID: 89211 RVA: 0x00651726 File Offset: 0x0064F926
	// (set) Token: 0x06015C7C RID: 89212 RVA: 0x0065172E File Offset: 0x0064F92E
	public ConfigPropValue PropId { get; set; }

	// Token: 0x17002109 RID: 8457
	// (get) Token: 0x06015C7D RID: 89213 RVA: 0x00651737 File Offset: 0x0064F937
	// (set) Token: 0x06015C7E RID: 89214 RVA: 0x0065173F File Offset: 0x0064F93F
	public int CurveId { get; set; }
}
