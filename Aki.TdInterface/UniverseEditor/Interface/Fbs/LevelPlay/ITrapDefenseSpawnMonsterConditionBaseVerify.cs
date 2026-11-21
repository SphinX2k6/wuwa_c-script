using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A2A RID: 18986
	public static class ITrapDefenseSpawnMonsterConditionBaseVerify
	{
		// Token: 0x0601C805 RID: 116741 RVA: 0x00405F1E File Offset: 0x0040411E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
