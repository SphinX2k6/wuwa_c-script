using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535B RID: 21339
	public static class IGuideLineCreatorComponentVerify
	{
		// Token: 0x06022E93 RID: 142995 RVA: 0x004D5DB8 File Offset: 0x004D3FB8
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

		// Token: 0x02007B51 RID: 31569
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401359F RID: 79263
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135A0 RID: 79264
			public static VerifyTableAction <1>__Verify;
		}
	}
}
