using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E1 RID: 22753
	public static class IGuideLineCreatorComponentVerify
	{
		// Token: 0x06024F47 RID: 151367 RVA: 0x00512C8C File Offset: 0x00510E8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGuideLineCreatorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGuideLineCreatorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IColorChangeStrategyOfRGBVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGuideLineCreatorComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGuideLineCreatorComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IGuideLineCreatorScanOptionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020083B0 RID: 33712
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014624 RID: 83492
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014625 RID: 83493
			public static VerifyTableAction <1>__Verify;
		}
	}
}
