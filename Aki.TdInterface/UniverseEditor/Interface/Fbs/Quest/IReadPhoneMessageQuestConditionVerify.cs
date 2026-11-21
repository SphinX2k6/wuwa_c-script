using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044B3 RID: 17587
	public static class IReadPhoneMessageQuestConditionVerify
	{
		// Token: 0x06019653 RID: 104019 RVA: 0x0039FE7C File Offset: 0x0039E07C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReadPhoneMessageQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReadPhoneMessageQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IReadPhoneMessageQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IReadPhoneMessageQuestConditionVerify.<>O.<1>__Verify = new VerifyTableAction(ICompleteMessageQuestConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200818E RID: 33166
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142C7 RID: 82631
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040142C8 RID: 82632
			public static VerifyTableAction <1>__Verify;
		}
	}
}
