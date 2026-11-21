using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200444D RID: 17485
	public static class IQuestRecallConfigVerify
	{
		// Token: 0x06019136 RID: 102710 RVA: 0x00393A78 File Offset: 0x00391C78
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

		// Token: 0x02008177 RID: 33143
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142A2 RID: 82594
			public static VerifyTableAction <0>__Verify;
		}
	}
}
