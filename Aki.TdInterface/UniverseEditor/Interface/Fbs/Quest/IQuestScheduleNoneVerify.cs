using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004471 RID: 17521
	public static class IQuestScheduleNoneVerify
	{
		// Token: 0x060192E4 RID: 103140 RVA: 0x00397BBA File Offset: 0x00395DBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
