using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007964 RID: 31076
	public static class ISplineMovePattern_UnionVerify
	{
		// Token: 0x06036BB1 RID: 224177 RVA: 0x00752710 File Offset: 0x00750910
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISplineMovePatternVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPathLineMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRacingTrackMoveVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISlideTrackMoveVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IAirPassageMoveVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IMechaAirPassageMoveVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IPetalGrabMoveVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IMotorcycleTrackVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
