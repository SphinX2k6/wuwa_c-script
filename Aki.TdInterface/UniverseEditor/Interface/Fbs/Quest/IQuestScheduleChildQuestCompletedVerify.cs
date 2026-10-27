using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004018 RID: 16408
	public static class IQuestScheduleChildQuestCompletedVerify
	{
		// Token: 0x06017B38 RID: 97080 RVA: 0x0036B374 File Offset: 0x00369574
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false))
			{
				short offsetId = 20;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestScheduleChildQuestCompletedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleChildQuestCompletedVerify.<>O.<0>__Verify = new VerifyTableAction(ITitlePreStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007934 RID: 31028
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013244 RID: 78404
			public static VerifyTableAction <0>__Verify;
		}
	}
}
