using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A9F RID: 31391
	public static class ITalkItemAvgExitVerify
	{
		// Token: 0x060378F6 RID: 227574 RVA: 0x0076F800 File Offset: 0x0076DA00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
			{
				short offsetId = 26;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemAvgExitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemAvgExitVerify.<>O.<0>__Verify = new VerifyTableAction(ICaptionParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkItemAvgExitVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkItemAvgExitVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITalkItemAvgExitVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkItemAvgExitVerify.<>O.<2>__Verify = new VerifyTableAction(ITalkOptionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkItemAvgExitVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkItemAvgExitVerify.<>O.<3>__Verify = new VerifyTableAction(IPlayMontageVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 34;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITalkItemAvgExitVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkItemAvgExitVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 36;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITalkItemAvgExitVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITalkItemAvgExitVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 38;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITalkItemAvgExitVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITalkItemAvgExitVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 40;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITalkItemAvgExitVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ITalkItemAvgExitVerify.<>O.<6>__Verify = new VerifyTableAction(IMontageDataVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 42;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ITalkItemAvgExitVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ITalkItemAvgExitVerify.<>O.<7>__Verify = new VerifyTableAction(IActorFaceExpressionVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 44;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ITalkItemAvgExitVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ITalkItemAvgExitVerify.<>O.<8>__Verify = new VerifyTableAction(IActorLookAtVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 46;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ITalkItemAvgExitVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ITalkItemAvgExitVerify.<>O.<9>__Verify = new VerifyTableAction(IActorTurnToVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
														{
															short typeIdVOffset = 48;
															short valueVOffset = 50;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = ITalkItemAvgExitVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ITalkItemAvgExitVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction12, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
															{
																short typeIdVOffset2 = 52;
																short valueVOffset2 = 54;
																VerifyUnionAction verifyAction13;
																if ((verifyAction13 = ITalkItemAvgExitVerify.<>O.<10>__Verify) == null)
																{
																	verifyAction13 = (ITalkItemAvgExitVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
																}
																if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction13, false))
																{
																	short offsetId12 = 56;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ITalkItemAvgExitVerify.<>O.<11>__Verify) == null)
																	{
																		verifyAction14 = (ITalkItemAvgExitVerify.<>O.<11>__Verify = new VerifyTableAction(IUniversalToneVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
																	{
																		short typeIdVOffset3 = 58;
																		short valueVOffset3 = 60;
																		VerifyUnionAction verifyAction15;
																		if ((verifyAction15 = ITalkItemAvgExitVerify.<>O.<12>__Verify) == null)
																		{
																			verifyAction15 = (ITalkItemAvgExitVerify.<>O.<12>__Verify = new VerifyUnionAction(TTalkBackgroundVerify.Verify));
																		}
																		if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction15, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
																		{
																			short offsetId13 = 64;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ITalkItemAvgExitVerify.<>O.<13>__Verify) == null)
																			{
																				verifyAction16 = (ITalkItemAvgExitVerify.<>O.<13>__Verify = new VerifyTableAction(ITimeLimitOptionGroupVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId13, verifyAction16, false))
																			{
																				short offsetId14 = 66;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ITalkItemAvgExitVerify.<>O.<14>__Verify) == null)
																				{
																					verifyAction17 = (ITalkItemAvgExitVerify.<>O.<14>__Verify = new VerifyTableAction(IGamepadShakeInTalkVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId14, verifyAction17, false))
																				{
																					short offsetId15 = 68;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ITalkItemAvgExitVerify.<>O.<1>__Verify) == null)
																					{
																						verifyAction18 = (ITalkItemAvgExitVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId15, verifyAction18, false))
																					{
																						short offsetId16 = 70;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ITalkItemAvgExitVerify.<>O.<15>__Verify) == null)
																						{
																							verifyAction19 = (ITalkItemAvgExitVerify.<>O.<15>__Verify = new VerifyTableAction(IActorFxEmoteVerify.Verify));
																						}
																						if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 72, 1UL, false))
																						{
																							short offsetId17 = 76;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ITalkItemAvgExitVerify.<>O.<16>__Verify) == null)
																							{
																								verifyAction20 = (ITalkItemAvgExitVerify.<>O.<16>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
																							}
																							if (verifier.VerifyVectorOfTables(tablePos, offsetId17, verifyAction20, false))
																							{
																								short offsetId18 = 78;
																								VerifyTableAction verifyAction21;
																								if ((verifyAction21 = ITalkItemAvgExitVerify.<>O.<17>__Verify) == null)
																								{
																									verifyAction21 = (ITalkItemAvgExitVerify.<>O.<17>__Verify = new VerifyTableAction(ITalkItemAvgRoleConfigVerify.Verify));
																								}
																								if (verifier.VerifyTable(tablePos, offsetId18, verifyAction21, false) && verifier.VerifyField(tablePos, 80, 4UL, 4UL, false))
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

		// Token: 0x0200871C RID: 34588
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B71 RID: 84849
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014B72 RID: 84850
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014B73 RID: 84851
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014B74 RID: 84852
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014B75 RID: 84853
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04014B76 RID: 84854
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04014B77 RID: 84855
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04014B78 RID: 84856
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04014B79 RID: 84857
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04014B7A RID: 84858
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04014B7B RID: 84859
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04014B7C RID: 84860
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04014B7D RID: 84861
			public static VerifyUnionAction <12>__Verify;

			// Token: 0x04014B7E RID: 84862
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04014B7F RID: 84863
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04014B80 RID: 84864
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04014B81 RID: 84865
			public static VerifyTableAction <16>__Verify;

			// Token: 0x04014B82 RID: 84866
			public static VerifyTableAction <17>__Verify;
		}
	}
}
