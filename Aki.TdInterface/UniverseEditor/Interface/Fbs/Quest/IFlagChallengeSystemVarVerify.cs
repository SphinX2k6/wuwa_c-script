using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004297 RID: 17047
	public static class IFlagChallengeSystemVarVerify
	{
		// Token: 0x06017DC0 RID: 97728 RVA: 0x00368884 File Offset: 0x00366A84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFlagChallengeSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlagChallengeSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200812F RID: 33071
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141FF RID: 82431
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
