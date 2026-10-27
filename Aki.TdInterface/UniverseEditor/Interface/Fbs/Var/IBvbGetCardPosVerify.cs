using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A62 RID: 14946
	public static class IBvbGetCardPosVerify
	{
		// Token: 0x0601442C RID: 82988 RVA: 0x002F5C58 File Offset: 0x002F3E58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbGetCardPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbGetCardPosVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007878 RID: 30840
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E0 RID: 78048
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
