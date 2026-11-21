using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004288 RID: 17032
	public static class IFinishSurvivorsRougeConditionVerify
	{
		// Token: 0x06017CEA RID: 97514 RVA: 0x00366324 File Offset: 0x00364524
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishSurvivorsRougeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishSurvivorsRougeConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishSurvivorsRougeConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishSurvivorsRougeConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TSurvivorsRougeConditionStepVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 12;
						short valueVOffset2 = 14;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IFinishSurvivorsRougeConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFinishSurvivorsRougeConditionVerify.<>O.<2>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200812B RID: 33067
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141F4 RID: 82420
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141F5 RID: 82421
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040141F6 RID: 82422
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
