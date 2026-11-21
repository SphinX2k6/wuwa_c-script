using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004162 RID: 16738
	public static class ICheckConditionGroupQuestConditionVerify
	{
		// Token: 0x06017052 RID: 94290 RVA: 0x00348670 File Offset: 0x00346870
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckConditionGroupQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckConditionGroupQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICheckConditionGroupQuestConditionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICheckConditionGroupQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080FB RID: 33019
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401418B RID: 82315
			public static VerifyTableAction <0>__Verify;
		}
	}
}
