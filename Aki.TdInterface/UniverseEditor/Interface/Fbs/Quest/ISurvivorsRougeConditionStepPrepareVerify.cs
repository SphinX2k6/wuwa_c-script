using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004168 RID: 16744
	public static class ISurvivorsRougeConditionStepPrepareVerify
	{
		// Token: 0x0601897B RID: 100731 RVA: 0x0038AEBA File Offset: 0x003890BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
