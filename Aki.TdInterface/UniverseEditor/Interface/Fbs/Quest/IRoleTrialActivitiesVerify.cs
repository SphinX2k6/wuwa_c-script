using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040EA RID: 16618
	public static class IRoleTrialActivitiesVerify
	{
		// Token: 0x0601837E RID: 99198 RVA: 0x0037CBFE File Offset: 0x0037ADFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
