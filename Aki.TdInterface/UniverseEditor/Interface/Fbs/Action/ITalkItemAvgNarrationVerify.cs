using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072CD RID: 29389
	public static class ITalkItemAvgNarrationVerify
	{
		// Token: 0x060346ED RID: 214765 RVA: 0x007118C0 File Offset: 0x0070FAC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
			{
				short offsetId = 26;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemAvgNarrationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemAvgNarrationVerify.<>O.<0>__Verify = new VerifyTableAction(ICaptionParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkItemAvgNarrationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkItemAvgNarrationVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITalkItemAvgNarrationVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkItemAvgNarrationVerify.<>O.<2>__Verify = new VerifyTableAction(ITalkOptionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkItemAvgNarrationVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkItemAvgNarrationVerify.<>O.<3>__Verify = new VerifyTableAction(IPlayMontageVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 34;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITalkItemAvgNarrationVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkItemAvgNarrationVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 36;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITalkItemAvgNarrationVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITalkItemAvgNarrationVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 38;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITalkItemAvgNarrationVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITalkItemAvgNarrationVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 40;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITalkItemAvgNarrationVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ITalkItemAvgNarrationVerify.<>O.<6>__Verify = new VerifyTableAction(IMontageDataVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 42;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ITalkItemAvgNarrationVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ITalkItemAvgNarrationVerify.<>O.<7>__Verify = new VerifyTableAction(IActorFaceExpressionVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 44;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ITalkItemAvgNarrationVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ITalkItemAvgNarrationVerify.<>O.<8>__Verify = new VerifyTableAction(IActorLookAtVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 46;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ITalkItemAvgNarrationVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ITalkItemAvgNarrationVerify.<>O.<9>__Verify = new VerifyTableAction(IActorTurnToVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
														{
															short typeIdVOffset = 48;
															short valueVOffset = 50;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = ITalkItemAvgNarrationVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ITalkItemAvgNarrationVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction12, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
															{
																short typeIdVOffset2 = 52;
																short valueVOffset2 = 54;
																VerifyUnionAction verifyAction13;
																if ((verifyAction13 = ITalkItemAvgNarrationVerify.<>O.<10>__Verify) == null)
																{
																	verifyAction13 = (ITalkItemAvgNarrationVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
																}
																if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction13, false))
																{
																	short offsetId12 = 56;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ITalkItemAvgNarrationVerify.<>O.<11>__Verify) == null)
																	{
																		verifyAction14 = (ITalkItemAvgNarrationVerify.<>O.<11>__Verify = new VerifyTableAction(IUniversalToneVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
																	{
																		short typeIdVOffset3 = 58;
																		short valueVOffset3 = 60;
																		VerifyUnionAction verifyAction15;
																		if ((verifyAction15 = ITalkItemAvgNarrationVerify.<>O.<12>__Verify) == null)
																		{
																			verifyAction15 = (ITalkItemAvgNarrationVerify.<>O.<12>__Verify = new VerifyUnionAction(TTalkBackgroundVerify.Verify));
																		}
																		if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction15, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
																		{
																			short offsetId13 = 64;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ITalkItemAvgNarrationVerify.<>O.<13>__Verify) == null)
																			{
																				verifyAction16 = (ITalkItemAvgNarrationVerify.<>O.<13>__Verify = new VerifyTableAction(ITimeLimitOptionGroupVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId13, verifyAction16, false))
																			{
																				short offsetId14 = 66;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ITalkItemAvgNarrationVerify.<>O.<14>__Verify) == null)
																				{
																					verifyAction17 = (ITalkItemAvgNarrationVerify.<>O.<14>__Verify = new VerifyTableAction(IGamepadShakeInTalkVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId14, verifyAction17, false))
																				{
																					short offsetId15 = 68;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ITalkItemAvgNarrationVerify.<>O.<1>__Verify) == null)
																					{
																						verifyAction18 = (ITalkItemAvgNarrationVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId15, verifyAction18, false))
																					{
																						short offsetId16 = 70;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ITalkItemAvgNarrationVerify.<>O.<15>__Verify) == null)
																						{
																							verifyAction19 = (ITalkItemAvgNarrationVerify.<>O.<15>__Verify = new VerifyTableAction(IActorFxEmoteVerify.Verify));
																						}
																						if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 72, 1UL, false))
																						{
																							short offsetId17 = 76;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ITalkItemAvgNarrationVerify.<>O.<16>__Verify) == null)
																							{
																								verifyAction20 = (ITalkItemAvgNarrationVerify.<>O.<16>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
																							}
																							if (verifier.VerifyVectorOfTables(tablePos, offsetId17, verifyAction20, false) && verifier.VerifyField(tablePos, 78, 4UL, 4UL, false))
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
			return false;
		}

		// Token: 0x02007E86 RID: 32390
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013AAC RID: 80556
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013AAD RID: 80557
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013AAE RID: 80558
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013AAF RID: 80559
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013AB0 RID: 80560
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013AB1 RID: 80561
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013AB2 RID: 80562
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013AB3 RID: 80563
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013AB4 RID: 80564
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04013AB5 RID: 80565
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04013AB6 RID: 80566
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04013AB7 RID: 80567
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04013AB8 RID: 80568
			public static VerifyUnionAction <12>__Verify;

			// Token: 0x04013AB9 RID: 80569
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04013ABA RID: 80570
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04013ABB RID: 80571
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04013ABC RID: 80572
			public static VerifyTableAction <16>__Verify;
		}
	}
}
