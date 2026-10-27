using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FunctionalTest
{
	// Token: 0x02004726 RID: 18214
	public static class ITestSuiteCollectionVerify
	{
		// Token: 0x0601BFC4 RID: 114628 RVA: 0x003F7440 File Offset: 0x003F5640
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITestSuiteCollectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITestSuiteCollectionVerify.<>O.<0>__Verify = new VerifyTableAction(ITestSuiteVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079DC RID: 31196
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013383 RID: 78723
			public static VerifyTableAction <0>__Verify;
		}
	}
}
