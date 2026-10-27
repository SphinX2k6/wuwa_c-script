using System;
using System.Runtime.CompilerServices;

// Token: 0x02002AF6 RID: 10998
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponWithBondInfo : ISurvivorsWeaponWithBondInfo
{
	// Token: 0x17001E8B RID: 7819
	// (get) Token: 0x06016E0A RID: 93706 RVA: 0x005CDA04 File Offset: 0x005CBC04
	// (set) Token: 0x06016E0B RID: 93707 RVA: 0x005CDA0C File Offset: 0x005CBC0C
	public SurvivorsWeaponGainData WeaponData { get; set; }

	// Token: 0x17001E8C RID: 7820
	// (get) Token: 0x06016E0C RID: 93708 RVA: 0x005CDA15 File Offset: 0x005CBC15
	// (set) Token: 0x06016E0D RID: 93709 RVA: 0x005CDA1D File Offset: 0x005CBC1D
	public int BondPosition { get; set; }
}
