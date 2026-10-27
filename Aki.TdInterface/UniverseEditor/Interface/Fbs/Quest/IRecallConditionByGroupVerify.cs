using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200407E RID: 16510
	public static class IRecallConditionByGroupVerify
	{
		// Token: 0x0601802E RID: 98350 RVA: 0x00376D6D File Offset: 0x00374F6D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
