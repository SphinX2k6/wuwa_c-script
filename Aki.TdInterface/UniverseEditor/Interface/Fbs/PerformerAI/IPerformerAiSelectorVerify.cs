using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004377 RID: 17271
	public static class IPerformerAiSelectorVerify
	{
		// Token: 0x06019A83 RID: 105091 RVA: 0x003AC560 File Offset: 0x003AA760
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 16, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
