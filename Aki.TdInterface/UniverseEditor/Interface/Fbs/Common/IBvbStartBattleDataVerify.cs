using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A0 RID: 25504
	public static class IBvbStartBattleDataVerify
	{
		// Token: 0x0602B4F1 RID: 177393 RVA: 0x005E74C2 File Offset: 0x005E56C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
