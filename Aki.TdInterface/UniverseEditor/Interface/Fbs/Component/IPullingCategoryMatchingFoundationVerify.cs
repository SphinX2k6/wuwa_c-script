using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB4 RID: 23988
	public static class IPullingCategoryMatchingFoundationVerify
	{
		// Token: 0x06027FDB RID: 163803 RVA: 0x005785A4 File Offset: 0x005767A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPullingCategoryMatchingFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPullingCategoryMatchingFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(ICategoryMatchingConfigBaseVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200845A RID: 33882
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014755 RID: 83797
			public static VerifyTableAction <0>__Verify;
		}
	}
}
