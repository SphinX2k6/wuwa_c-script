using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9D RID: 27549
	public enum INewSplineMoveTarget_Union : byte
	{
		// Token: 0x04011463 RID: 70755
		NONE,
		// Token: 0x04011464 RID: 70756
		INewSplineMoveTarget,
		// Token: 0x04011465 RID: 70757
		IPlayerNewSplineMoveTarget,
		// Token: 0x04011466 RID: 70758
		INpcNewSplineMoveTarget,
		// Token: 0x04011467 RID: 70759
		ISceneItemNewSplineMoveTarget,
		// Token: 0x04011468 RID: 70760
		IVehicleNewSplineMoveTarget
	}
}
