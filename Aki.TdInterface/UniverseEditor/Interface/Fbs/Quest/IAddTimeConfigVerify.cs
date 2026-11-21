using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410E RID: 16654
	public static class IAddTimeConfigVerify
	{
		// Token: 0x06016D44 RID: 93508 RVA: 0x00342548 File Offset: 0x00340748
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddTimeConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddTimeConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IKillMonsterVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAddTimeConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAddTimeConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IAddTimeStateConditionVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080F0 RID: 33008
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401417A RID: 82298
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401417B RID: 82299
			public static VerifyTableAction <1>__Verify;
		}
	}
}
