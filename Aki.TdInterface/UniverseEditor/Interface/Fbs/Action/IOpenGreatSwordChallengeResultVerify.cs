using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C08 RID: 27656
	public static class IOpenGreatSwordChallengeResultVerify
	{
		// Token: 0x06030A04 RID: 199172 RVA: 0x00699BCC File Offset: 0x00697DCC
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

		// Token: 0x02007DD1 RID: 32209
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013975 RID: 80245
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
