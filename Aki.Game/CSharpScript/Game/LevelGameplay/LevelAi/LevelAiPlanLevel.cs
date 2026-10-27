using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB0 RID: 28080
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiPlanLevel
	{
		// Token: 0x0604482D RID: 280621 RVA: 0x010E4F24 File Offset: 0x010E3124
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

		// Token: 0x0604482E RID: 280622 RVA: 0x010E4F8C File Offset: 0x010E318C
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

		// Token: 0x04023A18 RID: 145944
		public List<LevelAiPlanStep> Steps = new List<LevelAiPlanStep>();

		// Token: 0x04023A19 RID: 145945
		public SubNodesInfo RootSubNodesInfo;

		// Token: 0x04023A1A RID: 145946
		public LevelAiPlanStepId ParentStepId;

		// Token: 0x04023A1B RID: 145947
		public LevelAiWorldState WorldStateAtLevelStart;

		// Token: 0x04023A1C RID: 145948
		public int Cost;
	}
}
