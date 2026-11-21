using System;
using System.Runtime.CompilerServices;

// Token: 0x02002072 RID: 8306
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponWithBondInfo : ISurvivorsWeaponWithBondInfo
{
	// Token: 0x17001EE3 RID: 7907
	// (get) Token: 0x0601483B RID: 84027 RVA: 0x005FA584 File Offset: 0x005F8784
	// (set) Token: 0x0601483C RID: 84028 RVA: 0x005FA58C File Offset: 0x005F878C
	public SurvivorsWeaponGainData WeaponData { get; set; }

	// Token: 0x17001EE4 RID: 7908
	// (get) Token: 0x0601483D RID: 84029 RVA: 0x005FA595 File Offset: 0x005F8795
	// (set) Token: 0x0601483E RID: 84030 RVA: 0x005FA59D File Offset: 0x005F879D
	public int BondPosition { get; set; }
}
