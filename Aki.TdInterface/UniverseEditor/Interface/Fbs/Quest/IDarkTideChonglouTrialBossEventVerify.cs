using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EC RID: 16876
	public static class IDarkTideChonglouTrialBossEventVerify
	{
		// Token: 0x060176BD RID: 95933 RVA: 0x00358D7E File Offset: 0x00356F7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
