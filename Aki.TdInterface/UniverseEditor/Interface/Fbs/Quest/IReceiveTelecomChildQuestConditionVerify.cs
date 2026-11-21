using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E3 RID: 17635
	public static class IReceiveTelecomChildQuestConditionVerify
	{
		// Token: 0x0601980D RID: 104461 RVA: 0x003A2FA8 File Offset: 0x003A11A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReceiveTelecomChildQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReceiveTelecomChildQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008190 RID: 33168
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142CB RID: 82635
			public static VerifyTableAction <0>__Verify;
		}
	}
}
