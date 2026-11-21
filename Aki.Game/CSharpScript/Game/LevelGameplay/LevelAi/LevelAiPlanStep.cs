using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F2E RID: 24366
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanStep
	{
		// Token: 0x0603A990 RID: 240016 RVA: 0x0108F115 File Offset: 0x0108D315
		public LevelAiPlanStep(LevelAiStandaloneNode node, LevelAiWorldState worldState, int cost = 0, int subLevelIndex = -1)
		{
			this.Node = node;
			this.WorldState = worldState;
			this.SubNodesInfo = new SubNodesInfo();
			this.SubLevelIndex = subLevelIndex;
			this.Cost = Math.Max(0, cost);
		}

		// Token: 0x0401ECB5 RID: 126133
		public LevelAiStandaloneNode Node;

		// Token: 0x0401ECB6 RID: 126134
		public SubNodesInfo SubNodesInfo;

		// Token: 0x0401ECB7 RID: 126135
		public int SubLevelIndex;

		// Token: 0x0401ECB8 RID: 126136
		public LevelAiWorldState WorldState;

		// Token: 0x0401ECB9 RID: 126137
		public int Cost;
	}
}
