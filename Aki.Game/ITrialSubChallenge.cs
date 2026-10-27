using System;
using Aki.Config;

// Token: 0x02001DA7 RID: 7591
public interface ITrialSubChallenge
{
	// Token: 0x17001261 RID: 4705
	// (get) Token: 0x0600E66F RID: 58991
	// (set) Token: 0x0600E670 RID: 58992
	BlackSwordGameplay Config { get; set; }

	// Token: 0x17001262 RID: 4706
	// (get) Token: 0x0600E671 RID: 58993
	// (set) Token: 0x0600E672 RID: 58994
	bool Unlocked { get; set; }

	// Token: 0x17001263 RID: 4707
	// (get) Token: 0x0600E673 RID: 58995
	// (set) Token: 0x0600E674 RID: 58996
	bool Completed { get; set; }
}
