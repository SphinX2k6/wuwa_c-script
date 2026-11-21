using System;
using Aki.Config;

// Token: 0x0200126A RID: 4714
public class TrialSubChallenge : ITrialSubChallenge
{
	// Token: 0x1700128E RID: 4750
	// (get) Token: 0x0600BA93 RID: 47763 RVA: 0x00370D51 File Offset: 0x0036EF51
	// (set) Token: 0x0600BA94 RID: 47764 RVA: 0x00370D59 File Offset: 0x0036EF59
	public BlackSwordGameplay Config { get; set; }

	// Token: 0x1700128F RID: 4751
	// (get) Token: 0x0600BA95 RID: 47765 RVA: 0x00370D62 File Offset: 0x0036EF62
	// (set) Token: 0x0600BA96 RID: 47766 RVA: 0x00370D6A File Offset: 0x0036EF6A
	public bool Unlocked { get; set; }

	// Token: 0x17001290 RID: 4752
	// (get) Token: 0x0600BA97 RID: 47767 RVA: 0x00370D73 File Offset: 0x0036EF73
	// (set) Token: 0x0600BA98 RID: 47768 RVA: 0x00370D7B File Offset: 0x0036EF7B
	public bool Completed { get; set; }
}
