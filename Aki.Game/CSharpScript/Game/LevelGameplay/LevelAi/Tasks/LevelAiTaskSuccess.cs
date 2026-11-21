using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F45 RID: 24389
	public class LevelAiTaskSuccess : LevelAiTask
	{
		// Token: 0x0603AA4B RID: 240203 RVA: 0x01092977 File Offset: 0x01090B77
		[NullableContext(1)]
		protected override void CreatePlanSteps(PlanningContext context, LevelAiWorldState worldStateAfterTask)
		{
			context.SubmitCandidatePlanStep(this, worldStateAfterTask, this.Cost);
		}

		// Token: 0x0401ED10 RID: 126224
		public int Cost;
	}
}
