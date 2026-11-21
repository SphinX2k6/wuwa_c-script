using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004324 RID: 17188
	public static class IKurotatoConditionStepSaveRoleVerify
	{
		// Token: 0x060182CB RID: 99019 RVA: 0x0037275A File Offset: 0x0037095A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
