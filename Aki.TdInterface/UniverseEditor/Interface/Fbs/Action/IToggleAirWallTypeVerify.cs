using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F0 RID: 29680
	public static class IToggleAirWallTypeVerify
	{
		// Token: 0x06035EA6 RID: 220838 RVA: 0x0075661A File Offset: 0x0075481A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
