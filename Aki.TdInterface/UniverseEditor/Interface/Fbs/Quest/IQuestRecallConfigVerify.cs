using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200400C RID: 16396
	public static class IQuestRecallConfigVerify
	{
		// Token: 0x06017A9D RID: 96925 RVA: 0x00369C84 File Offset: 0x00367E84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestRecallConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestRecallConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRecallEntityListVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007930 RID: 31024
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401323F RID: 78399
			public static VerifyTableAction <0>__Verify;
		}
	}
}
