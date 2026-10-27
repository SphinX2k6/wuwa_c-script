using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004012 RID: 16402
	public static class IQuestRewardConfigVerify
	{
		// Token: 0x06017AD5 RID: 96981 RVA: 0x0036A31C File Offset: 0x0036851C
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

		// Token: 0x02007932 RID: 31026
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013241 RID: 78401
			public static VerifyTableAction <0>__Verify;
		}
	}
}
