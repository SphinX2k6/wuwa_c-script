using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004490 RID: 17552
	public static class IDartSkillResultTypeVerify
	{
		// Token: 0x0601A2DF RID: 107231 RVA: 0x003BD40E File Offset: 0x003BB60E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
