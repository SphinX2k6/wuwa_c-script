using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200453E RID: 17726
	public static class IRemainScoreCanWinConditionVerify
	{
		// Token: 0x0601AA9C RID: 109212 RVA: 0x003CDD52 File Offset: 0x003CBF52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
