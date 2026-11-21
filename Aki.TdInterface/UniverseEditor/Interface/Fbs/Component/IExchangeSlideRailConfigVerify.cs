using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005732 RID: 22322
	public static class IExchangeSlideRailConfigVerify
	{
		// Token: 0x06023EA1 RID: 147105 RVA: 0x004EFF04 File Offset: 0x004EE104
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExchangeSlideRailConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExchangeSlideRailConfigVerify.<>O.<0>__Verify = new VerifyTableAction(INextSlideRailVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008365 RID: 33637
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145B3 RID: 83379
			public static VerifyTableAction <0>__Verify;
		}
	}
}
