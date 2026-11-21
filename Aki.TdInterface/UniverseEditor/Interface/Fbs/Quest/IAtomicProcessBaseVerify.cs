using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004132 RID: 16690
	public static class IAtomicProcessBaseVerify
	{
		// Token: 0x06016E9E RID: 93854 RVA: 0x0034533A File Offset: 0x0034353A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
