using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA7 RID: 23207
	public static class ITimeScheduleGenerateParamsVerify
	{
		// Token: 0x060278B7 RID: 161975 RVA: 0x00570B08 File Offset: 0x0056ED08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeScheduleGenerateParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeScheduleGenerateParamsVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeScheduleGameDailyRefreshVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimeScheduleGenerateParamsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimeScheduleGenerateParamsVerify.<>O.<1>__Verify = new VerifyTableAction(ITimeScheduleRandomSchedulePositionDistributionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C65 RID: 31845
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013779 RID: 79737
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401377A RID: 79738
			public static VerifyTableAction <1>__Verify;
		}
	}
}
