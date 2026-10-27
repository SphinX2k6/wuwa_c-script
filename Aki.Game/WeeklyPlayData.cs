using System;
using Aki.Protocol;

// Token: 0x02002D2E RID: 11566
public class WeeklyPlayData
{
	// Token: 0x170020C6 RID: 8390
	// (get) Token: 0x060184FE RID: 99582 RVA: 0x006304CE File Offset: 0x0062E6CE
	// (set) Token: 0x060184FF RID: 99583 RVA: 0x006304D6 File Offset: 0x0062E6D6
	public int PlayId { get; set; }

	// Token: 0x170020C7 RID: 8391
	// (get) Token: 0x06018500 RID: 99584 RVA: 0x006304DF File Offset: 0x0062E6DF
	// (set) Token: 0x06018501 RID: 99585 RVA: 0x006304E7 File Offset: 0x0062E6E7
	public ActivityType Type { get; set; }

	// Token: 0x170020C8 RID: 8392
	// (get) Token: 0x06018502 RID: 99586 RVA: 0x006304F0 File Offset: 0x0062E6F0
	// (set) Token: 0x06018503 RID: 99587 RVA: 0x006304F8 File Offset: 0x0062E6F8
	public bool HasRecord { get; set; }
}
