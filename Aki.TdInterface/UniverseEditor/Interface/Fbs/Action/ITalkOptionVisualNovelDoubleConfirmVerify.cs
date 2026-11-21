using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B32 RID: 31538
	public static class ITalkOptionVisualNovelDoubleConfirmVerify
	{
		// Token: 0x06038CC4 RID: 232644 RVA: 0x007AE83A File Offset: 0x007ACA3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
