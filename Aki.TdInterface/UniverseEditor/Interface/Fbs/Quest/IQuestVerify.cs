using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004408 RID: 17416
	public static class IQuestVerify
	{
		// Token: 0x06018D3F RID: 101695 RVA: 0x0038A2D4 File Offset: 0x003884D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 20, 1UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyString(tablePos, 26, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 40, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 42, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 44, false) && verifier.VerifyField(tablePos, 46, 1UL, 1UL, false))
			{
				short offsetId = 48;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestVerify.<>O.<0>__Verify = new VerifyTableAction(IDistributeParamsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
				{
					short offsetId2 = 54;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IQuestVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IQuestVerify.<>O.<1>__Verify = new VerifyTableAction(IAccessQuestConditionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 56;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IQuestVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IQuestVerify.<>O.<1>__Verify = new VerifyTableAction(IAccessQuestConditionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyVectorOfData(tablePos, 58, 4UL, false) && verifier.VerifyField(tablePos, 60, 4UL, 4UL, false))
						{
							short offsetId4 = 62;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IQuestVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IQuestVerify.<>O.<2>__Verify = new VerifyTableAction(IQuestUnlockDelayTimeVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 64;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IQuestVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IQuestVerify.<>O.<3>__Verify = new VerifyTableAction(IPreShowInfoVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 66;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IQuestVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (IQuestVerify.<>O.<4>__Verify = new VerifyTableAction(IAddInteractOptionVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 68;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IQuestVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (IQuestVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 70;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IQuestVerify.<>O.<5>__Verify) == null)
											{
												verifyAction8 = (IQuestVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction8, false))
											{
												short offsetId9 = 72;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IQuestVerify.<>O.<5>__Verify) == null)
												{
													verifyAction9 = (IQuestVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
												}
												if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction9, false))
												{
													short offsetId10 = 74;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = IQuestVerify.<>O.<5>__Verify) == null)
													{
														verifyAction10 = (IQuestVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction10, false))
													{
														short offsetId11 = 76;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = IQuestVerify.<>O.<5>__Verify) == null)
														{
															verifyAction11 = (IQuestVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction11, false) && verifier.VerifyVectorOfData(tablePos, 78, 4UL, false) && verifier.VerifyField(tablePos, 80, 4UL, 4UL, false))
														{
															short offsetId12 = 82;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = IQuestVerify.<>O.<6>__Verify) == null)
															{
																verifyAction12 = (IQuestVerify.<>O.<6>__Verify = new VerifyTableAction(IFocusModeSettingVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId12, verifyAction12, false))
															{
																short offsetId13 = 84;
																VerifyTableAction verifyAction13;
																if ((verifyAction13 = IQuestVerify.<>O.<7>__Verify) == null)
																{
																	verifyAction13 = (IQuestVerify.<>O.<7>__Verify = new VerifyTableAction(IHardBattleModeSettingVerify.Verify));
																}
																if (verifier.VerifyTable(tablePos, offsetId13, verifyAction13, false) && verifier.VerifyField(tablePos, 86, 1UL, 1UL, false))
																{
																	short offsetId14 = 88;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = IQuestVerify.<>O.<8>__Verify) == null)
																	{
																		verifyAction14 = (IQuestVerify.<>O.<8>__Verify = new VerifyTableAction(IBehaviorTreeVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId14, verifyAction14, false))
																	{
																		short offsetId15 = 90;
																		VerifyTableAction verifyAction15;
																		if ((verifyAction15 = IQuestVerify.<>O.<9>__Verify) == null)
																		{
																			verifyAction15 = (IQuestVerify.<>O.<9>__Verify = new VerifyTableAction(IQuestRecallConfigVerify.Verify));
																		}
																		if (verifier.VerifyTable(tablePos, offsetId15, verifyAction15, false))
																		{
																			short offsetId16 = 92;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = IQuestVerify.<>O.<10>__Verify) == null)
																			{
																				verifyAction16 = (IQuestVerify.<>O.<10>__Verify = new VerifyTableAction(IEntityRefSearchPropVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId16, verifyAction16, false) && verifier.VerifyVectorOfStrings(tablePos, 94, false) && verifier.VerifyString(tablePos, 96, false) && verifier.VerifyField(tablePos, 98, 4UL, 4UL, false))
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
			return false;
		}

		// Token: 0x0200816A RID: 33130
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014274 RID: 82548
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014275 RID: 82549
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014276 RID: 82550
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014277 RID: 82551
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014278 RID: 82552
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04014279 RID: 82553
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401427A RID: 82554
			public static VerifyTableAction <6>__Verify;

			// Token: 0x0401427B RID: 82555
			public static VerifyTableAction <7>__Verify;

			// Token: 0x0401427C RID: 82556
			public static VerifyTableAction <8>__Verify;

			// Token: 0x0401427D RID: 82557
			public static VerifyTableAction <9>__Verify;

			// Token: 0x0401427E RID: 82558
			public static VerifyTableAction <10>__Verify;
		}
	}
}
