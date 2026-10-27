using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB3 RID: 23219
	public static class ITimeScheduleRefreshConfigVerify
	{
		// Token: 0x060278F9 RID: 162041 RVA: 0x005710D2 File Offset: 0x0056F2D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
