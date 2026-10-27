using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E8 RID: 23016
	public static class ISuccessConditionSameArbitraryStateVerify
	{
		// Token: 0x060270C1 RID: 159937 RVA: 0x0055F3AA File Offset: 0x0055D5AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
