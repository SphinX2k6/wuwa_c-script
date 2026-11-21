using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005920 RID: 22816
	public static class IHitLogicChangeNextAndLockTargetStateVerify
	{
		// Token: 0x06025185 RID: 151941 RVA: 0x00517487 File Offset: 0x00515687
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
