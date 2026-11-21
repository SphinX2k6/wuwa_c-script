using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A8 RID: 28840
	public static class ILifePointVerify
	{
		// Token: 0x0603213C RID: 205116 RVA: 0x006C7304 File Offset: 0x006C5504
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

		// Token: 0x02008613 RID: 34323
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149DC RID: 84444
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040149DD RID: 84445
			public static VerifyTableAction <1>__Verify;
		}
	}
}
