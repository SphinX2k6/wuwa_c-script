using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200731B RID: 29467
	public static class ITalkItemVisualNovelTalkVerify
	{
		// Token: 0x0603574C RID: 218956 RVA: 0x00747EC4 File Offset: 0x007460C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
			{
				short offsetId = 26;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemVisualNovelTalkVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemVisualNovelTalkVerify.<>O.<0>__Verify = new VerifyTableAction(ICaptionParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkItemVisualNovelTalkVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkItemVisualNovelTalkVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITalkItemVisualNovelTalkVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkItemVisualNovelTalkVerify.<>O.<2>__Verify = new VerifyTableAction(ITalkOptionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkItemVisualNovelTalkVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkItemVisualNovelTalkVerify.<>O.<3>__Verify = new VerifyTableAction(IPlayMontageVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 34;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITalkItemVisualNovelTalkVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkItemVisualNovelTalkVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 36;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITalkItemVisualNovelTalkVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITalkItemVisualNovelTalkVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 38;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITalkItemVisualNovelTalkVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITalkItemVisualNovelTalkVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 40;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITalkItemVisualNovelTalkVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ITalkItemVisualNovelTalkVerify.<>O.<6>__Verify = new VerifyTableAction(IMontageDataVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 42;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ITalkItemVisualNovelTalkVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ITalkItemVisualNovelTalkVerify.<>O.<7>__Verify = new VerifyTableAction(IActorFaceExpressionVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 44;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ITalkItemVisualNovelTalkVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ITalkItemVisualNovelTalkVerify.<>O.<8>__Verify = new VerifyTableAction(IActorLookAtVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 46;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ITalkItemVisualNovelTalkVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ITalkItemVisualNovelTalkVerify.<>O.<9>__Verify = new VerifyTableAction(IActorTurnToVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
														{
															short typeIdVOffset = 48;
															short valueVOffset = 50;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = ITalkItemVisualNovelTalkVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ITalkItemVisualNovelTalkVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction12, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
															{
																short typeIdVOffset2 = 52;
																short valueVOffset2 = 54;
																VerifyUnionAction verifyAction13;
																if ((verifyAction13 = ITalkItemVisualNovelTalkVerify.<>O.<10>__Verify) == null)
																{
																	verifyAction13 = (ITalkItemVisualNovelTalkVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
																}
																if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction13, false))
																{
																	short offsetId12 = 56;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ITalkItemVisualNovelTalkVerify.<>O.<11>__Verify) == null)
																	{
																		verifyAction14 = (ITalkItemVisualNovelTalkVerify.<>O.<11>__Verify = new VerifyTableAction(IUniversalToneVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
																	{
																		short typeIdVOffset3 = 58;
																		short valueVOffset3 = 60;
																		VerifyUnionAction verifyAction15;
																		if ((verifyAction15 = ITalkItemVisualNovelTalkVerify.<>O.<12>__Verify) == null)
																		{
																			verifyAction15 = (ITalkItemVisualNovelTalkVerify.<>O.<12>__Verify = new VerifyUnionAction(TTalkBackgroundVerify.Verify));
																		}
																		if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction15, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
																		{
																			short offsetId13 = 64;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ITalkItemVisualNovelTalkVerify.<>O.<13>__Verify) == null)
																			{
																				verifyAction16 = (ITalkItemVisualNovelTalkVerify.<>O.<13>__Verify = new VerifyTableAction(ITimeLimitOptionGroupVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId13, verifyAction16, false))
																			{
																				short offsetId14 = 66;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ITalkItemVisualNovelTalkVerify.<>O.<14>__Verify) == null)
																				{
																					verifyAction17 = (ITalkItemVisualNovelTalkVerify.<>O.<14>__Verify = new VerifyTableAction(IGamepadShakeInTalkVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId14, verifyAction17, false))
																				{
																					short offsetId15 = 68;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ITalkItemVisualNovelTalkVerify.<>O.<1>__Verify) == null)
																					{
																						verifyAction18 = (ITalkItemVisualNovelTalkVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId15, verifyAction18, false))
																					{
																						short offsetId16 = 70;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ITalkItemVisualNovelTalkVerify.<>O.<15>__Verify) == null)
																						{
																							verifyAction19 = (ITalkItemVisualNovelTalkVerify.<>O.<15>__Verify = new VerifyTableAction(IActorFxEmoteVerify.Verify));
																						}
																						if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 72, 1UL, false))
																						{
																							short offsetId17 = 76;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ITalkItemVisualNovelTalkVerify.<>O.<16>__Verify) == null)
																							{
																								verifyAction20 = (ITalkItemVisualNovelTalkVerify.<>O.<16>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
																							}
																							if (verifier.VerifyVectorOfTables(tablePos, offsetId17, verifyAction20, false) && verifier.VerifyField(tablePos, 78, 1UL, 1UL, false))
																							{
																								short offsetId18 = 80;
																								VerifyTableAction verifyAction21;
																								if ((verifyAction21 = ITalkItemVisualNovelTalkVerify.<>O.<17>__Verify) == null)
																								{
																									verifyAction21 = (ITalkItemVisualNovelTalkVerify.<>O.<17>__Verify = new VerifyTableAction(IVisualNovelOptionGroupSolarSchoolExamVerify.Verify));
																								}
																								if (verifier.VerifyTable(tablePos, offsetId18, verifyAction21, false) && verifier.VerifyField(tablePos, 82, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 84, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 86, false))
																								{
																									short offsetId19 = 88;
																									VerifyTableAction verifyAction22;
																									if ((verifyAction22 = ITalkItemVisualNovelTalkVerify.<>O.<18>__Verify) == null)
																									{
																										verifyAction22 = (ITalkItemVisualNovelTalkVerify.<>O.<18>__Verify = new VerifyTableAction(IVisualNovelPortraitTransformVerify.Verify));
																									}
																									if (verifier.VerifyTable(tablePos, offsetId19, verifyAction22, false))
																									{
																										short offsetId20 = 90;
																										VerifyTableAction verifyAction23;
																										if ((verifyAction23 = ITalkItemVisualNovelTalkVerify.<>O.<19>__Verify) == null)
																										{
																											verifyAction23 = (ITalkItemVisualNovelTalkVerify.<>O.<19>__Verify = new VerifyTableAction(IVisualNovelRoleConfigVerify.Verify));
																										}
																										if (verifier.VerifyTable(tablePos, offsetId20, verifyAction23, false) && verifier.VerifyField(tablePos, 92, 1UL, 1UL, false))
																										{
																											short typeIdVOffset4 = 92;
																											short valueVOffset4 = 94;
																											VerifyUnionAction verifyAction24;
																											if ((verifyAction24 = ITalkItemVisualNovelTalkVerify.<>O.<20>__Verify) == null)
																											{
																												verifyAction24 = (ITalkItemVisualNovelTalkVerify.<>O.<20>__Verify = new VerifyUnionAction(TVisualNovelBackgroundVerify.Verify));
																											}
																											if (verifier.VerifyUnion(tablePos, typeIdVOffset4, valueVOffset4, verifyAction24, false) && verifier.VerifyField(tablePos, 96, 1UL, 1UL, false))
																											{
																												short typeIdVOffset5 = 96;
																												short valueVOffset5 = 98;
																												VerifyUnionAction verifyAction25;
																												if ((verifyAction25 = ITalkItemVisualNovelTalkVerify.<>O.<21>__Verify) == null)
																												{
																													verifyAction25 = (ITalkItemVisualNovelTalkVerify.<>O.<21>__Verify = new VerifyUnionAction(TVisualNovelCgVerify.Verify));
																												}
																												if (verifier.VerifyUnion(tablePos, typeIdVOffset5, valueVOffset5, verifyAction25, false) && verifier.VerifyField(tablePos, 100, 1UL, 1UL, false))
																												{
																													short typeIdVOffset6 = 100;
																													short valueVOffset6 = 102;
																													VerifyUnionAction verifyAction26;
																													if ((verifyAction26 = ITalkItemVisualNovelTalkVerify.<>O.<22>__Verify) == null)
																													{
																														verifyAction26 = (ITalkItemVisualNovelTalkVerify.<>O.<22>__Verify = new VerifyUnionAction(TVisualNovelDisplayItemVerify.Verify));
																													}
																													if (verifier.VerifyUnion(tablePos, typeIdVOffset6, valueVOffset6, verifyAction26, false) && verifier.VerifyField(tablePos, 104, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 106, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 110, 1UL, false) && verifier.VerifyField(tablePos, 114, 4UL, 4UL, false))
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
				}
			}
			return false;
		}

		// Token: 0x02007E94 RID: 32404
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BB2 RID: 80818
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013BB3 RID: 80819
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013BB4 RID: 80820
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013BB5 RID: 80821
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013BB6 RID: 80822
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013BB7 RID: 80823
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013BB8 RID: 80824
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013BB9 RID: 80825
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013BBA RID: 80826
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04013BBB RID: 80827
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04013BBC RID: 80828
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04013BBD RID: 80829
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04013BBE RID: 80830
			public static VerifyUnionAction <12>__Verify;

			// Token: 0x04013BBF RID: 80831
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04013BC0 RID: 80832
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04013BC1 RID: 80833
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04013BC2 RID: 80834
			public static VerifyTableAction <16>__Verify;

			// Token: 0x04013BC3 RID: 80835
			public static VerifyTableAction <17>__Verify;

			// Token: 0x04013BC4 RID: 80836
			public static VerifyTableAction <18>__Verify;

			// Token: 0x04013BC5 RID: 80837
			public static VerifyTableAction <19>__Verify;

			// Token: 0x04013BC6 RID: 80838
			public static VerifyUnionAction <20>__Verify;

			// Token: 0x04013BC7 RID: 80839
			public static VerifyUnionAction <21>__Verify;

			// Token: 0x04013BC8 RID: 80840
			public static VerifyUnionAction <22>__Verify;
		}
	}
}
