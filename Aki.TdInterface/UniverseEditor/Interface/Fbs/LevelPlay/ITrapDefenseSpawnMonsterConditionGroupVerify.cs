using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045CB RID: 17867
	public static class ITrapDefenseSpawnMonsterConditionGroupVerify
	{
		// Token: 0x0601B07C RID: 110716 RVA: 0x003DA603 File Offset: 0x003D8803
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
