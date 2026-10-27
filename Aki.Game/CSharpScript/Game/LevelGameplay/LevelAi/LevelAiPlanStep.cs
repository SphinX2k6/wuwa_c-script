using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DAF RID: 28079
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanStep
	{
		// Token: 0x0604482C RID: 280620 RVA: 0x010E4EED File Offset: 0x010E30ED
		public LevelAiPlanStep(LevelAiStandaloneNode node, LevelAiWorldState worldState, int cost = 0, int subLevelIndex = -1)
		{
			this.Node = node;
			this.WorldState = worldState;
			this.SubNodesInfo = new SubNodesInfo();
			this.SubLevelIndex = subLevelIndex;
			this.Cost = Math.Max(0, cost);
		}

		// Token: 0x04023A13 RID: 145939
		public LevelAiStandaloneNode Node;

		// Token: 0x04023A14 RID: 145940
		public SubNodesInfo SubNodesInfo;

		// Token: 0x04023A15 RID: 145941
		public int SubLevelIndex;

		// Token: 0x04023A16 RID: 145942
		public LevelAiWorldState WorldState;

		// Token: 0x04023A17 RID: 145943
		public int Cost;
	}
}
