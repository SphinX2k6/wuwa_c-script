using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C2 RID: 31170
	public enum IStopNewMoveWithSplineType_Union : byte
	{
		// Token: 0x04012CCD RID: 77005
		NONE,
		// Token: 0x04012CCE RID: 77006
		IStopNewMoveWithSplineType,
		// Token: 0x04012CCF RID: 77007
		IStopNewMoveWithSplineAtCurrentPos,
		// Token: 0x04012CD0 RID: 77008
		IStopNewMoveWithSplineAtStartPoint,
		// Token: 0x04012CD1 RID: 77009
		IStopNewMoveWithSplineAtEndPoint,
		// Token: 0x04012CD2 RID: 77010
		IStopNewMoveWithSplineAtTargetPoint
	}
}
