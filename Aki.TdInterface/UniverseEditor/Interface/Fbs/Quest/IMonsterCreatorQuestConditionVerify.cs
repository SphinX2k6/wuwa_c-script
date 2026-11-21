using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004372 RID: 17266
	public static class IMonsterCreatorQuestConditionVerify
	{
		// Token: 0x0601863C RID: 99900 RVA: 0x0037A520 File Offset: 0x00378720
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMonsterCreatorQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMonsterCreatorQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IMonsterCreatorQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMonsterCreatorQuestConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						short offsetId2 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMonsterCreatorQuestConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IMonsterCreatorQuestConditionVerify.<>O.<2>__Verify = new VerifyTableAction(IMonsterMergedHpBarSettingsVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMonsterCreatorQuestConditionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IMonsterCreatorQuestConditionVerify.<>O.<3>__Verify = new VerifyTableAction(ISpecificMonsterDeadPositionVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008150 RID: 33104
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401423C RID: 82492
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401423D RID: 82493
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401423E RID: 82494
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401423F RID: 82495
			public static VerifyTableAction <3>__Verify;
		}
	}
}
