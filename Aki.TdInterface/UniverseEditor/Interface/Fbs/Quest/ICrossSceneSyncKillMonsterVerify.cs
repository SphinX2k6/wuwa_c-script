using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D7 RID: 16855
	public static class ICrossSceneSyncKillMonsterVerify
	{
		// Token: 0x06017629 RID: 95785 RVA: 0x00357D5C File Offset: 0x00355F5C
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

		// Token: 0x02008112 RID: 33042
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141CB RID: 82379
			public static VerifyTableAction <0>__Verify;
		}
	}
}
