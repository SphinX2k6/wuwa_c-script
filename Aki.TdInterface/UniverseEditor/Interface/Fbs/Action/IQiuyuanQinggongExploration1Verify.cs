using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE2 RID: 28130
	public static class IQiuyuanQinggongExploration1Verify
	{
		// Token: 0x06031B00 RID: 203520 RVA: 0x006BAB4A File Offset: 0x006B8D4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
