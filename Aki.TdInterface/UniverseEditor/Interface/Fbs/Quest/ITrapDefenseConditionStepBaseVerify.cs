using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004681 RID: 18049
	public static class ITrapDefenseConditionStepBaseVerify
	{
		// Token: 0x0601A7FB RID: 108539 RVA: 0x003C59F6 File Offset: 0x003C3BF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
