using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200415F RID: 16735
	public static class ICheckClientConditionGroupQuestConditionVerify
	{
		// Token: 0x06017038 RID: 94264 RVA: 0x003482DC File Offset: 0x003464DC
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

		// Token: 0x020080FA RID: 33018
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401418A RID: 82314
			public static VerifyTableAction <0>__Verify;
		}
	}
}
