using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200643E RID: 25662
	public static class ICloseSplineMovePattern_UnionVerify
	{
		// Token: 0x0602C6A9 RID: 181929 RVA: 0x00617FB8 File Offset: 0x006161B8
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
