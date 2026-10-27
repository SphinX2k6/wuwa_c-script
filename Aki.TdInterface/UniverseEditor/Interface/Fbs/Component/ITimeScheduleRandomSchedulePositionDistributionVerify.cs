using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB0 RID: 23216
	public static class ITimeScheduleRandomSchedulePositionDistributionVerify
	{
		// Token: 0x060278E7 RID: 162023 RVA: 0x00570F5A File Offset: 0x0056F15A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
