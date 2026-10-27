using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D36 RID: 23862
	public static class IBvbAiGetBestReplaceDataVerify
	{
		// Token: 0x06028CE4 RID: 167140 RVA: 0x0059B5C0 File Offset: 0x005997C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiGetBestReplaceDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiGetBestReplaceDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IBvbAiGetBestReplaceDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBvbAiGetBestReplaceDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C9B RID: 31899
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137C8 RID: 79816
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
