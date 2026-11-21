using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042EE RID: 17134
	public static class IInformationViewTypeVerify
	{
		// Token: 0x060180F1 RID: 98545 RVA: 0x0036EC32 File Offset: 0x0036CE32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
