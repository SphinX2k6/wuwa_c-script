using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D2D RID: 23853
	public static class IBvbAiEvolutionDataVerify
	{
		// Token: 0x06028C6C RID: 167020 RVA: 0x00599EBC File Offset: 0x005980BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiEvolutionDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiEvolutionDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IBvbAiEvolutionDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBvbAiEvolutionDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C98 RID: 31896
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137C5 RID: 79813
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
