using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B9 RID: 16825
	public static class ICompareVarConditionInChildQuestVerify
	{
		// Token: 0x0601741F RID: 95263 RVA: 0x00351E88 File Offset: 0x00350088
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICompareVarConditionInChildQuestVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompareVarConditionInChildQuestVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICompareVarConditionInChildQuestVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICompareVarConditionInChildQuestVerify.<>O.<1>__Verify = new VerifyTableAction(ICompareVarInChildQuestVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008109 RID: 33033
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141A7 RID: 82343
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141A8 RID: 82344
			public static VerifyTableAction <1>__Verify;
		}
	}
}
