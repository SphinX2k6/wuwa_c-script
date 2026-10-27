using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004282 RID: 17026
	public static class IWaitBattleConditionVerify
	{
		// Token: 0x0601935F RID: 103263 RVA: 0x0039F3F8 File Offset: 0x0039D5F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaitBattleConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaitBattleConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200797E RID: 31102
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132F9 RID: 78585
			public static VerifyTableAction <0>__Verify;
		}
	}
}
