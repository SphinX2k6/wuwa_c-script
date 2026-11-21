using System;

// Token: 0x0200167D RID: 5757
public class LordGymChallengeFailViewParam : ILordGymChallengeFailViewParam
{
	// Token: 0x17001571 RID: 5489
	// (get) Token: 0x0600E017 RID: 57367 RVA: 0x0041C52C File Offset: 0x0041A72C
	// (set) Token: 0x0600E018 RID: 57368 RVA: 0x0041C534 File Offset: 0x0041A734
	public int LordId { get; set; }

	// Token: 0x17001572 RID: 5490
	// (get) Token: 0x0600E019 RID: 57369 RVA: 0x0041C53D File Offset: 0x0041A73D
	// (set) Token: 0x0600E01A RID: 57370 RVA: 0x0041C545 File Offset: 0x0041A745
	public ELordGymVersion Version { get; set; }

	// Token: 0x17001573 RID: 5491
	// (get) Token: 0x0600E01B RID: 57371 RVA: 0x0041C54E File Offset: 0x0041A74E
	// (set) Token: 0x0600E01C RID: 57372 RVA: 0x0041C556 File Offset: 0x0041A756
	public bool IsFromGuide { get; set; }
}
