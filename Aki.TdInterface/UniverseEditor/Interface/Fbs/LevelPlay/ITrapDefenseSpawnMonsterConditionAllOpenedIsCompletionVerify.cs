using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045BF RID: 17855
	public static class ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionVerify
	{
		// Token: 0x0601B01E RID: 110622 RVA: 0x003D9B0A File Offset: 0x003D7D0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
