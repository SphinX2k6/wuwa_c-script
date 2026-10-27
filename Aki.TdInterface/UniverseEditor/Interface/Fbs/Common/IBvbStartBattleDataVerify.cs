using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D69 RID: 23913
	public static class IBvbStartBattleDataVerify
	{
		// Token: 0x06028E87 RID: 167559 RVA: 0x0059EA52 File Offset: 0x0059CC52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
