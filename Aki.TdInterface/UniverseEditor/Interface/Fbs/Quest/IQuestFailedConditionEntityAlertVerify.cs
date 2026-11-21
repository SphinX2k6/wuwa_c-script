using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200441D RID: 17437
	public static class IQuestFailedConditionEntityAlertVerify
	{
		// Token: 0x06018F03 RID: 102147 RVA: 0x0038EA41 File Offset: 0x0038CC41
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
