using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431E RID: 17182
	public static class IKurotatoConditionStepEndVerify
	{
		// Token: 0x060182A7 RID: 98983 RVA: 0x0037246A File Offset: 0x0037066A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
