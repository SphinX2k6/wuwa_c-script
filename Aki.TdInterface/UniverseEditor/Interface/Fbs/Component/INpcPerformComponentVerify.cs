using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BD2 RID: 23506
	public static class INpcPerformComponentVerify
	{
		// Token: 0x06026CE9 RID: 158953 RVA: 0x0055059C File Offset: 0x0054E79C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcPerformComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcPerformComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseRoleNpcPerformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcPerformComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INpcPerformComponentVerify.<>O.<1>__Verify = new VerifyTableAction(INpcHitShowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcPerformComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (INpcPerformComponentVerify.<>O.<2>__Verify = new VerifyTableAction(INpcBumpShowVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = INpcPerformComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (INpcPerformComponentVerify.<>O.<3>__Verify = new VerifyTableAction(INpcAwakeShowVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
							{
								short typeIdVOffset = 18;
								short valueVOffset = 20;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = INpcPerformComponentVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (INpcPerformComponentVerify.<>O.<4>__Verify = new VerifyUnionAction(TNpcStandbyShowOptionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false))
								{
									short offsetId5 = 22;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = INpcPerformComponentVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (INpcPerformComponentVerify.<>O.<5>__Verify = new VerifyTableAction(INpcPerformOnInteractVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false))
									{
										short offsetId6 = 24;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = INpcPerformComponentVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (INpcPerformComponentVerify.<>O.<6>__Verify = new VerifyTableAction(IConditionalNpcPerformOnInteractVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
										{
											short typeIdVOffset2 = 26;
											short valueVOffset2 = 28;
											VerifyUnionAction verifyAction8;
											if ((verifyAction8 = INpcPerformComponentVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (INpcPerformComponentVerify.<>O.<7>__Verify = new VerifyUnionAction(TNpcUiInteractOptionVerify.Verify));
											}
											if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction8, false) && verifier.VerifyVectorOfData(tablePos, 30, 1UL, false))
											{
												short offsetId7 = 34;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = INpcPerformComponentVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (INpcPerformComponentVerify.<>O.<8>__Verify = new VerifyTableAction(INpcPerformOnMonsterClosebyVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId7, verifyAction9, false))
												{
													short offsetId8 = 36;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = INpcPerformComponentVerify.<>O.<9>__Verify) == null)
													{
														verifyAction10 = (INpcPerformComponentVerify.<>O.<9>__Verify = new VerifyTableAction(INpcPerformStateVerify.Verify));
													}
													if (verifier.VerifyTable(tablePos, offsetId8, verifyAction10, false))
													{
														short offsetId9 = 38;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = INpcPerformComponentVerify.<>O.<10>__Verify) == null)
														{
															verifyAction11 = (INpcPerformComponentVerify.<>O.<10>__Verify = new VerifyTableAction(INpcDeathInteractVerify.Verify));
														}
														if (verifier.VerifyTable(tablePos, offsetId9, verifyAction11, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 42, false) && verifier.VerifyField(tablePos, 44, 4UL, 4UL, false))
														{
															short offsetId10 = 46;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = INpcPerformComponentVerify.<>O.<11>__Verify) == null)
															{
																verifyAction12 = (INpcPerformComponentVerify.<>O.<11>__Verify = new VerifyTableAction(INpcDefaultPerformVerify.Verify));
															}
															if (verifier.VerifyTable(tablePos, offsetId10, verifyAction12, false) && verifier.VerifyVectorOfData(tablePos, 48, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 52, 1UL, false) && verifier.VerifyField(tablePos, 54, 1UL, 1UL, false))
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
			return false;
		}

		// Token: 0x0200840F RID: 33807
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146D3 RID: 83667
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040146D4 RID: 83668
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040146D5 RID: 83669
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040146D6 RID: 83670
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040146D7 RID: 83671
			public static VerifyUnionAction <4>__Verify;

			// Token: 0x040146D8 RID: 83672
			public static VerifyTableAction <5>__Verify;

			// Token: 0x040146D9 RID: 83673
			public static VerifyTableAction <6>__Verify;

			// Token: 0x040146DA RID: 83674
			public static VerifyUnionAction <7>__Verify;

			// Token: 0x040146DB RID: 83675
			public static VerifyTableAction <8>__Verify;

			// Token: 0x040146DC RID: 83676
			public static VerifyTableAction <9>__Verify;

			// Token: 0x040146DD RID: 83677
			public static VerifyTableAction <10>__Verify;

			// Token: 0x040146DE RID: 83678
			public static VerifyTableAction <11>__Verify;
		}
	}
}
