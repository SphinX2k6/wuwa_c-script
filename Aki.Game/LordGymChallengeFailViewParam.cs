using System;

// Token: 0x02002199 RID: 8601
public class LordGymChallengeFailViewParam : ILordGymChallengeFailViewParam
{
	// Token: 0x1700153A RID: 5434
	// (get) Token: 0x06010B86 RID: 68486 RVA: 0x0040FC44 File Offset: 0x0040DE44
	// (set) Token: 0x06010B87 RID: 68487 RVA: 0x0040FC4C File Offset: 0x0040DE4C
	public int LordId { get; set; }

	// Token: 0x1700153B RID: 5435
	// (get) Token: 0x06010B88 RID: 68488 RVA: 0x0040FC55 File Offset: 0x0040DE55
	// (set) Token: 0x06010B89 RID: 68489 RVA: 0x0040FC5D File Offset: 0x0040DE5D
	public ELordGymVersion Version { get; set; }

	// Token: 0x1700153C RID: 5436
	// (get) Token: 0x06010B8A RID: 68490 RVA: 0x0040FC66 File Offset: 0x0040DE66
	// (set) Token: 0x06010B8B RID: 68491 RVA: 0x0040FC6E File Offset: 0x0040DE6E
	public bool IsFromGuide { get; set; }
}
