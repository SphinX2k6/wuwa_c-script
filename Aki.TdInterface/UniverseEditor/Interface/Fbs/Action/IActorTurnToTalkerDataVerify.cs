using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200610F RID: 24847
	public static class IActorTurnToTalkerDataVerify
	{
		// Token: 0x0602A73E RID: 173886 RVA: 0x005D906E File Offset: 0x005D726E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
