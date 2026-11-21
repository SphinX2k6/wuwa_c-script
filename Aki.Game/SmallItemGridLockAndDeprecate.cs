using System;

// Token: 0x02000E3A RID: 3642
public class SmallItemGridLockAndDeprecate : ISmallItemGridLockAndDeprecate
{
	// Token: 0x17001014 RID: 4116
	// (get) Token: 0x060092FC RID: 37628 RVA: 0x002BDF94 File Offset: 0x002BC194
	// (set) Token: 0x060092FD RID: 37629 RVA: 0x002BDF9C File Offset: 0x002BC19C
	public bool? IsLock { get; set; }

	// Token: 0x17001015 RID: 4117
	// (get) Token: 0x060092FE RID: 37630 RVA: 0x002BDFA5 File Offset: 0x002BC1A5
	// (set) Token: 0x060092FF RID: 37631 RVA: 0x002BDFAD File Offset: 0x002BC1AD
	public bool? IsDeprecate { get; set; }
}
