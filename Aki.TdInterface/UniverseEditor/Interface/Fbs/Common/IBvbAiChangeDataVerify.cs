using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D21 RID: 23841
	public static class IBvbAiChangeDataVerify
	{
		// Token: 0x06028BDD RID: 166877 RVA: 0x0059866C File Offset: 0x0059686C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiChangeDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiChangeDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C94 RID: 31892
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137C1 RID: 79809
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
