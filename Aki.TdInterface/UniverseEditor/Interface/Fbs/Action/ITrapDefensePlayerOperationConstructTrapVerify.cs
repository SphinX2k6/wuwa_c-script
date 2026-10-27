using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745F RID: 29791
	public static class ITrapDefensePlayerOperationConstructTrapVerify
	{
		// Token: 0x06036203 RID: 221699 RVA: 0x0075C246 File Offset: 0x0075A446
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
