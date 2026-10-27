using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D3C RID: 23868
	public static class IBvbAiRearrangeDataVerify
	{
		// Token: 0x06028D34 RID: 167220 RVA: 0x0059C518 File Offset: 0x0059A718
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiRearrangeDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiRearrangeDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IBvbAiRearrangeDataVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBvbAiRearrangeDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C9D RID: 31901
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137CA RID: 79818
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
