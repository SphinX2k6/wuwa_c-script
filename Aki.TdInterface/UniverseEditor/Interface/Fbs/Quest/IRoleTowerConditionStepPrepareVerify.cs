using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040DB RID: 16603
	public static class IRoleTowerConditionStepPrepareVerify
	{
		// Token: 0x0601830F RID: 99087 RVA: 0x0037BF5E File Offset: 0x0037A15E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
