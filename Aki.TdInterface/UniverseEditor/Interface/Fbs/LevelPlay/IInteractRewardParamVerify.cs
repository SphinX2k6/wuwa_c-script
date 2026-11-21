using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004949 RID: 18761
	public static class IInteractRewardParamVerify
	{
		// Token: 0x0601BDCE RID: 114126 RVA: 0x003EFD34 File Offset: 0x003EDF34
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

		// Token: 0x020081F4 RID: 33268
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401439C RID: 82844
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401439D RID: 82845
			public static VerifyTableAction <1>__Verify;
		}
	}
}
