using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ECD RID: 16077
	public static class IScoreDisplayParamsVarVerify
	{
		// Token: 0x06015C46 RID: 89158 RVA: 0x00321D5C File Offset: 0x0031FF5C
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

		// Token: 0x020080C1 RID: 32961
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014141 RID: 82241
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
