using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200403C RID: 16444
	public static class IQuestScheduleSubTitleVerify
	{
		// Token: 0x06017CDD RID: 97501 RVA: 0x0036F418 File Offset: 0x0036D618
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestScheduleSubTitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleSubTitleVerify.<>O.<0>__Verify = new VerifyUnionAction(TQuestScheduleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestScheduleSubTitleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestScheduleSubTitleVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
					{
						short offsetId2 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestScheduleSubTitleVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuestScheduleSubTitleVerify.<>O.<2>__Verify = new VerifyTableAction(IProgressBarVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IQuestScheduleSubTitleVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IQuestScheduleSubTitleVerify.<>O.<3>__Verify = new VerifyTableAction(IConditionTextVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
							{
								short offsetId4 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IQuestScheduleSubTitleVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IQuestScheduleSubTitleVerify.<>O.<4>__Verify = new VerifyTableAction(ICustomPlaceholderBindingProgressVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction5, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200793B RID: 31035
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401324E RID: 78414
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401324F RID: 78415
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013250 RID: 78416
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013251 RID: 78417
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013252 RID: 78418
			public static VerifyTableAction <4>__Verify;
		}
	}
}
