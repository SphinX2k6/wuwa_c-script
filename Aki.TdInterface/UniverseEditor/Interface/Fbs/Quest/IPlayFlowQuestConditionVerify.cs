using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E7 RID: 17383
	public static class IPlayFlowQuestConditionVerify
	{
		// Token: 0x06018B1E RID: 101150 RVA: 0x00385394 File Offset: 0x00383594
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayFlowQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayFlowQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPlayFlowQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlayFlowQuestConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008162 RID: 33122
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014268 RID: 82536
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014269 RID: 82537
			public static VerifyTableAction <1>__Verify;
		}
	}
}
