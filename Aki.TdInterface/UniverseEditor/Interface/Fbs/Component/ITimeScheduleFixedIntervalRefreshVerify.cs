using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A8 RID: 24744
	public static class ITimeScheduleFixedIntervalRefreshVerify
	{
		// Token: 0x06029DE5 RID: 171493 RVA: 0x005B730C File Offset: 0x005B550C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeScheduleFixedIntervalRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeScheduleFixedIntervalRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeScheduleRefreshIntervalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITimeScheduleFixedIntervalRefreshVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITimeScheduleFixedIntervalRefreshVerify.<>O.<1>__Verify = new VerifyTableAction(ITimeScheduleFixedPositionsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084D3 RID: 34003
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401481A RID: 83994
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401481B RID: 83995
			public static VerifyTableAction <1>__Verify;
		}
	}
}
