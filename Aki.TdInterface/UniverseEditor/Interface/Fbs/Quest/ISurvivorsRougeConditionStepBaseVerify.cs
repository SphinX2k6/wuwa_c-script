using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004153 RID: 16723
	public static class ISurvivorsRougeConditionStepBaseVerify
	{
		// Token: 0x060188F7 RID: 100599 RVA: 0x0038A35A File Offset: 0x0038855A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
