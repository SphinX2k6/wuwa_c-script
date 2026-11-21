using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200549B RID: 21659
	public static class ICategoryMatchingFoundationVerify
	{
		// Token: 0x0602215E RID: 139614 RVA: 0x004B2E40 File Offset: 0x004B1040
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICategoryMatchingFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICategoryMatchingFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082F9 RID: 33529
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014501 RID: 83201
			public static VerifyTableAction <0>__Verify;
		}
	}
}
