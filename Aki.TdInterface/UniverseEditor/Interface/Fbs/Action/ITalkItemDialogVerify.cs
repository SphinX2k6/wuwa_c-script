using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AB1 RID: 31409
	public static class ITalkItemDialogVerify
	{
		// Token: 0x06037E28 RID: 228904 RVA: 0x00780974 File Offset: 0x0077EB74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false))
			{
				short offsetId = 26;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkItemDialogVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemDialogVerify.<>O.<0>__Verify = new VerifyTableAction(ICaptionParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 28;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITalkItemDialogVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITalkItemDialogVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 30;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITalkItemDialogVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITalkItemDialogVerify.<>O.<2>__Verify = new VerifyTableAction(ITalkOptionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITalkItemDialogVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITalkItemDialogVerify.<>O.<3>__Verify = new VerifyTableAction(IPlayMontageVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 34;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITalkItemDialogVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITalkItemDialogVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraDataVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 36;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITalkItemDialogVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITalkItemDialogVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 38;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITalkItemDialogVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITalkItemDialogVerify.<>O.<5>__Verify = new VerifyTableAction(ISetFlowTemplateVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 40;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITalkItemDialogVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ITalkItemDialogVerify.<>O.<6>__Verify = new VerifyTableAction(IMontageDataVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 42;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ITalkItemDialogVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ITalkItemDialogVerify.<>O.<7>__Verify = new VerifyTableAction(IActorFaceExpressionVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 44;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ITalkItemDialogVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ITalkItemDialogVerify.<>O.<8>__Verify = new VerifyTableAction(IActorLookAtVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 46;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ITalkItemDialogVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ITalkItemDialogVerify.<>O.<9>__Verify = new VerifyTableAction(IActorTurnToVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
														{
															short typeIdVOffset = 48;
															short valueVOffset = 50;
															VerifyUnionAction verifyAction12;
															if ((verifyAction12 = ITalkItemDialogVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ITalkItemDialogVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
															}
															if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction12, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
															{
																short typeIdVOffset2 = 52;
																short valueVOffset2 = 54;
																VerifyUnionAction verifyAction13;
																if ((verifyAction13 = ITalkItemDialogVerify.<>O.<10>__Verify) == null)
																{
																	verifyAction13 = (ITalkItemDialogVerify.<>O.<10>__Verify = new VerifyUnionAction(TPostAkEventVerify.Verify));
																}
																if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction13, false))
																{
																	short offsetId12 = 56;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ITalkItemDialogVerify.<>O.<11>__Verify) == null)
																	{
																		verifyAction14 = (ITalkItemDialogVerify.<>O.<11>__Verify = new VerifyTableAction(IUniversalToneVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
																	{
																		short typeIdVOffset3 = 58;
																		short valueVOffset3 = 60;
																		VerifyUnionAction verifyAction15;
																		if ((verifyAction15 = ITalkItemDialogVerify.<>O.<12>__Verify) == null)
																		{
																			verifyAction15 = (ITalkItemDialogVerify.<>O.<12>__Verify = new VerifyUnionAction(TTalkBackgroundVerify.Verify));
																		}
																		if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction15, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false))
																		{
																			short offsetId13 = 64;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ITalkItemDialogVerify.<>O.<13>__Verify) == null)
																			{
																				verifyAction16 = (ITalkItemDialogVerify.<>O.<13>__Verify = new VerifyTableAction(ITimeLimitOptionGroupVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId13, verifyAction16, false))
																			{
																				short offsetId14 = 66;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ITalkItemDialogVerify.<>O.<14>__Verify) == null)
																				{
																					verifyAction17 = (ITalkItemDialogVerify.<>O.<14>__Verify = new VerifyTableAction(IGamepadShakeInTalkVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId14, verifyAction17, false))
																				{
																					short offsetId15 = 68;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ITalkItemDialogVerify.<>O.<1>__Verify) == null)
																					{
																						verifyAction18 = (ITalkItemDialogVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId15, verifyAction18, false))
																					{
																						short offsetId16 = 70;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ITalkItemDialogVerify.<>O.<15>__Verify) == null)
																						{
																							verifyAction19 = (ITalkItemDialogVerify.<>O.<15>__Verify = new VerifyTableAction(IActorFxEmoteVerify.Verify));
																						}
																						if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 72, 1UL, false))
																						{
																							short offsetId17 = 76;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ITalkItemDialogVerify.<>O.<16>__Verify) == null)
																							{
																								verifyAction20 = (ITalkItemDialogVerify.<>O.<16>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
																							}
																							if (verifier.VerifyVectorOfTables(tablePos, offsetId17, verifyAction20, false) && verifier.VerifyField(tablePos, 78, 1UL, 1UL, false))
																							{
																								short typeIdVOffset4 = 78;
																								short valueVOffset4 = 80;
																								VerifyUnionAction verifyAction21;
																								if ((verifyAction21 = ITalkItemDialogVerify.<>O.<17>__Verify) == null)
																								{
																									verifyAction21 = (ITalkItemDialogVerify.<>O.<17>__Verify = new VerifyUnionAction(TTalkItemStyleVerify.Verify));
																								}
																								if (verifier.VerifyUnion(tablePos, typeIdVOffset4, valueVOffset4, verifyAction21, false) && verifier.VerifyField(tablePos, 82, 1UL, 1UL, false))
																								{
																									short typeIdVOffset5 = 82;
																									short valueVOffset5 = 84;
																									VerifyUnionAction verifyAction22;
																									if ((verifyAction22 = ITalkItemDialogVerify.<>O.<18>__Verify) == null)
																									{
																										verifyAction22 = (ITalkItemDialogVerify.<>O.<18>__Verify = new VerifyUnionAction(TShowTalkCameraMotionVerify.Verify));
																									}
																									if (verifier.VerifyUnion(tablePos, typeIdVOffset5, valueVOffset5, verifyAction22, false))
																									{
																										short offsetId18 = 86;
																										VerifyTableAction verifyAction23;
																										if ((verifyAction23 = ITalkItemDialogVerify.<>O.<19>__Verify) == null)
																										{
																											verifyAction23 = (ITalkItemDialogVerify.<>O.<19>__Verify = new VerifyTableAction(ITalkItemAutoPlayConfigVerify.Verify));
																										}
																										if (verifier.VerifyTable(tablePos, offsetId18, verifyAction23, false) && verifier.VerifyField(tablePos, 88, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 90, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 92, 4UL, 4UL, false))
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
			return false;
		}

		// Token: 0x02008721 RID: 34593
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014BC9 RID: 84937
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014BCA RID: 84938
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014BCB RID: 84939
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014BCC RID: 84940
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014BCD RID: 84941
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04014BCE RID: 84942
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04014BCF RID: 84943
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04014BD0 RID: 84944
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04014BD1 RID: 84945
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04014BD2 RID: 84946
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04014BD3 RID: 84947
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04014BD4 RID: 84948
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04014BD5 RID: 84949
			public static VerifyUnionAction <12>__Verify;

			// Token: 0x04014BD6 RID: 84950
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04014BD7 RID: 84951
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04014BD8 RID: 84952
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04014BD9 RID: 84953
			public static VerifyTableAction <16>__Verify;

			// Token: 0x04014BDA RID: 84954
			public static VerifyUnionAction <17>__Verify;

			// Token: 0x04014BDB RID: 84955
			public static VerifyUnionAction <18>__Verify;

			// Token: 0x04014BDC RID: 84956
			public static VerifyTableAction <19>__Verify;
		}
	}
}
