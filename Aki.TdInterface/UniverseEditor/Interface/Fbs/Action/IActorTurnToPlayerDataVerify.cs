using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676B RID: 26475
	public static class IActorTurnToPlayerDataVerify
	{
		// Token: 0x0602CDF7 RID: 183799 RVA: 0x00622C12 File Offset: 0x00620E12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
