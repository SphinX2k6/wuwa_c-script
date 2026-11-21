using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006765 RID: 26469
	public static class IActorTurnToEmptyDataVerify
	{
		// Token: 0x0602CDCF RID: 183759 RVA: 0x0062289A File Offset: 0x00620A9A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
