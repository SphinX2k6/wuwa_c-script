using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA5 RID: 32165
	public static class IVisualNovelPerformanceExitVerify
	{
		// Token: 0x0603A17D RID: 237949 RVA: 0x007D4CA8 File Offset: 0x007D2EA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceExitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceExitVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelRoleConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200876A RID: 34666
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CF9 RID: 85241
			public static VerifyTableAction <0>__Verify;
		}
	}
}
