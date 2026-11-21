using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B5 RID: 17077
	public static class IGetItemQuestConditionVerify
	{
		// Token: 0x06017ECD RID: 97997 RVA: 0x0036A8B0 File Offset: 0x00368AB0
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

		// Token: 0x02008133 RID: 33075
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014204 RID: 82436
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014205 RID: 82437
			public static VerifyTableAction <1>__Verify;
		}
	}
}
