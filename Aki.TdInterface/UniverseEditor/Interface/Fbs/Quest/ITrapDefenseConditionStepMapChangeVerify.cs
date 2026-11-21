using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200468A RID: 18058
	public static class ITrapDefenseConditionStepMapChangeVerify
	{
		// Token: 0x0601A833 RID: 108595 RVA: 0x003C5EF6 File Offset: 0x003C40F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
