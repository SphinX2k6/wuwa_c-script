using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F2 RID: 16882
	public static class IDarkTideHecatePollutionBossEventVerify
	{
		// Token: 0x060176E1 RID: 95969 RVA: 0x0035906E File Offset: 0x0035726E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
