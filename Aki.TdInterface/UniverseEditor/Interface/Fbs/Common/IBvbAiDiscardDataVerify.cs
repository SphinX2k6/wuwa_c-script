using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D27 RID: 23847
	public static class IBvbAiDiscardDataVerify
	{
		// Token: 0x06028C26 RID: 166950 RVA: 0x00599330 File Offset: 0x00597530
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbAiDiscardDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbAiDiscardDataVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C96 RID: 31894
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137C3 RID: 79811
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
