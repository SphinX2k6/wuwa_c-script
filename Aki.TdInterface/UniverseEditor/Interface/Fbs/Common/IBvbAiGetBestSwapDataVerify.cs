using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D39 RID: 23865
	public static class IBvbAiGetBestSwapDataVerify
	{
		// Token: 0x06028D0C RID: 167180 RVA: 0x0059BD6C File Offset: 0x00599F6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiGetBestSwapDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiGetBestSwapDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IBvbAiGetBestSwapDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBvbAiGetBestSwapDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C9C RID: 31900
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137C9 RID: 79817
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
