using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02006DB3 RID: 28083
	[NullableContext(1)]
	[Nullable(0)]
	public class ActiveTaskInfo
	{
		// Token: 0x170099B6 RID: 39350
		// (get) Token: 0x0604483F RID: 280639 RVA: 0x010E553F File Offset: 0x010E373F
		// (set) Token: 0x06044840 RID: 280640 RVA: 0x010E5547 File Offset: 0x010E3747
		public LevelAiPlanInstance PlanInstance { get; set; }

		// Token: 0x170099B7 RID: 39351
		// (get) Token: 0x06044841 RID: 280641 RVA: 0x010E5550 File Offset: 0x010E3750
		// (set) Token: 0x06044842 RID: 280642 RVA: 0x010E5558 File Offset: 0x010E3758
		public LevelAiPlanStepId PlanStepId { get; set; }
	}
}
