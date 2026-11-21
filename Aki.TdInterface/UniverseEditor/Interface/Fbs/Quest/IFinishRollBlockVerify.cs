using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004285 RID: 17029
	public static class IFinishRollBlockVerify
	{
		// Token: 0x06017CBC RID: 97468 RVA: 0x003658A0 File Offset: 0x00363AA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishRollBlockVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishRollBlockVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
				{
					short typeIdVOffset = 22;
					short valueVOffset = 24;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishRollBlockVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishRollBlockVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 26;
						short valueVOffset2 = 28;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IFinishRollBlockVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IFinishRollBlockVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false))
						{
							short offsetId2 = 30;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFinishRollBlockVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IFinishRollBlockVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction4, false))
							{
								short offsetId3 = 32;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IFinishRollBlockVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IFinishRollBlockVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction5, false))
								{
									short offsetId4 = 34;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IFinishRollBlockVerify.<>O.<2>__Verify) == null)
									{
										verifyAction6 = (IFinishRollBlockVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction6, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false))
									{
										return verifier.VerifyTableEnd(tablePos);
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200812A RID: 33066
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141F1 RID: 82417
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141F2 RID: 82418
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040141F3 RID: 82419
			public static VerifyTableAction <2>__Verify;
		}
	}
}
