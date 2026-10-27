using System;

// Token: 0x02000EFD RID: 3837
public class SpeedModifier : ISpeedModifier
{
	// Token: 0x1700076C RID: 1900
	// (get) Token: 0x06006042 RID: 24642 RVA: 0x0012C9CA File Offset: 0x0012ABCA
	// (set) Token: 0x06006043 RID: 24643 RVA: 0x0012C9D2 File Offset: 0x0012ABD2
	public EModifierType Type { get; set; }

	// Token: 0x1700076D RID: 1901
	// (get) Token: 0x06006044 RID: 24644 RVA: 0x0012C9DB File Offset: 0x0012ABDB
	// (set) Token: 0x06006045 RID: 24645 RVA: 0x0012C9E3 File Offset: 0x0012ABE3
	public float Value { get; set; }

	// Token: 0x1700076E RID: 1902
	// (get) Token: 0x06006046 RID: 24646 RVA: 0x0012C9EC File Offset: 0x0012ABEC
	// (set) Token: 0x06006047 RID: 24647 RVA: 0x0012C9F4 File Offset: 0x0012ABF4
	public int Priority { get; set; }
}
