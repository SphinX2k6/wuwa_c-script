using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A0 RID: 17056
	public static class IFlipperConditionStepFightVerify
	{
		// Token: 0x06017DF0 RID: 97776 RVA: 0x00368CAE File Offset: 0x00366EAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
