using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416B RID: 16747
	public static class ISurvivorsRougeConditionStepShoppingVerify
	{
		// Token: 0x0601898D RID: 100749 RVA: 0x0038B032 File Offset: 0x00389232
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
