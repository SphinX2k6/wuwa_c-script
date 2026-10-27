using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA8 RID: 15784
	public static class ICompareVarInChildQuestVerify
	{
		// Token: 0x06015F2B RID: 89899 RVA: 0x0032B6A0 File Offset: 0x003298A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICompareVarInChildQuestVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompareVarInChildQuestVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICompareVarInChildQuestVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICompareVarInChildQuestVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078C7 RID: 30919
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401314E RID: 78158
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
