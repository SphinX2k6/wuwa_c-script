using System;

// Token: 0x0200197D RID: 6525
public class SmallItemGridLockAndDeprecate : ISmallItemGridLockAndDeprecate
{
	// Token: 0x17000FF0 RID: 4080
	// (get) Token: 0x0600BEF4 RID: 48884 RVA: 0x002B3010 File Offset: 0x002B1210
	// (set) Token: 0x0600BEF5 RID: 48885 RVA: 0x002B3018 File Offset: 0x002B1218
	public bool? IsLock { get; set; }

	// Token: 0x17000FF1 RID: 4081
	// (get) Token: 0x0600BEF6 RID: 48886 RVA: 0x002B3021 File Offset: 0x002B1221
	// (set) Token: 0x0600BEF7 RID: 48887 RVA: 0x002B3029 File Offset: 0x002B1229
	public bool? IsDeprecate { get; set; }
}
