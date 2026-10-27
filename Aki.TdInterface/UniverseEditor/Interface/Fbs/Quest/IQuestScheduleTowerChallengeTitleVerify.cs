using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004042 RID: 16450
	public static class IQuestScheduleTowerChallengeTitleVerify
	{
		// Token: 0x06017D15 RID: 97557 RVA: 0x0036FAEA File Offset: 0x0036DCEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
