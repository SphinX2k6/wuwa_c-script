using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F6 RID: 25078
	public static class IBattleStateMonsterSleepVerify
	{
		// Token: 0x0602B39E RID: 177054 RVA: 0x005F4B76 File Offset: 0x005F2D76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
