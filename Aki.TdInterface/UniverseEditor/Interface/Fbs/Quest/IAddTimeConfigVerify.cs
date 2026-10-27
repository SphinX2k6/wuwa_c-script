using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF7 RID: 15607
	public static class IAddTimeConfigVerify
	{
		// Token: 0x0601580C RID: 88076 RVA: 0x0031B2D0 File Offset: 0x003194D0
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

		// Token: 0x020078AC RID: 30892
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401311E RID: 78110
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401311F RID: 78111
			public static VerifyTableAction <1>__Verify;
		}
	}
}
