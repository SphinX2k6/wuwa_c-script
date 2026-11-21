using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FF5 RID: 24565
	public static class ISuccessConditionSameArbitraryStateVerify
	{
		// Token: 0x06029639 RID: 169529 RVA: 0x005A636E File Offset: 0x005A456E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
