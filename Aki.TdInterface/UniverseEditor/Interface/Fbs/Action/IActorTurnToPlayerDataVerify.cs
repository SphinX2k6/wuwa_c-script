using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006109 RID: 24841
	public static class IActorTurnToPlayerDataVerify
	{
		// Token: 0x0602A716 RID: 173846 RVA: 0x005D8C6A File Offset: 0x005D6E6A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
