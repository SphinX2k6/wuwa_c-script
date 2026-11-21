using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045AC RID: 17836
	public static class ISurvivorsRougeConditionStepPrepareVerify
	{
		// Token: 0x0601A043 RID: 106563 RVA: 0x003B5476 File Offset: 0x003B3676
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
