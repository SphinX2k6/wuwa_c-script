using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415F RID: 16735
	public static class ISurvivorsRougeConditionStepChooseItemVerify
	{
		// Token: 0x06018945 RID: 100677 RVA: 0x0038AA52 File Offset: 0x00388C52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
