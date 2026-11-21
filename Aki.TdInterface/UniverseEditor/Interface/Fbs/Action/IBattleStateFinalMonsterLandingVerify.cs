using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685E RID: 26718
	public static class IBattleStateFinalMonsterLandingVerify
	{
		// Token: 0x0602DAC1 RID: 187073 RVA: 0x0063F2FA File Offset: 0x0063D4FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
