using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004636 RID: 17974
	public static class ITimerQuestConditionVerify
	{
		// Token: 0x0601A4FD RID: 107773 RVA: 0x003BEC68 File Offset: 0x003BCE68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimerQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimerQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ITimerQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimerQuestConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short offsetId2 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITimerQuestConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITimerQuestConditionVerify.<>O.<2>__Verify = new VerifyTableAction(ITimerUiConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020081B3 RID: 33203
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014331 RID: 82737
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014332 RID: 82738
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04014333 RID: 82739
			public static VerifyTableAction <2>__Verify;
		}
	}
}
