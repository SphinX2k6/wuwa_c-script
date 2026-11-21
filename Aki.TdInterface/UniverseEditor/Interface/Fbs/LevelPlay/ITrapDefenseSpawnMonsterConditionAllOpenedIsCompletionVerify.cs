using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A27 RID: 18983
	public static class ITrapDefenseSpawnMonsterConditionAllOpenedIsCompletionVerify
	{
		// Token: 0x0601C7F3 RID: 116723 RVA: 0x00405DA6 File Offset: 0x00403FA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
