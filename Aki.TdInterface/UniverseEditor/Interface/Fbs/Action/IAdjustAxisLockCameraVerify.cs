using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A7 RID: 26535
	public static class IAdjustAxisLockCameraVerify
	{
		// Token: 0x0602D111 RID: 184593 RVA: 0x006292E8 File Offset: 0x006274E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdjustAxisLockCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustAxisLockCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdjustAxisLockCameraVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAdjustAxisLockCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAdjustAxisLockCameraVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IAdjustAxisLockCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IAdjustAxisLockCameraVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IAdjustAxisLockCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
							{
								short typeIdVOffset = 38;
								short valueVOffset = 40;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IAdjustAxisLockCameraVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IAdjustAxisLockCameraVerify.<>O.<2>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 46, false))
								{
									short offsetId5 = 48;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IAdjustAxisLockCameraVerify.<>O.<1>__Verify) == null)
									{
										verifyAction6 = (IAdjustAxisLockCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false))
									{
										short offsetId6 = 52;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IAdjustAxisLockCameraVerify.<>O.<3>__Verify) == null)
										{
											verifyAction7 = (IAdjustAxisLockCameraVerify.<>O.<3>__Verify = new VerifyTableAction(IAxisLockScreenConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyField(tablePos, 54, 4UL, 4UL, false))
										{
											short offsetId7 = 56;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IAdjustAxisLockCameraVerify.<>O.<4>__Verify) == null)
											{
												verifyAction8 = (IAdjustAxisLockCameraVerify.<>O.<4>__Verify = new VerifyTableAction(ISpringArmSoftZoneConfigVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId7, verifyAction8, false))
											{
												short offsetId8 = 58;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IAdjustAxisLockCameraVerify.<>O.<5>__Verify) == null)
												{
													verifyAction9 = (IAdjustAxisLockCameraVerify.<>O.<5>__Verify = new VerifyTableAction(ISpringArmFixConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId8, verifyAction9, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 62, 2UL, 2UL, false))
												{
													return verifier.VerifyTableEnd(tablePos);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008552 RID: 34130
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148BE RID: 84158
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040148BF RID: 84159
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040148C0 RID: 84160
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x040148C1 RID: 84161
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040148C2 RID: 84162
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040148C3 RID: 84163
			public static VerifyTableAction <5>__Verify;
		}
	}
}
