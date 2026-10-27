using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC4 RID: 28356
	public interface IDollGrabInfiniteShowCaseRewardData
	{
		// Token: 0x17009AB2 RID: 39602
		// (get) Token: 0x060450C6 RID: 282822
		// (set) Token: 0x060450C7 RID: 282823
		int DropId { get; set; }

		// Token: 0x17009AB3 RID: 39603
		// (get) Token: 0x060450C8 RID: 282824
		// (set) Token: 0x060450C9 RID: 282825
		int GetRewardIndex { get; set; }

		// Token: 0x17009AB4 RID: 39604
		// (get) Token: 0x060450CA RID: 282826
		// (set) Token: 0x060450CB RID: 282827
		int NextRewardIndex { get; set; }
	}
}
