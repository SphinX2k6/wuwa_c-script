using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425B RID: 16987
	public static class IUseSkillQuestConditionVerify
	{
		// Token: 0x0601922F RID: 102959 RVA: 0x0039CF30 File Offset: 0x0039B130
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IUseSkillQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUseSkillQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IUseSkillQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IUseSkillQuestConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TUseSkillCheckVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200797A RID: 31098
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132F2 RID: 78578
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132F3 RID: 78579
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
