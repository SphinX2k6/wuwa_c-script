using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.Capability
{
	// Token: 0x02005AA8 RID: 23208
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class DragGroupStat : IDragGroupStat
	{
		// Token: 0x17006CE2 RID: 27874
		// (get) Token: 0x060392E8 RID: 234216 RVA: 0x010044DA File Offset: 0x010026DA
		// (set) Token: 0x060392E9 RID: 234217 RVA: 0x010044E2 File Offset: 0x010026E2
		public int Total { get; set; }

		// Token: 0x17006CE3 RID: 27875
		// (get) Token: 0x060392EA RID: 234218 RVA: 0x010044EB File Offset: 0x010026EB
		// (set) Token: 0x060392EB RID: 234219 RVA: 0x010044F3 File Offset: 0x010026F3
		[RequiredMember]
		public int[] StateCounts { get; set; }

		// Token: 0x17006CE4 RID: 27876
		// (get) Token: 0x060392EC RID: 234220 RVA: 0x010044FC File Offset: 0x010026FC
		// (set) Token: 0x060392ED RID: 234221 RVA: 0x01004504 File Offset: 0x01002704
		public int ConditionOkCount { get; set; }

		// Token: 0x17006CE5 RID: 27877
		// (get) Token: 0x060392EE RID: 234222 RVA: 0x0100450D File Offset: 0x0100270D
		// (set) Token: 0x060392EF RID: 234223 RVA: 0x01004515 File Offset: 0x01002715
		public bool HasActive { get; set; }

		// Token: 0x060392F0 RID: 234224 RVA: 0x0100451E File Offset: 0x0100271E
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DragGroupStat()
		{
		}
	}
}
