using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200601F RID: 24607
	public static class ISwitcherComponentVerify
	{
		// Token: 0x060297E4 RID: 169956 RVA: 0x005A9B08 File Offset: 0x005A7D08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISwitcherComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISwitcherComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISwitcherComponentVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISwitcherComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084BB RID: 33979
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147EA RID: 83946
			public static VerifyTableAction <0>__Verify;
		}
	}
}
