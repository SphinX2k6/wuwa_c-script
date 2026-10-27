using System;
using Aki.Config;

// Token: 0x02002D0B RID: 11531
public class WeaponAttributeParam : IWeaponAttributeParam
{
	// Token: 0x170020AD RID: 8365
	// (get) Token: 0x060183DA RID: 99290 RVA: 0x0062B72E File Offset: 0x0062992E
	// (set) Token: 0x060183DB RID: 99291 RVA: 0x0062B736 File Offset: 0x00629936
	public ConfigPropValue PropId { get; set; }

	// Token: 0x170020AE RID: 8366
	// (get) Token: 0x060183DC RID: 99292 RVA: 0x0062B73F File Offset: 0x0062993F
	// (set) Token: 0x060183DD RID: 99293 RVA: 0x0062B747 File Offset: 0x00629947
	public int CurveId { get; set; }
}
