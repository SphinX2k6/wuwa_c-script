using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004672 RID: 18034
	public static class ITrackRuleTypeBaseVerify
	{
		// Token: 0x0601A776 RID: 108406 RVA: 0x003C47C2 File Offset: 0x003C29C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
