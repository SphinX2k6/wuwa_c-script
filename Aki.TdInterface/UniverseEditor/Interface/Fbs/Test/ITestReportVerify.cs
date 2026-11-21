using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Test
{
	// Token: 0x02003F7C RID: 16252
	public static class ITestReportVerify
	{
		// Token: 0x06016214 RID: 90644 RVA: 0x0032CB88 File Offset: 0x0032AD88
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

		// Token: 0x020080CD RID: 32973
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401414E RID: 82254
			public static VerifyTableAction <0>__Verify;
		}
	}
}
