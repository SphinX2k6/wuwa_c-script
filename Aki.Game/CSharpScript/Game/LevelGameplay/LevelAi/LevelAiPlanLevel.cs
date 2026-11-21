using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F2F RID: 24367
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanLevel
	{
		// Token: 0x0603A991 RID: 240017 RVA: 0x0108F14C File Offset: 0x0108D34C
		public LevelAiPlanLevel(LevelAiWorldState worldStateAtLevelStart, [Nullable(2)] LevelAiPlanStepId parentStepId = null)
		{
			this.WorldStateAtLevelStart = worldStateAtLevelStart;
			this.RootSubNodesInfo = new SubNodesInfo();
			this.ParentStepId = new LevelAiPlanStepId(-1, -1);
			if (parentStepId != null)
			{
				this.ParentStepId.CopyFrom(parentStepId);
			}
			else
			{
				this.ParentStepId.CopyFrom(LevelAiPlanStepId.None);
			}
			this.Cost = 0;
		}

		// Token: 0x0603A992 RID: 240018 RVA: 0x0108F1B4 File Offset: 0x0108D3B4
		public LevelAiPlanLevel MakeCopy()
		{
			LevelAiPlanLevel levelAiPlanLevel = new LevelAiPlanLevel(this.WorldStateAtLevelStart, this.ParentStepId);
			levelAiPlanLevel.Steps.Capacity = this.Steps.Count;
			for (int i = 0; i < this.Steps.Count; i++)
			{
				levelAiPlanLevel.Steps.Add(this.Steps[i]);
			}
			levelAiPlanLevel.Cost = this.Cost;
			return levelAiPlanLevel;
		}

		// Token: 0x0401ECBA RID: 126138
		public List<LevelAiPlanStep> Steps = new List<LevelAiPlanStep>();

		// Token: 0x0401ECBB RID: 126139
		public SubNodesInfo RootSubNodesInfo;

		// Token: 0x0401ECBC RID: 126140
		public LevelAiPlanStepId ParentStepId;

		// Token: 0x0401ECBD RID: 126141
		public LevelAiWorldState WorldStateAtLevelStart;

		// Token: 0x0401ECBE RID: 126142
		public int Cost;
	}
}
