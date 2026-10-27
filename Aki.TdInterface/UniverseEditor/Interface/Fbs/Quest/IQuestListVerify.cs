using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.SyncBlock;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FEE RID: 16366
	public static class IQuestListVerify
	{
		// Token: 0x0601790C RID: 96524 RVA: 0x00365E90 File Offset: 0x00364090
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

		// Token: 0x0200792A RID: 31018
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013232 RID: 78386
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013233 RID: 78387
			public static VerifyTableAction <1>__Verify;
		}
	}
}
