using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F73 RID: 20339
	public static class ICheckIsTrackingCurrentQuestVerify
	{
		// Token: 0x0601FAA0 RID: 129696 RVA: 0x0046710A File Offset: 0x0046530A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
