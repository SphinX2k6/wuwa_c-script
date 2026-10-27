using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004117 RID: 16663
	public static class ISheriffMainBoardConfigVerify
	{
		// Token: 0x06018666 RID: 99942 RVA: 0x0038508E File Offset: 0x0038328E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
