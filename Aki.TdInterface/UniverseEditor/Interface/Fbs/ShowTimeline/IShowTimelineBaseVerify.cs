using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB1 RID: 16305
	public static class IShowTimelineBaseVerify
	{
		// Token: 0x060163C4 RID: 91076 RVA: 0x0032FB12 File Offset: 0x0032DD12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
