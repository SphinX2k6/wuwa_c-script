using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200447A RID: 17530
	public static class IQuestScheduleScoreVerify
	{
		// Token: 0x06019327 RID: 103207 RVA: 0x0039830E File Offset: 0x0039650E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
