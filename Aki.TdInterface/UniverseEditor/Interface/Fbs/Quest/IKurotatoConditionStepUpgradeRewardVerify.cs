using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EEF RID: 16111
	public static class IKurotatoConditionStepUpgradeRewardVerify
	{
		// Token: 0x06016CAA RID: 93354 RVA: 0x003499F6 File Offset: 0x00347BF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
