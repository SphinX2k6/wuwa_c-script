using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C8 RID: 17864
	public static class ITrapDefenseSpawnMonsterConditionCompletedVerify
	{
		// Token: 0x0601B056 RID: 110678 RVA: 0x003DA000 File Offset: 0x003D8200
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
