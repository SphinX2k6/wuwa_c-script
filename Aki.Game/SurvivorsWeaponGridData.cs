using System;
using System.Runtime.CompilerServices;

// Token: 0x02002070 RID: 8304
[NullableContext(2)]
[Nullable(0)]
public class SurvivorsWeaponGridData : ISurvivorsWeaponGridData
{
	// Token: 0x17001EDC RID: 7900
	// (get) Token: 0x0601482E RID: 84014 RVA: 0x005FA527 File Offset: 0x005F8727
	// (set) Token: 0x0601482F RID: 84015 RVA: 0x005FA52F File Offset: 0x005F872F
	public SurvivorsWeaponGainData WeaponData { get; set; }

	// Token: 0x17001EDD RID: 7901
	// (get) Token: 0x06014830 RID: 84016 RVA: 0x005FA538 File Offset: 0x005F8738
	// (set) Token: 0x06014831 RID: 84017 RVA: 0x005FA540 File Offset: 0x005F8740
	public int? BondPosition { get; set; }

	// Token: 0x17001EDE RID: 7902
	// (get) Token: 0x06014832 RID: 84018 RVA: 0x005FA549 File Offset: 0x005F8749
	// (set) Token: 0x06014833 RID: 84019 RVA: 0x005FA551 File Offset: 0x005F8751
	public bool IsLock { get; set; }

	// Token: 0x17001EDF RID: 7903
	// (get) Token: 0x06014834 RID: 84020 RVA: 0x005FA55A File Offset: 0x005F875A
	// (set) Token: 0x06014835 RID: 84021 RVA: 0x005FA562 File Offset: 0x005F8762
	public int? UnlockBatch { get; set; }

	// Token: 0x17001EE0 RID: 7904
	// (get) Token: 0x06014836 RID: 84022 RVA: 0x005FA56B File Offset: 0x005F876B
	// (set) Token: 0x06014837 RID: 84023 RVA: 0x005FA573 File Offset: 0x005F8773
	public bool IsDisable { get; set; }
}
