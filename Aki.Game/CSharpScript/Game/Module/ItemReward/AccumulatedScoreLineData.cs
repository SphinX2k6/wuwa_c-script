using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047AF RID: 18351
	[NullableContext(1)]
	[Nullable(0)]
	public class AccumulatedScoreLineData : IAccumulatedScoreLineData
	{
		// Token: 0x17005DA8 RID: 23976
		// (get) Token: 0x0602E1E0 RID: 188896 RVA: 0x00CDF12E File Offset: 0x00CDD32E
		// (set) Token: 0x0602E1E1 RID: 188897 RVA: 0x00CDF136 File Offset: 0x00CDD336
		public string DescTextId { get; set; }

		// Token: 0x17005DA9 RID: 23977
		// (get) Token: 0x0602E1E2 RID: 188898 RVA: 0x00CDF13F File Offset: 0x00CDD33F
		// (set) Token: 0x0602E1E3 RID: 188899 RVA: 0x00CDF147 File Offset: 0x00CDD347
		public string ScoreText { get; set; }
	}
}
