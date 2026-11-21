using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004435 RID: 17461
	public static class IQuestMonsterHealthScoreVerify
	{
		// Token: 0x06019013 RID: 102419 RVA: 0x00391050 File Offset: 0x0038F250
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestMonsterHealthScoreVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestMonsterHealthScoreVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestMonsterHealthScoreVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestMonsterHealthScoreVerify.<>O.<1>__Verify = new VerifyTableAction(IMonsterHpPointTypeConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestMonsterHealthScoreVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuestMonsterHealthScoreVerify.<>O.<2>__Verify = new VerifyTableAction(IMonsterHpPointEntityConfigVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008173 RID: 33139
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014298 RID: 82584
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014299 RID: 82585
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401429A RID: 82586
			public static VerifyTableAction <2>__Verify;
		}
	}
}
