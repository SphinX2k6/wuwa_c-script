using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A23 RID: 27171
	[NullableContext(2)]
	public interface ISceneItemSplineMoveRuntimeData
	{
		// Token: 0x170098C0 RID: 39104
		// (get) Token: 0x06043947 RID: 276807
		// (set) Token: 0x06043948 RID: 276808
		float? DistanceAloneSpline { get; set; }

		// Token: 0x170098C1 RID: 39105
		// (get) Token: 0x06043949 RID: 276809
		// (set) Token: 0x0604394A RID: 276810
		Vector CurPos { get; set; }

		// Token: 0x170098C2 RID: 39106
		// (get) Token: 0x0604394B RID: 276811
		// (set) Token: 0x0604394C RID: 276812
		Rotator CurRot { get; set; }
	}
}
