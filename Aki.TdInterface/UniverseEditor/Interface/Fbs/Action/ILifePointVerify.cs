using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F8 RID: 27128
	public static class ILifePointVerify
	{
		// Token: 0x0602F77C RID: 194428 RVA: 0x00676FAC File Offset: 0x006751AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILifePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILifePointVerify.<>O.<0>__Verify = new VerifyTableAction(ILifePointColorBoardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILifePointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILifePointVerify.<>O.<1>__Verify = new VerifyTableAction(ILifePointMaxStepRewardRuleItemVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D99 RID: 32153
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401392C RID: 80172
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401392D RID: 80173
			public static VerifyTableAction <1>__Verify;
		}
	}
}
