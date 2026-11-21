using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B2 RID: 17074
	public static class IGameDifficultySystemConfigVerify
	{
		// Token: 0x06017EAD RID: 97965 RVA: 0x0036A446 File Offset: 0x00368646
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
