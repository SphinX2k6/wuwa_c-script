using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004306 RID: 17158
	public static class IKillChildQuestConditionVerify
	{
		// Token: 0x060181FD RID: 98813 RVA: 0x0037131C File Offset: 0x0036F51C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IKillChildQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IKillChildQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IKillChildQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IKillChildQuestConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IKillChildQuestConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IKillChildQuestConditionVerify.<>O.<2>__Verify = new VerifyTableAction(IEntityDeadPositionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IKillChildQuestConditionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IKillChildQuestConditionVerify.<>O.<3>__Verify = new VerifyTableAction(ISpecificMonsterDeadPositionVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008142 RID: 33090
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014218 RID: 82456
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014219 RID: 82457
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401421A RID: 82458
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401421B RID: 82459
			public static VerifyTableAction <3>__Verify;
		}
	}
}
