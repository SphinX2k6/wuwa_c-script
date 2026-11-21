using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F44 RID: 24388
	public static class ISlideRailComponentVerify
	{
		// Token: 0x06028FBB RID: 167867 RVA: 0x0059953C File Offset: 0x0059773C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISlideRailComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlideRailComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IExchangeSlideRailConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200849F RID: 33951
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147BB RID: 83899
			public static VerifyTableAction <0>__Verify;
		}
	}
}
