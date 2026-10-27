using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200454D RID: 17741
	public static class IRollBlock2Verify
	{
		// Token: 0x0601AB32 RID: 109362 RVA: 0x003CECCC File Offset: 0x003CCECC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
