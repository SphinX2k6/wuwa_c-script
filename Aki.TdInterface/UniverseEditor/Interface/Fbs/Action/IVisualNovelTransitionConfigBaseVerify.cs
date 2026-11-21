using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DF0 RID: 32240
	public static class IVisualNovelTransitionConfigBaseVerify
	{
		// Token: 0x0603A434 RID: 238644 RVA: 0x007D9C6E File Offset: 0x007D7E6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
