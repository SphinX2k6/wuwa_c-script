using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F06 RID: 24326
	public static class ISearchTargetCfgVerify
	{
		// Token: 0x06028D2D RID: 167213 RVA: 0x00594490 File Offset: 0x00592690
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISearchTargetCfgVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISearchTargetCfgVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityAngleWeightVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISearchTargetCfgVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISearchTargetCfgVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityCategoryWeightVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008496 RID: 33942
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147AE RID: 83886
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147AF RID: 83887
			public static VerifyTableAction <1>__Verify;
		}
	}
}
