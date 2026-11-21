using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200441A RID: 17434
	public static class IQuestFailedConditionVerify
	{
		// Token: 0x06018EE9 RID: 102121 RVA: 0x0038E484 File Offset: 0x0038C684
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestFailedConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestFailedConditionVerify.<>O.<0>__Verify = new VerifyTableAction(ITimerConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestFailedConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestFailedConditionVerify.<>O.<1>__Verify = new VerifyTableAction(ITimeRangeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 22, 4UL, false))
					{
						short offsetId3 = 24;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestFailedConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuestFailedConditionVerify.<>O.<2>__Verify = new VerifyTableAction(IRangeLimitingConditionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 26;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IQuestFailedConditionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IQuestFailedConditionVerify.<>O.<3>__Verify = new VerifyTableAction(IEntityDistanceLimitingConditionVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 28;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IQuestFailedConditionVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IQuestFailedConditionVerify.<>O.<4>__Verify = new VerifyTableAction(IQuestFailedConditionEntityAlertVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 30;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IQuestFailedConditionVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IQuestFailedConditionVerify.<>O.<5>__Verify = new VerifyTableAction(IQuestFailedConditionEntityDeathVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 32;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IQuestFailedConditionVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (IQuestFailedConditionVerify.<>O.<6>__Verify = new VerifyTableAction(IQuestFailedConditionEntityStateVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 34;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IQuestFailedConditionVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (IQuestFailedConditionVerify.<>O.<7>__Verify = new VerifyTableAction(ISneakPlayConditionVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 36;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IQuestFailedConditionVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (IQuestFailedConditionVerify.<>O.<8>__Verify = new VerifyTableAction(IQuestFailedConditionPlayerMotionStateVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 38;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = IQuestFailedConditionVerify.<>O.<9>__Verify) == null)
													{
														verifyAction10 = (IQuestFailedConditionVerify.<>O.<9>__Verify = new VerifyTableAction(IQuestFailedConditionPlayerMovementModeVerify.Verify));
													}
													if (verifier.VerifyTable(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 40;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = IQuestFailedConditionVerify.<>O.<10>__Verify) == null)
														{
															verifyAction11 = (IQuestFailedConditionVerify.<>O.<10>__Verify = new VerifyTableAction(ICheckDataLayerVerify.Verify));
														}
														if (verifier.VerifyTable(tablePos, offsetId11, verifyAction11, false))
														{
															short offsetId12 = 42;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = IQuestFailedConditionVerify.<>O.<11>__Verify) == null)
															{
																verifyAction12 = (IQuestFailedConditionVerify.<>O.<11>__Verify = new VerifyTableAction(IFailedTeleportVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId12, verifyAction12, false))
															{
																short offsetId13 = 44;
																VerifyTableAction verifyAction13;
																if ((verifyAction13 = IQuestFailedConditionVerify.<>O.<12>__Verify) == null)
																{
																	verifyAction13 = (IQuestFailedConditionVerify.<>O.<12>__Verify = new VerifyTableAction(IAddTimeConfigVerify.Verify));
																}
																if (verifier.VerifyTable(tablePos, offsetId13, verifyAction13, false))
																{
																	short offsetId14 = 46;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = IQuestFailedConditionVerify.<>O.<13>__Verify) == null)
																	{
																		verifyAction14 = (IQuestFailedConditionVerify.<>O.<13>__Verify = new VerifyTableAction(ICompareVarConditionInQuestFailedVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId14, verifyAction14, false))
																	{
																		short offsetId15 = 48;
																		VerifyTableAction verifyAction15;
																		if ((verifyAction15 = IQuestFailedConditionVerify.<>O.<14>__Verify) == null)
																		{
																			verifyAction15 = (IQuestFailedConditionVerify.<>O.<14>__Verify = new VerifyTableAction(IRecallFishingBoatVerify.Verify));
																		}
																		if (verifier.VerifyTable(tablePos, offsetId15, verifyAction15, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
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
			return false;
		}

		// Token: 0x0200816F RID: 33135
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014285 RID: 82565
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014286 RID: 82566
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014287 RID: 82567
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014288 RID: 82568
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014289 RID: 82569
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401428A RID: 82570
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401428B RID: 82571
			public static VerifyTableAction <6>__Verify;

			// Token: 0x0401428C RID: 82572
			public static VerifyTableAction <7>__Verify;

			// Token: 0x0401428D RID: 82573
			public static VerifyTableAction <8>__Verify;

			// Token: 0x0401428E RID: 82574
			public static VerifyTableAction <9>__Verify;

			// Token: 0x0401428F RID: 82575
			public static VerifyTableAction <10>__Verify;

			// Token: 0x04014290 RID: 82576
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04014291 RID: 82577
			public static VerifyTableAction <12>__Verify;

			// Token: 0x04014292 RID: 82578
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04014293 RID: 82579
			public static VerifyTableAction <14>__Verify;
		}
	}
}
