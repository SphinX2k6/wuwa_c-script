using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004453 RID: 17491
	public static class IQuestRewardConfigVerify
	{
		// Token: 0x0601916E RID: 102766 RVA: 0x00394110 File Offset: 0x00392310
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestRewardConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestRewardConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IItemGetUiConfigSpecialQuestVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008179 RID: 33145
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142A4 RID: 82596
			public static VerifyTableAction <0>__Verify;
		}
	}
}
