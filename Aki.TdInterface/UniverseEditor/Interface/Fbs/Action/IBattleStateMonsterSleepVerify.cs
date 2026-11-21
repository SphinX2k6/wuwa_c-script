using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006864 RID: 26724
	public static class IBattleStateMonsterSleepVerify
	{
		// Token: 0x0602DAE5 RID: 187109 RVA: 0x0063F5EA File Offset: 0x0063D7EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
