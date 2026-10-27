using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FDC RID: 16348
	public static class IQuestFailedConditionEntityAlertVerify
	{
		// Token: 0x0601786A RID: 96362 RVA: 0x00364C4D File Offset: 0x00362E4D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
