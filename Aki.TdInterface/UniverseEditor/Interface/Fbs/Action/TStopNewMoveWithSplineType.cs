using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FE2 RID: 32738
	public enum TStopNewMoveWithSplineType : byte
	{
		// Token: 0x04013A3E RID: 80446
		NONE,
		// Token: 0x04013A3F RID: 80447
		IStopNewMoveWithSplineAtCurrentPos,
		// Token: 0x04013A40 RID: 80448
		IStopNewMoveWithSplineAtEndPoint,
		// Token: 0x04013A41 RID: 80449
		IStopNewMoveWithSplineAtStartPoint,
		// Token: 0x04013A42 RID: 80450
		IStopNewMoveWithSplineAtTargetPoint
	}
}
