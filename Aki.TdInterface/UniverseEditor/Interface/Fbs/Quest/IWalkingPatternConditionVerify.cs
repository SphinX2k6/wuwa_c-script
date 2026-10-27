using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428B RID: 17035
	public static class IWalkingPatternConditionVerify
	{
		// Token: 0x060193CE RID: 103374 RVA: 0x003A030C File Offset: 0x0039E50C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWalkingPatternConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWalkingPatternConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IWalkingPatternConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IWalkingPatternConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007981 RID: 31105
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132FC RID: 78588
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132FD RID: 78589
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
