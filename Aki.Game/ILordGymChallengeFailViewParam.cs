using System;

// Token: 0x0200167C RID: 5756
public interface ILordGymChallengeFailViewParam
{
	// Token: 0x1700156E RID: 5486
	// (get) Token: 0x0600E011 RID: 57361
	// (set) Token: 0x0600E012 RID: 57362
	int LordId { get; set; }

	// Token: 0x1700156F RID: 5487
	// (get) Token: 0x0600E013 RID: 57363
	// (set) Token: 0x0600E014 RID: 57364
	ELordGymVersion Version { get; set; }

	// Token: 0x17001570 RID: 5488
	// (get) Token: 0x0600E015 RID: 57365
	// (set) Token: 0x0600E016 RID: 57366
	bool IsFromGuide { get; set; }
}
