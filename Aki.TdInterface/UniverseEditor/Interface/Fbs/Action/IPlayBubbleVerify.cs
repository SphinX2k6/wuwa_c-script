using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744A RID: 29770
	public static class IPlayBubbleVerify
	{
		// Token: 0x06034197 RID: 213399 RVA: 0x00705134 File Offset: 0x00703334
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

		// Token: 0x02008678 RID: 34424
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A63 RID: 84579
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A64 RID: 84580
			public static VerifyTableAction <1>__Verify;
		}
	}
}
