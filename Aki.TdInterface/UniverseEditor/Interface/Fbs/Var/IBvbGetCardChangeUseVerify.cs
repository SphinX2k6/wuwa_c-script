using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E37 RID: 15927
	public static class IBvbGetCardChangeUseVerify
	{
		// Token: 0x0601570E RID: 87822 RVA: 0x0031852C File Offset: 0x0031672C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbGetCardChangeUseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbGetCardChangeUseVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B4 RID: 32948
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014133 RID: 82227
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
