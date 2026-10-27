using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410B RID: 16651
	public static class ISelectBtNodeVerify
	{
		// Token: 0x06018558 RID: 99672 RVA: 0x00381670 File Offset: 0x0037F870
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISelectBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISelectBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISelectBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISelectBtNodeVerify.<>O.<1>__Verify = new VerifyTableAction(IQuestScheduleConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISelectBtNodeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISelectBtNodeVerify.<>O.<2>__Verify = new VerifyTableAction(IInformationViewConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISelectBtNodeVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ISelectBtNodeVerify.<>O.<3>__Verify = new VerifyTableAction(IInformationBoardConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								short offsetId5 = 30;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ISelectBtNodeVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ISelectBtNodeVerify.<>O.<4>__Verify = new VerifyTableAction(ISaveConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 32;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ISelectBtNodeVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ISelectBtNodeVerify.<>O.<5>__Verify = new VerifyTableAction(IForceClosedRestrictionVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyVectorOfStrings(tablePos, 34, false))
									{
										short offsetId7 = 36;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ISelectBtNodeVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (ISelectBtNodeVerify.<>O.<6>__Verify = new VerifyTableAction(ILogicNodeOccupationVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false))
										{
											short offsetId8 = 42;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ISelectBtNodeVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (ISelectBtNodeVerify.<>O.<7>__Verify = new VerifyTableAction(IQuestStatisticsVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId8, verifyAction8, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false))
											{
												short offsetId9 = 46;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ISelectBtNodeVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (ISelectBtNodeVerify.<>O.<8>__Verify = new VerifyTableAction(IQuestRewardConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId9, verifyAction9, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
												{
													short typeIdVOffset = 48;
													short valueVOffset = 50;
													VerifyUnionAction verifyAction10;
													if ((verifyAction10 = ISelectBtNodeVerify.<>O.<9>__Verify) == null)
													{
														verifyAction10 = (ISelectBtNodeVerify.<>O.<9>__Verify = new VerifyUnionAction(TSpecialGamePlayConfigVerify.Verify));
													}
													if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction10, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
													{
														short typeIdVOffset2 = 52;
														short valueVOffset2 = 54;
														VerifyUnionAction verifyAction11;
														if ((verifyAction11 = ISelectBtNodeVerify.<>O.<10>__Verify) == null)
														{
															verifyAction11 = (ISelectBtNodeVerify.<>O.<10>__Verify = new VerifyUnionAction(TEnableSystemConfigVerify.Verify));
														}
														if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction11, false))
														{
															short offsetId10 = 56;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = ISelectBtNodeVerify.<>O.<11>__Verify) == null)
															{
																verifyAction12 = (ISelectBtNodeVerify.<>O.<11>__Verify = new VerifyTableAction(IWaveConfigVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId10, verifyAction12, false))
															{
																short offsetId11 = 58;
																VerifyTableAction verifyAction13;
																if ((verifyAction13 = ISelectBtNodeVerify.<>O.<12>__Verify) == null)
																{
																	verifyAction13 = (ISelectBtNodeVerify.<>O.<12>__Verify = new VerifyTableAction(IDisableTrackAnimVerify.Verify));
																}
																if (verifier.VerifyTable(tablePos, offsetId11, verifyAction13, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 64, 1UL, 1UL, false))
																{
																	short offsetId12 = 66;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ISelectBtNodeVerify.<>O.<13>__Verify) == null)
																	{
																		verifyAction14 = (ISelectBtNodeVerify.<>O.<13>__Verify = new VerifyTableAction(ILogicProgramSpecialProcessVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false))
																	{
																		short offsetId13 = 68;
																		VerifyTableAction verifyAction15;
																		if ((verifyAction15 = ISelectBtNodeVerify.<>O.<14>__Verify) == null)
																		{
																			verifyAction15 = (ISelectBtNodeVerify.<>O.<14>__Verify = new VerifyTableAction(IQuestBuffActiveRangeVerify.Verify));
																		}
																		if (verifier.VerifyTable(tablePos, offsetId13, verifyAction15, false))
																		{
																			short offsetId14 = 70;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ISelectBtNodeVerify.<>O.<15>__Verify) == null)
																			{
																				verifyAction16 = (ISelectBtNodeVerify.<>O.<15>__Verify = new VerifyTableAction(ISunSpiritProcessVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId14, verifyAction16, false))
																			{
																				short offsetId15 = 72;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ISelectBtNodeVerify.<>O.<16>__Verify) == null)
																				{
																					verifyAction17 = (ISelectBtNodeVerify.<>O.<16>__Verify = new VerifyTableAction(ITrackAreaTextVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId15, verifyAction17, false) && verifier.VerifyField(tablePos, 74, 1UL, 1UL, false))
																				{
																					short offsetId16 = 76;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ISelectBtNodeVerify.<>O.<17>__Verify) == null)
																					{
																						verifyAction18 = (ISelectBtNodeVerify.<>O.<17>__Verify = new VerifyTableAction(IAreaNameSystemPromptVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction18, false))
																					{
																						short offsetId17 = 78;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ISelectBtNodeVerify.<>O.<18>__Verify) == null)
																						{
																							verifyAction19 = (ISelectBtNodeVerify.<>O.<18>__Verify = new VerifyTableAction(ITrackCustomBoardOnBtLogicNodeVerify.Verify));
																						}
																						if (verifier.VerifyTable(tablePos, offsetId17, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 80, 1UL, false))
																						{
																							short offsetId18 = 84;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ISelectBtNodeVerify.<>O.<19>__Verify) == null)
																							{
																								verifyAction20 = (ISelectBtNodeVerify.<>O.<19>__Verify = new VerifyTableAction(IPerformanceSettingVerify.Verify));
																							}
																							if (verifier.VerifyTable(tablePos, offsetId18, verifyAction20, false) && verifier.VerifyField(tablePos, 86, 2UL, 2UL, false))
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

		// Token: 0x02007952 RID: 31058
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013276 RID: 78454
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013277 RID: 78455
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013278 RID: 78456
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013279 RID: 78457
			public static VerifyTableAction <3>__Verify;

			// Token: 0x0401327A RID: 78458
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401327B RID: 78459
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401327C RID: 78460
			public static VerifyTableAction <6>__Verify;

			// Token: 0x0401327D RID: 78461
			public static VerifyTableAction <7>__Verify;

			// Token: 0x0401327E RID: 78462
			public static VerifyTableAction <8>__Verify;

			// Token: 0x0401327F RID: 78463
			public static VerifyUnionAction <9>__Verify;

			// Token: 0x04013280 RID: 78464
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x04013281 RID: 78465
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04013282 RID: 78466
			public static VerifyTableAction <12>__Verify;

			// Token: 0x04013283 RID: 78467
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04013284 RID: 78468
			public static VerifyTableAction <14>__Verify;

			// Token: 0x04013285 RID: 78469
			public static VerifyTableAction <15>__Verify;

			// Token: 0x04013286 RID: 78470
			public static VerifyTableAction <16>__Verify;

			// Token: 0x04013287 RID: 78471
			public static VerifyTableAction <17>__Verify;

			// Token: 0x04013288 RID: 78472
			public static VerifyTableAction <18>__Verify;

			// Token: 0x04013289 RID: 78473
			public static VerifyTableAction <19>__Verify;
		}
	}
}
