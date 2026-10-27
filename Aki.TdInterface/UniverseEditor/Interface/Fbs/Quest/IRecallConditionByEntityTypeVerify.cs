using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200407B RID: 16507
	public static class IRecallConditionByEntityTypeVerify
	{
		// Token: 0x0601800C RID: 98316 RVA: 0x003769A4 File Offset: 0x00374BA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
