using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FAB RID: 16299
	public static class IShowTimelineActionOptionBaseVerify
	{
		// Token: 0x060163A2 RID: 91042 RVA: 0x0032F80E File Offset: 0x0032DA0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
