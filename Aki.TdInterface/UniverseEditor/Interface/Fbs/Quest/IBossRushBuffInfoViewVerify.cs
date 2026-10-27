using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D39 RID: 15673
	public static class IBossRushBuffInfoViewVerify
	{
		// Token: 0x06015A58 RID: 88664 RVA: 0x0031FBFE File Offset: 0x0031DDFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
