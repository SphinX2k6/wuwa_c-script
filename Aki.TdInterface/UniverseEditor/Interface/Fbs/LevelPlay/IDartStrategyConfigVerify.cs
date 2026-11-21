using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048FE RID: 18686
	public static class IDartStrategyConfigVerify
	{
		// Token: 0x0601BAE0 RID: 113376 RVA: 0x003E9BB0 File Offset: 0x003E7DB0
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

		// Token: 0x020081ED RID: 33261
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014394 RID: 82836
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014395 RID: 82837
			public static VerifyTableAction <1>__Verify;
		}
	}
}
