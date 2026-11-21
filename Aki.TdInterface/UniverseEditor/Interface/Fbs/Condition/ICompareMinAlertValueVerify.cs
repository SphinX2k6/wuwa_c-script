using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A2 RID: 20642
	public static class ICompareMinAlertValueVerify
	{
		// Token: 0x060204E3 RID: 132323 RVA: 0x004797EA File Offset: 0x004779EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
