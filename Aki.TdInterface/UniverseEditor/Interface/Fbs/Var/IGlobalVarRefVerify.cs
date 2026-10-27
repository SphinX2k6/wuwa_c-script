using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A9E RID: 15006
	public static class IGlobalVarRefVerify
	{
		// Token: 0x060145E7 RID: 83431 RVA: 0x002F891D File Offset: 0x002F6B1D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
