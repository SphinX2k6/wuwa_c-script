using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FE4 RID: 32740
	public static class TStopNewMoveWithSplineTypeVerify
	{
		// Token: 0x0603AF0E RID: 241422 RVA: 0x007EAB04 File Offset: 0x007E8D04
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
