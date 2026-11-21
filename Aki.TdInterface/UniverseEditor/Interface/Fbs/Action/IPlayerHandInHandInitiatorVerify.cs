using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007470 RID: 29808
	public static class IPlayerHandInHandInitiatorVerify
	{
		// Token: 0x060342EC RID: 213740 RVA: 0x00707976 File Offset: 0x00705B76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
