using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597A RID: 22906
	public static class IIndependentSystemRewardTypeVerify
	{
		// Token: 0x06025572 RID: 152946 RVA: 0x0051FF7A File Offset: 0x0051E17A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
