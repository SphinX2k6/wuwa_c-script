using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA2 RID: 15778
	public static class ICompareVarConditionInChildQuestVerify
	{
		// Token: 0x06015EE7 RID: 89831 RVA: 0x0032AB5C File Offset: 0x00328D5C
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

		// Token: 0x020078C5 RID: 30917
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401314B RID: 78155
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401314C RID: 78156
			public static VerifyTableAction <1>__Verify;
		}
	}
}
