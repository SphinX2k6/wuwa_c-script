using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A3 RID: 17827
	public static class ISurvivorsRougeConditionStepChooseItemVerify
	{
		// Token: 0x0601A00D RID: 106509 RVA: 0x003B500E File Offset: 0x003B320E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
