using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200401E RID: 16414
	public static class IQuestScheduleConfigVerify
	{
		// Token: 0x06017B7E RID: 97150 RVA: 0x0036BD78 File Offset: 0x00369F78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestScheduleConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IQuestScheduleMainTitleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestScheduleConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestScheduleConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IQuestScheduleSubTitleVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestScheduleConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuestScheduleConfigVerify.<>O.<2>__Verify = new VerifyTableAction(ITrackTargetVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IQuestScheduleConfigVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IQuestScheduleConfigVerify.<>O.<3>__Verify = new VerifyTableAction(ILevelPlayTrackRadiusVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007935 RID: 31029
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013245 RID: 78405
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013246 RID: 78406
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013247 RID: 78407
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013248 RID: 78408
			public static VerifyTableAction <3>__Verify;
		}
	}
}
