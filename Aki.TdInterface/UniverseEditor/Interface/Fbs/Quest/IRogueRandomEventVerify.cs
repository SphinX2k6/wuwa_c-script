using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B4 RID: 16564
	public static class IRogueRandomEventVerify
	{
		// Token: 0x06018210 RID: 98832 RVA: 0x0037A652 File Offset: 0x00378852
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
