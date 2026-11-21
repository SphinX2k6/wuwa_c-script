using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D8A RID: 32138
	public static class IVisualNovelOptionGroupFullScreenVerify
	{
		// Token: 0x0603A02F RID: 237615 RVA: 0x007D2006 File Offset: 0x007D0206
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
