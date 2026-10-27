using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E47 RID: 15943
	public static class IFinishRoleTowerConditionVerify
	{
		// Token: 0x06016617 RID: 91671 RVA: 0x0033B574 File Offset: 0x00339774
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishRoleTowerConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishRoleTowerConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishRoleTowerConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishRoleTowerConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TRoleTowerConditionStepVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 12;
						short valueVOffset2 = 14;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IFinishRoleTowerConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFinishRoleTowerConditionVerify.<>O.<2>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
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

		// Token: 0x020078E3 RID: 30947
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013190 RID: 78224
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013191 RID: 78225
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04013192 RID: 78226
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
