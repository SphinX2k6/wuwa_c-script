using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B9B RID: 31643
	public static class ITeleportTransitionWithCustomScreenVerify
	{
		// Token: 0x06039016 RID: 233494 RVA: 0x007B44C0 File Offset: 0x007B26C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITeleportTransitionWithCustomScreenVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportTransitionWithCustomScreenVerify.<>O.<0>__Verify = new VerifyUnionAction(TCustomScreenVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITeleportTransitionWithCustomScreenVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITeleportTransitionWithCustomScreenVerify.<>O.<1>__Verify = new VerifyTableAction(IFadeBackgroundFadeInEffectVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITeleportTransitionWithCustomScreenVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITeleportTransitionWithCustomScreenVerify.<>O.<2>__Verify = new VerifyTableAction(IFadeBackgroundFadeOutEffectVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
						{
							short offsetId3 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITeleportTransitionWithCustomScreenVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITeleportTransitionWithCustomScreenVerify.<>O.<3>__Verify = new VerifyTableAction(ICustomShowUiVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008737 RID: 34615
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CB0 RID: 85168
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014CB1 RID: 85169
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014CB2 RID: 85170
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014CB3 RID: 85171
			public static VerifyTableAction <3>__Verify;
		}
	}
}
