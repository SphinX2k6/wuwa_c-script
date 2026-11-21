using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C88 RID: 31880
	public static class ITuningStandVerify
	{
		// Token: 0x060397F2 RID: 235506 RVA: 0x007C2DA8 File Offset: 0x007C0FA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITuningStandVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITuningStandVerify.<>O.<0>__Verify = new VerifyTableAction(ITuningStandBubbleConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false))
				{
					short offsetId2 = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITuningStandVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITuningStandVerify.<>O.<1>__Verify = new VerifyTableAction(ITuningStandGridBoardVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200874F RID: 34639
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CD5 RID: 85205
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CD6 RID: 85206
			public static VerifyTableAction <1>__Verify;
		}
	}
}
