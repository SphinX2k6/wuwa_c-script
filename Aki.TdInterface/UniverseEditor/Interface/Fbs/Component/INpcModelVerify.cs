using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005628 RID: 22056
	public static class INpcModelVerify
	{
		// Token: 0x060249F8 RID: 150008 RVA: 0x0050D71C File Offset: 0x0050B91C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INpcModelVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcModelVerify.<>O.<0>__Verify = new VerifyUnionAction(TNpcModelTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false) && verifier.VerifyVectorOfStrings(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BAB RID: 31659
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013642 RID: 79426
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
