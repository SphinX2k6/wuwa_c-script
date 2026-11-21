using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004519 RID: 17689
	public static class IRoleTowerConditionStepLoadSubLevelVerify
	{
		// Token: 0x0601999E RID: 104862 RVA: 0x003A5D36 File Offset: 0x003A3F36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
