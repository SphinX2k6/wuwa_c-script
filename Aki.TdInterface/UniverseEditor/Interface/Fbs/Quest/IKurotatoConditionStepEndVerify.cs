using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE0 RID: 16096
	public static class IKurotatoConditionStepEndVerify
	{
		// Token: 0x06016C50 RID: 93264 RVA: 0x0034929E File Offset: 0x0034749E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
