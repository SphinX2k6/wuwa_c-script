using System;
using Aki.Config;

// Token: 0x02001269 RID: 4713
public interface ITrialSubChallenge
{
	// Token: 0x1700128B RID: 4747
	// (get) Token: 0x0600BA8D RID: 47757
	// (set) Token: 0x0600BA8E RID: 47758
	BlackSwordGameplay Config { get; set; }

	// Token: 0x1700128C RID: 4748
	// (get) Token: 0x0600BA8F RID: 47759
	// (set) Token: 0x0600BA90 RID: 47760
	bool Unlocked { get; set; }

	// Token: 0x1700128D RID: 4749
	// (get) Token: 0x0600BA91 RID: 47761
	// (set) Token: 0x0600BA92 RID: 47762
	bool Completed { get; set; }
}
