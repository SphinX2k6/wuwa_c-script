using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004411 RID: 17425
	public static class IQuestConditionVerify
	{
		// Token: 0x06018D9D RID: 101789 RVA: 0x0038B2F4 File Offset: 0x003894F4
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

		// Token: 0x0200816D RID: 33133
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014281 RID: 82561
			public static VerifyTableAction <0>__Verify;
		}
	}
}
