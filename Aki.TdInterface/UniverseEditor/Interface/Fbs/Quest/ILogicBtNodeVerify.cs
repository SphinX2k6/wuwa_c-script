using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200434E RID: 17230
	public static class ILogicBtNodeVerify
	{
		// Token: 0x060184D3 RID: 99539 RVA: 0x003771E4 File Offset: 0x003753E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILogicBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILogicBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILogicBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILogicBtNodeVerify.<>O.<1>__Verify = new VerifyTableAction(IQuestScheduleConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILogicBtNodeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ILogicBtNodeVerify.<>O.<2>__Verify = new VerifyTableAction(IInformationViewConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ILogicBtNodeVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ILogicBtNodeVerify.<>O.<3>__Verify = new VerifyTableAction(IInformationBoardConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								short offsetId5 = 30;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ILogicBtNodeVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ILogicBtNodeVerify.<>O.<4>__Verify = new VerifyTableAction(ISaveConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 32;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ILogicBtNodeVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ILogicBtNodeVerify.<>O.<5>__Verify = new VerifyTableAction(IForceClosedRestrictionVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyVectorOfStrings(tablePos, 34, false))
									{
										short offsetId7 = 36;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ILogicBtNodeVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (ILogicBtNodeVerify.<>O.<6>__Verify = new VerifyTableAction(ILogicNodeOccupationVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false))
										{
											short offsetId8 = 42;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ILogicBtNodeVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (ILogicBtNodeVerify.<>O.<7>__Verify = new VerifyTableAction(IQuestStatisticsVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId8, verifyAction8, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false))
											{
												short offsetId9 = 46;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ILogicBtNodeVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (ILogicBtNodeVerify.<>O.<8>__Verify = new VerifyTableAction(IQuestRewardConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId9, verifyAction9, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
												{
													short typeIdVOffset = 48;
													short valueVOffset = 50;
													VerifyUnionAction verifyAction10;
													if ((verifyAction10 = ILogicBtNodeVerify.<>O.<9>__Verify) == null)
													{
														verifyAction10 = (ILogicBtNodeVerify.<>O.<9>__Verify = new VerifyUnionAction(TSpecialGamePlayConfigVerify.Verify));
													}
													if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction10, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
													{
														short typeIdVOffset2 = 52;
														short valueVOffset2 = 54;
														VerifyUnionAction verifyAction11;
														if ((verifyAction11 = ILogicBtNodeVerify.<>O.<10>__Verify) == null)
														{
															verifyAction11 = (ILogicBtNodeVerify.<>O.<10>__Verify = new VerifyUnionAction(TEnableSystemConfigVerify.Verify));
														}
														if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction11, false))
														{
															short offsetId10 = 56;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = ILogicBtNodeVerify.<>O.<11>__Verify) == null)
															{
																verifyAction12 = (ILogicBtNodeVerify.<>O.<11>__Verify = new VerifyTableAction(IWaveConfigVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId10, verifyAction12, false))
															{
																short offsetId11 = 58;
																VerifyTableAction verifyAction13;
																if ((verifyAction13 = ILogicBtNodeVerify.<>O.<12>__Verify) == null)
																{
																	verifyAction13 = (ILogicBtNodeVerify.<>O.<12>__Verify = new VerifyTableAction(IDisableTrackAnimVerify.Verify));
																}
																if (verifier.VerifyTable(tablePos, offsetId11, verifyAction13, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 64, 1UL, 1UL, false))
																{
																	short offsetId12 = 66;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ILogicBtNodeVerify.<>O.<13>__Verify) == null)
																	{
																		verifyAction14 = (ILogicBtNodeVerify.<>O.<13>__Verify = new VerifyTableAction(ILogicProgramSpecialProcessVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false))
																	{
																		short offsetId13 = 68;
																		VerifyTableAction verifyAction15;
																		if ((verifyAction15 = ILogicBtNodeVerify.<>O.<14>__Verify) == null)
																		{
																			verifyAction15 = (ILogicBtNodeVerify.<>O.<14>__Verify = new VerifyTableAction(IQuestBuffActiveRangeVerify.Verify));
																		}
																		if (verifier.VerifyTable(tablePos, offsetId13, verifyAction15, false))
																		{
																			short offsetId14 = 70;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ILogicBtNodeVerify.<>O.<15>__Verify) == null)
																			{
																				verifyAction16 = (ILogicBtNodeVerify.<>O.<15>__Verify = new VerifyTableAction(ISunSpiritProcessVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId14, verifyAction16, false))
																			{
																				short offsetId15 = 72;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ILogicBtNodeVerify.<>O.<16>__Verify) == null)
																				{
																					verifyAction17 = (ILogicBtNodeVerify.<>O.<16>__Verify = new VerifyTableAction(ITrackAreaTextVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId15, verifyAction17, false) && verifier.VerifyField(tablePos, 74, 1UL, 1UL, false))
																				{
																					short offsetId16 = 76;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ILogicBtNodeVerify.<>O.<17>__Verify) == null)
																					{
																						verifyAction18 = (ILogicBtNodeVerify.<>O.<17>__Verify = new VerifyTableAction(IAreaNameSystemPromptVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction18, false))
																					{
																						short offsetId17 = 78;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ILogicBtNodeVerify.<>O.<18>__Verify) == null)
																						{
																							verifyAction19 = (ILogicBtNodeVerify.<>O.<18>__Verify = new VerifyTableAction(ITrackCustomBoardOnBtLogicNodeVerify.Verify));
																						}
																						if (verifier.VerifyTable(tablePos, offsetId17, verifyAction19, false) && verifier.VerifyField(tablePos, 80, 2UL, 2UL, false))
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
			return false;
		}

		// Token: 0x0200814B RID: 33099
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014225 RID: 82469
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014226 RID: 82470
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014227 RID: 82471
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014228 RID: 82472
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014229 RID: 82473
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401422A RID: 82474
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401422B RID: 82475
			public static VerifyTableAction <6>__Verify;

			// Token: 0x0401422C RID: 82476
			public static VerifyTableAction <7>__Verify;

			// Token: 0x0401422D RID: 82477
			public static VerifyTableAction <8>__Verify;

			// Token: 0x0401422E RID: 82478
			public static VerifyUnionAction <9>__Verify;

			// Token: 0x0401422F RID: 82479
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04014230 RID: 82480
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04014231 RID: 82481
			public static VerifyTableAction <12>__Verify;

			// Token: 0x04014232 RID: 82482
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04014233 RID: 82483
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04014234 RID: 82484
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04014235 RID: 82485
			public static VerifyTableAction <16>__Verify;

			// Token: 0x04014236 RID: 82486
			public static VerifyTableAction <17>__Verify;

			// Token: 0x04014237 RID: 82487
			public static VerifyTableAction <18>__Verify;
		}
	}
}
