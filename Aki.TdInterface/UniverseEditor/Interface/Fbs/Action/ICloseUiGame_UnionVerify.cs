using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006447 RID: 25671
	public static class ICloseUiGame_UnionVerify
	{
		// Token: 0x0602C6E1 RID: 181985 RVA: 0x006184D8 File Offset: 0x006166D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICloseUiGameVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICloseDragActorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICloseBrokenRockVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICloseRideFlyingCarVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
