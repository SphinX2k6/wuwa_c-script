using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F6 RID: 24822
	public static class ITriggerExitConfigVerify
	{
		// Token: 0x0602A11F RID: 172319 RVA: 0x005BE27C File Offset: 0x005BC47C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITriggerExitConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerExitConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITriggerExitConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITriggerExitConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020084DD RID: 34013
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014831 RID: 84017
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014832 RID: 84018
			public static VerifyTableAction <1>__Verify;
		}
	}
}
