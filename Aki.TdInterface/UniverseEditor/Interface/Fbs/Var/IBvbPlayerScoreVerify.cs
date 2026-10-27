using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A83 RID: 14979
	public static class IBvbPlayerScoreVerify
	{
		// Token: 0x060144F2 RID: 83186 RVA: 0x002F6CBE File Offset: 0x002F4EBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
