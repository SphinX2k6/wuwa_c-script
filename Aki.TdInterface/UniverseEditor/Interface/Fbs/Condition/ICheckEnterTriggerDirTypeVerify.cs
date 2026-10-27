using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049ED RID: 18925
	public static class ICheckEnterTriggerDirTypeVerify
	{
		// Token: 0x0601D91D RID: 121117 RVA: 0x0042972E File Offset: 0x0042792E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
