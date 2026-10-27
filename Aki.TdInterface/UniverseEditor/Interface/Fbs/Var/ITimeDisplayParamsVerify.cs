using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AF2 RID: 15090
	public static class ITimeDisplayParamsVerify
	{
		// Token: 0x060148FF RID: 84223 RVA: 0x002FE6B6 File Offset: 0x002FC8B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
