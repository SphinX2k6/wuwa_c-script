using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8B RID: 28555
	public static class IHeadStyleWeakSignalVerify
	{
		// Token: 0x060316C7 RID: 202439 RVA: 0x006B363E File Offset: 0x006B183E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
