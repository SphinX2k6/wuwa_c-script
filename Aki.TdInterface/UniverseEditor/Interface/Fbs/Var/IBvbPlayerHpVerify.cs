using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A7D RID: 14973
	public static class IBvbPlayerHpVerify
	{
		// Token: 0x060144CE RID: 83150 RVA: 0x002F69CE File Offset: 0x002F4BCE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
