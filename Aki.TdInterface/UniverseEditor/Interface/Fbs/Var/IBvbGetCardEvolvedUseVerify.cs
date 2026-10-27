using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A5F RID: 14943
	public static class IBvbGetCardEvolvedUseVerify
	{
		// Token: 0x0601440F RID: 82959 RVA: 0x002F57CC File Offset: 0x002F39CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbGetCardEvolvedUseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbGetCardEvolvedUseVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007877 RID: 30839
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130DF RID: 78047
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
