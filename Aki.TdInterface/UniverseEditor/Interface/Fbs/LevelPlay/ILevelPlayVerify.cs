using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044EA RID: 17642
	public static class ILevelPlayVerify
	{
		// Token: 0x0601A78C RID: 108428 RVA: 0x003C7DC4 File Offset: 0x003C5FC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 20, 1UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 32, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 36, false) && verifier.VerifyField(tablePos, 38, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 40, 4UL, 4UL, false))
			{
				short offsetId = 42;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayZaxisVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 44, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 46, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 48, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 54, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 56, 1UL, 1UL, false))
				{
					short offsetId2 = 58;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelPlayVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 60;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILevelPlayVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ILevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 62;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ILevelPlayVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (ILevelPlayVerify.<>O.<2>__Verify = new VerifyTableAction(ILevelPlayMarkVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 64;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ILevelPlayVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (ILevelPlayVerify.<>O.<3>__Verify = new VerifyTableAction(ILevelPlayTrackVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 66, 1UL, 1UL, false))
								{
									short typeIdVOffset = 66;
									short valueVOffset = 68;
									VerifyUnionAction verifyAction6;
									if ((verifyAction6 = ILevelPlayVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (ILevelPlayVerify.<>O.<4>__Verify = new VerifyUnionAction(TLevelPlayRewardVerify.Verify));
									}
									if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction6, false) && verifier.VerifyField(tablePos, 70, 1UL, 1UL, false))
									{
										short typeIdVOffset2 = 70;
										short valueVOffset2 = 72;
										VerifyUnionAction verifyAction7;
										if ((verifyAction7 = ILevelPlayVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ILevelPlayVerify.<>O.<5>__Verify = new VerifyUnionAction(TLevelPlayRefreshVerify.Verify));
										}
										if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction7, false))
										{
											short offsetId6 = 74;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ILevelPlayVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ILevelPlayVerify.<>O.<6>__Verify = new VerifyTableAction(ILevelPlayOpenConditionVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId6, verifyAction8, false))
											{
												short offsetId7 = 76;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ILevelPlayVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ILevelPlayVerify.<>O.<7>__Verify = new VerifyTableAction(ILevelPlayActiveVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId7, verifyAction9, false))
												{
													short offsetId8 = 78;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ILevelPlayVerify.<>O.<1>__Verify) == null)
													{
														verifyAction10 = (ILevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction10, false))
													{
														short offsetId9 = 80;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ILevelPlayVerify.<>O.<1>__Verify) == null)
														{
															verifyAction11 = (ILevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction11, false) && verifier.VerifyField(tablePos, 82, 4UL, 4UL, false))
														{
															short offsetId10 = 84;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = ILevelPlayVerify.<>O.<8>__Verify) == null)
															{
																verifyAction12 = (ILevelPlayVerify.<>O.<8>__Verify = new VerifyTableAction(ILevelPlayExploratoryConfigVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId10, verifyAction12, false) && verifier.VerifyVectorOfData(tablePos, 86, 4UL, false))
															{
																short offsetId11 = 88;
																VerifyTableAction verifyAction13;
																if ((verifyAction13 = ILevelPlayVerify.<>O.<9>__Verify) == null)
																{
																	verifyAction13 = (ILevelPlayVerify.<>O.<9>__Verify = new VerifyTableAction(IBehaviorTreeVerify.Verify));
																}
																if (verifier.VerifyTable(tablePos, offsetId11, verifyAction13, false))
																{
																	short offsetId12 = 90;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ILevelPlayVerify.<>O.<10>__Verify) == null)
																	{
																		verifyAction14 = (ILevelPlayVerify.<>O.<10>__Verify = new VerifyTableAction(ILevelPlayFixProcessorVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 92, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 94, 4UL, 4UL, false))
																	{
																		short offsetId13 = 96;
																		VerifyTableAction verifyAction15;
																		if ((verifyAction15 = ILevelPlayVerify.<>O.<11>__Verify) == null)
																		{
																			verifyAction15 = (ILevelPlayVerify.<>O.<11>__Verify = new VerifyTableAction(IRangeAbsorbPhantomVerify.Verify));
																		}
																		if (verifier.VerifyTable(tablePos, offsetId13, verifyAction15, false))
																		{
																			short offsetId14 = 98;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ILevelPlayVerify.<>O.<12>__Verify) == null)
																			{
																				verifyAction16 = (ILevelPlayVerify.<>O.<12>__Verify = new VerifyTableAction(IRewardConfigVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId14, verifyAction16, false) && verifier.VerifyField(tablePos, 100, 1UL, 1UL, false))
																			{
																				short offsetId15 = 102;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ILevelPlayVerify.<>O.<13>__Verify) == null)
																				{
																					verifyAction17 = (ILevelPlayVerify.<>O.<13>__Verify = new VerifyTableAction(ILevelPlayRecallConfigVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId15, verifyAction17, false))
																				{
																					short offsetId16 = 104;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ILevelPlayVerify.<>O.<14>__Verify) == null)
																					{
																						verifyAction18 = (ILevelPlayVerify.<>O.<14>__Verify = new VerifyTableAction(IEntityRefSearchPropVerify.Verify));
																					}
																					if (verifier.VerifyTable(tablePos, offsetId16, verifyAction18, false) && verifier.VerifyVectorOfStrings(tablePos, 106, false) && verifier.VerifyString(tablePos, 108, false) && verifier.VerifyField(tablePos, 110, 4UL, 4UL, false))
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
			return false;
		}

		// Token: 0x020079AE RID: 31150
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401333A RID: 78650
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401333B RID: 78651
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401333C RID: 78652
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401333D RID: 78653
			public static VerifyTableAction <3>__Verify;

			// Token: 0x0401333E RID: 78654
			public static VerifyUnionAction <4>__Verify;

			// Token: 0x0401333F RID: 78655
			public static VerifyUnionAction <5>__Verify;

			// Token: 0x04013340 RID: 78656
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013341 RID: 78657
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013342 RID: 78658
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04013343 RID: 78659
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04013344 RID: 78660
			public static VerifyTableAction <10>__Verify;

			// Token: 0x04013345 RID: 78661
			public static VerifyTableAction <11>__Verify;

			// Token: 0x04013346 RID: 78662
			public static VerifyTableAction <12>__Verify;

			// Token: 0x04013347 RID: 78663
			public static VerifyTableAction <13>__Verify;

			// Token: 0x04013348 RID: 78664
			public static VerifyTableAction <14>__Verify;
		}
	}
}
