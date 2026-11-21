using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004165 RID: 16741
	public static class ICheckEntityStateQuestConditionVerify
	{
		// Token: 0x06017072 RID: 94322 RVA: 0x00348B30 File Offset: 0x00346D30
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckEntityStateQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEntityStateQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICheckEntityStateQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckEntityStateQuestConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080FC RID: 33020
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401418C RID: 82316
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401418D RID: 82317
			public static VerifyTableAction <1>__Verify;
		}
	}
}
