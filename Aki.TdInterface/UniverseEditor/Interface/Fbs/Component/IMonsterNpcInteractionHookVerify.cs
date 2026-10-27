using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558F RID: 21903
	public static class IMonsterNpcInteractionHookVerify
	{
		// Token: 0x0602442E RID: 148526 RVA: 0x00501D4A File Offset: 0x004FFF4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
