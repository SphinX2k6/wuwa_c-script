using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200640E RID: 25614
	public static class IClientUnlockAchievementSystemItemVerify
	{
		// Token: 0x0602C520 RID: 181536 RVA: 0x0061548A File Offset: 0x0061368A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
