using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B80 RID: 23424
	[NullableContext(2)]
	public interface ISceneItemSplineMoveRuntimeData
	{
		// Token: 0x17006DA5 RID: 28069
		// (get) Token: 0x06039995 RID: 235925
		// (set) Token: 0x06039996 RID: 235926
		float? DistanceAloneSpline { get; set; }

		// Token: 0x17006DA6 RID: 28070
		// (get) Token: 0x06039997 RID: 235927
		// (set) Token: 0x06039998 RID: 235928
		Vector CurPos { get; set; }

		// Token: 0x17006DA7 RID: 28071
		// (get) Token: 0x06039999 RID: 235929
		// (set) Token: 0x0603999A RID: 235930
		Rotator CurRot { get; set; }
	}
}
