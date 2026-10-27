using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE9 RID: 16105
	public static class IKurotatoConditionStepShoppingVerify
	{
		// Token: 0x06016C86 RID: 93318 RVA: 0x00349706 File Offset: 0x00347906
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
