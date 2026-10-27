using System;
using Aki.Config;

// Token: 0x02001DA8 RID: 7592
public class TrialSubChallenge : ITrialSubChallenge
{
	// Token: 0x17001264 RID: 4708
	// (get) Token: 0x0600E675 RID: 58997 RVA: 0x003650F1 File Offset: 0x003632F1
	// (set) Token: 0x0600E676 RID: 58998 RVA: 0x003650F9 File Offset: 0x003632F9
	public BlackSwordGameplay Config { get; set; }

	// Token: 0x17001265 RID: 4709
	// (get) Token: 0x0600E677 RID: 58999 RVA: 0x00365102 File Offset: 0x00363302
	// (set) Token: 0x0600E678 RID: 59000 RVA: 0x0036510A File Offset: 0x0036330A
	public bool Unlocked { get; set; }

	// Token: 0x17001266 RID: 4710
	// (get) Token: 0x0600E679 RID: 59001 RVA: 0x00365113 File Offset: 0x00363313
	// (set) Token: 0x0600E67A RID: 59002 RVA: 0x0036511B File Offset: 0x0036331B
	public bool Completed { get; set; }
}
