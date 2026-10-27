using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EB RID: 23019
	public static class ISuccessConditionSameSpecificStateVerify
	{
		// Token: 0x060270D9 RID: 159961 RVA: 0x0055F5D3 File Offset: 0x0055D7D3
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
