using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004549 RID: 17737
	public static class IScheduleTimeConditionVerify
	{
		// Token: 0x06019B17 RID: 105239 RVA: 0x003A87C4 File Offset: 0x003A69C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IScheduleTimeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IScheduleTimeConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IScheduleTimeConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IScheduleTimeConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IBaseTimeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IScheduleTimeConditionVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IScheduleTimeConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IBaseTimeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008198 RID: 33176
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142D7 RID: 82647
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040142D8 RID: 82648
			public static VerifyTableAction <1>__Verify;
		}
	}
}
