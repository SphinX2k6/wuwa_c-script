using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAA RID: 23210
	public static class ITimeScheduleNpcSourceVerify
	{
		// Token: 0x060278C9 RID: 161993 RVA: 0x00570CE6 File Offset: 0x0056EEE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
