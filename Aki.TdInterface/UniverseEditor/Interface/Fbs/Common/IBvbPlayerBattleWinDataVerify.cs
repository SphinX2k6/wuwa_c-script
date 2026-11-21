using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200638B RID: 25483
	public static class IBvbPlayerBattleWinDataVerify
	{
		// Token: 0x0602B477 RID: 177271 RVA: 0x005E6AAA File Offset: 0x005E4CAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
