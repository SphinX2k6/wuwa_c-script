using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C2 RID: 16834
	public static class ICompleteMessageQuestConditionVerify
	{
		// Token: 0x06017475 RID: 95349 RVA: 0x00352BBE File Offset: 0x00350DBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
