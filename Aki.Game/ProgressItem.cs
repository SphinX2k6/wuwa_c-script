using System;

// Token: 0x02001047 RID: 4167
public class ProgressItem : IProgressItem
{
	// Token: 0x17001185 RID: 4485
	// (get) Token: 0x0600A5DE RID: 42462 RVA: 0x0030CFB5 File Offset: 0x0030B1B5
	// (set) Token: 0x0600A5DF RID: 42463 RVA: 0x0030CFBD File Offset: 0x0030B1BD
	public int DayIndex { get; set; }

	// Token: 0x17001186 RID: 4486
	// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x0030CFC6 File Offset: 0x0030B1C6
	// (set) Token: 0x0600A5E1 RID: 42465 RVA: 0x0030CFCE File Offset: 0x0030B1CE
	public bool IsPassed { get; set; }
}
