using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DE1 RID: 15841
	public static class IDoInteractQuestConditionVerify
	{
		// Token: 0x06016216 RID: 90646 RVA: 0x00332BD0 File Offset: 0x00330DD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDoInteractQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDoInteractQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDoInteractQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDoInteractQuestConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IAddInteractOptionVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078D4 RID: 30932
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013176 RID: 78198
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013177 RID: 78199
			public static VerifyTableAction <1>__Verify;
		}
	}
}
