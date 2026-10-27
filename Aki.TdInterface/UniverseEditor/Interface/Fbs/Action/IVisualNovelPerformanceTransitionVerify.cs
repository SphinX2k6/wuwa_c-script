using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CA RID: 30154
	public static class IVisualNovelPerformanceTransitionVerify
	{
		// Token: 0x06036EB9 RID: 224953 RVA: 0x0077454C File Offset: 0x0077274C
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

		// Token: 0x02007ED6 RID: 32470
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C28 RID: 80936
			public static VerifyTableAction <0>__Verify;
		}
	}
}
