using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DE8 RID: 28136
	public static class IQiuyuanQinggongExploration3Verify
	{
		// Token: 0x06031B24 RID: 203556 RVA: 0x006BAE3A File Offset: 0x006B903A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
