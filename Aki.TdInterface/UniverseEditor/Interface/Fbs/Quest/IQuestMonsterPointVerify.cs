using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF7 RID: 16375
	public static class IQuestMonsterPointVerify
	{
		// Token: 0x060179CF RID: 96719 RVA: 0x003680B4 File Offset: 0x003662B4
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

		// Token: 0x0200792D RID: 31021
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013238 RID: 78392
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013239 RID: 78393
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401323A RID: 78394
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401323B RID: 78395
			public static VerifyTableAction <3>__Verify;
		}
	}
}
