using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044E1 RID: 17633
	public static class IInteractRewardParamVerify
	{
		// Token: 0x0601A5FD RID: 108029 RVA: 0x003C3B28 File Offset: 0x003C1D28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractRewardParamVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractRewardParamVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayInteractResetOptionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IInteractRewardParamVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IInteractRewardParamVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IInteractRewardParamVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IInteractRewardParamVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020079AB RID: 31147
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013335 RID: 78645
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013336 RID: 78646
			public static VerifyTableAction <1>__Verify;
		}
	}
}
