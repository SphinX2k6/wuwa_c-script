using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057AD RID: 22445
	public static class IPullingCategoryMatchingFoundationVerify
	{
		// Token: 0x06025ABB RID: 154299 RVA: 0x00532418 File Offset: 0x00530618
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

		// Token: 0x02007BEC RID: 31724
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136B5 RID: 79541
			public static VerifyTableAction <0>__Verify;
		}
	}
}
