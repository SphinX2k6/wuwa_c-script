using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005634 RID: 22068
	public static class INpcPerformComponentVerify
	{
		// Token: 0x06024ACA RID: 150218 RVA: 0x0050FC88 File Offset: 0x0050DE88
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
															if (verifier.VerifyTable(tablePos, offsetId10, verifyAction12, false) && verifier.VerifyVectorOfData(tablePos, 48, 1UL, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
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

		// Token: 0x02007BAD RID: 31661
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013644 RID: 79428
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013645 RID: 79429
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013646 RID: 79430
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013647 RID: 79431
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013648 RID: 79432
			public static VerifyUnionAction <4>__Verify;

			// Token: 0x04013649 RID: 79433
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401364A RID: 79434
			public static VerifyTableAction <6>__Verify;

			// Token: 0x0401364B RID: 79435
			public static VerifyUnionAction <7>__Verify;

			// Token: 0x0401364C RID: 79436
			public static VerifyTableAction <8>__Verify;

			// Token: 0x0401364D RID: 79437
			public static VerifyTableAction <9>__Verify;

			// Token: 0x0401364E RID: 79438
			public static VerifyTableAction <10>__Verify;

			// Token: 0x0401364F RID: 79439
			public static VerifyTableAction <11>__Verify;
		}
	}
}
