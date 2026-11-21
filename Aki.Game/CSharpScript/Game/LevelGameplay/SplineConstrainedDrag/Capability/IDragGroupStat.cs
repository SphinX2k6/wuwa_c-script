using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x02005AA7 RID: 23207
	[NullableContext(1)]
	public interface IDragGroupStat
	{
		// Token: 0x17006CDE RID: 27870
		// (get) Token: 0x060392E0 RID: 234208
		// (set) Token: 0x060392E1 RID: 234209
		int Total { get; set; }

		// Token: 0x17006CDF RID: 27871
		// (get) Token: 0x060392E2 RID: 234210
		// (set) Token: 0x060392E3 RID: 234211
		int[] StateCounts { get; set; }

		// Token: 0x17006CE0 RID: 27872
		// (get) Token: 0x060392E4 RID: 234212
		// (set) Token: 0x060392E5 RID: 234213
		int ConditionOkCount { get; set; }

		// Token: 0x17006CE1 RID: 27873
		// (get) Token: 0x060392E6 RID: 234214
		// (set) Token: 0x060392E7 RID: 234215
		bool HasActive { get; set; }
	}
}
