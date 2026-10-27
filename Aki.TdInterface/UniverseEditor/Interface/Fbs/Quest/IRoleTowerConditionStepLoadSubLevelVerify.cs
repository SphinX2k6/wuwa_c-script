using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D8 RID: 16600
	public static class IRoleTowerConditionStepLoadSubLevelVerify
	{
		// Token: 0x060182FD RID: 99069 RVA: 0x0037BDE6 File Offset: 0x00379FE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
