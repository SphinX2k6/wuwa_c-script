using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200736C RID: 29548
	public static class IOpenGreatSwordChallengeResultVerify
	{
		// Token: 0x06033924 RID: 211236 RVA: 0x006F3560 File Offset: 0x006F1760
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenGreatSwordChallengeResultVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenGreatSwordChallengeResultVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200865A RID: 34394
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A36 RID: 84534
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
