using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E98 RID: 16024
	public enum IFishState_Union : byte
	{
		// Token: 0x0400B87C RID: 47228
		NONE,
		// Token: 0x0400B87D RID: 47229
		IFishState,
		// Token: 0x0400B87E RID: 47230
		IFishIdleState,
		// Token: 0x0400B87F RID: 47231
		IFishFollowState,
		// Token: 0x0400B880 RID: 47232
		IFishSplinePatrolState,
		// Token: 0x0400B881 RID: 47233
		IFishDestroyState
	}
}
