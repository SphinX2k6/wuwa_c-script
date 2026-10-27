using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C45 RID: 19525
	public static class IHourToHourConditionVerify
	{
		// Token: 0x0601EF36 RID: 126774 RVA: 0x00454690 File Offset: 0x00452890
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

		// Token: 0x02007A60 RID: 31328
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013428 RID: 78888
			public static VerifyTableAction <0>__Verify;
		}
	}
}
