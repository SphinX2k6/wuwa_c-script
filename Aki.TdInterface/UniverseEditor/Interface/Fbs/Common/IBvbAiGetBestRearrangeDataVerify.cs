using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D33 RID: 23859
	public static class IBvbAiGetBestRearrangeDataVerify
	{
		// Token: 0x06028CBC RID: 167100 RVA: 0x0059AE14 File Offset: 0x00599014
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiGetBestRearrangeDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiGetBestRearrangeDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IBvbAiGetBestRearrangeDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBvbAiGetBestRearrangeDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C9A RID: 31898
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137C7 RID: 79815
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
