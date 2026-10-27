using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007318 RID: 29464
	public static class ITalkItemVisualNovelOptionVerify
	{
		// Token: 0x060355ED RID: 218605 RVA: 0x00742D88 File Offset: 0x00740F88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
			{
				short offsetId = 26;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemVisualNovelOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemVisualNovelOptionVerify.<>O.<0>__Verify = new VerifyTableAction(ICaptionParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkItemVisualNovelOptionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkItemVisualNovelOptionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITalkItemVisualNovelOptionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkItemVisualNovelOptionVerify.<>O.<2>__Verify = new VerifyTableAction(ITalkOptionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkItemVisualNovelOptionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkItemVisualNovelOptionVerify.<>O.<3>__Verify = new VerifyTableAction(IPlayMontageVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 34;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITalkItemVisualNovelOptionVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkItemVisualNovelOptionVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 36;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITalkItemVisualNovelOptionVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITalkItemVisualNovelOptionVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 38;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITalkItemVisualNovelOptionVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITalkItemVisualNovelOptionVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 40;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITalkItemVisualNovelOptionVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ITalkItemVisualNovelOptionVerify.<>O.<6>__Verify = new VerifyTableAction(IMontageDataVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 42;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ITalkItemVisualNovelOptionVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ITalkItemVisualNovelOptionVerify.<>O.<7>__Verify = new VerifyTableAction(IActorFaceExpressionVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 44;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ITalkItemVisualNovelOptionVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ITalkItemVisualNovelOptionVerify.<>O.<8>__Verify = new VerifyTableAction(IActorLookAtVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 46;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ITalkItemVisualNovelOptionVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ITalkItemVisualNovelOptionVerify.<>O.<9>__Verify = new VerifyTableAction(IActorTurnToVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
														{
															short typeIdVOffset = 48;
															short valueVOffset = 50;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = ITalkItemVisualNovelOptionVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ITalkItemVisualNovelOptionVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction12, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
															{
																short typeIdVOffset2 = 52;
																short valueVOffset2 = 54;
																VerifyUnionAction verifyAction13;
																if ((verifyAction13 = ITalkItemVisualNovelOptionVerify.<>O.<10>__Verify) == null)
																{
																	verifyAction13 = (ITalkItemVisualNovelOptionVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
																}
																if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction13, false))
																{
																	short offsetId12 = 56;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ITalkItemVisualNovelOptionVerify.<>O.<11>__Verify) == null)
																	{
																		verifyAction14 = (ITalkItemVisualNovelOptionVerify.<>O.<11>__Verify = new VerifyTableAction(IUniversalToneVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
																	{
																		short typeIdVOffset3 = 58;
																		short valueVOffset3 = 60;
																		VerifyUnionAction verifyAction15;
																		if ((verifyAction15 = ITalkItemVisualNovelOptionVerify.<>O.<12>__Verify) == null)
																		{
																			verifyAction15 = (ITalkItemVisualNovelOptionVerify.<>O.<12>__Verify = new VerifyUnionAction(TTalkBackgroundVerify.Verify));
																		}
																		if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction15, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
																		{
																			short offsetId13 = 64;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ITalkItemVisualNovelOptionVerify.<>O.<13>__Verify) == null)
																			{
																				verifyAction16 = (ITalkItemVisualNovelOptionVerify.<>O.<13>__Verify = new VerifyTableAction(ITimeLimitOptionGroupVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId13, verifyAction16, false))
																			{
																				short offsetId14 = 66;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ITalkItemVisualNovelOptionVerify.<>O.<14>__Verify) == null)
																				{
																					verifyAction17 = (ITalkItemVisualNovelOptionVerify.<>O.<14>__Verify = new VerifyTableAction(IGamepadShakeInTalkVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId14, verifyAction17, false))
																				{
																					short offsetId15 = 68;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ITalkItemVisualNovelOptionVerify.<>O.<1>__Verify) == null)
																					{
																						verifyAction18 = (ITalkItemVisualNovelOptionVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId15, verifyAction18, false))
																					{
																						short offsetId16 = 70;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ITalkItemVisualNovelOptionVerify.<>O.<15>__Verify) == null)
																						{
																							verifyAction19 = (ITalkItemVisualNovelOptionVerify.<>O.<15>__Verify = new VerifyTableAction(IActorFxEmoteVerify.Verify));
																						}
																						if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 72, 1UL, false))
																						{
																							short offsetId17 = 76;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ITalkItemVisualNovelOptionVerify.<>O.<16>__Verify) == null)
																							{
																								verifyAction20 = (ITalkItemVisualNovelOptionVerify.<>O.<16>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
																							}
																							if (verifier.VerifyVectorOfTables(tablePos, offsetId17, verifyAction20, false) && verifier.VerifyField(tablePos, 78, 1UL, 1UL, false))
																							{
																								short offsetId18 = 80;
																								VerifyTableAction verifyAction21;
																								if ((verifyAction21 = ITalkItemVisualNovelOptionVerify.<>O.<17>__Verify) == null)
																								{
																									verifyAction21 = (ITalkItemVisualNovelOptionVerify.<>O.<17>__Verify = new VerifyTableAction(IVisualNovelOptionGroupSolarSchoolExamVerify.Verify));
																								}
																								if (verifier.VerifyTable(tablePos, offsetId18, verifyAction21, false) && verifier.VerifyField(tablePos, 82, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 84, false) && verifier.VerifyField(tablePos, 86, 1UL, 1UL, false))
																								{
																									short typeIdVOffset4 = 86;
																									short valueVOffset4 = 88;
																									VerifyUnionAction verifyAction22;
																									if ((verifyAction22 = ITalkItemVisualNovelOptionVerify.<>O.<18>__Verify) == null)
																									{
																										verifyAction22 = (ITalkItemVisualNovelOptionVerify.<>O.<18>__Verify = new VerifyUnionAction(TVisualNovelBackgroundVerify.Verify));
																									}
																									if (verifier.VerifyUnion(tablePos, typeIdVOffset4, valueVOffset4, verifyAction22, false) && verifier.VerifyField(tablePos, 90, 1UL, 1UL, false))
																									{
																										short typeIdVOffset5 = 90;
																										short valueVOffset5 = 92;
																										VerifyUnionAction verifyAction23;
																										if ((verifyAction23 = ITalkItemVisualNovelOptionVerify.<>O.<19>__Verify) == null)
																										{
																											verifyAction23 = (ITalkItemVisualNovelOptionVerify.<>O.<19>__Verify = new VerifyUnionAction(TVisualNovelCgVerify.Verify));
																										}
																										if (verifier.VerifyUnion(tablePos, typeIdVOffset5, valueVOffset5, verifyAction23, false) && verifier.VerifyField(tablePos, 94, 1UL, 1UL, false))
																										{
																											short typeIdVOffset6 = 94;
																											short valueVOffset6 = 96;
																											VerifyUnionAction verifyAction24;
																											if ((verifyAction24 = ITalkItemVisualNovelOptionVerify.<>O.<20>__Verify) == null)
																											{
																												verifyAction24 = (ITalkItemVisualNovelOptionVerify.<>O.<20>__Verify = new VerifyUnionAction(TVisualNovelDisplayItemVerify.Verify));
																											}
																											if (verifier.VerifyUnion(tablePos, typeIdVOffset6, valueVOffset6, verifyAction24, false) && verifier.VerifyField(tablePos, 98, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 100, 4UL, 4UL, false))
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
					}
				}
			}
			return false;
		}

		// Token: 0x02007E93 RID: 32403
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013B9D RID: 80797
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013B9E RID: 80798
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013B9F RID: 80799
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013BA0 RID: 80800
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013BA1 RID: 80801
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013BA2 RID: 80802
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013BA3 RID: 80803
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013BA4 RID: 80804
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013BA5 RID: 80805
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04013BA6 RID: 80806
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04013BA7 RID: 80807
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04013BA8 RID: 80808
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04013BA9 RID: 80809
			public static VerifyUnionAction <12>__Verify;

			// Token: 0x04013BAA RID: 80810
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04013BAB RID: 80811
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04013BAC RID: 80812
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04013BAD RID: 80813
			public static VerifyTableAction <16>__Verify;

			// Token: 0x04013BAE RID: 80814
			public static VerifyTableAction <17>__Verify;

			// Token: 0x04013BAF RID: 80815
			public static VerifyUnionAction <18>__Verify;

			// Token: 0x04013BB0 RID: 80816
			public static VerifyUnionAction <19>__Verify;

			// Token: 0x04013BB1 RID: 80817
			public static VerifyUnionAction <20>__Verify;
		}
	}
}
