using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005138 RID: 20792
	public static class IHourToHourConditionVerify
	{
		// Token: 0x06020B3A RID: 133946 RVA: 0x00487F6C File Offset: 0x0048616C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHourToHourConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHourToHourConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IHourVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHourToHourConditionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IHourToHourConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IHourVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082B2 RID: 33458
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014498 RID: 83096
			public static VerifyTableAction <0>__Verify;
		}
	}
}
