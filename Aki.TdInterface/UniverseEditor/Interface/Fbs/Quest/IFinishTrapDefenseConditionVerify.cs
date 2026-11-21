using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428E RID: 17038
	public static class IFinishTrapDefenseConditionVerify
	{
		// Token: 0x06017D75 RID: 97653 RVA: 0x00367E48 File Offset: 0x00366048
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishTrapDefenseConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishTrapDefenseConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishTrapDefenseConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishTrapDefenseConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TTrapDefenseConditionStepVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 12;
						short valueVOffset2 = 14;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IFinishTrapDefenseConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IFinishTrapDefenseConditionVerify.<>O.<2>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200812D RID: 33069
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141FB RID: 82427
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141FC RID: 82428
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040141FD RID: 82429
			public static VerifyUnionAction <2>__Verify;
		}
	}
}
