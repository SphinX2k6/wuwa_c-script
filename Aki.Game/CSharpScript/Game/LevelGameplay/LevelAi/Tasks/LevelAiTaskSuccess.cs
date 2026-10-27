using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DC6 RID: 28102
	public class LevelAiTaskSuccess : LevelAiTask
	{
		// Token: 0x060448E7 RID: 280807 RVA: 0x010E8727 File Offset: 0x010E6927
		[NullableContext(1)]
		protected override void CreatePlanSteps(PlanningContext context, LevelAiWorldState worldStateAfterTask)
		{
			context.SubmitCandidatePlanStep(this, worldStateAfterTask, this.Cost);
		}

		// Token: 0x04023A6E RID: 146030
		public int Cost;
	}
}
