using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007931 RID: 31025
	public static class ISoaringChallengeSettlementVerify
	{
		// Token: 0x06036A2B RID: 223787 RVA: 0x0074F95E File Offset: 0x0074DB5E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
