using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E3 RID: 29411
	public enum INewSplineMoveTarget_Union : byte
	{
		// Token: 0x0401238D RID: 74637
		NONE,
		// Token: 0x0401238E RID: 74638
		INewSplineMoveTarget,
		// Token: 0x0401238F RID: 74639
		IPlayerNewSplineMoveTarget,
		// Token: 0x04012390 RID: 74640
		INpcNewSplineMoveTarget,
		// Token: 0x04012391 RID: 74641
		ISceneItemNewSplineMoveTarget,
		// Token: 0x04012392 RID: 74642
		IVehicleNewSplineMoveTarget
	}
}
