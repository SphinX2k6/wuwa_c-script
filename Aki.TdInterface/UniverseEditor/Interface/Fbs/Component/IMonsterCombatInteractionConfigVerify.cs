using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B03 RID: 23299
	public static class IMonsterCombatInteractionConfigVerify
	{
		// Token: 0x06026493 RID: 156819 RVA: 0x0053EC52 File Offset: 0x0053CE52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
