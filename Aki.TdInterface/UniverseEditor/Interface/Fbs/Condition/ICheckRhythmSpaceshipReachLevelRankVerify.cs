using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B0A RID: 19210
	public static class ICheckRhythmSpaceshipReachLevelRankVerify
	{
		// Token: 0x0601E361 RID: 123745 RVA: 0x0043C7B4 File Offset: 0x0043A9B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
