using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A9 RID: 17833
	public static class ISurvivorsRougeConditionStepEndVerify
	{
		// Token: 0x0601A031 RID: 106545 RVA: 0x003B52FE File Offset: 0x003B34FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
