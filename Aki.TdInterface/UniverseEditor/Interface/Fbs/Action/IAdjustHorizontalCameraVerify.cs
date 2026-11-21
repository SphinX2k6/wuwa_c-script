using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CB RID: 26571
	public static class IAdjustHorizontalCameraVerify
	{
		// Token: 0x0602D53F RID: 185663 RVA: 0x006348C8 File Offset: 0x00632AC8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdjustHorizontalCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustHorizontalCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdjustHorizontalCameraVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAdjustHorizontalCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAdjustHorizontalCameraVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IAdjustHorizontalCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IAdjustHorizontalCameraVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IAdjustHorizontalCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
							{
								short typeIdVOffset = 38;
								short valueVOffset = 40;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IAdjustHorizontalCameraVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IAdjustHorizontalCameraVerify.<>O.<2>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 46, false) && verifier.VerifyField(tablePos, 48, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 50, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 52, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 54, 4UL, 4UL, false))
								{
									short offsetId5 = 56;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IAdjustHorizontalCameraVerify.<>O.<3>__Verify) == null)
									{
										verifyAction6 = (IAdjustHorizontalCameraVerify.<>O.<3>__Verify = new VerifyTableAction(ICameraDepthOfFieldVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false))
									{
										short offsetId6 = 58;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IAdjustHorizontalCameraVerify.<>O.<4>__Verify) == null)
										{
											verifyAction7 = (IAdjustHorizontalCameraVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraOffsetInMovementDirectionVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyField(tablePos, 60, 4UL, 4UL, false))
										{
											short offsetId7 = 62;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IAdjustHorizontalCameraVerify.<>O.<5>__Verify) == null)
											{
												verifyAction8 = (IAdjustHorizontalCameraVerify.<>O.<5>__Verify = new VerifyTableAction(ISpringArmSoftZoneConfigVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId7, verifyAction8, false))
											{
												short offsetId8 = 64;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IAdjustHorizontalCameraVerify.<>O.<6>__Verify) == null)
												{
													verifyAction9 = (IAdjustHorizontalCameraVerify.<>O.<6>__Verify = new VerifyTableAction(ISpringArmFixConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId8, verifyAction9, false) && verifier.VerifyField(tablePos, 66, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 68, 2UL, 2UL, false))
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

		// Token: 0x0200855B RID: 34139
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148E5 RID: 84197
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040148E6 RID: 84198
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040148E7 RID: 84199
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x040148E8 RID: 84200
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040148E9 RID: 84201
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040148EA RID: 84202
			public static VerifyTableAction <5>__Verify;

			// Token: 0x040148EB RID: 84203
			public static VerifyTableAction <6>__Verify;
		}
	}
}
