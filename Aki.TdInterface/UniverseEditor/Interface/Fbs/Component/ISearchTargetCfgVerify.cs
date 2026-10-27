using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F9 RID: 22777
	public static class ISearchTargetCfgVerify
	{
		// Token: 0x060267C3 RID: 157635 RVA: 0x0054D824 File Offset: 0x0054BA24
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

		// Token: 0x02007C27 RID: 31783
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401370C RID: 79628
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401370D RID: 79629
			public static VerifyTableAction <1>__Verify;
		}
	}
}
