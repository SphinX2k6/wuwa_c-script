using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B89 RID: 31625
	public static class ITeleportTransitionInSeamlessTypeVerify
	{
		// Token: 0x06038F6D RID: 233325 RVA: 0x007B2FF8 File Offset: 0x007B11F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false))
			{
				short offsetId = 18;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportTransitionInSeamlessTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportTransitionInSeamlessTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IFloorSettingsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 22, 1UL, false))
				{
					short offsetId2 = 24;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITeleportTransitionInSeamlessTypeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITeleportTransitionInSeamlessTypeVerify.<>O.<1>__Verify = new VerifyTableAction(ISeamlessTeleportFinishConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008735 RID: 34613
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CAD RID: 85165
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CAE RID: 85166
			public static VerifyTableAction <1>__Verify;
		}
	}
}
