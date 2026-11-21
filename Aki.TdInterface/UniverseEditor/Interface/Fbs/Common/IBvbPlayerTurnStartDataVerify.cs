using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006391 RID: 25489
	public static class IBvbPlayerTurnStartDataVerify
	{
		// Token: 0x0602B49B RID: 177307 RVA: 0x005E6D9A File Offset: 0x005E4F9A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
