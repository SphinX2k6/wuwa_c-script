using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC0 RID: 15808
	public static class ICrossSceneSyncKillMonsterVerify
	{
		// Token: 0x060160F0 RID: 90352 RVA: 0x003309D4 File Offset: 0x0032EBD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICrossSceneSyncKillMonsterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICrossSceneSyncKillMonsterVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078CE RID: 30926
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401316F RID: 78191
			public static VerifyTableAction <0>__Verify;
		}
	}
}
