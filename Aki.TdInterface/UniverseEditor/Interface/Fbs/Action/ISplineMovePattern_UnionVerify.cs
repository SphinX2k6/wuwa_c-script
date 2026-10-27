using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718F RID: 29071
	public static class ISplineMovePattern_UnionVerify
	{
		// Token: 0x060338B7 RID: 211127 RVA: 0x006F14D4 File Offset: 0x006EF6D4
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
