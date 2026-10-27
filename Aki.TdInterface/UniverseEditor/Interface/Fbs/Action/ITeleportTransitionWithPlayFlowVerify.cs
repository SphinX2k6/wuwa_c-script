using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C0 RID: 29632
	public static class ITeleportTransitionWithPlayFlowVerify
	{
		// Token: 0x06035CF7 RID: 220407 RVA: 0x00752EB0 File Offset: 0x007510B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportTransitionWithPlayFlowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportTransitionWithPlayFlowVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITeleportTransitionWithPlayFlowVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITeleportTransitionWithPlayFlowVerify.<>O.<1>__Verify = new VerifyTableAction(IFadeBackgroundFadeInEffectVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITeleportTransitionWithPlayFlowVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITeleportTransitionWithPlayFlowVerify.<>O.<2>__Verify = new VerifyTableAction(IFadeBackgroundFadeOutEffectVerify.Verify));
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

		// Token: 0x02007E9F RID: 32415
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BDB RID: 80859
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013BDC RID: 80860
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013BDD RID: 80861
			public static VerifyTableAction <2>__Verify;
		}
	}
}
