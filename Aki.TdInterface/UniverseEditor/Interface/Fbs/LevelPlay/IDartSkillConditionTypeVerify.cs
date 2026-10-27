using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004487 RID: 17543
	public static class IDartSkillConditionTypeVerify
	{
		// Token: 0x0601A29D RID: 107165 RVA: 0x003BCCEA File Offset: 0x003BAEEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
