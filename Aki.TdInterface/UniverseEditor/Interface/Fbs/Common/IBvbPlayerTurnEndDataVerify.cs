using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200638E RID: 25486
	public static class IBvbPlayerTurnEndDataVerify
	{
		// Token: 0x0602B489 RID: 177289 RVA: 0x005E6C22 File Offset: 0x005E4E22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
