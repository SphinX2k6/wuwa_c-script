using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004496 RID: 17558
	public static class IDartStrategyConfigVerify
	{
		// Token: 0x0601A30F RID: 107279 RVA: 0x003BD9A4 File Offset: 0x003BBBA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDartStrategyConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDartStrategyConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDartThrowStrategyVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDartStrategyConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDartStrategyConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IDartHitJudgeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020079A4 RID: 31140
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401332D RID: 78637
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401332E RID: 78638
			public static VerifyTableAction <1>__Verify;
		}
	}
}
