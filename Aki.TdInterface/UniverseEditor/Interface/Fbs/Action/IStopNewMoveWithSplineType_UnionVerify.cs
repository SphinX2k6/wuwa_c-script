using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C4 RID: 31172
	public static class IStopNewMoveWithSplineType_UnionVerify
	{
		// Token: 0x06036EBF RID: 224959 RVA: 0x007581A4 File Offset: 0x007563A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IStopNewMoveWithSplineTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IStopNewMoveWithSplineAtCurrentPosVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IStopNewMoveWithSplineAtStartPointVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IStopNewMoveWithSplineAtEndPointVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
