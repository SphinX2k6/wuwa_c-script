using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005937 RID: 22839
	public static class ISlideRailComponentVerify
	{
		// Token: 0x06026A51 RID: 158289 RVA: 0x005528D0 File Offset: 0x00550AD0
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

		// Token: 0x02007C30 RID: 31792
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013719 RID: 79641
			public static VerifyTableAction <0>__Verify;
		}
	}
}
