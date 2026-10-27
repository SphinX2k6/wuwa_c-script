using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E9 RID: 17897
	public static class IVariableRewardConfigVerify
	{
		// Token: 0x0601B1AC RID: 111020 RVA: 0x003DCE34 File Offset: 0x003DB034
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVariableRewardConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVariableRewardConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IVariableRewardConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IVariableRewardConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020079C8 RID: 31176
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013364 RID: 78692
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
