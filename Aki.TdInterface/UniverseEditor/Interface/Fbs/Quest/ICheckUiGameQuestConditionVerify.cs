using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419E RID: 16798
	public static class ICheckUiGameQuestConditionVerify
	{
		// Token: 0x0601724E RID: 94798 RVA: 0x0034CC40 File Offset: 0x0034AE40
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckUiGameQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckUiGameQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008104 RID: 33028
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014198 RID: 82328
			public static VerifyTableAction <0>__Verify;
		}
	}
}
