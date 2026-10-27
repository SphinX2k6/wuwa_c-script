using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004374 RID: 17268
	public static class IPerformerAiProbabilityVerify
	{
		// Token: 0x06019A37 RID: 105015 RVA: 0x003AB738 File Offset: 0x003A9938
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 16, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 20, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
