using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200608E RID: 24718
	public static class ITimelineTrackControlDataVerify
	{
		// Token: 0x06029CE4 RID: 171236 RVA: 0x005B5242 File Offset: 0x005B3442
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
