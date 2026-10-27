using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EC8 RID: 16072
	public static class IKillChildQuestConditionVerify
	{
		// Token: 0x06016BA6 RID: 93094 RVA: 0x0034817C File Offset: 0x0034637C
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
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020078FC RID: 30972
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131BA RID: 78266
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131BB RID: 78267
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040131BC RID: 78268
			public static VerifyTableAction <2>__Verify;
		}
	}
}
