using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045AF RID: 17839
	public static class ISurvivorsRougeConditionStepShoppingVerify
	{
		// Token: 0x0601A055 RID: 106581 RVA: 0x003B55EE File Offset: 0x003B37EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
