using System;

// Token: 0x02001B88 RID: 7048
public class ProgressItem : IProgressItem
{
	// Token: 0x17001160 RID: 4448
	// (get) Token: 0x0600D1CD RID: 53709 RVA: 0x00301EDD File Offset: 0x003000DD
	// (set) Token: 0x0600D1CE RID: 53710 RVA: 0x00301EE5 File Offset: 0x003000E5
	public int DayIndex { get; set; }

	// Token: 0x17001161 RID: 4449
	// (get) Token: 0x0600D1CF RID: 53711 RVA: 0x00301EEE File Offset: 0x003000EE
	// (set) Token: 0x0600D1D0 RID: 53712 RVA: 0x00301EF6 File Offset: 0x003000F6
	public bool IsPassed { get; set; }
}
