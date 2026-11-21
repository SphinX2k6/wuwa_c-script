using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200432A RID: 17194
	public static class IKurotatoConditionStepUpdateBatchVerify
	{
		// Token: 0x060182EF RID: 99055 RVA: 0x00372A4A File Offset: 0x00370C4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
