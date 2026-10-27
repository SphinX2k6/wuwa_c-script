using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA6 RID: 16294
	public static class IPlayFlowQuestConditionVerify
	{
		// Token: 0x0601748F RID: 95375 RVA: 0x0035B77C File Offset: 0x0035997C
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

		// Token: 0x0200791B RID: 31003
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013206 RID: 78342
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013207 RID: 78343
			public static VerifyTableAction <1>__Verify;
		}
	}
}
