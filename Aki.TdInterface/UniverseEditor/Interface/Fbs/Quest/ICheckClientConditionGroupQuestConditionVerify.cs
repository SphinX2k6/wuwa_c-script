using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D48 RID: 15688
	public static class ICheckClientConditionGroupQuestConditionVerify
	{
		// Token: 0x06015B00 RID: 88832 RVA: 0x00321064 File Offset: 0x0031F264
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckClientConditionGroupQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckClientConditionGroupQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICheckClientConditionGroupQuestConditionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICheckClientConditionGroupQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078B6 RID: 30902
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401312E RID: 78126
			public static VerifyTableAction <0>__Verify;
		}
	}
}
