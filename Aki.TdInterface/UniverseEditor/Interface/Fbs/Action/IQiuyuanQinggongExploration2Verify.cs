using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007560 RID: 30048
	public static class IQiuyuanQinggongExploration2Verify
	{
		// Token: 0x06034B0E RID: 215822 RVA: 0x007163AA File Offset: 0x007145AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
