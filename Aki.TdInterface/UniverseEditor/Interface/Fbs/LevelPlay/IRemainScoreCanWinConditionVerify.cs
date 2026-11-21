using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049A6 RID: 18854
	public static class IRemainScoreCanWinConditionVerify
	{
		// Token: 0x0601C271 RID: 115313 RVA: 0x003F9FEE File Offset: 0x003F81EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
