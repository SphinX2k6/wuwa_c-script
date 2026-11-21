using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E96 RID: 32406
	public static class TCloseSplineMovePatternVerify
	{
		// Token: 0x0603A804 RID: 239620 RVA: 0x007DFA94 File Offset: 0x007DDC94
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
