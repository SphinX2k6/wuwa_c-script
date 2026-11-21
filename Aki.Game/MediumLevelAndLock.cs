using System;

// Token: 0x02000DD6 RID: 3542
public class MediumLevelAndLock : IMediumLevelAndLock
{
	// Token: 0x17000FDB RID: 4059
	// (get) Token: 0x06009039 RID: 36921 RVA: 0x002B4CDB File Offset: 0x002B2EDB
	// (set) Token: 0x0600903A RID: 36922 RVA: 0x002B4CE3 File Offset: 0x002B2EE3
	public int? Level { get; set; }

	// Token: 0x17000FDC RID: 4060
	// (get) Token: 0x0600903B RID: 36923 RVA: 0x002B4CEC File Offset: 0x002B2EEC
	// (set) Token: 0x0600903C RID: 36924 RVA: 0x002B4CF4 File Offset: 0x002B2EF4
	public bool? IsLevelInfinite { get; set; }

	// Token: 0x17000FDD RID: 4061
	// (get) Token: 0x0600903D RID: 36925 RVA: 0x002B4CFD File Offset: 0x002B2EFD
	// (set) Token: 0x0600903E RID: 36926 RVA: 0x002B4D05 File Offset: 0x002B2F05
	public bool? IsLockVisible { get; set; }

	// Token: 0x17000FDE RID: 4062
	// (get) Token: 0x0600903F RID: 36927 RVA: 0x002B4D0E File Offset: 0x002B2F0E
	// (set) Token: 0x06009040 RID: 36928 RVA: 0x002B4D16 File Offset: 0x002B2F16
	public bool? IsLevelUseChangeColor { get; set; }

	// Token: 0x17000FDF RID: 4063
	// (get) Token: 0x06009041 RID: 36929 RVA: 0x002B4D1F File Offset: 0x002B2F1F
	// (set) Token: 0x06009042 RID: 36930 RVA: 0x002B4D27 File Offset: 0x002B2F27
	public bool? IsUseVision { get; set; }

	// Token: 0x17000FE0 RID: 4064
	// (get) Token: 0x06009043 RID: 36931 RVA: 0x002B4D30 File Offset: 0x002B2F30
	// (set) Token: 0x06009044 RID: 36932 RVA: 0x002B4D38 File Offset: 0x002B2F38
	public bool? IsDeprecate { get; set; }
}
