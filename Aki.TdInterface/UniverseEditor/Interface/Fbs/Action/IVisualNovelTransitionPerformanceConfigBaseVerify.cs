using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DF9 RID: 32249
	public static class IVisualNovelTransitionPerformanceConfigBaseVerify
	{
		// Token: 0x0603A472 RID: 238706 RVA: 0x007DA246 File Offset: 0x007D8446
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
