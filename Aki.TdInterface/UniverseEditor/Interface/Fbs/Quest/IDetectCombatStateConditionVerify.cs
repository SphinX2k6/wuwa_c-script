using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200420D RID: 16909
	public static class IDetectCombatStateConditionVerify
	{
		// Token: 0x060177B5 RID: 96181 RVA: 0x0035A6C0 File Offset: 0x003588C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDetectCombatStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDetectCombatStateConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008117 RID: 33047
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141D1 RID: 82385
			public static VerifyTableAction <0>__Verify;
		}
	}
}
