using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EE6 RID: 16102
	public static class IKurotatoConditionStepSaveRoleVerify
	{
		// Token: 0x06016C74 RID: 93300 RVA: 0x0034958E File Offset: 0x0034778E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
