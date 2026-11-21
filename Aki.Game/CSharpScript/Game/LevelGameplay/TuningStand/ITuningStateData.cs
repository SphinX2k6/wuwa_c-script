using System;

namespace CSharpScript.Game.LevelGamePlay.TuningStand
{
	// Token: 0x02005B1F RID: 23327
	public interface ITuningStateData
	{
		// Token: 0x17006D45 RID: 27973
		// (get) Token: 0x06039621 RID: 235041
		// (set) Token: 0x06039622 RID: 235042
		EGridBelongType State { get; set; }

		// Token: 0x17006D46 RID: 27974
		// (get) Token: 0x06039623 RID: 235043
		// (set) Token: 0x06039624 RID: 235044
		int? Prev { get; set; }

		// Token: 0x17006D47 RID: 27975
		// (get) Token: 0x06039625 RID: 235045
		// (set) Token: 0x06039626 RID: 235046
		int? Next { get; set; }
	}
}
