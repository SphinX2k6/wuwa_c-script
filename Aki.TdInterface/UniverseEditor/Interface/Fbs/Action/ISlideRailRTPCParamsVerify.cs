using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007153 RID: 29011
	public static class ISlideRailRTPCParamsVerify
	{
		// Token: 0x060336DD RID: 210653 RVA: 0x006EDF75 File Offset: 0x006EC175
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
