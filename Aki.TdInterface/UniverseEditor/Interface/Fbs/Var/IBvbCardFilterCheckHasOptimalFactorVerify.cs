using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E0D RID: 15885
	public static class IBvbCardFilterCheckHasOptimalFactorVerify
	{
		// Token: 0x060155A3 RID: 87459 RVA: 0x00315C10 File Offset: 0x00313E10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbCardFilterCheckHasOptimalFactorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbCardFilterCheckHasOptimalFactorVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B1 RID: 32945
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014130 RID: 82224
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
