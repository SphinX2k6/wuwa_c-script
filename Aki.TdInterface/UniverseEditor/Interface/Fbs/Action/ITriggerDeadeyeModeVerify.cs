using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007477 RID: 29815
	public static class ITriggerDeadeyeModeVerify
	{
		// Token: 0x060362DD RID: 221917 RVA: 0x0075DBD4 File Offset: 0x0075BDD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITriggerDeadeyeModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerDeadeyeModeVerify.<>O.<0>__Verify = new VerifyTableAction(IDeadeyeFollowShooterConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITriggerDeadeyeModeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITriggerDeadeyeModeVerify.<>O.<1>__Verify = new VerifyTableAction(IDeadeyeFadeOutConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITriggerDeadeyeModeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITriggerDeadeyeModeVerify.<>O.<2>__Verify = new VerifyTableAction(IDeadeyeEnergyConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITriggerDeadeyeModeVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITriggerDeadeyeModeVerify.<>O.<3>__Verify = new VerifyTableAction(IDeadeyeCameraConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITriggerDeadeyeModeVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITriggerDeadeyeModeVerify.<>O.<4>__Verify = new VerifyTableAction(IDeadEyeEffectConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007EB0 RID: 32432
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BF2 RID: 80882
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013BF3 RID: 80883
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013BF4 RID: 80884
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013BF5 RID: 80885
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013BF6 RID: 80886
			public static VerifyTableAction <4>__Verify;
		}
	}
}
