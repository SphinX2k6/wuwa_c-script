using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E5C RID: 15964
	public static class IFlagChallengeSystemVarVerify
	{
		// Token: 0x06016799 RID: 92057 RVA: 0x0033FD54 File Offset: 0x0033DF54
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

		// Token: 0x020078E9 RID: 30953
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131A1 RID: 78241
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
