using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071ED RID: 29165
	public enum IStopNewMoveWithSplineType_Union : byte
	{
		// Token: 0x04011CCB RID: 72907
		NONE,
		// Token: 0x04011CCC RID: 72908
		IStopNewMoveWithSplineType,
		// Token: 0x04011CCD RID: 72909
		IStopNewMoveWithSplineAtCurrentPos,
		// Token: 0x04011CCE RID: 72910
		IStopNewMoveWithSplineAtStartPoint,
		// Token: 0x04011CCF RID: 72911
		IStopNewMoveWithSplineAtEndPoint,
		// Token: 0x04011CD0 RID: 72912
		IStopNewMoveWithSplineAtTargetPoint
	}
}
