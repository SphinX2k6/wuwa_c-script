using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEB RID: 28139
	public static class IQiuyuanQinggongExploration4Verify
	{
		// Token: 0x06031B36 RID: 203574 RVA: 0x006BAFB2 File Offset: 0x006B91B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
