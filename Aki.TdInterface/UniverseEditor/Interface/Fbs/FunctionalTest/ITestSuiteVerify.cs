using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004B8B RID: 19339
	public static class ITestSuiteVerify
	{
		// Token: 0x0601D777 RID: 120695 RVA: 0x0042326C File Offset: 0x0042146C
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

		// Token: 0x02008224 RID: 33316
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143E9 RID: 82921
			public static VerifyTableAction <0>__Verify;
		}
	}
}
