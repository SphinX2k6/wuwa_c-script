using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200635E RID: 25438
	public static class IBvbAiDiscardDataVerify
	{
		// Token: 0x0602B290 RID: 176784 RVA: 0x005E1DA0 File Offset: 0x005DFFA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiDiscardDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiDiscardDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008507 RID: 34055
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014869 RID: 84073
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
