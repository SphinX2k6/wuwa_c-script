using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007378 RID: 29560
	public static class IOpenMotorRaceChallengeResultWithReturnVerify
	{
		// Token: 0x060339CE RID: 211406 RVA: 0x006F52F0 File Offset: 0x006F34F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenMotorRaceChallengeResultWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenMotorRaceChallengeResultWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 16;
					short valueVOffset2 = 18;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IOpenMotorRaceChallengeResultWithReturnVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IOpenMotorRaceChallengeResultWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200865E RID: 34398
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A3B RID: 84539
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
