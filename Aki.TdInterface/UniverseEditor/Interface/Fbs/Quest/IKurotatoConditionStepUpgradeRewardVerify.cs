using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432D RID: 17197
	public static class IKurotatoConditionStepUpgradeRewardVerify
	{
		// Token: 0x06018301 RID: 99073 RVA: 0x00372BC2 File Offset: 0x00370DC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
