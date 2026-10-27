using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592E RID: 22830
	public static class ISlidePerformComponentVerify
	{
		// Token: 0x06026A03 RID: 158211 RVA: 0x00551FB0 File Offset: 0x005501B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISlidePerformComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlidePerformComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IExchangeSlideRailConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISlidePerformComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISlidePerformComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ISlopeSlidePerformVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C2F RID: 31791
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013717 RID: 79639
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013718 RID: 79640
			public static VerifyTableAction <1>__Verify;
		}
	}
}
