using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007922 RID: 31010
	public static class ISlideRailStartVerify
	{
		// Token: 0x060369A7 RID: 223655 RVA: 0x0074EB6C File Offset: 0x0074CD6C
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

		// Token: 0x020086FC RID: 34556
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B18 RID: 84760
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014B19 RID: 84761
			public static VerifyTableAction <1>__Verify;
		}
	}
}
