using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006163 RID: 24931
	public static class IAdjustFixedSurveillanceCameraVerify
	{
		// Token: 0x0602ADB0 RID: 175536 RVA: 0x005E8CC0 File Offset: 0x005E6EC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdjustFixedSurveillanceCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustFixedSurveillanceCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdjustFixedSurveillanceCameraVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAdjustFixedSurveillanceCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAdjustFixedSurveillanceCameraVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IAdjustFixedSurveillanceCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IAdjustFixedSurveillanceCameraVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IAdjustFixedSurveillanceCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
							{
								short typeIdVOffset = 38;
								short valueVOffset = 40;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IAdjustFixedSurveillanceCameraVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IAdjustFixedSurveillanceCameraVerify.<>O.<2>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 46, false))
								{
									short offsetId5 = 48;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IAdjustFixedSurveillanceCameraVerify.<>O.<1>__Verify) == null)
									{
										verifyAction6 = (IAdjustFixedSurveillanceCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false))
									{
										short offsetId6 = 50;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IAdjustFixedSurveillanceCameraVerify.<>O.<3>__Verify) == null)
										{
											verifyAction7 = (IAdjustFixedSurveillanceCameraVerify.<>O.<3>__Verify = new VerifyTableAction(IBlendFunctionVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false))
										{
											short offsetId7 = 52;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IAdjustFixedSurveillanceCameraVerify.<>O.<3>__Verify) == null)
											{
												verifyAction8 = (IAdjustFixedSurveillanceCameraVerify.<>O.<3>__Verify = new VerifyTableAction(IBlendFunctionVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId7, verifyAction8, false))
											{
												short offsetId8 = 54;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IAdjustFixedSurveillanceCameraVerify.<>O.<4>__Verify) == null)
												{
													verifyAction9 = (IAdjustFixedSurveillanceCameraVerify.<>O.<4>__Verify = new VerifyTableAction(IAdjustFixedCameraOrthogonalConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId8, verifyAction9, false) && verifier.VerifyField(tablePos, 56, 1UL, 1UL, false))
												{
													short typeIdVOffset2 = 56;
													short valueVOffset2 = 58;
													VerifyUnionAction verifyAction10;
													if ((verifyAction10 = IAdjustFixedSurveillanceCameraVerify.<>O.<5>__Verify) == null)
													{
														verifyAction10 = (IAdjustFixedSurveillanceCameraVerify.<>O.<5>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
													}
													if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction10, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false))
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
			}
			return false;
		}

		// Token: 0x02007CE9 RID: 31977
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013839 RID: 79929
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401383A RID: 79930
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401383B RID: 79931
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x0401383C RID: 79932
			public static VerifyTableAction <3>__Verify;

			// Token: 0x0401383D RID: 79933
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401383E RID: 79934
			public static VerifyUnionAction <5>__Verify;
		}
	}
}
