using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BD0 RID: 19408
	public static class ICompareVarConditionVerify
	{
		// Token: 0x0601EA48 RID: 125512 RVA: 0x0044932C File Offset: 0x0044752C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICompareVarConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompareVarConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 12;
					short valueVOffset2 = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICompareVarConditionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICompareVarConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A57 RID: 31319
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401341F RID: 78879
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
