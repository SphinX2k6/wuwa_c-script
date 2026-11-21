using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004952 RID: 18770
	public static class ILevelPlayVerify
	{
		// Token: 0x0601BF61 RID: 114529 RVA: 0x003F4050 File Offset: 0x003F2250
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyVectorOfStrings(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 22, 1UL, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 34, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 38, false) && verifier.VerifyField(tablePos, 40, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 42, 4UL, 4UL, false))
			{
				short offsetId = 44;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayZaxisVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 46, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 48, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 50, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 54, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 56, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
				{
					short offsetId2 = 60;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelPlayVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ILevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 62;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILevelPlayVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ILevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 64;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ILevelPlayVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (ILevelPlayVerify.<>O.<2>__Verify = new VerifyTableAction(ILevelPlayMarkVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 66;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ILevelPlayVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (ILevelPlayVerify.<>O.<3>__Verify = new VerifyTableAction(ILevelPlayTrackVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 68, 1UL, 1UL, false))
								{
									short typeIdVOffset = 68;
									short valueVOffset = 70;
									VerifyUnionAction verifyAction6;
									if ((verifyAction6 = ILevelPlayVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (ILevelPlayVerify.<>O.<4>__Verify = new VerifyUnionAction(TLevelPlayRewardVerify.Verify));
									}
									if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction6, false) && verifier.VerifyField(tablePos, 72, 1UL, 1UL, false))
									{
										short typeIdVOffset2 = 72;
										short valueVOffset2 = 74;
										VerifyUnionAction verifyAction7;
										if ((verifyAction7 = ILevelPlayVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ILevelPlayVerify.<>O.<5>__Verify = new VerifyUnionAction(TLevelPlayRefreshVerify.Verify));
										}
										if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction7, false))
										{
											short offsetId6 = 76;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ILevelPlayVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ILevelPlayVerify.<>O.<6>__Verify = new VerifyTableAction(ILevelPlayOpenConditionVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId6, verifyAction8, false))
											{
												short offsetId7 = 78;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ILevelPlayVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ILevelPlayVerify.<>O.<7>__Verify = new VerifyTableAction(ILevelPlayActiveVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId7, verifyAction9, false))
												{
													short offsetId8 = 80;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ILevelPlayVerify.<>O.<1>__Verify) == null)
													{
														verifyAction10 = (ILevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId8, verifyAction10, false))
													{
														short offsetId9 = 82;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ILevelPlayVerify.<>O.<1>__Verify) == null)
														{
															verifyAction11 = (ILevelPlayVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction11, false) && verifier.VerifyField(tablePos, 84, 4UL, 4UL, false))
														{
															short offsetId10 = 86;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = ILevelPlayVerify.<>O.<8>__Verify) == null)
															{
																verifyAction12 = (ILevelPlayVerify.<>O.<8>__Verify = new VerifyTableAction(ILevelPlayExploratoryConfigVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId10, verifyAction12, false) && verifier.VerifyVectorOfData(tablePos, 88, 4UL, false))
															{
																short offsetId11 = 90;
																VerifyTableAction verifyAction13;
																if ((verifyAction13 = ILevelPlayVerify.<>O.<9>__Verify) == null)
																{
																	verifyAction13 = (ILevelPlayVerify.<>O.<9>__Verify = new VerifyTableAction(IBehaviorTreeVerify.Verify));
																}
																if (verifier.VerifyTable(tablePos, offsetId11, verifyAction13, false))
																{
																	short offsetId12 = 92;
																	VerifyTableAction verifyAction14;
																	if ((verifyAction14 = ILevelPlayVerify.<>O.<10>__Verify) == null)
																	{
																		verifyAction14 = (ILevelPlayVerify.<>O.<10>__Verify = new VerifyTableAction(ILevelPlayFixProcessorVerify.Verify));
																	}
																	if (verifier.VerifyTable(tablePos, offsetId12, verifyAction14, false) && verifier.VerifyField(tablePos, 94, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 96, 4UL, 4UL, false))
																	{
																		short offsetId13 = 98;
																		VerifyTableAction verifyAction15;
																		if ((verifyAction15 = ILevelPlayVerify.<>O.<11>__Verify) == null)
																		{
																			verifyAction15 = (ILevelPlayVerify.<>O.<11>__Verify = new VerifyTableAction(IRangeAbsorbPhantomVerify.Verify));
																		}
																		if (verifier.VerifyTable(tablePos, offsetId13, verifyAction15, false))
																		{
																			short offsetId14 = 100;
																			VerifyTableAction verifyAction16;
																			if ((verifyAction16 = ILevelPlayVerify.<>O.<12>__Verify) == null)
																			{
																				verifyAction16 = (ILevelPlayVerify.<>O.<12>__Verify = new VerifyTableAction(IRewardConfigVerify.Verify));
																			}
																			if (verifier.VerifyTable(tablePos, offsetId14, verifyAction16, false) && verifier.VerifyField(tablePos, 102, 1UL, 1UL, false))
																			{
																				short offsetId15 = 104;
																				VerifyTableAction verifyAction17;
																				if ((verifyAction17 = ILevelPlayVerify.<>O.<13>__Verify) == null)
																				{
																					verifyAction17 = (ILevelPlayVerify.<>O.<13>__Verify = new VerifyTableAction(ILevelPlayRecallConfigVerify.Verify));
																				}
																				if (verifier.VerifyTable(tablePos, offsetId15, verifyAction17, false))
																				{
																					short offsetId16 = 106;
																					VerifyTableAction verifyAction18;
																					if ((verifyAction18 = ILevelPlayVerify.<>O.<14>__Verify) == null)
																					{
																						verifyAction18 = (ILevelPlayVerify.<>O.<14>__Verify = new VerifyTableAction(IEntityRefSearchPropVerify.Verify));
																					}
																					if (verifier.VerifyTable(tablePos, offsetId16, verifyAction18, false) && verifier.VerifyVectorOfStrings(tablePos, 108, false) && verifier.VerifyString(tablePos, 110, false) && verifier.VerifyField(tablePos, 112, 4UL, 4UL, false))
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

		// Token: 0x020081F7 RID: 33271
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143A1 RID: 82849
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143A2 RID: 82850
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040143A3 RID: 82851
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040143A4 RID: 82852
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040143A5 RID: 82853
			public static VerifyUnionAction <4>__Verify;

			// Token: 0x040143A6 RID: 82854
			public static VerifyUnionAction <5>__Verify;

			// Token: 0x040143A7 RID: 82855
			public static VerifyTableAction <6>__Verify;

			// Token: 0x040143A8 RID: 82856
			public static VerifyTableAction <7>__Verify;

			// Token: 0x040143A9 RID: 82857
			public static VerifyTableAction <8>__Verify;

			// Token: 0x040143AA RID: 82858
			public static VerifyTableAction <9>__Verify;

			// Token: 0x040143AB RID: 82859
			public static VerifyTableAction <10>__Verify;

			// Token: 0x040143AC RID: 82860
			public static VerifyTableAction <11>__Verify;

			// Token: 0x040143AD RID: 82861
			public static VerifyTableAction <12>__Verify;

			// Token: 0x040143AE RID: 82862
			public static VerifyTableAction <13>__Verify;

			// Token: 0x040143AF RID: 82863
			public static VerifyTableAction <14>__Verify;
		}
	}
}
