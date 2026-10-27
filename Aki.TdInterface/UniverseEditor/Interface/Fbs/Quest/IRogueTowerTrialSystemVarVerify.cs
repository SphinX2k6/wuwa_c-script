using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040BA RID: 16570
	public static class IRogueTowerTrialSystemVarVerify
	{
		// Token: 0x06018249 RID: 98889 RVA: 0x0037AE4C File Offset: 0x0037904C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRogueTowerTrialSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRogueTowerTrialSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200794C RID: 31052
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401326D RID: 78445
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
