using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007435 RID: 29749
	public static class ITrackingEventTypeBaseVerify
	{
		// Token: 0x060360BB RID: 221371 RVA: 0x00759DBE File Offset: 0x00757FBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
