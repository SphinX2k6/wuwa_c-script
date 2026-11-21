using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004597 RID: 17815
	public static class ISurvivorsRougeConditionStepBaseVerify
	{
		// Token: 0x06019FBF RID: 106431 RVA: 0x003B4916 File Offset: 0x003B2B16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
