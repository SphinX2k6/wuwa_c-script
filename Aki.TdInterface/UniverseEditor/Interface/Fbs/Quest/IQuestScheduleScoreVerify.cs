using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004039 RID: 16441
	public static class IQuestScheduleScoreVerify
	{
		// Token: 0x06017C8E RID: 97422 RVA: 0x0036E51A File Offset: 0x0036C71A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
