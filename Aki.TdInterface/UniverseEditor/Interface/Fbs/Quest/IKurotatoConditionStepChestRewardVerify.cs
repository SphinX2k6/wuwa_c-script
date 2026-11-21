using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431B RID: 17179
	public static class IKurotatoConditionStepChestRewardVerify
	{
		// Token: 0x06018295 RID: 98965 RVA: 0x003722F2 File Offset: 0x003704F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
