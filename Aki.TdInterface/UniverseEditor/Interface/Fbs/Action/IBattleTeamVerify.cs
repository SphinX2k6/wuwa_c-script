using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686D RID: 26733
	public static class IBattleTeamVerify
	{
		// Token: 0x0602DB17 RID: 187159 RVA: 0x0063FA22 File Offset: 0x0063DC22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
