using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415C RID: 16732
	public static class ISurvivorsRougeConditionStepChestRewardVerify
	{
		// Token: 0x06018933 RID: 100659 RVA: 0x0038A8DA File Offset: 0x00388ADA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
