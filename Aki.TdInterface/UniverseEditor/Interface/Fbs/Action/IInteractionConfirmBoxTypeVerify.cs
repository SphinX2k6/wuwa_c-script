using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698C RID: 27020
	public static class IInteractionConfirmBoxTypeVerify
	{
		// Token: 0x0602F307 RID: 193287 RVA: 0x0066D76A File Offset: 0x0066B96A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
