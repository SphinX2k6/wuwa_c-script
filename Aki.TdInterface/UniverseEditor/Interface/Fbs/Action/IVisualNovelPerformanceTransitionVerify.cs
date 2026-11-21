using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC3 RID: 32195
	public static class IVisualNovelPerformanceTransitionVerify
	{
		// Token: 0x0603A2E8 RID: 238312 RVA: 0x007D7CD4 File Offset: 0x007D5ED4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceTransitionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceTransitionVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelTransitionPerformanceSolarSchoolVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008772 RID: 34674
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D04 RID: 85252
			public static VerifyTableAction <0>__Verify;
		}
	}
}
