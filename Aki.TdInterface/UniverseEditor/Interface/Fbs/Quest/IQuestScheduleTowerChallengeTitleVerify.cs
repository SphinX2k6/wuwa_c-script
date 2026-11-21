using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004483 RID: 17539
	public static class IQuestScheduleTowerChallengeTitleVerify
	{
		// Token: 0x060193AE RID: 103342 RVA: 0x003998DE File Offset: 0x00397ADE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
