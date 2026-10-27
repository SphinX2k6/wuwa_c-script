using System;

// Token: 0x02001950 RID: 6480
public class SelectedData : ISelectedData
{
	// Token: 0x17000FC8 RID: 4040
	// (get) Token: 0x0600BD33 RID: 48435 RVA: 0x002ACABA File Offset: 0x002AACBA
	// (set) Token: 0x0600BD34 RID: 48436 RVA: 0x002ACAC2 File Offset: 0x002AACC2
	public int ItemId { get; set; }

	// Token: 0x17000FC9 RID: 4041
	// (get) Token: 0x0600BD35 RID: 48437 RVA: 0x002ACACB File Offset: 0x002AACCB
	// (set) Token: 0x0600BD36 RID: 48438 RVA: 0x002ACAD3 File Offset: 0x002AACD3
	public int IncId { get; set; }

	// Token: 0x17000FCA RID: 4042
	// (get) Token: 0x0600BD37 RID: 48439 RVA: 0x002ACADC File Offset: 0x002AACDC
	// (set) Token: 0x0600BD38 RID: 48440 RVA: 0x002ACAE4 File Offset: 0x002AACE4
	public int Count { get; set; }

	// Token: 0x17000FCB RID: 4043
	// (get) Token: 0x0600BD39 RID: 48441 RVA: 0x002ACAED File Offset: 0x002AACED
	// (set) Token: 0x0600BD3A RID: 48442 RVA: 0x002ACAF5 File Offset: 0x002AACF5
	public int SelectedCount { get; set; }

	// Token: 0x17000FCC RID: 4044
	// (get) Token: 0x0600BD3B RID: 48443 RVA: 0x002ACAFE File Offset: 0x002AACFE
	// (set) Token: 0x0600BD3C RID: 48444 RVA: 0x002ACB06 File Offset: 0x002AAD06
	public bool? OnlyTextFlag { get; set; }
}
