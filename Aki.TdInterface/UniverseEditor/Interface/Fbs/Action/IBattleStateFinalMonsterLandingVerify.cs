using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F0 RID: 25072
	public static class IBattleStateFinalMonsterLandingVerify
	{
		// Token: 0x0602B37A RID: 177018 RVA: 0x005F4886 File Offset: 0x005F2A86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
