using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D42 RID: 23874
	public static class IBvbAiSwapDataVerify
	{
		// Token: 0x06028D79 RID: 167289 RVA: 0x0059D150 File Offset: 0x0059B350
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiSwapDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiSwapDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IBvbAiSwapDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBvbAiSwapDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C9F RID: 31903
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137CC RID: 79820
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
