using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C32 RID: 27698
	public static class IOpenSoaringChallengeResultWithReturnVerify
	{
		// Token: 0x06030BD5 RID: 199637 RVA: 0x0069E4E0 File Offset: 0x0069C6E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenSoaringChallengeResultWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenSoaringChallengeResultWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 16;
					short valueVOffset2 = 18;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IOpenSoaringChallengeResultWithReturnVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IOpenSoaringChallengeResultWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DDB RID: 32219
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013982 RID: 80258
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
