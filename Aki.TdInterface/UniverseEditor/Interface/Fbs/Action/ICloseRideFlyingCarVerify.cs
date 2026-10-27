using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200642C RID: 25644
	public static class ICloseRideFlyingCarVerify
	{
		// Token: 0x0602C60C RID: 181772 RVA: 0x00616BAA File Offset: 0x00614DAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
