using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F5 RID: 17653
	public static class IRogueRandomEventVerify
	{
		// Token: 0x060198B1 RID: 104625 RVA: 0x003A45A2 File Offset: 0x003A27A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
