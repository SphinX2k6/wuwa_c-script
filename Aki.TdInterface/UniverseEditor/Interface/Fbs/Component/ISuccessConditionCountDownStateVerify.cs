using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF2 RID: 24562
	public static class ISuccessConditionCountDownStateVerify
	{
		// Token: 0x06029627 RID: 169511 RVA: 0x005A61F6 File Offset: 0x005A43F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
