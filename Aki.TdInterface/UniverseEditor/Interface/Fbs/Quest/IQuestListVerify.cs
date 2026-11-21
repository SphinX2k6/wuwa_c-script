using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200442F RID: 17455
	public static class IQuestListVerify
	{
		// Token: 0x06018FA5 RID: 102309 RVA: 0x0038FC84 File Offset: 0x0038DE84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestListVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestListVerify.<>O.<0>__Verify = new VerifyTableAction(IQuestVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestListVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestListVerify.<>O.<1>__Verify = new VerifyTableAction(ISyncBlockGroupVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008171 RID: 33137
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014295 RID: 82581
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014296 RID: 82582
			public static VerifyTableAction <1>__Verify;
		}
	}
}
