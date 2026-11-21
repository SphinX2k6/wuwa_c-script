using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB7 RID: 32183
	public static class IVisualNovelPerformanceRoleIntroductionVerify
	{
		// Token: 0x0603A262 RID: 238178 RVA: 0x007D6C8C File Offset: 0x007D4E8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceRoleIntroductionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceRoleIntroductionVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelRoleIntroductionSolarSchoolVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200876F RID: 34671
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D01 RID: 85249
			public static VerifyTableAction <0>__Verify;
		}
	}
}
