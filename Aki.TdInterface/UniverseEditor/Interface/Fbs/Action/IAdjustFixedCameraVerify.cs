using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B3 RID: 26547
	public static class IAdjustFixedCameraVerify
	{
		// Token: 0x0602D326 RID: 185126 RVA: 0x0062F01C File Offset: 0x0062D21C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdjustFixedCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustFixedCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdjustFixedCameraVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAdjustFixedCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAdjustFixedCameraVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IAdjustFixedCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IAdjustFixedCameraVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IAdjustFixedCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
							{
								short typeIdVOffset = 38;
								short valueVOffset = 40;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IAdjustFixedCameraVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IAdjustFixedCameraVerify.<>O.<2>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 46, false))
								{
									short offsetId5 = 48;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IAdjustFixedCameraVerify.<>O.<1>__Verify) == null)
									{
										verifyAction6 = (IAdjustFixedCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false))
									{
										short offsetId6 = 50;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IAdjustFixedCameraVerify.<>O.<1>__Verify) == null)
										{
											verifyAction7 = (IAdjustFixedCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false))
										{
											short offsetId7 = 52;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IAdjustFixedCameraVerify.<>O.<3>__Verify) == null)
											{
												verifyAction8 = (IAdjustFixedCameraVerify.<>O.<3>__Verify = new VerifyTableAction(IBlendFunctionVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId7, verifyAction8, false))
											{
												short offsetId8 = 54;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IAdjustFixedCameraVerify.<>O.<3>__Verify) == null)
												{
													verifyAction9 = (IAdjustFixedCameraVerify.<>O.<3>__Verify = new VerifyTableAction(IBlendFunctionVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId8, verifyAction9, false))
												{
													short offsetId9 = 56;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = IAdjustFixedCameraVerify.<>O.<4>__Verify) == null)
													{
														verifyAction10 = (IAdjustFixedCameraVerify.<>O.<4>__Verify = new VerifyTableAction(IAdjustFixedCameraOrthogonalConfigVerify.Verify));
													}
													if (verifier.VerifyTable(tablePos, offsetId9, verifyAction10, false))
													{
														short offsetId10 = 58;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = IAdjustFixedCameraVerify.<>O.<5>__Verify) == null)
														{
															verifyAction11 = (IAdjustFixedCameraVerify.<>O.<5>__Verify = new VerifyTableAction(IAdjustFixedCameraRotateConfigVerify.Verify));
														}
														if (verifier.VerifyTable(tablePos, offsetId10, verifyAction11, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false))
														{
															short typeIdVOffset2 = 60;
															short valueVOffset2 = 62;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = IAdjustFixedCameraVerify.<>O.<6>__Verify) == null)
															{
																verifyAction12 = (IAdjustFixedCameraVerify.<>O.<6>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction12, false) && verifier.VerifyField(tablePos, 64, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 66, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 68, 2UL, 2UL, false))
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
				}
			}
			return false;
		}

		// Token: 0x02008556 RID: 34134
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148D0 RID: 84176
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040148D1 RID: 84177
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040148D2 RID: 84178
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x040148D3 RID: 84179
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040148D4 RID: 84180
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040148D5 RID: 84181
			public static VerifyTableAction <5>__Verify;

			// Token: 0x040148D6 RID: 84182
			public static VerifyUnionAction <6>__Verify;
		}
	}
}
