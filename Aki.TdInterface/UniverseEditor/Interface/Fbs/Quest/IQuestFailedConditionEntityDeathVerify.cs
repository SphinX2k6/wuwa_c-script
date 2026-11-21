using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004420 RID: 17440
	public static class IQuestFailedConditionEntityDeathVerify
	{
		// Token: 0x06018F1D RID: 102173 RVA: 0x0038ECE5 File Offset: 0x0038CEE5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
