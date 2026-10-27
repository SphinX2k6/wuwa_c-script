using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045CE RID: 17870
	public static class ITrapDefenseSpawnMonsterConditionOpenVerify
	{
		// Token: 0x0601B092 RID: 110738 RVA: 0x003DA800 File Offset: 0x003D8A00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
