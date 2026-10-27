using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E77 RID: 15991
	public static class IGameDifficultySystemConfigVerify
	{
		// Token: 0x06016876 RID: 92278 RVA: 0x003416C2 File Offset: 0x0033F8C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
