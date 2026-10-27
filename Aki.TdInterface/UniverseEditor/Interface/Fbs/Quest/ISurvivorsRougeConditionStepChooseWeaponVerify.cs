using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004162 RID: 16738
	public static class ISurvivorsRougeConditionStepChooseWeaponVerify
	{
		// Token: 0x06018957 RID: 100695 RVA: 0x0038ABCA File Offset: 0x00388DCA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
