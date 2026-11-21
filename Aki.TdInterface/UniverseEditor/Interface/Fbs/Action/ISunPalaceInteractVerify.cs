using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A15 RID: 31253
	public static class ISunPalaceInteractVerify
	{
		// Token: 0x06037105 RID: 225541 RVA: 0x0075BD26 File Offset: 0x00759F26
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
