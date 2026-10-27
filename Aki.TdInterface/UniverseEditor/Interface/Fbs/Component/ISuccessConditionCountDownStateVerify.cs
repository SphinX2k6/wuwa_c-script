using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E5 RID: 23013
	public static class ISuccessConditionCountDownStateVerify
	{
		// Token: 0x060270AF RID: 159919 RVA: 0x0055F232 File Offset: 0x0055D432
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
