using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F34 RID: 16180
	public static class IMonsterCreatorQuestConditionVerify
	{
		// Token: 0x06016FDA RID: 94170 RVA: 0x003510D8 File Offset: 0x0034F2D8
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
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200790A RID: 30986
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131DD RID: 78301
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131DE RID: 78302
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040131DF RID: 78303
			public static VerifyTableAction <2>__Verify;
		}
	}
}
