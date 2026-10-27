using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ACB RID: 15051
	public static class IScoreDisplayParamsVarVerify
	{
		// Token: 0x0601479C RID: 83868 RVA: 0x002FBACC File Offset: 0x002F9CCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IScoreDisplayParamsVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IScoreDisplayParamsVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200787E RID: 30846
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E6 RID: 78054
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
