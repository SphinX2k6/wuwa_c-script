using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F48 RID: 28488
	[NullableContext(1)]
	public interface IBrokenRockRingConfig
	{
		// Token: 0x17009B3D RID: 39741
		// (get) Token: 0x060454C3 RID: 283843
		// (set) Token: 0x060454C4 RID: 283844
		int Id { get; set; }

		// Token: 0x17009B3E RID: 39742
		// (get) Token: 0x060454C5 RID: 283845
		// (set) Token: 0x060454C6 RID: 283846
		List<List<int>> InvalidBox { get; set; }

		// Token: 0x17009B3F RID: 39743
		// (get) Token: 0x060454C7 RID: 283847
		// (set) Token: 0x060454C8 RID: 283848
		int[] RandomBox { get; set; }

		// Token: 0x17009B40 RID: 39744
		// (get) Token: 0x060454C9 RID: 283849
		// (set) Token: 0x060454CA RID: 283850
		int PerfectBox { get; set; }

		// Token: 0x17009B41 RID: 39745
		// (get) Token: 0x060454CB RID: 283851
		// (set) Token: 0x060454CC RID: 283852
		Dictionary<int, int> BonusRate { get; set; }

		// Token: 0x17009B42 RID: 39746
		// (get) Token: 0x060454CD RID: 283853
		// (set) Token: 0x060454CE RID: 283854
		int GoodScore { get; set; }

		// Token: 0x17009B43 RID: 39747
		// (get) Token: 0x060454CF RID: 283855
		// (set) Token: 0x060454D0 RID: 283856
		int PerfectScore { get; set; }

		// Token: 0x17009B44 RID: 39748
		// (get) Token: 0x060454D1 RID: 283857
		// (set) Token: 0x060454D2 RID: 283858
		int BonusScore { get; set; }

		// Token: 0x17009B45 RID: 39749
		// (get) Token: 0x060454D3 RID: 283859
		// (set) Token: 0x060454D4 RID: 283860
		Dictionary<int, int> Speed { get; set; }

		// Token: 0x17009B46 RID: 39750
		// (get) Token: 0x060454D5 RID: 283861
		// (set) Token: 0x060454D6 RID: 283862
		int ColdTime { get; set; }

		// Token: 0x17009B47 RID: 39751
		// (get) Token: 0x060454D7 RID: 283863
		// (set) Token: 0x060454D8 RID: 283864
		int MultiBoxGroup { get; set; }

		// Token: 0x17009B48 RID: 39752
		// (get) Token: 0x060454D9 RID: 283865
		// (set) Token: 0x060454DA RID: 283866
		int[] Offset { get; set; }

		// Token: 0x17009B49 RID: 39753
		// (get) Token: 0x060454DB RID: 283867
		// (set) Token: 0x060454DC RID: 283868
		bool IsAnticlockwise { get; set; }
	}
}
