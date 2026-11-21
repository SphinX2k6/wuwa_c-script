using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005207 RID: 20999
	public static class IUltimateSkillReadyVerify
	{
		// Token: 0x06021128 RID: 135464 RVA: 0x00491C1A File Offset: 0x0048FE1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
