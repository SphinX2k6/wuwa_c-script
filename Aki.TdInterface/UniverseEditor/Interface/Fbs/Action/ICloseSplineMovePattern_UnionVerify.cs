using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB2 RID: 27314
	public static class ICloseSplineMovePattern_UnionVerify
	{
		// Token: 0x0602EE2E RID: 192046 RVA: 0x006635FC File Offset: 0x006617FC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICloseSplineMovePatternVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICloseAirPassageMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICloseMotorcycleTrackMoveVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IClosePathLineMoveVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICloseRacingTrackMoveVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICloseSlideTrackMoveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
