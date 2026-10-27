using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D54 RID: 23892
	public static class IBvbPlayerBattleWinDataVerify
	{
		// Token: 0x06028E0D RID: 167437 RVA: 0x0059E03A File Offset: 0x0059C23A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
