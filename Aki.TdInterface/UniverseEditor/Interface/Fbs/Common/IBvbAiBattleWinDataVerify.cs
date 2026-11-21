using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006355 RID: 25429
	public static class IBvbAiBattleWinDataVerify
	{
		// Token: 0x0602B22A RID: 176682 RVA: 0x005E0C8E File Offset: 0x005DEE8E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
