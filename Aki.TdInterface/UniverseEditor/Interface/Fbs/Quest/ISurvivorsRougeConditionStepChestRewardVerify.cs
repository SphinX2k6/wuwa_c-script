using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A0 RID: 17824
	public static class ISurvivorsRougeConditionStepChestRewardVerify
	{
		// Token: 0x06019FFB RID: 106491 RVA: 0x003B4E96 File Offset: 0x003B3096
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
