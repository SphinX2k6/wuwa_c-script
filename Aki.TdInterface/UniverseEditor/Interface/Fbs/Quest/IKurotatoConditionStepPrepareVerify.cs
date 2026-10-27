using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE3 RID: 16099
	public static class IKurotatoConditionStepPrepareVerify
	{
		// Token: 0x06016C62 RID: 93282 RVA: 0x00349416 File Offset: 0x00347616
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
