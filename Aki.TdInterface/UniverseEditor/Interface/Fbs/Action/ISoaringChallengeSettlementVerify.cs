using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007165 RID: 29029
	public static class ISoaringChallengeSettlementVerify
	{
		// Token: 0x06033781 RID: 210817 RVA: 0x006EF152 File Offset: 0x006ED352
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
