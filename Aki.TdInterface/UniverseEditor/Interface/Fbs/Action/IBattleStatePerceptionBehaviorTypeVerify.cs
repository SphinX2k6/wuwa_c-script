using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F9 RID: 25081
	public static class IBattleStatePerceptionBehaviorTypeVerify
	{
		// Token: 0x0602B3B0 RID: 177072 RVA: 0x005F4CEE File Offset: 0x005F2EEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
