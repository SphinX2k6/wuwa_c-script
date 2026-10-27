using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F1 RID: 30193
	public static class IVisualNovelTransitionPerformanceSolarSchoolVerify
	{
		// Token: 0x06036FF3 RID: 225267 RVA: 0x00776584 File Offset: 0x00774784
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

		// Token: 0x02007ED7 RID: 32471
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C29 RID: 80937
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
