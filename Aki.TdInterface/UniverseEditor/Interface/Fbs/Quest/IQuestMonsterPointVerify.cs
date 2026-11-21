using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004438 RID: 17464
	public static class IQuestMonsterPointVerify
	{
		// Token: 0x06019068 RID: 102504 RVA: 0x00391EA8 File Offset: 0x003900A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestMonsterPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestMonsterPointVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short offsetId = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestMonsterPointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestMonsterPointVerify.<>O.<1>__Verify = new VerifyTableAction(IMonsterPointTypeConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 20;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestMonsterPointVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuestMonsterPointVerify.<>O.<2>__Verify = new VerifyTableAction(IMonsterPointEntityConfigVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
						{
							short offsetId3 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IQuestMonsterPointVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IQuestMonsterPointVerify.<>O.<3>__Verify = new VerifyTableAction(IBindCrossSceneSyncKillMonsterVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008174 RID: 33140
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401429B RID: 82587
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401429C RID: 82588
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401429D RID: 82589
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401429E RID: 82590
			public static VerifyTableAction <3>__Verify;
		}
	}
}
