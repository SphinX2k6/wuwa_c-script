using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200459D RID: 17821
	public static class ISurvivorsRougeConditionStepBattleVerify
	{
		// Token: 0x06019FE9 RID: 106473 RVA: 0x003B4D1E File Offset: 0x003B2F1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
