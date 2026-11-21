using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8E RID: 27278
	public static class IClientUnlockAchievementSystemItemVerify
	{
		// Token: 0x0602ECF6 RID: 191734 RVA: 0x00661316 File Offset: 0x0065F516
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
