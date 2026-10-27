using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E7A RID: 15994
	public static class IGetItemQuestConditionVerify
	{
		// Token: 0x06016896 RID: 92310 RVA: 0x00341B2C File Offset: 0x0033FD2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGetItemQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGetItemQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGetItemQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGetItemQuestConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IItemConfigVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078ED RID: 30957
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131A6 RID: 78246
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131A7 RID: 78247
			public static VerifyTableAction <1>__Verify;
		}
	}
}
