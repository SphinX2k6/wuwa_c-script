using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD0 RID: 16336
	public static class IQuestConditionVerify
	{
		// Token: 0x0601770A RID: 96010 RVA: 0x003615CC File Offset: 0x0035F7CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007926 RID: 31014
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401321E RID: 78366
			public static VerifyTableAction <0>__Verify;
		}
	}
}
