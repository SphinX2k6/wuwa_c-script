using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF1 RID: 28657
	public static class ISetFlowTemplateVerify
	{
		// Token: 0x06032B0D RID: 207629 RVA: 0x006D6F14 File Offset: 0x006D5114
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetFlowTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetFlowTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowTemplateModeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISetFlowTemplateVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetFlowTemplateVerify.<>O.<1>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISetFlowTemplateVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISetFlowTemplateVerify.<>O.<2>__Verify = new VerifyTableAction(ISetCameraAnimVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISetFlowTemplateVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ISetFlowTemplateVerify.<>O.<3>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 14;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ISetFlowTemplateVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (ISetFlowTemplateVerify.<>O.<3>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 16;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ISetFlowTemplateVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (ISetFlowTemplateVerify.<>O.<4>__Verify = new VerifyTableAction(ICameraPosAndRotVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 18;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ISetFlowTemplateVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ISetFlowTemplateVerify.<>O.<5>__Verify = new VerifyTableAction(ICameraSettingVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
										{
											short typeIdVOffset = 20;
											short valueVOffset = 22;
											VerifyUnionAction verifyAction8;
											if ((verifyAction8 = ISetFlowTemplateVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (ISetFlowTemplateVerify.<>O.<6>__Verify = new VerifyUnionAction(TShowTalkCameraMotionVerify.Verify));
											}
											if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction8, false))
											{
												short offsetId8 = 24;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ISetFlowTemplateVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (ISetFlowTemplateVerify.<>O.<7>__Verify = new VerifyTableAction(IFlowTemplateBlurTransitionEffectVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId8, verifyAction9, false))
												{
													short offsetId9 = 26;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = ISetFlowTemplateVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (ISetFlowTemplateVerify.<>O.<8>__Verify = new VerifyTableAction(IFlowActorIndexDataVerify.Verify));
													}
													if (verifier.VerifyVectorOfTables(tablePos, offsetId9, verifyAction10, false))
													{
														short offsetId10 = 28;
														VerifyTableAction verifyAction11;
														if ((verifyAction11 = ISetFlowTemplateVerify.<>O.<9>__Verify) == null)
														{
															verifyAction11 = (ISetFlowTemplateVerify.<>O.<9>__Verify = new VerifyTableAction(IFlowTemplateInitialLookAtVerify.Verify));
														}
														if (verifier.VerifyVectorOfTables(tablePos, offsetId10, verifyAction11, false))
														{
															short offsetId11 = 30;
															VerifyTableAction verifyAction12;
															if ((verifyAction12 = ISetFlowTemplateVerify.<>O.<10>__Verify) == null)
															{
																verifyAction12 = (ISetFlowTemplateVerify.<>O.<10>__Verify = new VerifyTableAction(IActorVisibilityVerify.Verify));
															}
															if (verifier.VerifyVectorOfTables(tablePos, offsetId11, verifyAction12, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false))
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

		// Token: 0x02007E3A RID: 32314
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139FA RID: 80378
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139FB RID: 80379
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040139FC RID: 80380
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040139FD RID: 80381
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040139FE RID: 80382
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040139FF RID: 80383
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013A00 RID: 80384
			public static VerifyUnionAction <6>__Verify;

			// Token: 0x04013A01 RID: 80385
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013A02 RID: 80386
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04013A03 RID: 80387
			public static VerifyTableAction <9>__Verify;

			// Token: 0x04013A04 RID: 80388
			public static VerifyTableAction <10>__Verify;
		}
	}
}
