using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract;

namespace CSharpScript.Game.LevelGamePlay.SceneInteractExplorePlaced
{
	// Token: 0x02006A96 RID: 27286
	[NullableContext(1)]
	public interface IRangeGatedBoxDesc : IBoxDesc
	{
		// Token: 0x1700993D RID: 39229
		// (get) Token: 0x06043CAE RID: 277678
		// (set) Token: 0x06043CAF RID: 277679
		List<Vector> PointLocationOffsets { get; set; }

		// Token: 0x1700993E RID: 39230
		// (get) Token: 0x06043CB0 RID: 277680
		// (set) Token: 0x06043CB1 RID: 277681
		int? LandingSplineEntityId { get; set; }
	}
}
