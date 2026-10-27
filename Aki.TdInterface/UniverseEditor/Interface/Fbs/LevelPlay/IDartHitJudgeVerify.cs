using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004475 RID: 17525
	public static class IDartHitJudgeVerify
	{
		// Token: 0x0601A203 RID: 107011 RVA: 0x003BB754 File Offset: 0x003B9954
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDartHitJudgeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDartHitJudgeVerify.<>O.<0>__Verify = new VerifyTableAction(IDartPreciseJudgeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDartHitJudgeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDartHitJudgeVerify.<>O.<1>__Verify = new VerifyTableAction(IDartScatterJudgeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IDartHitJudgeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IDartHitJudgeVerify.<>O.<2>__Verify = new VerifyTableAction(IDartMissJudgeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020079A1 RID: 31137
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013326 RID: 78630
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013327 RID: 78631
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013328 RID: 78632
			public static VerifyTableAction <2>__Verify;
		}
	}
}
