using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B8 RID: 17080
	public static class IGetSkillQuestConditionVerify
	{
		// Token: 0x06017EEB RID: 98027 RVA: 0x0036AC58 File Offset: 0x00368E58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGetSkillQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGetSkillQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008134 RID: 33076
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014206 RID: 82438
			public static VerifyTableAction <0>__Verify;
		}
	}
}
