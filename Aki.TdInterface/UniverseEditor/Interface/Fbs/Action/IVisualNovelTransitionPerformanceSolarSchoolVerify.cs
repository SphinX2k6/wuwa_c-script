using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DFF RID: 32255
	public static class IVisualNovelTransitionPerformanceSolarSchoolVerify
	{
		// Token: 0x0603A498 RID: 238744 RVA: 0x007DA680 File Offset: 0x007D8880
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVisualNovelTransitionPerformanceSolarSchoolVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelTransitionPerformanceSolarSchoolVerify.<>O.<0>__Verify = new VerifyUnionAction(TVisualNovelTransitionConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008773 RID: 34675
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D05 RID: 85253
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
