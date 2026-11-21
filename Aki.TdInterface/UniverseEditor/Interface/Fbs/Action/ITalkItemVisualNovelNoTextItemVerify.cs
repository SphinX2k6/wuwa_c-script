using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AED RID: 31469
	public static class ITalkItemVisualNovelNoTextItemVerify
	{
		// Token: 0x060387F1 RID: 231409 RVA: 0x007A0954 File Offset: 0x0079EB54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
			{
				short offsetId = 26;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemVisualNovelNoTextItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemVisualNovelNoTextItemVerify.<>O.<0>__Verify = new VerifyTableAction(ICaptionParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkItemVisualNovelNoTextItemVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITalkItemVisualNovelNoTextItemVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<2>__Verify = new VerifyTableAction(ITalkOptionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkItemVisualNovelNoTextItemVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<3>__Verify = new VerifyTableAction(IPlayMontageVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 34;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITalkItemVisualNovelNoTextItemVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 36;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITalkItemVisualNovelNoTextItemVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 38;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITalkItemVisualNovelNoTextItemVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 40;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITalkItemVisualNovelNoTextItemVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<6>__Verify = new VerifyTableAction(IMontageDataVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 42;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ITalkItemVisualNovelNoTextItemVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<7>__Verify = new VerifyTableAction(IActorFaceExpressionVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 44;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ITalkItemVisualNovelNoTextItemVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<8>__Verify = new VerifyTableAction(IActorLookAtVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 46;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ITalkItemVisualNovelNoTextItemVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<9>__Verify = new VerifyTableAction(IActorTurnToVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
														{
															short typeIdVOffset = 48;
															short valueVOffset = 50;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = ITalkItemVisualNovelNoTextItemVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction12, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
															{
																short typeIdVOffset2 = 52;
																short valueVOffset2 = 54;
																VerifyUnionAction verifyAction13;
																if ((verifyAction13 = ITalkItemVisualNovelNoTextItemVerify.<>O.<10>__Verify) == null)
																{
																	verifyAction13 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
																}
																if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction13, false))
																{
																	short offsetId12 = 56;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ITalkItemVisualNovelNoTextItemVerify.<>O.<11>__Verify) == null)
																	{
																		verifyAction14 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<11>__Verify = new VerifyTableAction(IUniversalToneVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
																	{
																		short typeIdVOffset3 = 58;
																		short valueVOffset3 = 60;
																		VerifyUnionAction verifyAction15;
																		if ((verifyAction15 = ITalkItemVisualNovelNoTextItemVerify.<>O.<12>__Verify) == null)
																		{
																			verifyAction15 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<12>__Verify = new VerifyUnionAction(TTalkBackgroundVerify.Verify));
																		}
																		if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction15, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
																		{
																			short offsetId13 = 64;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ITalkItemVisualNovelNoTextItemVerify.<>O.<13>__Verify) == null)
																			{
																				verifyAction16 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<13>__Verify = new VerifyTableAction(ITimeLimitOptionGroupVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId13, verifyAction16, false))
																			{
																				short offsetId14 = 66;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ITalkItemVisualNovelNoTextItemVerify.<>O.<14>__Verify) == null)
																				{
																					verifyAction17 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<14>__Verify = new VerifyTableAction(IGamepadShakeInTalkVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId14, verifyAction17, false))
																				{
																					short offsetId15 = 68;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ITalkItemVisualNovelNoTextItemVerify.<>O.<1>__Verify) == null)
																					{
																						verifyAction18 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId15, verifyAction18, false))
																					{
																						short offsetId16 = 70;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ITalkItemVisualNovelNoTextItemVerify.<>O.<15>__Verify) == null)
																						{
																							verifyAction19 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<15>__Verify = new VerifyTableAction(IActorFxEmoteVerify.Verify));
																						}
																						if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 72, 1UL, false))
																						{
																							short offsetId17 = 76;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ITalkItemVisualNovelNoTextItemVerify.<>O.<16>__Verify) == null)
																							{
																								verifyAction20 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<16>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
																							}
																							if (verifier.VerifyVectorOfTables(tablePos, offsetId17, verifyAction20, false) && verifier.VerifyField(tablePos, 78, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 80, 1UL, 1UL, false))
																							{
																								short typeIdVOffset4 = 80;
																								short valueVOffset4 = 82;
																								VerifyUnionAction verifyAction21;
																								if ((verifyAction21 = ITalkItemVisualNovelNoTextItemVerify.<>O.<17>__Verify) == null)
																								{
																									verifyAction21 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<17>__Verify = new VerifyUnionAction(TVisualNovelOptionGroupConfigVerify.Verify));
																								}
																								if (verifier.VerifyUnion(tablePos, typeIdVOffset4, valueVOffset4, verifyAction21, false) && verifier.VerifyField(tablePos, 84, 1UL, 1UL, false))
																								{
																									short typeIdVOffset5 = 84;
																									short valueVOffset5 = 86;
																									VerifyUnionAction verifyAction22;
																									if ((verifyAction22 = ITalkItemVisualNovelNoTextItemVerify.<>O.<18>__Verify) == null)
																									{
																										verifyAction22 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<18>__Verify = new VerifyUnionAction(TVisualNovelBackgroundVerify.Verify));
																									}
																									if (verifier.VerifyUnion(tablePos, typeIdVOffset5, valueVOffset5, verifyAction22, false) && verifier.VerifyField(tablePos, 88, 1UL, 1UL, false))
																									{
																										short typeIdVOffset6 = 88;
																										short valueVOffset6 = 90;
																										VerifyUnionAction verifyAction23;
																										if ((verifyAction23 = ITalkItemVisualNovelNoTextItemVerify.<>O.<19>__Verify) == null)
																										{
																											verifyAction23 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<19>__Verify = new VerifyUnionAction(TVisualNovelCgVerify.Verify));
																										}
																										if (verifier.VerifyUnion(tablePos, typeIdVOffset6, valueVOffset6, verifyAction23, false) && verifier.VerifyField(tablePos, 92, 1UL, 1UL, false))
																										{
																											short typeIdVOffset7 = 92;
																											short valueVOffset7 = 94;
																											VerifyUnionAction verifyAction24;
																											if ((verifyAction24 = ITalkItemVisualNovelNoTextItemVerify.<>O.<20>__Verify) == null)
																											{
																												verifyAction24 = (ITalkItemVisualNovelNoTextItemVerify.<>O.<20>__Verify = new VerifyUnionAction(TVisualNovelDisplayItemVerify.Verify));
																											}
																											if (verifier.VerifyUnion(tablePos, typeIdVOffset7, valueVOffset7, verifyAction24, false) && verifier.VerifyField(tablePos, 96, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 98, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 102, 1UL, false) && verifier.VerifyField(tablePos, 106, 4UL, 4UL, false))
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

		// Token: 0x0200872A RID: 34602
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014C60 RID: 85088
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014C61 RID: 85089
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014C62 RID: 85090
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014C63 RID: 85091
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014C64 RID: 85092
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04014C65 RID: 85093
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04014C66 RID: 85094
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04014C67 RID: 85095
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04014C68 RID: 85096
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04014C69 RID: 85097
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04014C6A RID: 85098
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04014C6B RID: 85099
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04014C6C RID: 85100
			public static VerifyUnionAction <12>__Verify;

			// Token: 0x04014C6D RID: 85101
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04014C6E RID: 85102
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04014C6F RID: 85103
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04014C70 RID: 85104
			public static VerifyTableAction <16>__Verify;

			// Token: 0x04014C71 RID: 85105
			public static VerifyUnionAction <17>__Verify;

			// Token: 0x04014C72 RID: 85106
			public static VerifyUnionAction <18>__Verify;

			// Token: 0x04014C73 RID: 85107
			public static VerifyUnionAction <19>__Verify;

			// Token: 0x04014C74 RID: 85108
			public static VerifyUnionAction <20>__Verify;
		}
	}
}
