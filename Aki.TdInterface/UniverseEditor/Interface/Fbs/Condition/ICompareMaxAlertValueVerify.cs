using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200509F RID: 20639
	public static class ICompareMaxAlertValueVerify
	{
		// Token: 0x060204D1 RID: 132305 RVA: 0x00479672 File Offset: 0x00477872
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
