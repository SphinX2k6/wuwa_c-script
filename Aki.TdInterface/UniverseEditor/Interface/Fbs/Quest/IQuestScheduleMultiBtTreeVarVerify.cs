using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200446E RID: 17518
	public static class IQuestScheduleMultiBtTreeVarVerify
	{
		// Token: 0x060192D2 RID: 103122 RVA: 0x00397A04 File Offset: 0x00395C04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestScheduleMultiBtTreeVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleMultiBtTreeVarVerify.<>O.<0>__Verify = new VerifyTableAction(IWordArtConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008180 RID: 33152
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142AF RID: 82607
			public static VerifyTableAction <0>__Verify;
		}
	}
}
