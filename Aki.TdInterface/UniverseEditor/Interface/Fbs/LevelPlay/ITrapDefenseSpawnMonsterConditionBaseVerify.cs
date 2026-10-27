using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C2 RID: 17858
	public static class ITrapDefenseSpawnMonsterConditionBaseVerify
	{
		// Token: 0x0601B030 RID: 110640 RVA: 0x003D9C82 File Offset: 0x003D7E82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
