using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004159 RID: 16729
	public static class ISurvivorsRougeConditionStepBattleVerify
	{
		// Token: 0x06018921 RID: 100641 RVA: 0x0038A762 File Offset: 0x00388962
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
