using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC6 RID: 28358
	public interface IDollCollectData
	{
		// Token: 0x17009AB8 RID: 39608
		// (get) Token: 0x060450D3 RID: 282835
		// (set) Token: 0x060450D4 RID: 282836
		int CurrentCollectCount { get; set; }

		// Token: 0x17009AB9 RID: 39609
		// (get) Token: 0x060450D5 RID: 282837
		// (set) Token: 0x060450D6 RID: 282838
		int TotalCollectCount { get; set; }

		// Token: 0x17009ABA RID: 39610
		// (get) Token: 0x060450D7 RID: 282839
		// (set) Token: 0x060450D8 RID: 282840
		int CurrentCollectItemCount { get; set; }

		// Token: 0x17009ABB RID: 39611
		// (get) Token: 0x060450D9 RID: 282841
		// (set) Token: 0x060450DA RID: 282842
		int TotalCollectItemCount { get; set; }
	}
}
