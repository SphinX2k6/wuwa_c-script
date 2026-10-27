using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007156 RID: 29014
	public static class ISlideRailStartVerify
	{
		// Token: 0x060336FD RID: 210685 RVA: 0x006EE360 File Offset: 0x006EC560
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISlideRailStartVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlideRailStartVerify.<>O.<0>__Verify = new VerifyTableAction(ISlideRailFollowConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISlideRailStartVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISlideRailStartVerify.<>O.<1>__Verify = new VerifyTableAction(ISlideRailRTPCParamsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007E66 RID: 32358
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A43 RID: 80451
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A44 RID: 80452
			public static VerifyTableAction <1>__Verify;
		}
	}
}
