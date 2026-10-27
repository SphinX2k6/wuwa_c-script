using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007688 RID: 30344
	public static class TCloseSplineMovePatternVerify
	{
		// Token: 0x0603735D RID: 226141 RVA: 0x0077B94C File Offset: 0x00779B4C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICloseAirPassageMoveVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICloseMotorcycleTrackMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClosePathLineMoveVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICloseRacingTrackMoveVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
