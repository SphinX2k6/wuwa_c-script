using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E02 RID: 32258
	public static class IVisualNovelTransitionTimeVerify
	{
		// Token: 0x0603A4BA RID: 238778 RVA: 0x007DAA90 File Offset: 0x007D8C90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelTransitionTimeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelTransitionTimeVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelDateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008774 RID: 34676
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D06 RID: 85254
			public static VerifyTableAction <0>__Verify;
		}
	}
}
