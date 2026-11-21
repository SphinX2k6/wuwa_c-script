using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004693 RID: 18067
	public static class ITrapDefenseConditionStepSpawnMonsterVerify
	{
		// Token: 0x0601A869 RID: 108649 RVA: 0x003C635E File Offset: 0x003C455E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
