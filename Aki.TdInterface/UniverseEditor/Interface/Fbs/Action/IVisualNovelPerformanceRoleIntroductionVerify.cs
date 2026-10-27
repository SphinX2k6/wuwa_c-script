using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075BE RID: 30142
	public static class IVisualNovelPerformanceRoleIntroductionVerify
	{
		// Token: 0x06036E35 RID: 224821 RVA: 0x007735FC File Offset: 0x007717FC
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

		// Token: 0x02007ED4 RID: 32468
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C26 RID: 80934
			public static VerifyTableAction <0>__Verify;
		}
	}
}
