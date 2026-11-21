using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675F RID: 26463
	public static class IActorTurnToDataVerify
	{
		// Token: 0x0602CDA9 RID: 183721 RVA: 0x00622512 File Offset: 0x00620712
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
