using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C28 RID: 31784
	public static class ITrackingEventTypeBaseVerify
	{
		// Token: 0x060394A4 RID: 234660 RVA: 0x007BCAEA File Offset: 0x007BACEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
