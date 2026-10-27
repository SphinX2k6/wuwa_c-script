using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005236 RID: 21046
	public static class IFanInteractByHitVerify
	{
		// Token: 0x060223B6 RID: 140214 RVA: 0x004BFA06 File Offset: 0x004BDC06
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
