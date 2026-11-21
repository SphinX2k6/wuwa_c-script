using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F0 RID: 30704
	public static class ISetMotorSpeedTypeVerify
	{
		// Token: 0x06035F10 RID: 220944 RVA: 0x00739DCE File Offset: 0x00737FCE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
