using System;

// Token: 0x02002B6B RID: 11115
public class WeaponEvolveData : IWeaponEvolveData
{
	// Token: 0x17001EB7 RID: 7863
	// (get) Token: 0x06017074 RID: 94324 RVA: 0x005D8A45 File Offset: 0x005D6C45
	// (set) Token: 0x06017075 RID: 94325 RVA: 0x005D8A4D File Offset: 0x005D6C4D
	public int EvolveId { get; set; }

	// Token: 0x17001EB8 RID: 7864
	// (get) Token: 0x06017076 RID: 94326 RVA: 0x005D8A56 File Offset: 0x005D6C56
	// (set) Token: 0x06017077 RID: 94327 RVA: 0x005D8A5E File Offset: 0x005D6C5E
	public bool IsUnlock { get; set; }

	// Token: 0x17001EB9 RID: 7865
	// (get) Token: 0x06017078 RID: 94328 RVA: 0x005D8A67 File Offset: 0x005D6C67
	// (set) Token: 0x06017079 RID: 94329 RVA: 0x005D8A6F File Offset: 0x005D6C6F
	public bool ShowLine { get; set; }
}
