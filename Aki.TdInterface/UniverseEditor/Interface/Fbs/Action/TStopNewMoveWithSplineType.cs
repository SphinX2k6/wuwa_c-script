using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AA RID: 30634
	public enum TStopNewMoveWithSplineType : byte
	{
		// Token: 0x04012986 RID: 76166
		NONE,
		// Token: 0x04012987 RID: 76167
		IStopNewMoveWithSplineAtCurrentPos,
		// Token: 0x04012988 RID: 76168
		IStopNewMoveWithSplineAtEndPoint,
		// Token: 0x04012989 RID: 76169
		IStopNewMoveWithSplineAtStartPoint,
		// Token: 0x0401298A RID: 76170
		IStopNewMoveWithSplineAtTargetPoint
	}
}
