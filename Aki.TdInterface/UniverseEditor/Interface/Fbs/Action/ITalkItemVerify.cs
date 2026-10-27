using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BE RID: 29374
	public static class ITalkItemVerify
	{
		// Token: 0x060342E3 RID: 213731 RVA: 0x00704354 File Offset: 0x00702554
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
			{
				short offsetId = 26;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemVerify.<>O.<0>__Verify = new VerifyTableAction(ICaptionParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkItemVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkItemVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITalkItemVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkItemVerify.<>O.<2>__Verify = new VerifyTableAction(ITalkOptionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkItemVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkItemVerify.<>O.<3>__Verify = new VerifyTableAction(IPlayMontageVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 34;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITalkItemVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkItemVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 36;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITalkItemVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITalkItemVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 38;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITalkItemVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITalkItemVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 40;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITalkItemVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ITalkItemVerify.<>O.<6>__Verify = new VerifyTableAction(IMontageDataVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 42;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ITalkItemVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ITalkItemVerify.<>O.<7>__Verify = new VerifyTableAction(IActorFaceExpressionVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 44;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ITalkItemVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ITalkItemVerify.<>O.<8>__Verify = new VerifyTableAction(IActorLookAtVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 46;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ITalkItemVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ITalkItemVerify.<>O.<9>__Verify = new VerifyTableAction(IActorTurnToVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
														{
															short typeIdVOffset = 48;
															short valueVOffset = 50;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = ITalkItemVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ITalkItemVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction12, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
															{
																short typeIdVOffset2 = 52;
																short valueVOffset2 = 54;
																VerifyUnionAction verifyAction13;
																if ((verifyAction13 = ITalkItemVerify.<>O.<10>__Verify) == null)
																{
																	verifyAction13 = (ITalkItemVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
																}
																if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction13, false))
																{
																	short offsetId12 = 56;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ITalkItemVerify.<>O.<11>__Verify) == null)
																	{
																		verifyAction14 = (ITalkItemVerify.<>O.<11>__Verify = new VerifyTableAction(IUniversalToneVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
																	{
																		short typeIdVOffset3 = 58;
																		short valueVOffset3 = 60;
																		VerifyUnionAction verifyAction15;
																		if ((verifyAction15 = ITalkItemVerify.<>O.<12>__Verify) == null)
																		{
																			verifyAction15 = (ITalkItemVerify.<>O.<12>__Verify = new VerifyUnionAction(TTalkBackgroundVerify.Verify));
																		}
																		if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction15, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
																		{
																			short offsetId13 = 64;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ITalkItemVerify.<>O.<13>__Verify) == null)
																			{
																				verifyAction16 = (ITalkItemVerify.<>O.<13>__Verify = new VerifyTableAction(ITimeLimitOptionGroupVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId13, verifyAction16, false))
																			{
																				short offsetId14 = 66;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ITalkItemVerify.<>O.<14>__Verify) == null)
																				{
																					verifyAction17 = (ITalkItemVerify.<>O.<14>__Verify = new VerifyTableAction(IGamepadShakeInTalkVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId14, verifyAction17, false))
																				{
																					short offsetId15 = 68;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ITalkItemVerify.<>O.<1>__Verify) == null)
																					{
																						verifyAction18 = (ITalkItemVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId15, verifyAction18, false))
																					{
																						short offsetId16 = 70;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ITalkItemVerify.<>O.<15>__Verify) == null)
																						{
																							verifyAction19 = (ITalkItemVerify.<>O.<15>__Verify = new VerifyTableAction(IActorFxEmoteVerify.Verify));
																						}
																						if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 72, 1UL, false))
																						{
																							short offsetId17 = 76;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ITalkItemVerify.<>O.<16>__Verify) == null)
																							{
																								verifyAction20 = (ITalkItemVerify.<>O.<16>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
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

		// Token: 0x02007E81 RID: 32385
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A65 RID: 80485
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A66 RID: 80486
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013A67 RID: 80487
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013A68 RID: 80488
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013A69 RID: 80489
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013A6A RID: 80490
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013A6B RID: 80491
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013A6C RID: 80492
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013A6D RID: 80493
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04013A6E RID: 80494
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04013A6F RID: 80495
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04013A70 RID: 80496
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04013A71 RID: 80497
			public static VerifyUnionAction <12>__Verify;

			// Token: 0x04013A72 RID: 80498
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04013A73 RID: 80499
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04013A74 RID: 80500
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04013A75 RID: 80501
			public static VerifyTableAction <16>__Verify;
		}
	}
}
