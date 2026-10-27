using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AC RID: 30636
	public static class TStopNewMoveWithSplineTypeVerify
	{
		// Token: 0x0603798D RID: 227725 RVA: 0x00785534 File Offset: 0x00783734
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IStopNewMoveWithSplineAtCurrentPosVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IStopNewMoveWithSplineAtEndPointVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IStopNewMoveWithSplineAtStartPointVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IStopNewMoveWithSplineAtTargetPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
