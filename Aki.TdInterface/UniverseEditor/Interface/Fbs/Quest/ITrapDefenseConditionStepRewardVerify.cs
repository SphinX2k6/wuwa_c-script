using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004234 RID: 16948
	public static class ITrapDefenseConditionStepRewardVerify
	{
		// Token: 0x060190EB RID: 102635 RVA: 0x0039AB0E File Offset: 0x00398D0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
