using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AA4 RID: 19108
	public static class ICheckIsTrackingCurrentQuestVerify
	{
		// Token: 0x0601DFB7 RID: 122807 RVA: 0x004358EA File Offset: 0x00433AEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
