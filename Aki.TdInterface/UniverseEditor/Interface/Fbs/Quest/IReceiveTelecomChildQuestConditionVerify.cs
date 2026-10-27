using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A2 RID: 16546
	public static class IReceiveTelecomChildQuestConditionVerify
	{
		// Token: 0x0601816C RID: 98668 RVA: 0x00379078 File Offset: 0x00377278
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
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007949 RID: 31049
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013268 RID: 78440
			public static VerifyTableAction <0>__Verify;
		}
	}
}
