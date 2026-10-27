using System;

// Token: 0x0200191D RID: 6429
public class MediumLevelAndLock : IMediumLevelAndLock
{
	// Token: 0x17000FB8 RID: 4024
	// (get) Token: 0x0600BC4F RID: 48207 RVA: 0x002AA57F File Offset: 0x002A877F
	// (set) Token: 0x0600BC50 RID: 48208 RVA: 0x002AA587 File Offset: 0x002A8787
	public int? Level { get; set; }

	// Token: 0x17000FB9 RID: 4025
	// (get) Token: 0x0600BC51 RID: 48209 RVA: 0x002AA590 File Offset: 0x002A8790
	// (set) Token: 0x0600BC52 RID: 48210 RVA: 0x002AA598 File Offset: 0x002A8798
	public bool? IsLevelInfinite { get; set; }

	// Token: 0x17000FBA RID: 4026
	// (get) Token: 0x0600BC53 RID: 48211 RVA: 0x002AA5A1 File Offset: 0x002A87A1
	// (set) Token: 0x0600BC54 RID: 48212 RVA: 0x002AA5A9 File Offset: 0x002A87A9
	public bool? IsLockVisible { get; set; }

	// Token: 0x17000FBB RID: 4027
	// (get) Token: 0x0600BC55 RID: 48213 RVA: 0x002AA5B2 File Offset: 0x002A87B2
	// (set) Token: 0x0600BC56 RID: 48214 RVA: 0x002AA5BA File Offset: 0x002A87BA
	public bool? IsLevelUseChangeColor { get; set; }

	// Token: 0x17000FBC RID: 4028
	// (get) Token: 0x0600BC57 RID: 48215 RVA: 0x002AA5C3 File Offset: 0x002A87C3
	// (set) Token: 0x0600BC58 RID: 48216 RVA: 0x002AA5CB File Offset: 0x002A87CB
	public bool? IsUseVision { get; set; }

	// Token: 0x17000FBD RID: 4029
	// (get) Token: 0x0600BC59 RID: 48217 RVA: 0x002AA5D4 File Offset: 0x002A87D4
	// (set) Token: 0x0600BC5A RID: 48218 RVA: 0x002AA5DC File Offset: 0x002A87DC
	public bool? IsDeprecate { get; set; }
}
