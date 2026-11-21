using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C8 RID: 22984
	public static class IInteractComponentVerify
	{
		// Token: 0x06025854 RID: 153684 RVA: 0x00525A60 File Offset: 0x00523C60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractScreenDetectShapeCircleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IInteractComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IInteractComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IRangeByTagVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						short offsetId3 = 20;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IInteractComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IInteractComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IInteractSectorRangeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
						{
							short typeIdVOffset = 22;
							short valueVOffset = 24;
							VerifyUnionAction verifyAction4;
							if ((verifyAction4 = IInteractComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IInteractComponentVerify.<>O.<3>__Verify = new VerifyUnionAction(TInteractPlayerDiractionOptionVerify.Verify));
							}
							if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction4, false))
							{
								short offsetId4 = 26;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IInteractComponentVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IInteractComponentVerify.<>O.<4>__Verify = new VerifyTableAction(IInteractOptionVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction5, false))
								{
									short offsetId5 = 28;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IInteractComponentVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IInteractComponentVerify.<>O.<5>__Verify = new VerifyTableAction(IRandomInteractVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
									{
										short offsetId6 = 40;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IInteractComponentVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (IInteractComponentVerify.<>O.<6>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyString(tablePos, 42, false))
										{
											short offsetId7 = 44;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IInteractComponentVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (IInteractComponentVerify.<>O.<7>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId7, verifyAction8, false) && verifier.VerifyVectorOfData(tablePos, 46, 1UL, false))
											{
												short offsetId8 = 50;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IInteractComponentVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (IInteractComponentVerify.<>O.<8>__Verify = new VerifyTableAction(IFishingPointAdditionalInfoVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId8, verifyAction9, false))
												{
													short offsetId9 = 52;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = IInteractComponentVerify.<>O.<9>__Verify) == null)
													{
														verifyAction10 = (IInteractComponentVerify.<>O.<9>__Verify = new VerifyTableAction(IInteractPointIconConfigVerify.Verify));
													}
													if (verifier.VerifyTable(tablePos, offsetId9, verifyAction10, false))
													{
														short offsetId10 = 54;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = IInteractComponentVerify.<>O.<10>__Verify) == null)
														{
															verifyAction11 = (IInteractComponentVerify.<>O.<10>__Verify = new VerifyTableAction(IInteractCameraOffsetConfigVerify.Verify));
														}
														if (verifier.VerifyTable(tablePos, offsetId10, verifyAction11, false) && verifier.VerifyField(tablePos, 56, 1UL, 1UL, false))
														{
															short typeIdVOffset2 = 56;
															short valueVOffset2 = 58;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = IInteractComponentVerify.<>O.<11>__Verify) == null)
															{
																verifyAction12 = (IInteractComponentVerify.<>O.<11>__Verify = new VerifyUnionAction(TInteractStyleVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction12, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 64, 2UL, 2UL, false))
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

		// Token: 0x020083CA RID: 33738
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014655 RID: 83541
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014656 RID: 83542
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014657 RID: 83543
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014658 RID: 83544
			public static VerifyUnionAction <3>__Verify;

			// Token: 0x04014659 RID: 83545
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401465A RID: 83546
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401465B RID: 83547
			public static VerifyTableAction <6>__Verify;

			// Token: 0x0401465C RID: 83548
			public static VerifyTableAction <7>__Verify;

			// Token: 0x0401465D RID: 83549
			public static VerifyTableAction <8>__Verify;

			// Token: 0x0401465E RID: 83550
			public static VerifyTableAction <9>__Verify;

			// Token: 0x0401465F RID: 83551
			public static VerifyTableAction <10>__Verify;

			// Token: 0x04014660 RID: 83552
			public static VerifyUnionAction <11>__Verify;
		}
	}
}
