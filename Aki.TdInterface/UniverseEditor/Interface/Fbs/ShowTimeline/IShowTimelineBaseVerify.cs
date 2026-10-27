using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BA9 RID: 15273
	public static class IShowTimelineBaseVerify
	{
		// Token: 0x06014EFA RID: 85754 RVA: 0x0030957A File Offset: 0x0030777A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
