using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004723 RID: 18211
	public static class ITestSuiteVerify
	{
		// Token: 0x0601BFA2 RID: 114594 RVA: 0x003F6FD0 File Offset: 0x003F51D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITestSuiteVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITestSuiteVerify.<>O.<0>__Verify = new VerifyTableAction(ITestCaseVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079DB RID: 31195
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013382 RID: 78722
			public static VerifyTableAction <0>__Verify;
		}
	}
}
