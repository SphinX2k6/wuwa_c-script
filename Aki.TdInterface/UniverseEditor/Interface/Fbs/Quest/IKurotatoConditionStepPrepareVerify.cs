using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004321 RID: 17185
	public static class IKurotatoConditionStepPrepareVerify
	{
		// Token: 0x060182B9 RID: 99001 RVA: 0x003725E2 File Offset: 0x003707E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
