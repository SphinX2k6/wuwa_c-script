using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A6 RID: 26790
	public static class IBubbleRangeCylinderConfigVerify
	{
		// Token: 0x0602DCD0 RID: 187600 RVA: 0x0064286C File Offset: 0x00640A6C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBubbleRangeCylinderConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBubbleRangeCylinderConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleCylinderConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBubbleRangeCylinderConfigVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBubbleRangeCylinderConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleCylinderConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200856C RID: 34156
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014900 RID: 84224
			public static VerifyTableAction <0>__Verify;
		}
	}
}
