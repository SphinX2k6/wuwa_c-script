using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046B7 RID: 18103
	public static class IUseSkillQuestConditionVerify
	{
		// Token: 0x0601A99B RID: 108955 RVA: 0x003C8608 File Offset: 0x003C6808
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

		// Token: 0x020081C3 RID: 33219
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014359 RID: 82777
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401435A RID: 82778
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
