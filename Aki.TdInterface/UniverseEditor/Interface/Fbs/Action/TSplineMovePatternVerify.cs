using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FD8 RID: 32728
	public static class TSplineMovePatternVerify
	{
		// Token: 0x0603AED2 RID: 241362 RVA: 0x007EA528 File Offset: 0x007E8728
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAirPassageMoveVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechaAirPassageMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMotorcycleTrackVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPathLineMoveVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPetalGrabMoveVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRacingTrackMoveVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = ISlideTrackMoveVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
