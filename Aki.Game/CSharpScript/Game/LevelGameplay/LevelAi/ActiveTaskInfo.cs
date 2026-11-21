using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelAi
{
	// Token: 0x02005F32 RID: 24370
	[NullableContext(1)]
	[Nullable(0)]
	public class ActiveTaskInfo
	{
		// Token: 0x17006EB9 RID: 28345
		// (get) Token: 0x0603A9A3 RID: 240035 RVA: 0x0108F767 File Offset: 0x0108D967
		// (set) Token: 0x0603A9A4 RID: 240036 RVA: 0x0108F76F File Offset: 0x0108D96F
		public LevelAiPlanInstance PlanInstance { get; set; }

		// Token: 0x17006EBA RID: 28346
		// (get) Token: 0x0603A9A5 RID: 240037 RVA: 0x0108F778 File Offset: 0x0108D978
		// (set) Token: 0x0603A9A6 RID: 240038 RVA: 0x0108F780 File Offset: 0x0108D980
		public LevelAiPlanStepId PlanStepId { get; set; }
	}
}
