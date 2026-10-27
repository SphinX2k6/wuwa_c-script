using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BF RID: 16831
	public static class ITetrisPlayModeBaseVerify
	{
		// Token: 0x06018C97 RID: 101527 RVA: 0x0039166A File Offset: 0x0038F86A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
