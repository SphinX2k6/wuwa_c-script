using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x0200694C RID: 26956
	[NullableContext(1)]
	public interface IDragGroupStat
	{
		// Token: 0x170097FE RID: 38910
		// (get) Token: 0x060432A9 RID: 275113
		// (set) Token: 0x060432AA RID: 275114
		int Total { get; set; }

		// Token: 0x170097FF RID: 38911
		// (get) Token: 0x060432AB RID: 275115
		// (set) Token: 0x060432AC RID: 275116
		int[] StateCounts { get; set; }

		// Token: 0x17009800 RID: 38912
		// (get) Token: 0x060432AD RID: 275117
		// (set) Token: 0x060432AE RID: 275118
		int ConditionOkCount { get; set; }

		// Token: 0x17009801 RID: 38913
		// (get) Token: 0x060432AF RID: 275119
		// (set) Token: 0x060432B0 RID: 275120
		bool HasActive { get; set; }
	}
}
