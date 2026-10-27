using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A81 RID: 23169
	public static class ITimelineTrackControlDataVerify
	{
		// Token: 0x0602776C RID: 161644 RVA: 0x0056E236 File Offset: 0x0056C436
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
