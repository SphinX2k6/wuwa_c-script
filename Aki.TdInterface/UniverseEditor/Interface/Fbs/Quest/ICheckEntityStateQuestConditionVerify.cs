using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D4E RID: 15694
	public static class ICheckEntityStateQuestConditionVerify
	{
		// Token: 0x06015B3A RID: 88890 RVA: 0x003218B8 File Offset: 0x0031FAB8
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

		// Token: 0x020078B8 RID: 30904
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013130 RID: 78128
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013131 RID: 78129
			public static VerifyTableAction <1>__Verify;
		}
	}
}
