using System;

// Token: 0x02000F40 RID: 3904
public class DrinksRequireInfo : IDrinksRequireInfo
{
	// Token: 0x170007A3 RID: 1955
	// (get) Token: 0x06006394 RID: 25492 RVA: 0x00139A70 File Offset: 0x00137C70
	// (set) Token: 0x06006395 RID: 25493 RVA: 0x00139A78 File Offset: 0x00137C78
	public int RequireId { get; set; }

	// Token: 0x170007A4 RID: 1956
	// (get) Token: 0x06006396 RID: 25494 RVA: 0x00139A81 File Offset: 0x00137C81
	// (set) Token: 0x06006397 RID: 25495 RVA: 0x00139A89 File Offset: 0x00137C89
	public EDrinksRequireType Type { get; set; }

	// Token: 0x170007A5 RID: 1957
	// (get) Token: 0x06006398 RID: 25496 RVA: 0x00139A92 File Offset: 0x00137C92
	// (set) Token: 0x06006399 RID: 25497 RVA: 0x00139A9A File Offset: 0x00137C9A
	public int? FlavorRangeId { get; set; }

	// Token: 0x170007A6 RID: 1958
	// (get) Token: 0x0600639A RID: 25498 RVA: 0x00139AA3 File Offset: 0x00137CA3
	// (set) Token: 0x0600639B RID: 25499 RVA: 0x00139AAB File Offset: 0x00137CAB
	public bool Completed { get; set; }
}
