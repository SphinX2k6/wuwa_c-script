using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02005BF3 RID: 23539
	[NullableContext(1)]
	public interface IRangeGatedBoxDesc : IBoxDesc
	{
		// Token: 0x17006E22 RID: 28194
		// (get) Token: 0x06039CFC RID: 236796
		// (set) Token: 0x06039CFD RID: 236797
		List<Vector> PointLocationOffsets { get; set; }

		// Token: 0x17006E23 RID: 28195
		// (get) Token: 0x06039CFE RID: 236798
		// (set) Token: 0x06039CFF RID: 236799
		int? LandingSplineEntityId { get; set; }
	}
}
