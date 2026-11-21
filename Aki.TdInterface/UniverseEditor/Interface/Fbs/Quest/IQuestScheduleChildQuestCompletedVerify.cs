using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004459 RID: 17497
	public static class IQuestScheduleChildQuestCompletedVerify
	{
		// Token: 0x060191D1 RID: 102865 RVA: 0x00395168 File Offset: 0x00393368
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

		// Token: 0x0200817B RID: 33147
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142A7 RID: 82599
			public static VerifyTableAction <0>__Verify;
		}
	}
}
