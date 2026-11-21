using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006867 RID: 26727
	public static class IBattleStatePerceptionBehaviorTypeVerify
	{
		// Token: 0x0602DAF7 RID: 187127 RVA: 0x0063F762 File Offset: 0x0063D962
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
