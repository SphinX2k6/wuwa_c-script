using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E50 RID: 15952
	public static class IFinishTetrisVerify
	{
		// Token: 0x0601671A RID: 91930 RVA: 0x0033E860 File Offset: 0x0033CA60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishTetrisVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishTetrisVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset = 10;
					short valueVOffset = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishTetrisVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishTetrisVerify.<>O.<1>__Verify = new VerifyUnionAction(TTetrisPlayModeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false))
					{
						short offsetId2 = 20;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFinishTetrisVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFinishTetrisVerify.<>O.<2>__Verify = new VerifyTableAction(ITetrisIndexedBoardVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyVectorOfStrings(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
						{
							short typeIdVOffset2 = 24;
							short valueVOffset2 = 26;
							VerifyUnionAction verifyAction4;
							if ((verifyAction4 = IFinishTetrisVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IFinishTetrisVerify.<>O.<3>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
							}
							if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction4, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								short typeIdVOffset3 = 28;
								short valueVOffset3 = 30;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IFinishTetrisVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IFinishTetrisVerify.<>O.<3>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction5, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
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

		// Token: 0x020078E6 RID: 30950
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013199 RID: 78233
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401319A RID: 78234
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x0401319B RID: 78235
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401319C RID: 78236
			public static VerifyUnionAction <3>__Verify;
		}
	}
}
