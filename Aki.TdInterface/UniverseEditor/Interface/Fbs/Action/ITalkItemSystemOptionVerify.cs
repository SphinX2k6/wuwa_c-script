using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200730C RID: 29452
	public static class ITalkItemSystemOptionVerify
	{
		// Token: 0x06035121 RID: 217377 RVA: 0x00731CE4 File Offset: 0x0072FEE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
			{
				short offsetId = 26;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemSystemOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemSystemOptionVerify.<>O.<0>__Verify = new VerifyTableAction(ICaptionParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkItemSystemOptionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkItemSystemOptionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITalkItemSystemOptionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkItemSystemOptionVerify.<>O.<2>__Verify = new VerifyTableAction(ITalkOptionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkItemSystemOptionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkItemSystemOptionVerify.<>O.<3>__Verify = new VerifyTableAction(IPlayMontageVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 34;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITalkItemSystemOptionVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkItemSystemOptionVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 36;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITalkItemSystemOptionVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITalkItemSystemOptionVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 38;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITalkItemSystemOptionVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITalkItemSystemOptionVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 40;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITalkItemSystemOptionVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ITalkItemSystemOptionVerify.<>O.<6>__Verify = new VerifyTableAction(IMontageDataVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 42;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ITalkItemSystemOptionVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ITalkItemSystemOptionVerify.<>O.<7>__Verify = new VerifyTableAction(IActorFaceExpressionVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 44;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ITalkItemSystemOptionVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ITalkItemSystemOptionVerify.<>O.<8>__Verify = new VerifyTableAction(IActorLookAtVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 46;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ITalkItemSystemOptionVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ITalkItemSystemOptionVerify.<>O.<9>__Verify = new VerifyTableAction(IActorTurnToVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
														{
															short typeIdVOffset = 48;
															short valueVOffset = 50;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = ITalkItemSystemOptionVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ITalkItemSystemOptionVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction12, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
															{
																short typeIdVOffset2 = 52;
																short valueVOffset2 = 54;
																VerifyUnionAction verifyAction13;
																if ((verifyAction13 = ITalkItemSystemOptionVerify.<>O.<10>__Verify) == null)
																{
																	verifyAction13 = (ITalkItemSystemOptionVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
																}
																if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction13, false))
																{
																	short offsetId12 = 56;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ITalkItemSystemOptionVerify.<>O.<11>__Verify) == null)
																	{
																		verifyAction14 = (ITalkItemSystemOptionVerify.<>O.<11>__Verify = new VerifyTableAction(IUniversalToneVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
																	{
																		short typeIdVOffset3 = 58;
																		short valueVOffset3 = 60;
																		VerifyUnionAction verifyAction15;
																		if ((verifyAction15 = ITalkItemSystemOptionVerify.<>O.<12>__Verify) == null)
																		{
																			verifyAction15 = (ITalkItemSystemOptionVerify.<>O.<12>__Verify = new VerifyUnionAction(TTalkBackgroundVerify.Verify));
																		}
																		if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction15, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
																		{
																			short offsetId13 = 64;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ITalkItemSystemOptionVerify.<>O.<13>__Verify) == null)
																			{
																				verifyAction16 = (ITalkItemSystemOptionVerify.<>O.<13>__Verify = new VerifyTableAction(ITimeLimitOptionGroupVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId13, verifyAction16, false))
																			{
																				short offsetId14 = 66;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ITalkItemSystemOptionVerify.<>O.<14>__Verify) == null)
																				{
																					verifyAction17 = (ITalkItemSystemOptionVerify.<>O.<14>__Verify = new VerifyTableAction(IGamepadShakeInTalkVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId14, verifyAction17, false))
																				{
																					short offsetId15 = 68;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ITalkItemSystemOptionVerify.<>O.<1>__Verify) == null)
																					{
																						verifyAction18 = (ITalkItemSystemOptionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId15, verifyAction18, false))
																					{
																						short offsetId16 = 70;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ITalkItemSystemOptionVerify.<>O.<15>__Verify) == null)
																						{
																							verifyAction19 = (ITalkItemSystemOptionVerify.<>O.<15>__Verify = new VerifyTableAction(IActorFxEmoteVerify.Verify));
																						}
																						if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 72, 1UL, false))
																						{
																							short offsetId17 = 76;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ITalkItemSystemOptionVerify.<>O.<16>__Verify) == null)
																							{
																								verifyAction20 = (ITalkItemSystemOptionVerify.<>O.<16>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
																							}
																							if (verifier.VerifyVectorOfTables(tablePos, offsetId17, verifyAction20, false) && verifier.VerifyField(tablePos, 78, 1UL, 1UL, false))
																							{
																								short typeIdVOffset4 = 78;
																								short valueVOffset4 = 80;
																								VerifyUnionAction verifyAction21;
																								if ((verifyAction21 = ITalkItemSystemOptionVerify.<>O.<17>__Verify) == null)
																								{
																									verifyAction21 = (ITalkItemSystemOptionVerify.<>O.<17>__Verify = new VerifyUnionAction(TSystemOptionVerify.Verify));
																								}
																								if (verifier.VerifyUnion(tablePos, typeIdVOffset4, valueVOffset4, verifyAction21, false) && verifier.VerifyField(tablePos, 82, 4UL, 4UL, false))
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

		// Token: 0x02007E8F RID: 32399
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013B4F RID: 80719
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013B50 RID: 80720
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013B51 RID: 80721
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013B52 RID: 80722
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013B53 RID: 80723
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013B54 RID: 80724
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013B55 RID: 80725
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013B56 RID: 80726
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013B57 RID: 80727
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04013B58 RID: 80728
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04013B59 RID: 80729
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04013B5A RID: 80730
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04013B5B RID: 80731
			public static VerifyUnionAction <12>__Verify;

			// Token: 0x04013B5C RID: 80732
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04013B5D RID: 80733
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04013B5E RID: 80734
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04013B5F RID: 80735
			public static VerifyTableAction <16>__Verify;

			// Token: 0x04013B60 RID: 80736
			public static VerifyUnionAction <17>__Verify;
		}
	}
}
