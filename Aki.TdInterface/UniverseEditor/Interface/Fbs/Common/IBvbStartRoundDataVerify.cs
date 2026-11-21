using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A3 RID: 25507
	public static class IBvbStartRoundDataVerify
	{
		// Token: 0x0602B503 RID: 177411 RVA: 0x005E763A File Offset: 0x005E583A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
