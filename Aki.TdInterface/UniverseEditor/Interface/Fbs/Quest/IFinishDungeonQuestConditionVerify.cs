using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E35 RID: 15925
	public static class IFinishDungeonQuestConditionVerify
	{
		// Token: 0x06016538 RID: 91448 RVA: 0x003391C0 File Offset: 0x003373C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishDungeonQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishDungeonQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishDungeonQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishDungeonQuestConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TDungeonConditionTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078DD RID: 30941
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013185 RID: 78213
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013186 RID: 78214
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
