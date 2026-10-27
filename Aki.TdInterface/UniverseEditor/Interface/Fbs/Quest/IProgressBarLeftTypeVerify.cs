using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FBE RID: 16318
	public static class IProgressBarLeftTypeVerify
	{
		// Token: 0x06017559 RID: 95577 RVA: 0x0035CFE2 File Offset: 0x0035B1E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
