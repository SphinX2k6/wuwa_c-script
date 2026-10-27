using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD7 RID: 27863
	public static class IPlayBubbleVerify
	{
		// Token: 0x060311D2 RID: 201170 RVA: 0x006AA078 File Offset: 0x006A8278
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayBubbleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayBubbleVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPlayBubbleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlayBubbleVerify.<>O.<1>__Verify = new VerifyTableAction(IBubbleRangeCylinderConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DED RID: 32237
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139A0 RID: 80288
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139A1 RID: 80289
			public static VerifyTableAction <1>__Verify;
		}
	}
}
