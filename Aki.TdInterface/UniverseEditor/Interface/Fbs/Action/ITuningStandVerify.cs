using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007495 RID: 29845
	public static class ITuningStandVerify
	{
		// Token: 0x06036405 RID: 222213 RVA: 0x0075FFEC File Offset: 0x0075E1EC
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

		// Token: 0x02007EB5 RID: 32437
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BFB RID: 80891
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013BFC RID: 80892
			public static VerifyTableAction <1>__Verify;
		}
	}
}
