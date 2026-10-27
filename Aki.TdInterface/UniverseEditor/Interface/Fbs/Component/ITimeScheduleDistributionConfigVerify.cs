using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A98 RID: 23192
	public static class ITimeScheduleDistributionConfigVerify
	{
		// Token: 0x06027845 RID: 161861 RVA: 0x0056FD7E File Offset: 0x0056DF7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
