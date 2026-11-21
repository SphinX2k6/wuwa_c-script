using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02005BF4 RID: 23540
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class RangeGatedBoxDesc : IRangeGatedBoxDesc, IBoxDesc
	{
		// Token: 0x17006E24 RID: 28196
		// (get) Token: 0x06039D00 RID: 236800 RVA: 0x0103C867 File Offset: 0x0103AA67
		// (set) Token: 0x06039D01 RID: 236801 RVA: 0x0103C86F File Offset: 0x0103AA6F
		[RequiredMember]
		public Vector LocationOffset { get; set; }

		// Token: 0x17006E25 RID: 28197
		// (get) Token: 0x06039D02 RID: 236802 RVA: 0x0103C878 File Offset: 0x0103AA78
		// (set) Token: 0x06039D03 RID: 236803 RVA: 0x0103C880 File Offset: 0x0103AA80
		[RequiredMember]
		public Vector HalfExtent { get; set; }

		// Token: 0x17006E26 RID: 28198
		// (get) Token: 0x06039D04 RID: 236804 RVA: 0x0103C889 File Offset: 0x0103AA89
		// (set) Token: 0x06039D05 RID: 236805 RVA: 0x0103C891 File Offset: 0x0103AA91
		[RequiredMember]
		public List<Vector> PointLocationOffsets { get; set; }

		// Token: 0x17006E27 RID: 28199
		// (get) Token: 0x06039D06 RID: 236806 RVA: 0x0103C89A File Offset: 0x0103AA9A
		// (set) Token: 0x06039D07 RID: 236807 RVA: 0x0103C8A2 File Offset: 0x0103AAA2
		public int? LandingSplineEntityId { get; set; }

		// Token: 0x06039D08 RID: 236808 RVA: 0x0103C8AB File Offset: 0x0103AAAB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public RangeGatedBoxDesc()
		{
		}
	}
}
