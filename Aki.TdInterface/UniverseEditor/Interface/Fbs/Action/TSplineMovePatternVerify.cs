using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A0 RID: 30624
	public static class TSplineMovePatternVerify
	{
		// Token: 0x06037955 RID: 227669 RVA: 0x00784FF8 File Offset: 0x007831F8
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
				result = IRacingTrackMoveVerify.Verify(verifier, tablePos);
				break;
			case 6:
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
