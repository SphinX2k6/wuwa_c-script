using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004072 RID: 16498
	public static class IReadPhoneMessageQuestConditionVerify
	{
		// Token: 0x06017FBA RID: 98234 RVA: 0x00376044 File Offset: 0x00374244
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

		// Token: 0x02007947 RID: 31047
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013264 RID: 78436
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013265 RID: 78437
			public static VerifyTableAction <1>__Verify;
		}
	}
}
