using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005834 RID: 22580
	public static class IRefreshRuleVerify
	{
		// Token: 0x06025FA8 RID: 155560 RVA: 0x0053C5E6 File Offset: 0x0053A7E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
