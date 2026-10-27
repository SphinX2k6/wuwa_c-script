using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004225 RID: 16933
	public static class ITrapDefenseConditionStepBaseVerify
	{
		// Token: 0x0601908F RID: 102543 RVA: 0x0039A31E File Offset: 0x0039851E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
