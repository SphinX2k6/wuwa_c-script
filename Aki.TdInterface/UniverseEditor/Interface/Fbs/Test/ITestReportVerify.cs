using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003B74 RID: 15220
	public static class ITestReportVerify
	{
		// Token: 0x06014D4A RID: 85322 RVA: 0x003065F0 File Offset: 0x003047F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 16, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITestReportVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITestReportVerify.<>O.<0>__Verify = new VerifyTableAction(ITestReportVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200788A RID: 30858
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130F3 RID: 78067
			public static VerifyTableAction <0>__Verify;
		}
	}
}
