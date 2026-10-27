using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200768B RID: 30347
	public static class TCloseUiGameVerify
	{
		// Token: 0x0603736B RID: 226155 RVA: 0x0077BAB4 File Offset: 0x00779CB4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICloseBrokenRockVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICloseDragActorVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
