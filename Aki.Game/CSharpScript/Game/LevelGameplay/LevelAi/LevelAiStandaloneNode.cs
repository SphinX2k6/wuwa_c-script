using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F37 RID: 24375
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiStandaloneNode : LevelAiNode
	{
		// Token: 0x0603A9F7 RID: 240119 RVA: 0x01091078 File Offset: 0x0108F278
		public virtual void MakePlanExpansions(PlanningContext context, LevelAiWorldState worldState)
		{
		}

		// Token: 0x0603A9F8 RID: 240120 RVA: 0x0109107A File Offset: 0x0108F27A
		public virtual void GetNextSteps(GetNextStepsContext context, LevelAiPlanStepId thisStepId)
		{
			context.SubmitPlanStep(thisStepId);
		}

		// Token: 0x0603A9F9 RID: 240121 RVA: 0x01091083 File Offset: 0x0108F283
		public virtual bool OnSubLevelStepFinished(LevelAiPlanInstance planInstance, LevelAiPlanStepId thisStepId, LevelAiPlanStepId finishedSubLevelStepId, ELevelAiNodeResult result, bool bFinishedLevel)
		{
			return true;
		}

		// Token: 0x0401ECE3 RID: 126179
		public bool PlanNextNodesAfterThis = true;

		// Token: 0x0401ECE4 RID: 126180
		public List<LevelAiStandaloneNode> NextNodes = new List<LevelAiStandaloneNode>();

		// Token: 0x0401ECE5 RID: 126181
		public List<LevelAiDecorator> Decorators = new List<LevelAiDecorator>();
	}
}
