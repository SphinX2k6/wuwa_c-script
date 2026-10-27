using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EDD RID: 16093
	public static class IKurotatoConditionStepChestRewardVerify
	{
		// Token: 0x06016C3E RID: 93246 RVA: 0x00349126 File Offset: 0x00347326
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
