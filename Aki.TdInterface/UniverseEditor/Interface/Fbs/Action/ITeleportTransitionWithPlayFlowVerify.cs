using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BA7 RID: 31655
	public static class ITeleportTransitionWithPlayFlowVerify
	{
		// Token: 0x06039092 RID: 233618 RVA: 0x007B53F0 File Offset: 0x007B35F0
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

		// Token: 0x02008738 RID: 34616
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CB4 RID: 85172
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014CB5 RID: 85173
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014CB6 RID: 85174
			public static VerifyTableAction <2>__Verify;
		}
	}
}
