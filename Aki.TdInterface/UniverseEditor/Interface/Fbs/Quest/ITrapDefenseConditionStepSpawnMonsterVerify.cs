using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004237 RID: 16951
	public static class ITrapDefenseConditionStepSpawnMonsterVerify
	{
		// Token: 0x060190FD RID: 102653 RVA: 0x0039AC86 File Offset: 0x00398E86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
