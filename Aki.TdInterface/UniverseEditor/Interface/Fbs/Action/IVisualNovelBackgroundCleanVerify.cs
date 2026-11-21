using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D57 RID: 32087
	public static class IVisualNovelBackgroundCleanVerify
	{
		// Token: 0x06039EC1 RID: 237249 RVA: 0x007CFCCE File Offset: 0x007CDECE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
