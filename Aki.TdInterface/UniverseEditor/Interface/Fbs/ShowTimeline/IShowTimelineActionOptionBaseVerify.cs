using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BA3 RID: 15267
	public static class IShowTimelineActionOptionBaseVerify
	{
		// Token: 0x06014ED8 RID: 85720 RVA: 0x00309276 File Offset: 0x00307476
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
