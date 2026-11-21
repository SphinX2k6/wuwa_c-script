using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048EF RID: 18671
	public static class IDartSkillConditionTypeVerify
	{
		// Token: 0x0601BA6E RID: 113262 RVA: 0x003E8EF6 File Offset: 0x003E70F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
