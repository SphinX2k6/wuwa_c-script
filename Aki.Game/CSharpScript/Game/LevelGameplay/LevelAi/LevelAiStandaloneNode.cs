using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB8 RID: 28088
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiStandaloneNode : LevelAiNode
	{
		// Token: 0x06044893 RID: 280723 RVA: 0x010E6E50 File Offset: 0x010E5050
		public virtual void MakePlanExpansions(PlanningContext context, LevelAiWorldState worldState)
		{
		}

		// Token: 0x06044894 RID: 280724 RVA: 0x010E6E52 File Offset: 0x010E5052
		public virtual void GetNextSteps(GetNextStepsContext context, LevelAiPlanStepId thisStepId)
		{
			context.SubmitPlanStep(thisStepId);
		}

		// Token: 0x06044895 RID: 280725 RVA: 0x010E6E5B File Offset: 0x010E505B
		public virtual bool OnSubLevelStepFinished(LevelAiPlanInstance planInstance, LevelAiPlanStepId thisStepId, LevelAiPlanStepId finishedSubLevelStepId, ELevelAiNodeResult result, bool bFinishedLevel)
		{
			return true;
		}

		// Token: 0x04023A41 RID: 145985
		public bool PlanNextNodesAfterThis = true;

		// Token: 0x04023A42 RID: 145986
		public List<LevelAiStandaloneNode> NextNodes = new List<LevelAiStandaloneNode>();

		// Token: 0x04023A43 RID: 145987
		public List<LevelAiDecorator> Decorators = new List<LevelAiDecorator>();
	}
}
