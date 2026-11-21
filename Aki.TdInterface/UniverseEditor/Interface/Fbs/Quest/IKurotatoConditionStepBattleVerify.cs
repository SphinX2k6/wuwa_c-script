using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004318 RID: 17176
	public static class IKurotatoConditionStepBattleVerify
	{
		// Token: 0x06018283 RID: 98947 RVA: 0x0037217A File Offset: 0x0037037A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
