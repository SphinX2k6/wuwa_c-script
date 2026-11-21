using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200446B RID: 17515
	public static class IQuestScheduleMeetConditionVerify
	{
		// Token: 0x060192A8 RID: 103080 RVA: 0x0039724C File Offset: 0x0039544C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestScheduleMeetConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleMeetConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200817F RID: 33151
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142AE RID: 82606
			public static VerifyTableAction <0>__Verify;
		}
	}
}
