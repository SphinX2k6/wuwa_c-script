using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCC RID: 28108
	public static class IFaceExpressionConfigDataVerify
	{
		// Token: 0x0603084C RID: 198732 RVA: 0x00696F28 File Offset: 0x00695128
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFaceExpressionConfigDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFaceExpressionConfigDataVerify.<>O.<0>__Verify = new VerifyUnionAction(IFaceExpressionConfig_UnionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFaceExpressionConfigDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFaceExpressionConfigDataVerify.<>O.<0>__Verify = new VerifyUnionAction(IFaceExpressionConfig_UnionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020085D7 RID: 34263
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401498B RID: 84363
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
