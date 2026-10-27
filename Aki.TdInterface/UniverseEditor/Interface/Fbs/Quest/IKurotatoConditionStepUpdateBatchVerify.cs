using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EEC RID: 16108
	public static class IKurotatoConditionStepUpdateBatchVerify
	{
		// Token: 0x06016C98 RID: 93336 RVA: 0x0034987E File Offset: 0x00347A7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
