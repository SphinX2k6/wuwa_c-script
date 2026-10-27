using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A12 RID: 23058
	public static class ISwitcherComponentVerify
	{
		// Token: 0x0602726C RID: 160364 RVA: 0x00562B44 File Offset: 0x00560D44
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

		// Token: 0x02007C4C RID: 31820
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013746 RID: 79686
			public static VerifyTableAction <0>__Verify;
		}
	}
}
