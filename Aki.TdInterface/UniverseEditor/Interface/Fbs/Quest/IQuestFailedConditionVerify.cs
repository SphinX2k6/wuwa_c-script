using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FD9 RID: 16345
	public static class IQuestFailedConditionVerify
	{
		// Token: 0x06017850 RID: 96336 RVA: 0x003646A0 File Offset: 0x003628A0
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
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 20, 4UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestFailedConditionVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IQuestFailedConditionVerify.<>O.<2>__Verify = new VerifyTableAction(IRangeLimitingConditionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IQuestFailedConditionVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IQuestFailedConditionVerify.<>O.<3>__Verify = new VerifyTableAction(IEntityDistanceLimitingConditionVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 26;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IQuestFailedConditionVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IQuestFailedConditionVerify.<>O.<4>__Verify = new VerifyTableAction(IQuestFailedConditionEntityAlertVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 28;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IQuestFailedConditionVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IQuestFailedConditionVerify.<>O.<5>__Verify = new VerifyTableAction(IQuestFailedConditionEntityDeathVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 30;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IQuestFailedConditionVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (IQuestFailedConditionVerify.<>O.<6>__Verify = new VerifyTableAction(IQuestFailedConditionEntityStateVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 32;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IQuestFailedConditionVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (IQuestFailedConditionVerify.<>O.<7>__Verify = new VerifyTableAction(ISneakPlayConditionVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 34;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IQuestFailedConditionVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (IQuestFailedConditionVerify.<>O.<8>__Verify = new VerifyTableAction(IQuestFailedConditionPlayerMotionStateVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 36;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = IQuestFailedConditionVerify.<>O.<9>__Verify) == null)
													{
														verifyAction10 = (IQuestFailedConditionVerify.<>O.<9>__Verify = new VerifyTableAction(IQuestFailedConditionPlayerMovementModeVerify.Verify));
													}
													if (verifier.VerifyTable(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 38;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = IQuestFailedConditionVerify.<>O.<10>__Verify) == null)
														{
															verifyAction11 = (IQuestFailedConditionVerify.<>O.<10>__Verify = new VerifyTableAction(ICheckDataLayerVerify.Verify));
														}
														if (verifier.VerifyTable(tablePos, offsetId11, verifyAction11, false))
														{
															short offsetId12 = 40;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = IQuestFailedConditionVerify.<>O.<11>__Verify) == null)
															{
																verifyAction12 = (IQuestFailedConditionVerify.<>O.<11>__Verify = new VerifyTableAction(IFailedTeleportVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId12, verifyAction12, false))
															{
																short offsetId13 = 42;
																VerifyTableAction verifyAction13;
																if ((verifyAction13 = IQuestFailedConditionVerify.<>O.<12>__Verify) == null)
																{
																	verifyAction13 = (IQuestFailedConditionVerify.<>O.<12>__Verify = new VerifyTableAction(IAddTimeConfigVerify.Verify));
																}
																if (verifier.VerifyTable(tablePos, offsetId13, verifyAction13, false))
																{
																	short offsetId14 = 44;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = IQuestFailedConditionVerify.<>O.<13>__Verify) == null)
																	{
																		verifyAction14 = (IQuestFailedConditionVerify.<>O.<13>__Verify = new VerifyTableAction(ICompareVarConditionInQuestFailedVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId14, verifyAction14, false))
																	{
																		short offsetId15 = 46;
																		VerifyTableAction verifyAction15;
																		if ((verifyAction15 = IQuestFailedConditionVerify.<>O.<14>__Verify) == null)
																		{
																			verifyAction15 = (IQuestFailedConditionVerify.<>O.<14>__Verify = new VerifyTableAction(IRecallFishingBoatVerify.Verify));
																		}
																		if (verifier.VerifyTable(tablePos, offsetId15, verifyAction15, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false))
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

		// Token: 0x02007928 RID: 31016
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013222 RID: 78370
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013223 RID: 78371
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013224 RID: 78372
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013225 RID: 78373
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013226 RID: 78374
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013227 RID: 78375
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013228 RID: 78376
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013229 RID: 78377
			public static VerifyTableAction <7>__Verify;

			// Token: 0x0401322A RID: 78378
			public static VerifyTableAction <8>__Verify;

			// Token: 0x0401322B RID: 78379
			public static VerifyTableAction <9>__Verify;

			// Token: 0x0401322C RID: 78380
			public static VerifyTableAction <10>__Verify;

			// Token: 0x0401322D RID: 78381
			public static VerifyTableAction <11>__Verify;

			// Token: 0x0401322E RID: 78382
			public static VerifyTableAction <12>__Verify;

			// Token: 0x0401322F RID: 78383
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04013230 RID: 78384
			public static VerifyTableAction <14>__Verify;
		}
	}
}
