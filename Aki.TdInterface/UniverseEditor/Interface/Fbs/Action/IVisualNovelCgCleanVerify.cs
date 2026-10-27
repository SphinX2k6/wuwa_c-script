using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756D RID: 30061
	public static class IVisualNovelCgCleanVerify
	{
		// Token: 0x06036AF5 RID: 223989 RVA: 0x0076D0A2 File Offset: 0x0076B2A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
