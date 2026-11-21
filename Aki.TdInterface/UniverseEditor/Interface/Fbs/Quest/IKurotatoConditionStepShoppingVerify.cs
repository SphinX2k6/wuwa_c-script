using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004327 RID: 17191
	public static class IKurotatoConditionStepShoppingVerify
	{
		// Token: 0x060182DD RID: 99037 RVA: 0x003728D2 File Offset: 0x00370AD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
