using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200454F RID: 17743
	public static class ISequenceBtNodeVerify
	{
		// Token: 0x06019CDD RID: 105693 RVA: 0x003AE888 File Offset: 0x003ACA88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISequenceBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISequenceBtNodeVerify.<>O.<1>__Verify = new VerifyTableAction(IQuestScheduleConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISequenceBtNodeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISequenceBtNodeVerify.<>O.<2>__Verify = new VerifyTableAction(IInformationViewConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISequenceBtNodeVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ISequenceBtNodeVerify.<>O.<3>__Verify = new VerifyTableAction(IInformationBoardConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
							{
								short offsetId5 = 30;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ISequenceBtNodeVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ISequenceBtNodeVerify.<>O.<4>__Verify = new VerifyTableAction(ISaveConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 32;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ISequenceBtNodeVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ISequenceBtNodeVerify.<>O.<5>__Verify = new VerifyTableAction(IForceClosedRestrictionVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyVectorOfStrings(tablePos, 34, false))
									{
										short offsetId7 = 36;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ISequenceBtNodeVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (ISequenceBtNodeVerify.<>O.<6>__Verify = new VerifyTableAction(ILogicNodeOccupationVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false))
										{
											short offsetId8 = 42;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ISequenceBtNodeVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (ISequenceBtNodeVerify.<>O.<7>__Verify = new VerifyTableAction(IQuestStatisticsVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId8, verifyAction8, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false))
											{
												short offsetId9 = 46;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ISequenceBtNodeVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (ISequenceBtNodeVerify.<>O.<8>__Verify = new VerifyTableAction(IQuestRewardConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId9, verifyAction9, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
												{
													short typeIdVOffset = 48;
													short valueVOffset = 50;
													VerifyUnionAction verifyAction10;
													if ((verifyAction10 = ISequenceBtNodeVerify.<>O.<9>__Verify) == null)
													{
														verifyAction10 = (ISequenceBtNodeVerify.<>O.<9>__Verify = new VerifyUnionAction(TSpecialGamePlayConfigVerify.Verify));
													}
													if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction10, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
													{
														short typeIdVOffset2 = 52;
														short valueVOffset2 = 54;
														VerifyUnionAction verifyAction11;
														if ((verifyAction11 = ISequenceBtNodeVerify.<>O.<10>__Verify) == null)
														{
															verifyAction11 = (ISequenceBtNodeVerify.<>O.<10>__Verify = new VerifyUnionAction(TEnableSystemConfigVerify.Verify));
														}
														if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction11, false))
														{
															short offsetId10 = 56;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = ISequenceBtNodeVerify.<>O.<11>__Verify) == null)
															{
																verifyAction12 = (ISequenceBtNodeVerify.<>O.<11>__Verify = new VerifyTableAction(IWaveConfigVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId10, verifyAction12, false))
															{
																short offsetId11 = 58;
																VerifyTableAction verifyAction13;
																if ((verifyAction13 = ISequenceBtNodeVerify.<>O.<12>__Verify) == null)
																{
																	verifyAction13 = (ISequenceBtNodeVerify.<>O.<12>__Verify = new VerifyTableAction(IDisableTrackAnimVerify.Verify));
																}
																if (verifier.VerifyTable(tablePos, offsetId11, verifyAction13, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 62, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 64, 1UL, 1UL, false))
																{
																	short offsetId12 = 66;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ISequenceBtNodeVerify.<>O.<13>__Verify) == null)
																	{
																		verifyAction14 = (ISequenceBtNodeVerify.<>O.<13>__Verify = new VerifyTableAction(ILogicProgramSpecialProcessVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false))
																	{
																		short offsetId13 = 68;
																		VerifyTableAction verifyAction15;
																		if ((verifyAction15 = ISequenceBtNodeVerify.<>O.<14>__Verify) == null)
																		{
																			verifyAction15 = (ISequenceBtNodeVerify.<>O.<14>__Verify = new VerifyTableAction(IQuestBuffActiveRangeVerify.Verify));
																		}
																		if (verifier.VerifyTable(tablePos, offsetId13, verifyAction15, false))
																		{
																			short offsetId14 = 70;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ISequenceBtNodeVerify.<>O.<15>__Verify) == null)
																			{
																				verifyAction16 = (ISequenceBtNodeVerify.<>O.<15>__Verify = new VerifyTableAction(ISunSpiritProcessVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId14, verifyAction16, false))
																			{
																				short offsetId15 = 72;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ISequenceBtNodeVerify.<>O.<16>__Verify) == null)
																				{
																					verifyAction17 = (ISequenceBtNodeVerify.<>O.<16>__Verify = new VerifyTableAction(ITrackAreaTextVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId15, verifyAction17, false) && verifier.VerifyField(tablePos, 74, 1UL, 1UL, false))
																				{
																					short offsetId16 = 76;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ISequenceBtNodeVerify.<>O.<17>__Verify) == null)
																					{
																						verifyAction18 = (ISequenceBtNodeVerify.<>O.<17>__Verify = new VerifyTableAction(IAreaNameSystemPromptVerify.Verify));
																					}
																					if (verifier.VerifyVectorOfTables(tablePos, offsetId16, verifyAction18, false))
																					{
																						short offsetId17 = 78;
																						VerifyTableAction verifyAction19;
																						if ((verifyAction19 = ISequenceBtNodeVerify.<>O.<18>__Verify) == null)
																						{
																							verifyAction19 = (ISequenceBtNodeVerify.<>O.<18>__Verify = new VerifyTableAction(ITrackCustomBoardOnBtLogicNodeVerify.Verify));
																						}
																						if (verifier.VerifyTable(tablePos, offsetId17, verifyAction19, false) && verifier.VerifyVectorOfData(tablePos, 80, 1UL, false))
																						{
																							short offsetId18 = 84;
																							VerifyTableAction verifyAction20;
																							if ((verifyAction20 = ISequenceBtNodeVerify.<>O.<19>__Verify) == null)
																							{
																								verifyAction20 = (ISequenceBtNodeVerify.<>O.<19>__Verify = new VerifyTableAction(IPerformanceSettingVerify.Verify));
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

		// Token: 0x0200819A RID: 33178
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142ED RID: 82669
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040142EE RID: 82670
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040142EF RID: 82671
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040142F0 RID: 82672
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040142F1 RID: 82673
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040142F2 RID: 82674
			public static VerifyTableAction <5>__Verify;

			// Token: 0x040142F3 RID: 82675
			public static VerifyTableAction <6>__Verify;

			// Token: 0x040142F4 RID: 82676
			public static VerifyTableAction <7>__Verify;

			// Token: 0x040142F5 RID: 82677
			public static VerifyTableAction <8>__Verify;

			// Token: 0x040142F6 RID: 82678
			public static VerifyUnionAction <9>__Verify;

			// Token: 0x040142F7 RID: 82679
			public static VerifyUnionAction <10>__Verify;

			// Token: 0x040142F8 RID: 82680
			public static VerifyTableAction <11>__Verify;

			// Token: 0x040142F9 RID: 82681
			public static VerifyTableAction <12>__Verify;

			// Token: 0x040142FA RID: 82682
			public static VerifyTableAction <13>__Verify;

			// Token: 0x040142FB RID: 82683
			public static VerifyTableAction <14>__Verify;

			// Token: 0x040142FC RID: 82684
			public static VerifyTableAction <15>__Verify;

			// Token: 0x040142FD RID: 82685
			public static VerifyTableAction <16>__Verify;

			// Token: 0x040142FE RID: 82686
			public static VerifyTableAction <17>__Verify;

			// Token: 0x040142FF RID: 82687
			public static VerifyTableAction <18>__Verify;

			// Token: 0x04014300 RID: 82688
			public static VerifyTableAction <19>__Verify;
		}
	}
}
